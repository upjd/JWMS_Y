using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;

namespace WMSM
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

       

        private void BackupForm_Load(object sender, EventArgs e)
        {
            DBHelp.wmsConnStr = MaLogin.WmsCon;
            DataTable ModelDT = new System.Data.DataTable("modeldt");
            var cl1 = new DataColumn("name", typeof(string));
            var cl2 = new DataColumn("crdate", typeof(string));
            var cl3 = new DataColumn("filename", typeof(string));
            var cl4 = new DataColumn("backup", typeof(string));
            var cl5 = new DataColumn("operation", typeof(string));

            ModelDT.Columns.Add(cl1);
            ModelDT.Columns.Add(cl2);
            ModelDT.Columns.Add(cl3);
            ModelDT.Columns.Add(cl4);
            ModelDT.Columns.Add(cl5);

            DataTable dt = DBHelp.GetDataTable("select name,crdate,filename from [sysdatabases] where dbid > '6' order by dbid");

            foreach (DataRow dr in dt.Rows) 
            {
                DataRow item = ModelDT.NewRow();
                item["name"] = dr["name"].ToString();
                item["crdate"] = dr["crdate"].ToString();
                item["filename"] = dr["filename"].ToString();
                item["backup"] = "";
                item["operation"] = "备份";
                ModelDT.Rows.Add(item);
            }
            this.ugdList.DataSource = ModelDT;

            Initial();

        }


        private void Initial() 
        {
            this.ugdList.ClickCellButton += ugdList_ClickCellButton;
        }

        void ugdList_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {

            if (e.Cell.Column.CellButtonAppearance.Tag.ToString() == "选择路径")
            {
                this.fbdFile.ShowDialog();
                if (!string.IsNullOrEmpty(this.fbdFile.SelectedPath))
                    e.Cell.Row.Cells["backup"].Value = this.fbdFile.SelectedPath + @"\" + e.Cell.Row.Cells["name"].Value + ".bak";
                else return;
            }
            else if (e.Cell.Column.CellButtonAppearance.Tag.ToString() == "操作")
            {
                var isok = MessageBox.Show("确定备份？", "提示", MessageBoxButtons.OKCancel);
                if (isok == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(e.Cell.Row.Cells["backup"].Value.ToString())) 
                    {
                        MessageBox.Show("请选择地址！");
                        return;
                    }
                    else if (File.Exists(e.Cell.Row.Cells["backup"].Value.ToString()))
                    {
                        if (MessageBox.Show("该文件已存在！是否将它覆盖？", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel) return;
                    }
                    string sql = string.Format(@"BACKUP DATABASE {0} TO DISK ='{1}'", e.Cell.Row.Cells["name"].Value, e.Cell.Row.Cells["backup"].Value);
                    DBHelp.ExecuteNonQuery(sql);

                    if (File.Exists(e.Cell.Row.Cells["backup"].Value.ToString()))
                        MessageBox.Show("备份成功");
                    else MessageBox.Show("备份失败");
                    
                }
                else return; 
            }
            
        }

        private void tsmiOnline_Click(object sender, EventArgs e)
        {
            new ActivateLicense().ShowDialog();
        }

        
        
     
      


    }
}
