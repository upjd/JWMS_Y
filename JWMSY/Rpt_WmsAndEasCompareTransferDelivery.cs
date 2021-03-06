﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using JWMSY.DLL;
using System.Data.SqlClient;


namespace JWMSY
{
    /// <summary>
    /// WMS与EAS调拨出库数据对照表
    /// </summary>
    public partial class Rpt_WmsAndEasCompareTransferDelivery : Form
    {
       

        /// <summary>
        /// WMS与EAS调拨数据对照表
        /// </summary>
        public Rpt_WmsAndEasCompareTransferDelivery()
        {
            InitializeComponent();
        }

        private void Rpt_ProPrintRecord_Load(object sender, EventArgs e)
        {
            
            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);

            
        }

        private void biExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tsgfMain.SaveExcel2003();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void biSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (beidDate.EditValue == null)
            {
                beidDate.EditValue = DateTime.Now.Date;
            }
            var cdDate = beidDate.EditValue.ToString();
            DateTime dDate;

            if (!DateTime.TryParse(cdDate, out dDate))
            {
                dDate = DateTime.Now.Date;
            }
            //通过WebService获取报单系统数据
            var js = new CompareService.EasAndWmsCompareReport();

            var easData = js.GetMoveIssue(dDate);

            var wf = new WmsFunction(BaseStructure.WmsCon);
            var cGuid = Guid.NewGuid();
            //写临时表
            for (var i = 0; i < easData.Rows.Count; i++)
            {
                var cmdInsertTemp = new SqlCommand("insert into Tmp_Compare(cInvCode,cInvName,iQuantity,cUnit,cGuid,cOrderNumber) " +
                                    "Values(@cInvCode,@cInvName,@iQuantity,@cUnit,@cGuid,@cOrderNumber)");
                cmdInsertTemp.Parameters.AddWithValue("@cInvCode", easData.Rows[i]["cInvCode"].ToString());
                cmdInsertTemp.Parameters.AddWithValue("@cInvName", easData.Rows[i]["cInvName"].ToString());
                cmdInsertTemp.Parameters.AddWithValue("@iQuantity", easData.Rows[i]["iSumQuantity"].ToString());
                cmdInsertTemp.Parameters.AddWithValue("@cUnit", easData.Rows[i]["cUnit"].ToString());
                cmdInsertTemp.Parameters.AddWithValue("@cGuid", cGuid);
                cmdInsertTemp.Parameters.AddWithValue("@cOrderNumber", easData.Rows[i]["cOrderNumber"].ToString());
                wf.ExecSqlCmd(cmdInsertTemp);
            }

            var cmd =new SqlCommand("CompareTransferDeliveryNew"){CommandType = CommandType.StoredProcedure};
            cmd.Parameters.AddWithValue("@dDate", dDate);
            cmd.Parameters.AddWithValue("@cGuid", cGuid);
            
            uGridProBoxBarCode.DataSource=wf.GetSqlTable(cmd);

            var cmdDelete = new SqlCommand("Delete from Tmp_Compare where cGuid=@cGuid");
            cmdDelete.Parameters.AddWithValue("@cGuid", cGuid);
            wf.ExecSqlCmd(cmdDelete);
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

    }
}
