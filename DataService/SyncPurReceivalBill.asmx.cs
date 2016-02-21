using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace DataService
{
    /// <summary>
    /// 采购收货单同步
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class SyncOrder : WebService
    {
        /// <summary>
        /// 采购收货主表
        /// </summary>
        private PurReceivalBill _receivalBill = new PurReceivalBill();

        /// <summary>
        /// 采购收货子表
        /// </summary>
        private PurReceivalEntry _receivalEntry = new PurReceivalEntry();

        /// <summary>
        /// 财务组织
        /// </summary>
        private string _storageUnit;

        private int _fpurchasetype=0;

        string BillCmdStr = "Insert into T_IM_PurReceivalBill(" +
                               "FID," +
                               "FCREATORID," +
                               "FCREATETIME," +
                               "FCONTROLUNITID," +
                               "FNUMBER," +
                               "FBIZDATE," +
                               "FBASESTATUS," +
                               "FBIZTYPEID," +
                               "FSOURCEBILLTYPEID," +
                               "FBILLTYPEID," +
                               "FSTORAGEORGUNITID," +
                               "FTRANSACTIONTYPEID," +
                               "FISINITBILL," +
                               "FSUPPLIERID," +
                               "FCONVERTMODE," +
                               "FISCENTRALBALANCE," +
                               "FPURCHASETYPE," +
                               "FMONTH," +
                               "FDAY," +
                                "FYear," +
                            "FPeriod," +
                            "FIsReversed) " +
                               "Values(" +
                               ":FID," +
                               ":FCREATORID," +
                               ":FCREATETIME," +
                               ":FCONTROLUNITID," +
                               ":FNUMBER," +
                               ":FBIZDATE," +
                               ":FBASESTATUS," +
                               ":FBIZTYPEID," +
                               ":FSOURCEBILLTYPEID," +
                               ":FBILLTYPEID," +
                               ":FSTORAGEORGUNITID," +
                               ":FTRANSACTIONTYPEID," +
                               ":FISINITBILL," +
                               ":FSUPPLIERID," +
                               ":FCONVERTMODE," +
                               ":FISCENTRALBALANCE," +
                               ":FPURCHASETYPE," +
                               ":FMONTH," +
                               ":FDAY," +
                               ":FYear," +
                            ":FPeriod," +
                            ":FIsReversed)";

        string BillEntryCmdStr = "Insert into T_IM_PurReceivalEntry(" +
                               "FID," +
                               "FSEQ," +
                               "FSOURCEBILLID," +
                               "FSOURCEBILLNUMBER," +
                               "FSOURCEBILLTYPEID," +
                               "FSOURCEBILLENTRYID," +
                               "FSOURCEBILLENTRYSEQ," +
                               "FASSCOEFFICIENT," +
                               "FBASESTATUS," +
                               "FMATERIALID," +
                               "FUNITID," +
                               "FBASEUNITID," +
                               "FASSOCIATEQTY," +
                               "FSTORAGEORGUNITID," +
                               "FCOMPANYORGUNITID," +
                               "FWAREHOUSEID," +
                               "FQTY," +
                               "FLOT, " +
                               "FASSISTQTY," +
                               "FBASEQTY," +
                               "FREVERSEQTY," +
                               "FRETURNSQTY," +
                               "FPRICE," +
                               "FAMOUNT," +
                               "FUNITSTANDARDCOST," +
                               "FSTANDARDCOST," +
                               "FUNITACTUALCOST," +
                               "FACTUALCOST," +
                               "FISPRESENT," +
                               "FPARENTID," +
                               "FPURORDERID," +
                               "FPURORDERENTRYID," +
                               "FRECEIPTQTY," +
                               "FPURORDERNUM," +
                               "FPURORDERENTRYSEQ," +
                               "FREVERSEBASEQTY," +
                               "FRECEIPTBASEQTY," +
                               "FRETURNBASEQTY," +
                               "FORDERPRICE," +
                               "FTAXPRICE," +
                               "FACTUALPRICE," +
                               "FISREQUESTTORECEIVED," +
                               "FQUALIFIEDQTY," +
                               "FUNQUALIFIEDQTY," +
                               "FCONCESSIVERECQTY," +
                               "FQUALIFIEDBASEQTY," +
                               "FUNQUALIFIEDBASEQTY," +
                               "FCONCESSIVERECBASEQTY," +
                               "FBILLROWTYPEID," +
                               "FNONUMMATERIALNAME," +
                               "FTOFIXASSETSQTY," +
                               "FUNTOFIXASSETSQTY," +
                               "FCOREBILLID," +
                               "FCOREBILLENTRYID," +
                               "FCHECKRETURNEDQTY," +
                               "FCHECKRETURNEDBASEQTY," +
                               "FPURCHASEORGUNITID," +
                               "FQUALITYORGUNITID," +
                               "FISCHECK," +
                               "FISURGENTPASS," +
                               "FCHECKQTY," +
                               "FUNCHECKQTY," +
                               "FCHECKBASEQTY," +
                               "FUNCHECKBASEQTY," +
                               "FPURCONTRACTSEQ) " +
                               "Values( " +
                               ":FID," +
                               ":FSEQ," +
                               ":FSOURCEBILLID," +
                               ":FSOURCEBILLNUMBER," +
                               ":FSOURCEBILLTYPEID," +
                               ":FSOURCEBILLENTRYID," +
                               ":FSOURCEBILLENTRYSEQ," +
                               ":FASSCOEFFICIENT," +
                               ":FBASESTATUS," +
                               ":FMATERIALID," +
                               ":FUNITID," +
                               ":FBASEUNITID," +
                               ":FASSOCIATEQTY," +
                               ":FSTORAGEORGUNITID," +
                               ":FCOMPANYORGUNITID," +
                               ":FWAREHOUSEID," +
                               ":FQTY," +
                               ":FLOT,"+
                               ":FASSISTQTY," +
                               ":FBASEQTY," +
                               ":FREVERSEQTY," +
                               ":FRETURNSQTY," +
                               ":FPRICE," +
                               ":FAMOUNT," +
                               ":FUNITSTANDARDCOST," +
                               ":FSTANDARDCOST," +
                               ":FUNITACTUALCOST," +
                               ":FACTUALCOST," +
                               ":FISPRESENT," +
                               ":FPARENTID," +
                               ":FPURORDERID," +
                               ":FPURORDERENTRYID," +
                               ":FRECEIPTQTY," +
                               ":FPURORDERNUM," +
                               ":FPURORDERENTRYSEQ," +
                               ":FREVERSEBASEQTY," +
                               ":FRECEIPTBASEQTY," +
                               ":FRETURNBASEQTY," +
                               ":FORDERPRICE," +
                               ":FTAXPRICE," +
                               ":FACTUALPRICE," +
                               ":FISREQUESTTORECEIVED," +
                               ":FQUALIFIEDQTY," +
                               ":FUNQUALIFIEDQTY," +
                               ":FCONCESSIVERECQTY," +
                               ":FQUALIFIEDBASEQTY," +
                               ":FUNQUALIFIEDBASEQTY," +
                               ":FCONCESSIVERECBASEQTY," +
                               ":FBILLROWTYPEID," +
                               ":FNONUMMATERIALNAME," +
                               ":FTOFIXASSETSQTY," +
                               ":FUNTOFIXASSETSQTY," +
                               ":FCOREBILLID," +
                               ":FCOREBILLENTRYID," +
                               ":FCHECKRETURNEDQTY," +
                               ":FCHECKRETURNEDBASEQTY," +
                               ":FPURCHASEORGUNITID," +
                               ":FQUALITYORGUNITID," +
                               ":FISCHECK," +
                               ":FISURGENTPASS," +
                               ":FCHECKQTY," +
                               ":FUNCHECKQTY," +
                               ":FCHECKBASEQTY," +
                               ":FUNCHECKBASEQTY," +
                               ":FPURCONTRACTSEQ)";

        private string RelationCmdstr = "insert into t_bot_relation(" +
                                        "FID," +
                                        "FSRCENTITYID," +
                                        "FDESTENTITYID," +
                                        "FSRCOBJECTID," +
                                        "FDESTOBJECTID," +
                                        "FDATE," +
                                        "FOPERATORID," +
                                        "FISEFFECTED," +
                                        "FBOTMAPPINGID," +
                                        "FTYPE) " +
                                        "Values( " +
                                        ":FID," +
                                        ":FSRCENTITYID," +
                                        ":FDESTENTITYID," +
                                        ":FSRCOBJECTID," +
                                        ":FDESTOBJECTID," +
                                        ":FDATE," +
                                        ":FOPERATORID," +
                                        ":FISEFFECTED," +
                                        ":FBOTMAPPINGID," +
                                        ":FTYPE) ";

        //private string RelationEntryCmdstr = "";

        ///// <summary>
        ///// 采购收货单
        ///// </summary>
        ///// <returns></returns>
        //[WebMethod]
        //public string SyncPurReceivalBill()
        //{
        //    using (var conn = new OracleConnection(Properties.Settings.Default.EasCon))
        //    {
        //        OracleTransaction otransaction = null;
        //        try
        //        {
        //            conn.Open();
        //            otransaction = conn.BeginTransaction();//事务开始
                    
        //            //生成采购主表数据并导入
        //            GenerReceivalBill();
        //            AddReceivalBill(otransaction, conn);

        //            //生成采购收货子表数据并导入
        //            GetReceivalEntry();
        //            AddReceivalEntry(otransaction, conn);

        //            otransaction.Commit();//提交

        //        }
        //        catch
        //        {
        //            if (otransaction != null) 
        //                otransaction.Rollback();//回滚    
        //        }
        //    }

        //    return "Done";
        //}

        /// <summary>
        /// 传递WMS要与EAS同步的单据
        /// </summary>
        /// <param name="cOrderNumber">单据号</param>
        /// <param name="cEasNewOrder"></param>
        /// <param name="cGuid">单据GUID</param>
        /// <param name="iCount">fpurchasetype 表示是委外还是采购</param>
        /// <returns></returns>
        [WebMethod]
        public string SyncPurReceivalBill(string cOrderNumber,string cEasNewOrder, string cGuid, int iCount)
        {
            var dtRmStore = GetImportDataTable(cGuid);
            if (dtRmStore.Rows.Count < 1)
                return "无内容";
            var cUserName = dtRmStore.Rows[0]["cUser"].ToString();
            _fpurchasetype = iCount;
            using (var ocon = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                ocon.Open();
                {
                    using (var otran = ocon.BeginTransaction())
                    {
                        OracleCommand ocmd;
                        using (ocmd = new OracleCommand())
                        {
                            ocmd.Connection = ocon;
                            try
                            {

                                ocmd.CommandText = "select FNUMBER from T_IM_PurReceivalBill where FNUMBER=:FNUMBER";
                                ocmd.Parameters.Add(":FNUMBER", cEasNewOrder);
                                if (ocmd.ExecuteReader().Read())
                                    return "OK";
                                ocmd.Parameters.Clear();

                                //执行主表写入
                                ocmd.CommandText = BillCmdStr;
                                FillBill(cOrderNumber, cEasNewOrder, cUserName);
                                GenBillPara(ocmd);
                                ocmd.ExecuteNonQuery();

                                //执行子表写入，先填充，再写入
                                ocmd.CommandText = BillEntryCmdStr;
                                for (var i = 0; i < dtRmStore.Rows.Count; i++)
                                {
                                    ocmd.Parameters.Clear();
                                    var cInvCode = dtRmStore.Rows[i]["cInvCode"].ToString();
                                    var cInvName = dtRmStore.Rows[i]["cInvName"].ToString();
                                    var iQuantity = dtRmStore.Rows[i]["iQuantity"].ToString();
                                    var cLotNo= dtRmStore.Rows[i]["cLotNo"].ToString();
                                    FillBillEntry(cOrderNumber, cInvCode, iQuantity, cInvName, cLotNo, i + 1);
                                    GenBillEntryPara(ocmd);
                                    ocmd.ExecuteNonQuery();
                                }
                                ocmd.CommandText = RelationCmdstr;
                                ocmd.Parameters.Clear();
                                GenRelationPara(ocmd);
                                ocmd.ExecuteNonQuery();
                                
                                otran.Commit();
                                return "OK";
                            }

                            catch (OracleException ex)
                            {

                                otran.Rollback();
                                return ex.Message;
                            }
                        }
                    }
                }
            }
        }


        private DataTable GetImportDataTable(string cGuid)
        {
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                using (var cmd = new SqlCommand("select * from View_Compare_PoReceive where cGuid=@cGuid", con))
                {
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable("RmStore");
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        /// <summary>
        /// 给写入主表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", _receivalBill.FID);
            ocmd.Parameters.Add(":FCREATORID", _receivalBill.FCREATORID);
            ocmd.Parameters.Add(":FCREATETIME", _receivalBill.FCREATETIME);
            ocmd.Parameters.Add(":FCONTROLUNITID", _receivalBill.FCONTROLUNITID);
            ocmd.Parameters.Add(":FNUMBER", _receivalBill.FNUMBER);
            ocmd.Parameters.Add(":FBIZDATE", _receivalBill.FBIZDATE);
            ocmd.Parameters.Add(":FBASESTATUS", _receivalBill.FBASESTATUS);
            ocmd.Parameters.Add(":FBIZTYPEID", _receivalBill.FBIZTYPEID);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", _receivalBill.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FBILLTYPEID", _receivalBill.FBILLTYPEID);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", _receivalBill.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FTRANSACTIONTYPEID", _receivalBill.FTRANSACTIONTYPEID);
            ocmd.Parameters.Add(":FISINITBILL", _receivalBill.FISINITBILL);
            ocmd.Parameters.Add(":FSUPPLIERID", _receivalBill.FSUPPLIERID);
            ocmd.Parameters.Add(":FCONVERTMODE", _receivalBill.FCONVERTMODE);
            ocmd.Parameters.Add(":FISCENTRALBALANCE", _receivalBill.FISCENTRALBALANCE);
            ocmd.Parameters.Add(":FPURCHASETYPE", _receivalBill.FPURCHASETYPE);
            ocmd.Parameters.Add(":FMONTH", _receivalBill.FMONTH);
            ocmd.Parameters.Add(":FDAY", _receivalBill.FDAY);
            ocmd.Parameters.Add(":FYear", _receivalBill.FBIZDATE.Year);
            ocmd.Parameters.Add(":FPeriod", _receivalBill.FBIZDATE.Month);
            ocmd.Parameters.Add(":FIsReversed", "0");

        }


        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillEntryPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", _receivalEntry.FID);
            ocmd.Parameters.Add(":FSEQ", _receivalEntry.FSEQ);
            ocmd.Parameters.Add(":FSOURCEBILLID", _receivalEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FSOURCEBILLNUMBER", _receivalEntry.FSOURCEBILLNUMBER);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", _receivalEntry.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYID", _receivalEntry.FSOURCEBILLENTRYID);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYSEQ", _receivalEntry.FSOURCEBILLENTRYSEQ);
            ocmd.Parameters.Add(":FASSCOEFFICIENT", _receivalEntry.FASSCOEFFICIENT);
            ocmd.Parameters.Add(":FBASESTATUS", _receivalEntry.FBASESTATUS);
            ocmd.Parameters.Add(":FMATERIALID", _receivalEntry.FMATERIALID);
            ocmd.Parameters.Add(":FUNITID", _receivalEntry.FUNITID);
            ocmd.Parameters.Add(":FBASEUNITID", _receivalEntry.FBASEUNITID);
            ocmd.Parameters.Add(":FASSOCIATEQTY", _receivalEntry.FASSOCIATEQTY);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", _receivalEntry.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FCOMPANYORGUNITID", _receivalEntry.FCOMPANYORGUNITID);
            ocmd.Parameters.Add(":FWAREHOUSEID", _receivalEntry.FWAREHOUSEID);
            ocmd.Parameters.Add(":FQTY", _receivalEntry.FQTY);
            ocmd.Parameters.Add(":FLOT", _receivalEntry.FLOT);
            ocmd.Parameters.Add(":FASSISTQTY", _receivalEntry.FASSISTQTY);
            ocmd.Parameters.Add(":FBASEQTY", _receivalEntry.FBASEQTY);
            ocmd.Parameters.Add(":FREVERSEQTY", _receivalEntry.FREVERSEQTY);
            ocmd.Parameters.Add(":FRETURNSQTY", _receivalEntry.FRETURNSQTY);
            ocmd.Parameters.Add(":FPRICE", _receivalEntry.FPRICE);
            ocmd.Parameters.Add(":FAMOUNT", _receivalEntry.FAMOUNT);
            ocmd.Parameters.Add(":FUNITSTANDARDCOST", _receivalEntry.FUNITSTANDARDCOST);
            ocmd.Parameters.Add(":FSTANDARDCOST", _receivalEntry.FSTANDARDCOST);
            ocmd.Parameters.Add(":FUNITACTUALCOST", _receivalEntry.FUNITACTUALCOST);
            ocmd.Parameters.Add(":FACTUALCOST", _receivalEntry.FACTUALCOST);
            ocmd.Parameters.Add(":FISPRESENT", _receivalEntry.FISPRESENT);
            ocmd.Parameters.Add(":FPARENTID", _receivalEntry.FPARENTID);
            ocmd.Parameters.Add(":FPURORDERID", _receivalEntry.FPURORDERID);
            ocmd.Parameters.Add(":FPURORDERENTRYID", _receivalEntry.FPURORDERENTRYID);
            ocmd.Parameters.Add(":FRECEIPTQTY", _receivalEntry.FRECEIPTQTY);
            ocmd.Parameters.Add(":FPURORDERNUM", _receivalEntry.FPURORDERNUM);
            ocmd.Parameters.Add(":FPURORDERENTRYSEQ", _receivalEntry.FPURORDERENTRYSEQ);
            ocmd.Parameters.Add(":FREVERSEBASEQTY", _receivalEntry.FREVERSEBASEQTY);
            ocmd.Parameters.Add(":FRECEIPTBASEQTY", _receivalEntry.FRECEIPTBASEQTY);
            ocmd.Parameters.Add(":FRETURNBASEQTY", _receivalEntry.FRETURNBASEQTY);
            ocmd.Parameters.Add(":FORDERPRICE", _receivalEntry.FORDERPRICE);
            ocmd.Parameters.Add(":FTAXPRICE", _receivalEntry.FTAXPRICE);
            ocmd.Parameters.Add(":FACTUALPRICE", _receivalEntry.FACTUALPRICE);
            ocmd.Parameters.Add(":FISREQUESTTORECEIVED", _receivalEntry.FISREQUESTTORECEIVED);
            ocmd.Parameters.Add(":FQUALIFIEDQTY", _receivalEntry.FQUALIFIEDQTY);
            ocmd.Parameters.Add(":FUNQUALIFIEDQTY", _receivalEntry.FUNQUALIFIEDQTY);
            ocmd.Parameters.Add(":FCONCESSIVERECQTY", _receivalEntry.FCONCESSIVERECQTY);
            ocmd.Parameters.Add(":FQUALIFIEDBASEQTY", _receivalEntry.FQUALIFIEDBASEQTY);
            ocmd.Parameters.Add(":FUNQUALIFIEDBASEQTY", _receivalEntry.FUNQUALIFIEDBASEQTY);
            ocmd.Parameters.Add(":FCONCESSIVERECBASEQTY", _receivalEntry.FCONCESSIVERECBASEQTY);
            ocmd.Parameters.Add(":FBILLROWTYPEID", _receivalEntry.FBILLROWTYPEID);
            ocmd.Parameters.Add(":FNONUMMATERIALNAME", _receivalEntry.FNONUMMATERIALNAME);
            ocmd.Parameters.Add(":FTOFIXASSETSQTY", _receivalEntry.FTOFIXASSETSQTY);
            ocmd.Parameters.Add(":FUNTOFIXASSETSQTY", _receivalEntry.FUNTOFIXASSETSQTY);
            ocmd.Parameters.Add(":FCOREBILLID", _receivalEntry.FCOREBILLID);
            ocmd.Parameters.Add(":FCOREBILLENTRYID", _receivalEntry.FCOREBILLENTRYID);
            ocmd.Parameters.Add(":FCHECKRETURNEDQTY", _receivalEntry.FCHECKRETURNEDQTY);
            ocmd.Parameters.Add(":FCHECKRETURNEDBASEQTY", _receivalEntry.FCHECKRETURNEDBASEQTY);
            ocmd.Parameters.Add(":FPURCHASEORGUNITID", _receivalEntry.FPURCHASEORGUNITID);
            ocmd.Parameters.Add(":FQUALITYORGUNITID", _receivalEntry.FQUALITYORGUNITID);
            ocmd.Parameters.Add(":FISCHECK", _receivalEntry.FISCHECK);
            ocmd.Parameters.Add(":FISURGENTPASS", _receivalEntry.FISURGENTPASS);
            ocmd.Parameters.Add(":FCHECKQTY", _receivalEntry.FCHECKQTY);
            ocmd.Parameters.Add(":FUNCHECKQTY", _receivalEntry.FUNCHECKQTY);
            ocmd.Parameters.Add(":FCHECKBASEQTY", _receivalEntry.FCHECKBASEQTY);
            ocmd.Parameters.Add(":FUNCHECKBASEQTY", _receivalEntry.FUNCHECKBASEQTY);
            ocmd.Parameters.Add(":FPURCONTRACTSEQ", _receivalEntry.FPURCONTRACTSEQ);

        }

        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenRelationPara(OracleCommand ocmd)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            ocmd.Parameters.Add(":FID", iof.GetFID("59302EC6"));
            ocmd.Parameters.Add(":FSRCENTITYID", "3171BFAD");
            ocmd.Parameters.Add(":FDESTENTITYID", "15F2BD83");
            ocmd.Parameters.Add(":FSRCOBJECTID", _receivalEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FDESTOBJECTID", _receivalBill.FID);
            ocmd.Parameters.Add(":FDATE", DateTime.Now);
            ocmd.Parameters.Add(":FOPERATORID", "yofoto");
            ocmd.Parameters.Add(":FISEFFECTED", "1");
            ocmd.Parameters.Add(":FBOTMAPPINGID", "51899a5a-0108-1000-e000-032bdb991305045122C4");
            ocmd.Parameters.Add(":FTYPE", 1);

        }


        /// <summary>
        /// 填充主表数据
        /// </summary>
        /// <returns></returns>
        private void FillBill(string cOrderNumber,string cNewEasOrder,string cUserName)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            _receivalBill.FID = iof.GetFID("15F2BD83");
            //制单人
            var cUserId = iof.GetUserIDbyUserName(cUserName);
            _receivalBill.FCREATORID = string.IsNullOrEmpty(cUserId) ? "K7Li625bRC6r8uAH5mlIDRO33n8=" : cUserId;
            _storageUnit = iof.GetControlIDByOrderNumber(cOrderNumber, "T_SM_PurOrder");
            _receivalBill.FCREATETIME = DateTime.Now;
            _receivalBill.FCONTROLUNITID = _storageUnit;
            _receivalBill.FNUMBER = cNewEasOrder;

            _receivalBill.FBIZDATE = DateTime.Now;
            _receivalBill.FBASESTATUS = 1;
            _receivalBill.FBIZTYPEID = "d8e80652-0106-1000-e000-04c5c0a812202407435C";
            _receivalBill.FSOURCEBILLTYPEID = "510b6503-0105-1000-e000-010bc0a812fd463ED552";
            _receivalBill.FBILLTYPEID = "50957179-0105-1000-e000-0157c0a812fd463ED552";
            _receivalBill.FSTORAGEORGUNITID = _storageUnit;
            _receivalBill.FTRANSACTIONTYPEID = "DawAAAAPoAWwCNyn";
            _receivalBill.FISINITBILL = 0;
            _receivalBill.FSUPPLIERID = iof.GetSupplyByOrderNumber(cOrderNumber);
            _receivalBill.FCONVERTMODE = 0;
            _receivalBill.FISCENTRALBALANCE = 0;
            _receivalBill.FPURCHASETYPE = _fpurchasetype;
            _receivalBill.FMONTH = int.Parse(DateTime.Now.ToString("yyyyMM"));
            _receivalBill.FDAY = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

        }


        /// <summary>
        /// 填充子表数据
        /// </summary>
        /// <returns></returns>
        private void FillBillEntry(string cOrderNumber, string cInvCode, string iQuantity, string cInvName, string cLotNo, int iRowIndex)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            _receivalEntry.FID = iof.GetFID("A8919E76");
            _receivalEntry.FSEQ = iRowIndex;
            _receivalEntry.FMATERIALID = iof.GetInvCode(cInvCode);
            _receivalEntry.FSOURCEBILLID = iof.GetSourIDByOrderNumber(cOrderNumber, "T_SM_PurOrder");
            _receivalEntry.FSOURCEBILLNUMBER = cOrderNumber;
            _receivalEntry.FSOURCEBILLTYPEID = "510b6503-0105-1000-e000-010bc0a812fd463ED552";
            _receivalEntry.FSOURCEBILLENTRYID = iof.GetEntrySourIDByOrderNumber(_receivalEntry.FSOURCEBILLID, _receivalEntry.FMATERIALID, "T_SM_PurOrderEntry");
            var cSeq = iof.GetEntrySeqByEntryFid(_receivalEntry.FSOURCEBILLENTRYID, "T_SM_PurOrderEntry");
            int iSeq;
            if (!int.TryParse(cSeq, out iSeq))
            {
                iSeq = 1;
            }
            _receivalEntry.FSOURCEBILLENTRYSEQ =iSeq ;
            _receivalEntry.FASSCOEFFICIENT = 0;
            _receivalEntry.FBASESTATUS = 2;

            _receivalEntry.FUNITID = iof.GetInvUnit(_receivalEntry.FMATERIALID);
            _receivalEntry.FBASEUNITID = _receivalEntry.FUNITID;
            
            _receivalEntry.FSTORAGEORGUNITID = _storageUnit;
            _receivalEntry.FCOMPANYORGUNITID = _storageUnit;


            _receivalEntry.FWAREHOUSEID = iof.GetWarehouseIDByfID(_receivalEntry.FSOURCEBILLENTRYID, "T_SM_PurOrderEntry");

            //数量
            var cQty = iQuantity;
            decimal iQty;
            if (!decimal.TryParse(cQty, out iQty))
            {
                iQty = 0;
            }
            _receivalEntry.FQTY = iQty;
            _receivalEntry.FASSOCIATEQTY = iQty;
            _receivalEntry.FASSISTQTY = 0;
            _receivalEntry.FBASEQTY = iQty;
            //是否批次管理
            var bLot = iof.GetBLotById(_receivalEntry.FMATERIALID);
            if (bLot.Equals("1"))
            {
                _receivalEntry.FLOT = cLotNo;
            }
            else
            {
                _receivalEntry.FLOT = "";
            }
            _receivalEntry.FREVERSEQTY = 0;
            _receivalEntry.FRETURNSQTY = 0;
            _receivalEntry.FPRICE = 0;
            _receivalEntry.FAMOUNT = 0;
            _receivalEntry.FUNITSTANDARDCOST = 0;
            _receivalEntry.FSTANDARDCOST = 0;
            _receivalEntry.FUNITACTUALCOST = 0;
            _receivalEntry.FACTUALCOST = 0;
            _receivalEntry.FISPRESENT = 0;
            _receivalEntry.FPARENTID = _receivalBill.FID;
            _receivalEntry.FPURORDERID = _receivalEntry.FSOURCEBILLID;
            _receivalEntry.FPURORDERENTRYID = _receivalEntry.FSOURCEBILLENTRYID;
            _receivalEntry.FRECEIPTQTY = 0;
            _receivalEntry.FPURORDERNUM = cOrderNumber;
            _receivalEntry.FPURORDERENTRYSEQ = _receivalEntry.FSOURCEBILLENTRYSEQ;
            _receivalEntry.FREVERSEBASEQTY = 0;
            _receivalEntry.FRECEIPTBASEQTY = 0;
            _receivalEntry.FRETURNBASEQTY = 0;
            var cPrice = iof.GetEntryPriceByEntryFid(_receivalEntry.FSOURCEBILLENTRYID, "T_SM_PurOrderEntry");
            decimal iPrice;
            if (!decimal.TryParse(cPrice, out iPrice))
            {
                iPrice = 0;
            }
            _receivalEntry.FORDERPRICE = iPrice;
            _receivalEntry.FTAXPRICE = iPrice*(decimal)1.17;
            _receivalEntry.FACTUALPRICE = iPrice;
            _receivalEntry.FISREQUESTTORECEIVED = 1;
            _receivalEntry.FQUALIFIEDQTY = 0;
            _receivalEntry.FUNQUALIFIEDQTY = 0;
            _receivalEntry.FCONCESSIVERECQTY = 0;
            _receivalEntry.FQUALIFIEDBASEQTY = 0;
            _receivalEntry.FUNQUALIFIEDBASEQTY = 0;
            _receivalEntry.FCONCESSIVERECBASEQTY = 0;
            _receivalEntry.FBILLROWTYPEID = "00000000-0000-0000-0000-0000000000017C7DC4A3";
            _receivalEntry.FNONUMMATERIALNAME = cInvName;
            _receivalEntry.FTOFIXASSETSQTY = 0;
            _receivalEntry.FUNTOFIXASSETSQTY = 0;
            _receivalEntry.FCOREBILLID = _receivalEntry.FSOURCEBILLID;
            _receivalEntry.FCOREBILLENTRYID = _receivalEntry.FSOURCEBILLENTRYID;
            _receivalEntry.FCHECKRETURNEDQTY = 0;
            _receivalEntry.FCHECKRETURNEDBASEQTY = 0;
            _receivalEntry.FPURCHASEORGUNITID = _storageUnit;
            _receivalEntry.FQUALITYORGUNITID = _storageUnit;
            _receivalEntry.FISCHECK = 1;
            _receivalEntry.FISURGENTPASS = 0;
            _receivalEntry.FCHECKQTY = 0;
            _receivalEntry.FUNCHECKQTY =iQty;
            _receivalEntry.FCHECKBASEQTY = 0;
            _receivalEntry.FUNCHECKBASEQTY = iQty;
            _receivalEntry.FPURCONTRACTSEQ = 0;
        }

        ///// <summary>
        ///// 写入主表
        ///// </summary>
        ///// <returns></returns>
        //private bool AddReceivalBill(OracleTransaction otran,OracleConnection ocon)
        //{
        //    var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
        //    var ocmd = new OracleCommand();
        //    ocmd.Transaction = otran;
        //    ocmd.CommandText = "Insert into T_IM_PurReceivalBill(" +
        //                       "FID," +
        //                       "FCREATORID," +
        //                       "FCREATETIME," +
        //                       "FCONTROLUNITID," +
        //                       "FNUMBER," +
        //                       "FBIZDATE," +
        //                       "FBASESTATUS," +
        //                       "FBIZTYPEID," +
        //                       "FSOURCEBILLTYPEID," +
        //                       "FBILLTYPEID," +
        //                       "FSTORAGEORGUNITID," +
        //                       "FTRANSACTIONTYPEID," +
        //                       "FISINITBILL," +
        //                       "FSUPPLIERID," +
        //                       "FCONVERTMODE," +
        //                       "FISCENTRALBALANCE," +
        //                       "FPURCHASETYPE," +
        //                       "FMONTH," +
        //                       "FDAY) " +
        //                       "Values(" +
        //                       ":FID," +
        //                       ":FCREATORID," +
        //                       ":FCREATETIME," +
        //                       ":FCONTROLUNITID," +
        //                       ":FNUMBER," +
        //                       ":FBIZDATE," +
        //                       ":FBASESTATUS," +
        //                       ":FBIZTYPEID," +
        //                       ":FSOURCEBILLTYPEID," +
        //                       ":FBILLTYPEID," +
        //                       ":FSTORAGEORGUNITID," +
        //                       ":FTRANSACTIONTYPEID," +
        //                       ":FISINITBILL," +
        //                       ":FSUPPLIERID," +
        //                       ":FCONVERTMODE," +
        //                       ":FISCENTRALBALANCE," +
        //                       ":FPURCHASETYPE," +
        //                       ":FMONTH," +
        //                       ":FDAY )";
        //    ocmd.Parameters.Add(":FID", _receivalBill.FID);
        //    ocmd.Parameters.Add(":FCREATORID", _receivalBill.FCREATORID);
        //    ocmd.Parameters.Add(":FCREATETIME", _receivalBill.FCREATETIME);
        //    ocmd.Parameters.Add(":FCONTROLUNITID", _receivalBill.FCONTROLUNITID);
        //    ocmd.Parameters.Add(":FNUMBER", _receivalBill.FNUMBER);
        //    ocmd.Parameters.Add(":FBIZDATE", _receivalBill.FBIZDATE);
        //    ocmd.Parameters.Add(":FBASESTATUS", _receivalBill.FBASESTATUS);
        //    ocmd.Parameters.Add(":FBIZTYPEID", _receivalBill.FBIZTYPEID);
        //    ocmd.Parameters.Add(":FSOURCEBILLTYPEID", _receivalBill.FSOURCEBILLTYPEID);
        //    ocmd.Parameters.Add(":FBILLTYPEID", _receivalBill.FBILLTYPEID);
        //    ocmd.Parameters.Add(":FSTORAGEORGUNITID", _receivalBill.FSTORAGEORGUNITID);
        //    ocmd.Parameters.Add(":FTRANSACTIONTYPEID", _receivalBill.FTRANSACTIONTYPEID);
        //    ocmd.Parameters.Add(":FISINITBILL", _receivalBill.FISINITBILL);
        //    ocmd.Parameters.Add(":FSUPPLIERID", _receivalBill.FSUPPLIERID);
        //    ocmd.Parameters.Add(":FCONVERTMODE", _receivalBill.FCONVERTMODE);
        //    ocmd.Parameters.Add(":FISCENTRALBALANCE", _receivalBill.FISCENTRALBALANCE);
        //    ocmd.Parameters.Add(":FPURCHASETYPE", _receivalBill.FPURCHASETYPE);
        //    ocmd.Parameters.Add(":FMONTH", _receivalBill.FMONTH);
        //    ocmd.Parameters.Add(":FDAY", _receivalBill.FDAY);
        //    iof.ExecOracleCmd(ocmd, ocon, "写入采购收货主表");


            
        //    return true;
        //}

        ///// <summary>
        ///// 写入子表
        ///// </summary>
        ///// <returns></returns>
        //private bool AddReceivalEntry(OracleTransaction otran, OracleConnection ocon)
        //{
        //    var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
        //    var ocmd = new OracleCommand();
        //    ocmd.Transaction = otran;
        //    ocmd.CommandText = "Insert into T_IM_PurReceivalEntry(" +
        //                       "FID," +
        //                       "FSEQ," +
        //                       "FSOURCEBILLID," +
        //                       "FSOURCEBILLNUMBER," +
        //                       "FSOURCEBILLTYPEID," +
        //                       "FSOURCEBILLENTRYID," +
        //                       "FSOURCEBILLENTRYSEQ," +
        //                       "FASSCOEFFICIENT," +
        //                       "FBASESTATUS," +
        //                       "FMATERIALID," +
        //                       "FUNITID," +
        //                       "FBASEUNITID," +
        //                       "FASSOCIATEQTY," +
        //                       "FSTORAGEORGUNITID," +
        //                       "FCOMPANYORGUNITID," +
        //                       "FWAREHOUSEID," +
        //                       "FQTY," +
        //                       "FASSISTQTY," +
        //                       "FBASEQTY," +
        //                       "FREVERSEQTY," +
        //                       "FRETURNSQTY," +
        //                       "FPRICE," +
        //                       "FAMOUNT," +
        //                       "FUNITSTANDARDCOST," +
        //                       "FSTANDARDCOST," +
        //                       "FUNITACTUALCOST," +
        //                       "FACTUALCOST," +
        //                       "FISPRESENT," +
        //                       "FPARENTID," +
        //                       "FPURORDERID," +
        //                       "FPURORDERENTRYID," +
        //                       "FRECEIPTQTY," +
        //                       "FPURORDERNUM," +
        //                       "FPURORDERENTRYSEQ," +
        //                       "FREVERSEBASEQTY," +
        //                       "FRECEIPTBASEQTY," +
        //                       "FRETURNBASEQTY," +
        //                       "FORDERPRICE," +
        //                       "FTAXPRICE," +
        //                       "FACTUALPRICE," +
        //                       "FISREQUESTTORECEIVED," +
        //                       "FQUALIFIEDQTY," +
        //                       "FUNQUALIFIEDQTY," +
        //                       "FCONCESSIVERECQTY," +
        //                       "FQUALIFIEDBASEQTY," +
        //                       "FUNQUALIFIEDBASEQTY," +
        //                       "FCONCESSIVERECBASEQTY," +
        //                       "FBILLROWTYPEID," +
        //                       "FNONUMMATERIALNAME," +
        //                       "FTOFIXASSETSQTY," +
        //                       "FUNTOFIXASSETSQTY," +
        //                       "FCOREBILLID," +
        //                       "FCOREBILLENTRYID," +
        //                       "FCHECKRETURNEDQTY," +
        //                       "FCHECKRETURNEDBASEQTY," +
        //                       "FPURCHASEORGUNITID," +
        //                       "FISCHECK," +
        //                       "FISURGENTPASS," +
        //                       "FCHECKQTY," +
        //                       "FUNCHECKQTY," +
        //                       "FCHECKBASEQTY," +
        //                       "FUNCHECKBASEQTY," +
        //                       "FPURCONTRACTSEQ) " +
        //                       "Values( " +
        //                       ":FID," +
        //                       ":FSEQ," +
        //                       ":FSOURCEBILLID," +
        //                       ":FSOURCEBILLNUMBER," +
        //                       ":FSOURCEBILLTYPEID," +
        //                       ":FSOURCEBILLENTRYID," +
        //                       ":FSOURCEBILLENTRYSEQ," +
        //                       ":FASSCOEFFICIENT," +
        //                       ":FBASESTATUS," +
        //                       ":FMATERIALID," +
        //                       ":FUNITID," +
        //                       ":FBASEUNITID," +
        //                       ":FASSOCIATEQTY," +
        //                       ":FSTORAGEORGUNITID," +
        //                       ":FCOMPANYORGUNITID," +
        //                       ":FWAREHOUSEID," +
        //                       ":FQTY," +
        //                       ":FASSISTQTY," +
        //                       ":FBASEQTY," +
        //                       ":FREVERSEQTY," +
        //                       ":FRETURNSQTY," +
        //                       ":FPRICE," +
        //                       ":FAMOUNT," +
        //                       ":FUNITSTANDARDCOST," +
        //                       ":FSTANDARDCOST," +
        //                       ":FUNITACTUALCOST," +
        //                       ":FACTUALCOST," +
        //                       ":FISPRESENT," +
        //                       ":FPARENTID," +
        //                       ":FPURORDERID," +
        //                       ":FPURORDERENTRYID," +
        //                       ":FRECEIPTQTY," +
        //                       ":FPURORDERNUM," +
        //                       ":FPURORDERENTRYSEQ," +
        //                       ":FREVERSEBASEQTY," +
        //                       ":FRECEIPTBASEQTY," +
        //                       ":FRETURNBASEQTY," +
        //                       ":FORDERPRICE," +
        //                       ":FTAXPRICE," +
        //                       ":FACTUALPRICE," +
        //                       ":FISREQUESTTORECEIVED," +
        //                       ":FQUALIFIEDQTY," +
        //                       ":FUNQUALIFIEDQTY," +
        //                       ":FCONCESSIVERECQTY," +
        //                       ":FQUALIFIEDBASEQTY," +
        //                       ":FUNQUALIFIEDBASEQTY," +
        //                       ":FCONCESSIVERECBASEQTY," +
        //                       ":FBILLROWTYPEID," +
        //                       ":FNONUMMATERIALNAME," +
        //                       ":FTOFIXASSETSQTY," +
        //                       ":FUNTOFIXASSETSQTY," +
        //                       ":FCOREBILLID," +
        //                       ":FCOREBILLENTRYID," +
        //                       ":FCHECKRETURNEDQTY," +
        //                       ":FCHECKRETURNEDBASEQTY," +
        //                       ":FPURCHASEORGUNITID," +
        //                       ":FISCHECK," +
        //                       ":FISURGENTPASS," +
        //                       ":FCHECKQTY," +
        //                       ":FUNCHECKQTY," +
        //                       ":FCHECKBASEQTY," +
        //                       ":FUNCHECKBASEQTY," +
        //                       ":FPURCONTRACTSEQ)";

        //    ocmd.Parameters.Add(":FID", _receivalEntry.FID);
        //    ocmd.Parameters.Add(":FSEQ", _receivalEntry.FSEQ);
        //    ocmd.Parameters.Add(":FSOURCEBILLID", _receivalEntry.FSOURCEBILLID);
        //    ocmd.Parameters.Add(":FSOURCEBILLNUMBER", _receivalEntry.FSOURCEBILLNUMBER);
        //    ocmd.Parameters.Add(":FSOURCEBILLTYPEID", _receivalEntry.FSOURCEBILLTYPEID);
        //    ocmd.Parameters.Add(":FSOURCEBILLENTRYID", _receivalEntry.FSOURCEBILLENTRYID);
        //    ocmd.Parameters.Add(":FSOURCEBILLENTRYSEQ", _receivalEntry.FSOURCEBILLENTRYSEQ);
        //    ocmd.Parameters.Add(":FASSCOEFFICIENT", _receivalEntry.FASSCOEFFICIENT);
        //    ocmd.Parameters.Add(":FBASESTATUS", _receivalEntry.FBASESTATUS);
        //    ocmd.Parameters.Add(":FMATERIALID", _receivalEntry.FMATERIALID);
        //    ocmd.Parameters.Add(":FUNITID", _receivalEntry.FUNITID);
        //    ocmd.Parameters.Add(":FBASEUNITID", _receivalEntry.FBASEUNITID);
        //    ocmd.Parameters.Add(":FASSOCIATEQTY", _receivalEntry.FASSOCIATEQTY);
        //    ocmd.Parameters.Add(":FSTORAGEORGUNITID", _receivalEntry.FSTORAGEORGUNITID);
        //    ocmd.Parameters.Add(":FCOMPANYORGUNITID", _receivalEntry.FCOMPANYORGUNITID);
        //    ocmd.Parameters.Add(":FWAREHOUSEID", _receivalEntry.FWAREHOUSEID);
        //    ocmd.Parameters.Add(":FQTY", _receivalEntry.FQTY);
        //    ocmd.Parameters.Add(":FASSISTQTY", _receivalEntry.FASSISTQTY);
        //    ocmd.Parameters.Add(":FBASEQTY", _receivalEntry.FBASEQTY);
        //    ocmd.Parameters.Add(":FREVERSEQTY", _receivalEntry.FREVERSEQTY);
        //    ocmd.Parameters.Add(":FRETURNSQTY", _receivalEntry.FRETURNSQTY);
        //    ocmd.Parameters.Add(":FPRICE", _receivalEntry.FPRICE);
        //    ocmd.Parameters.Add(":FAMOUNT", _receivalEntry.FAMOUNT);
        //    ocmd.Parameters.Add(":FUNITSTANDARDCOST", _receivalEntry.FUNITSTANDARDCOST);
        //    ocmd.Parameters.Add(":FSTANDARDCOST", _receivalEntry.FSTANDARDCOST);
        //    ocmd.Parameters.Add(":FUNITACTUALCOST", _receivalEntry.FUNITACTUALCOST);
        //    ocmd.Parameters.Add(":FACTUALCOST", _receivalEntry.FACTUALCOST);
        //    ocmd.Parameters.Add(":FISPRESENT", _receivalEntry.FISPRESENT);
        //    ocmd.Parameters.Add(":FPARENTID", _receivalEntry.FPARENTID);
        //    ocmd.Parameters.Add(":FPURORDERID", _receivalEntry.FPURORDERID);
        //    ocmd.Parameters.Add(":FPURORDERENTRYID", _receivalEntry.FPURORDERENTRYID);
        //    ocmd.Parameters.Add(":FRECEIPTQTY", _receivalEntry.FRECEIPTQTY);
        //    ocmd.Parameters.Add(":FPURORDERNUM", _receivalEntry.FPURORDERNUM);
        //    ocmd.Parameters.Add(":FPURORDERENTRYSEQ", _receivalEntry.FPURORDERENTRYSEQ);
        //    ocmd.Parameters.Add(":FREVERSEBASEQTY", _receivalEntry.FREVERSEBASEQTY);
        //    ocmd.Parameters.Add(":FRECEIPTBASEQTY", _receivalEntry.FRECEIPTBASEQTY);
        //    ocmd.Parameters.Add(":FRETURNBASEQTY", _receivalEntry.FRETURNBASEQTY);
        //    ocmd.Parameters.Add(":FORDERPRICE", _receivalEntry.FORDERPRICE);
        //    ocmd.Parameters.Add(":FTAXPRICE", _receivalEntry.FTAXPRICE);
        //    ocmd.Parameters.Add(":FACTUALPRICE", _receivalEntry.FACTUALPRICE);
        //    ocmd.Parameters.Add(":FISREQUESTTORECEIVED", _receivalEntry.FISREQUESTTORECEIVED);
        //    ocmd.Parameters.Add(":FQUALIFIEDQTY", _receivalEntry.FQUALIFIEDQTY);
        //    ocmd.Parameters.Add(":FUNQUALIFIEDQTY", _receivalEntry.FUNQUALIFIEDQTY);
        //    ocmd.Parameters.Add(":FCONCESSIVERECQTY", _receivalEntry.FCONCESSIVERECQTY);
        //    ocmd.Parameters.Add(":FQUALIFIEDBASEQTY", _receivalEntry.FQUALIFIEDBASEQTY);
        //    ocmd.Parameters.Add(":FUNQUALIFIEDBASEQTY", _receivalEntry.FUNQUALIFIEDBASEQTY);
        //    ocmd.Parameters.Add(":FCONCESSIVERECBASEQTY", _receivalEntry.FCONCESSIVERECBASEQTY);
        //    ocmd.Parameters.Add(":FBILLROWTYPEID", _receivalEntry.FBILLROWTYPEID);
        //    ocmd.Parameters.Add(":FNONUMMATERIALNAME", _receivalEntry.FNONUMMATERIALNAME);
        //    ocmd.Parameters.Add(":FTOFIXASSETSQTY", _receivalEntry.FTOFIXASSETSQTY);
        //    ocmd.Parameters.Add(":FUNTOFIXASSETSQTY", _receivalEntry.FUNTOFIXASSETSQTY);
        //    ocmd.Parameters.Add(":FCOREBILLID", _receivalEntry.FCOREBILLID);
        //    ocmd.Parameters.Add(":FCOREBILLENTRYID", _receivalEntry.FCOREBILLENTRYID);
        //    ocmd.Parameters.Add(":FCHECKRETURNEDQTY", _receivalEntry.FCHECKRETURNEDQTY);
        //    ocmd.Parameters.Add(":FCHECKRETURNEDBASEQTY", _receivalEntry.FCHECKRETURNEDBASEQTY);
        //    ocmd.Parameters.Add(":FPURCHASEORGUNITID", _receivalEntry.FPURCHASEORGUNITID);
        //    ocmd.Parameters.Add(":FISCHECK", _receivalEntry.FISCHECK);
        //    ocmd.Parameters.Add(":FISURGENTPASS", _receivalEntry.FISURGENTPASS);
        //    ocmd.Parameters.Add(":FCHECKQTY", _receivalEntry.FCHECKQTY);
        //    ocmd.Parameters.Add(":FUNCHECKQTY", _receivalEntry.FUNCHECKQTY);
        //    ocmd.Parameters.Add(":FCHECKBASEQTY", _receivalEntry.FCHECKBASEQTY);
        //    ocmd.Parameters.Add(":FUNCHECKBASEQTY", _receivalEntry.FUNCHECKBASEQTY);
        //    ocmd.Parameters.Add(":FPURCONTRACTSEQ", _receivalEntry.FPURCONTRACTSEQ);
        //    iof.ExecOracleCmd(ocmd,ocon, "写入采购收货子表");
        //    return true;
        //}


        ///// <summary>
        ///// 获取采购收货主表
        ///// </summary>
        ///// <returns></returns>
        //private bool GenerReceivalBill()
        //{
        //    var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
        //    _receivalBill.FID = iof.GetFID("71D272F1");
        //    _receivalBill.FCREATORID = "PIjE1WQ3Si6Vwf1xl/cX3xO33n8=";
        //    _receivalBill.FCREATETIME = DateTime.Now;
        //    _receivalBill.FCONTROLUNITID = "riQAAAAAAD7M567U";
        //    _receivalBill.FNUMBER = "PUA15015456";
        //    _receivalBill.FBIZDATE = DateTime.Now;
        //    _receivalBill.FBASESTATUS = 2;
        //    _receivalBill.FBIZTYPEID = "d8e80652-0106-1000-e000-04c5c0a812202407435C";
        //    _receivalBill.FSOURCEBILLTYPEID = "510b6503-0105-1000-e000-010bc0a812fd463ED552";
        //    _receivalBill.FBILLTYPEID = "50957179-0105-1000-e000-0157c0a812fd463ED552";
        //    _receivalBill.FSTORAGEORGUNITID = "riQAAAAAAD7M567U";
        //    _receivalBill.FTRANSACTIONTYPEID = "DawAAAAPoAewCNyn";
        //    _receivalBill.FISINITBILL = 0;
        //    _receivalBill.FSUPPLIERID = "riQAAAAAKLY3xn38";
        //    _receivalBill.FCONVERTMODE = 0;
        //    _receivalBill.FISCENTRALBALANCE = 0;
        //    _receivalBill.FPURCHASETYPE = 0;
        //    _receivalBill.FMONTH = int.Parse(DateTime.Now.ToString("yyyyMM"));
        //    _receivalBill.FDAY = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

           

        //    return true;
        //}

        ///// <summary>
        ///// 获取采购收货明细 
        ///// </summary>
        ///// <returns></returns>
        //private bool GetReceivalEntry()
        //{
        //    var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
        //    _receivalEntry.FID = iof.GetFID("71D272F1");
        //    _receivalEntry.FSEQ = 1;
        //    _receivalEntry.FSOURCEBILLID = "NiMGmyefTN6ZwlMBozsbwTFxv60=";
        //    _receivalEntry.FSOURCEBILLNUMBER = "PO2015010002";
        //    _receivalEntry.FSOURCEBILLTYPEID = "510b6503-0105-1000-e000-010bc0a812fd463ED552";
        //    _receivalEntry.FSOURCEBILLENTRYID = "+/jZEmfRQ6qJ7wgN686hmCYEHMU=";
        //    _receivalEntry.FSOURCEBILLENTRYSEQ = 2;
        //    _receivalEntry.FASSCOEFFICIENT = 0;
        //    _receivalEntry.FBASESTATUS = 2;
        //    _receivalEntry.FMATERIALID = "riQAAAAAN0pECefw";
        //    _receivalEntry.FUNITID = "riQAAAAALShbglxX";
        //    _receivalEntry.FBASEUNITID = "riQAAAAALShbglxX";
        //    _receivalEntry.FASSOCIATEQTY = 99;
        //    _receivalEntry.FSTORAGEORGUNITID = "riQAAAAAAD7M567U";
        //    _receivalEntry.FCOMPANYORGUNITID = "riQAAAAAAD7M567U";
        //    _receivalEntry.FWAREHOUSEID = "riQAAAAAJ2q76fiu";
        //    _receivalEntry.FQTY = 99;
        //    _receivalEntry.FASSISTQTY = 0;
        //    _receivalEntry.FBASEQTY = 99;
        //    _receivalEntry.FREVERSEQTY = 0;
        //    _receivalEntry.FRETURNSQTY = 0;
        //    _receivalEntry.FPRICE = 0;
        //    _receivalEntry.FAMOUNT = 0;
        //    _receivalEntry.FUNITSTANDARDCOST = 0;
        //    _receivalEntry.FSTANDARDCOST = 0;
        //    _receivalEntry.FUNITACTUALCOST = 0;
        //    _receivalEntry.FACTUALCOST = 0;
        //    _receivalEntry.FISPRESENT = 0;
        //    _receivalEntry.FPARENTID = _receivalBill.FID;
        //    _receivalEntry.FPURORDERID = "NiMGmyefTN6ZwlMBozsbwTFxv60=";
        //    _receivalEntry.FPURORDERENTRYID = "+/jZEmfRQ6qJ7wgN686hmCYEHMU=";
        //    _receivalEntry.FRECEIPTQTY = 0;
        //    _receivalEntry.FPURORDERNUM = "PO2015010002";
        //    _receivalEntry.FPURORDERENTRYSEQ = 2;
        //    _receivalEntry.FREVERSEBASEQTY = 0;
        //    _receivalEntry.FRECEIPTBASEQTY = 0;
        //    _receivalEntry.FRETURNBASEQTY = 0;
        //    _receivalEntry.FORDERPRICE = (decimal)84.615385;
        //    _receivalEntry.FTAXPRICE = 99;
        //    _receivalEntry.FACTUALPRICE = (decimal)84.615385;
        //    _receivalEntry.FISREQUESTTORECEIVED = 1;
        //    _receivalEntry.FQUALIFIEDQTY = 0;
        //    _receivalEntry.FUNQUALIFIEDQTY = 0;
        //    _receivalEntry.FCONCESSIVERECQTY = 0;
        //    _receivalEntry.FQUALIFIEDBASEQTY = 0;
        //    _receivalEntry.FUNQUALIFIEDBASEQTY = 0;
        //    _receivalEntry.FCONCESSIVERECBASEQTY = 0;
        //    _receivalEntry.FBILLROWTYPEID = "00000000-0000-0000-0000-0000000000017C7DC4A3";
        //    _receivalEntry.FNONUMMATERIALNAME = "葡萄酒酒杯";
        //    _receivalEntry.FTOFIXASSETSQTY = 0;
        //    _receivalEntry.FUNTOFIXASSETSQTY = 0;
        //    _receivalEntry.FCOREBILLID = "NiMGmyefTN6ZwlMBozsbwTFxv60=";
        //    _receivalEntry.FCOREBILLENTRYID = "+/jZEmfRQ6qJ7wgN686hmCYEHMU=";
        //    _receivalEntry.FCHECKRETURNEDQTY = 0;
        //    _receivalEntry.FCHECKRETURNEDBASEQTY = 0;
        //    _receivalEntry.FPURCHASEORGUNITID = "riQAAAAAAD7M567U";
        //    _receivalEntry.FISCHECK = 0;
        //    _receivalEntry.FISURGENTPASS = 0;
        //    _receivalEntry.FCHECKQTY = 0;
        //    _receivalEntry.FUNCHECKQTY = 99;
        //    _receivalEntry.FCHECKBASEQTY = 0;
        //    _receivalEntry.FUNCHECKBASEQTY = 99;
        //    _receivalEntry.FPURCONTRACTSEQ = 0;
        //    return true;
        //}

        
    }
}
