using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using JWMSY.DLL;
using System.Windows.Forms;

namespace JWMSY
{


    /// <summary>
    /// 产成品物流箱标签记录表
    /// </summary>
    public partial class Rpt_ProPrintBoxSSRecord : Form
    {

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
        /// 产成品物流箱标签记录表构造函数
        /// </summary>
        public Rpt_ProPrintBoxSSRecord()
        {
            InitializeComponent();
        }

        private void Rpt_ProPrintBoxSSRecord_Load(object sender, EventArgs e)
        {
            pageListMain.Constr = BaseStructure.WmsCon;
            pageListMain.GetRecord();
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            DllWorkPrintLabel.GetTemplet("物流箱标签", ref _cCaption, ref _cPrinter, ref _cTempletFileName);
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uGridProBoxSSBarCode.UpdateData();
            var dt = new DataUseTableFormat().Bar_ProBoxSerialRecord;
            foreach (var uRow in uGridProBoxSSBarCode.Rows.GetFilteredInNonGroupByRows())
            {
                if ((bool)uRow.Cells["bSelect"].Value)
                {
                    var dr = dt.NewBar_ProBoxSerialRecordRow();
                    var cBoxNumber = uRow.Cells["cBoxNumber"].Value.ToString();
                    dr.cBoxNumber = uRow.Cells["cBoxNumber"].Value.ToString();
                    dr.cMemo = uRow.Cells["cMemo"].Value.ToString();
                    dt.Rows.Add(dr);
                    UpdatePrintNum( cBoxNumber);
                }
            }


            DllWorkPrintLabel.ProBoxPrintCodeSoft(dt, _cTempletFileName, _cPrinter, DllWorkPrintLabel.GetUri());
        }

        private void UpdatePrintNum(string cBoxNumber)
        {
            var cmd = new SqlCommand("update SS_Box set iPrintNum=iPrintNum+1  where cBoxNumber=@cBoxNumber");
            cmd.Parameters.AddWithValue("@cBoxNumber", cBoxNumber);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            wf.ExecSqlCmd(cmd);
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bfun = new WmsFunction(BaseStructure.WmsCon);
            var strTemp = bfun.GetWhereSqlStr("SS_Box");
            if (string.IsNullOrEmpty(strTemp))
                return;
            pageListMain.Condition = " SS_Box where " + strTemp;
            pageListMain.WhereStr = strTemp;
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }


        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageListMain.WhereStr = "";
            pageListMain.Condition = "SS_Box";
            pageListMain.GetRecord();
            MessageBox.Show(@"查询成功", @"成功");
        }
    }
}
