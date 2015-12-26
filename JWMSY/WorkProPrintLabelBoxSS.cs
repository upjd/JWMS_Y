using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using JWMSY.DLL;

namespace JWMSY
{
    /// <summary>
    /// 物流箱标签打印界面
    /// </summary>
    public partial class WorkProPrintLabelBoxSS : Form
    {
        /// <summary>
        /// 进行记录跳转用ID
        /// </summary>
        private string _lid;

        /// <summary>
        /// Guid
        /// </summary>
        private string _cGuid;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cTempletFileName;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cCaption;

        /// <summary>
        /// 打印机
        /// </summary>
        private string _cPrinter;

        /// <summary>
        /// 物流箱标签打印界面构造函数
        /// </summary>
        public WorkProPrintLabelBoxSS()
        {
            InitializeComponent();
        }

        private void biAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            biAddNew.Enabled = false;
            biSave.Enabled = true;
            uneiNum.Enabled = true;
            txtcMemo.Enabled = true;
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int iSerialQty;
            if (uneiNum.Value == null)
            {
                MessageBox.Show(@"输入的列序数不正确,请输入正整数");
                return;
            }
            if (!int.TryParse(uneiNum.Value.ToString(), out iSerialQty))
            {
                MessageBox.Show(@"输入的列序数不正确,请输入正整数");
                return;
            }
            if (iSerialQty < 1 || iSerialQty > 100000)
            {
                MessageBox.Show(@"输入的列序数不能小于1，并且不能大于10万");
                return;
            }
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd = new SqlCommand { CommandType = CommandType.StoredProcedure, Connection = con })
                {
                    
                   cmd.CommandText = "GenerateBoxNumber";

                   _cGuid = Guid.NewGuid().ToString();
                   cmd.Parameters.AddWithValue("@cGuid", _cGuid);
                   cmd.Parameters.AddWithValue("@iSerialQty", iSerialQty);

                    
                    cmd.Parameters.AddWithValue("@cMemo", txtcMemo.Text);
                    con.Open();

                    try
                    {
                        var ieffect = cmd.ExecuteNonQuery();
                        //判断是否是真的完成了主表的写入
                        if (ieffect < 0)
                        {
                            return;
                        }

                        MessageBox.Show(@"保存成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        biSave.Enabled = false;
                        biAddNew.Enabled = true;
                        pageChange.WhereStr = string.Format("cGuid ='{0}'", _cGuid);
                        pageChange.GetRecord();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void WorkProPrintLabelBoxSS_Load(object sender, EventArgs e)
        {
            
            pageChange.Constr = BaseStructure.WmsCon;
            pageChange.GetRecord();

            DllWorkPrintLabel.GetTemplet("物流箱标签", ref _cCaption, ref _cPrinter, ref _cTempletFileName);

            biPrinter.Caption = _cPrinter;
            biTemplet.Caption = _cCaption;

            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);




            if (string.IsNullOrEmpty(_lid))
            {
                SetPanelVlaue("", "btnLast");
            }
            else
            {
                SetPanelVlaue(_lid);
            }

            lblTitleMain.btnFirst.Click += btnFirst_Click;
            lblTitleMain.btnNext.Click += btnFirst_Click;
            lblTitleMain.btnPre.Click += btnFirst_Click;
            lblTitleMain.btnLast.Click += btnFirst_Click;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (biSave.Enabled)
            {
                MessageBox.Show(@"请取消编辑后再翻页!", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var btn = (Button)sender;
            SetPanelVlaue(lblTitleMain.lblAutoID.Text, btn.Name);
        }
        /// <summary>
        /// 进行数据库数据定位显示
        /// </summary>
        /// <param name="lId"></param>
        /// <param name="llocation"></param>
        public void SetPanelVlaue(string lId, string llocation = "")
        {
            var sqlcmd = new SqlCommand();
            switch (llocation)
            {
                case "btnLast":
                    sqlcmd.CommandText = "select top 1 * from View_SS_BOX order by AutoID desc";
                    break;
                case "btnFirst":
                    sqlcmd.CommandText = "select top 1 * from View_SS_BOX order by AutoID";
                    break;
                case "btnPre":
                    if (string.IsNullOrEmpty(lId))
                    {
                        MessageBox.Show(@"已到首页");
                        return;
                    }
                    sqlcmd.CommandText = "select top 1 * from View_SS_BOX where AutoID<@AutoID order by AutoID desc";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
                case "btnNext":
                    if (string.IsNullOrEmpty(lId))
                    {
                        MessageBox.Show(@"已到末页");
                        return;
                    }
                    sqlcmd.CommandText = "select top 1 * from View_SS_BOX where AutoID>@AutoID order by AutoID";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
                case "":
                    sqlcmd.CommandText = "select top 1 * from View_SS_BOX where AutoID=@AutoID";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
            }

            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                sqlcmd.Connection = con;
                con.Open();
                #region 读取数据库中数据
                using (var dr = sqlcmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        //获取所有取得的数据并显示
                        lblTitleMain.lblAutoID.Text = dr["AutoID"].ToString();
                        lblTitleMain.lblcSerialNumber.Text = dr["cBoxNumber"].ToString();
                        
                        _cGuid = dr["cGuid"].ToString();
                        txtcMemo.Text = dr["cMemo"].ToString();
                        pageChange.WhereStr = string.Format("cGuid ='{0}'", _cGuid);
                        pageChange.GetRecord();
                    }
                    else
                    {
                        switch (llocation)
                        {
                            case "btnPre":
                                MessageBox.Show(@"已经是首页");
                                break;
                            case "btnNext":
                                MessageBox.Show(@"已经是末页");
                                break;
                            default:
                                MessageBox.Show(@"无记录");
                                //ResetNull();
                                //SetControlDisable();
                                break;
                        }

                    }
                #endregion
                }
            }

        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void biPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(_cGuid))
                return;
            var iPrintNum=PrintCount();
            if (iPrintNum >= 1)
            {
                MessageBox.Show(@"该批条码已经被打印过，不允许重复打印");
                return;
            }
            if (PrinterDone())
            {
                UpdatePrintNum(iPrintNum);
            }
        }



        private bool PrinterDone()
        {
            var strUri = DllWorkPrintLabel.GetUri();
            if (string.IsNullOrEmpty(strUri))
            {
                MessageBox.Show(@"WMS配置Web端不正确", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            var dt = GetPrintTable();
            try
            {
                DllWorkPrintLabel.ProBoxPrintCodeSoft(dt, _cTempletFileName, _cPrinter, strUri);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private int PrintCount()
        {
            var cmd = new SqlCommand("select top 1 isnull(iPrintNum,1) from SS_Box where cGuid=@cGuid");
            cmd.Parameters.AddWithValue("@cGuid", _cGuid);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var ciPrintNum = wf.ReturnFirstSingle(cmd);
            int iPrintNum;
            return int.TryParse(ciPrintNum, out iPrintNum) ? iPrintNum : 1;
        }


        private void UpdatePrintNum(int iPrintNum)
        {
            var cmd = new SqlCommand("update SS_Box set iPrintNum=@iPrintNum  where cGuid=@cGuid");
            cmd.Parameters.AddWithValue("@cGuid", _cGuid);
            cmd.Parameters.AddWithValue("@iPrintNum", iPrintNum+1);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            wf.ExecSqlCmd(cmd);
        }


        private DataTable GetPrintTable()
        {
            var cmd = new SqlCommand("select * from SS_Box where cGuid=@cGuid");
            cmd.Parameters.AddWithValue("@cGuid", _cGuid);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            return wf.GetSqlTable(cmd);
        }

        private void biTemplet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var st = new Base_Templet(true, "物流箱标签"))
            {
                if (st.ShowDialog() == DialogResult.Yes)
                {
                    biTemplet.Caption = st.URow.Cells["cCaption"].Value.ToString();
                    _cCaption = st.URow.Cells["cCaption"].Value.ToString();
                    _cTempletFileName = st.URow.Cells["cTempletPath"].Value.ToString();
                    biPrinter.Caption = st.URow.Cells["cPrinter"].Value.ToString();
                    _cPrinter = st.URow.Cells["cPrinter"].Value.ToString();
                }
            }
        }

        private void bbiTempBox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var wtb = new WorkTempBox(_cPrinter))
            {
                wtb.ShowDialog();
            }
        }

        private void biVipBox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var wtb = new WorkTempVipBox(_cPrinter))
            {
                wtb.ShowDialog();
            }
        }

    }
}
