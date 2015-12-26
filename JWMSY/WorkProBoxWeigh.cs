using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace JWMSY
{
    /// <summary>
    /// 物流箱称重界面
    /// </summary>
    public partial class WorkProBoxWeigh : Form
    {
        /// <summary>
        /// 物流箱称重界面
        /// </summary>
        public WorkProBoxWeigh()
        {
            InitializeComponent();
        }

        

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            biSave.Enabled = true;
            biAddNew.Enabled = false;
            utecBoxNumber.Enabled = true;
            dtpdDate.Enabled = true;
            utecBoxNumber.Text = "";
        }

        private void spMain_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //判断Com口是否打开
                if (!spMain.IsOpen) return;
                Thread.Sleep(50);
                var bytes = spMain.BytesToRead;
                var buffer = new byte[bytes];
                spMain.Read(buffer, 0, bytes);
                var strbuffer = Encoding.ASCII.GetString(buffer);

                //判断获取的值是否正常
                if (strbuffer.Length < 5)
                    return;
                var strWeight = strbuffer.Substring(3, 5);
                decimal iWeight;
                if (decimal.TryParse(strWeight, out iWeight))
                {
                    uteiWeight.Value = iWeight;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(utecBoxNumber.Text))
            {
                MessageBox.Show(@"箱号必输");
                return;
                
            }
                

            var cmd = new SqlCommand("update SS_Box set iWeight=@iWeight,dWeight=Getdate() where cBoxNumber=@cBoxNumber");
            cmd.Parameters.AddWithValue("@iWeight", uteiWeight.Value ?? 0);
            cmd.Parameters.AddWithValue("@cBoxNumber", utecBoxNumber.Text);

            var wf = new WmsFunction(BaseStructure.WmsCon);
            if (wf.ExecSqlCmd(cmd))
            {
                MessageBox.Show(@"箱重量更新成功");
            }
            else
            {
                MessageBox.Show(@"更新失败,请检查箱号是否存在！");
                return;
            }

            var GetBoxCmd = new SqlCommand("select * from SS_Box where cBoxNumber=@cBoxNumber");
            GetBoxCmd.Parameters.AddWithValue("@cBoxNumber", utecBoxNumber.Text);
            var dtSource = wf.GetSqlTable(GetBoxCmd);
            if(dtSource!=null)
            {
                uGridOutBox.DataSource = dtSource;
            }
            

            biSave.Enabled = false;
            biAddNew.Enabled = true;
            utecBoxNumber.Enabled = false;
            dtpdDate.Enabled = false;
        }

        private void WorkProBoxWeigh_Load(object sender, EventArgs e)
        {

        }

        private void uteiWeight_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (spMain.IsOpen)
            {
                return;
            }
            try
            {
                spMain.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Com1口打开失败
"+ex.Message);
            }
        }

        private void WorkProBoxWeigh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!spMain.IsOpen) return;
            spMain.Close();
            spMain.Dispose();
        }

        private void utecBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            var indexBox = utecBoxNumber.Text.IndexOf("boxnumber=", StringComparison.Ordinal);
            var lengthBox = utecBoxNumber.Text.Length;
            if (lengthBox - indexBox > 10)
            {
                utecBoxNumber.Text = utecBoxNumber.Text.Substring(indexBox + 10, lengthBox - indexBox - 10);
            }
        }
    }
}
