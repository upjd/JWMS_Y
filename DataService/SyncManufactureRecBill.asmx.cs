using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using Oracle.DataAccess.Client;

namespace DataService
{
    /// <summary>
    /// 生产入库单同步
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class SyncManufactureRecBill : System.Web.Services.WebService
    {

        /// <summary>
        /// 定义完工入库主表实例化
        /// </summary>
        private ManufactureRecBill mrbill=new ManufactureRecBill();
        /// <summary>
        /// 定义完工入库子表实例化
        /// </summary>
        private ManufactureRecBillEntry mrbillEntry = new ManufactureRecBillEntry();

        private string _storageUnit;
        #region 写入生产入库主表
        private string BillCmdStr = "insert into T_IM_ManufactureRecBill(" +
                                    "FID," +
                                    "FCREATORID," +
                                    "FCREATETIME," +
                                    "FLASTUPDATEUSERID," +
                                    "FLASTUPDATETIME," +
                                    "FCONTROLUNITID," +
                                    "FNUMBER," +
                                    "FBIZDATE," +
                                    "FAUDITORID," +
                                    "FSOURCEBILLID," +
                                    "FSOURCEFUNCTION," +
                                    "FAUDITTIME," +
                                    "FBASESTATUS," +
                                    "FBIZTYPEID," +
                                    "FSOURCEBILLTYPEID," +
                                    "FBILLTYPEID," +
                                    "FYEAR," +
                                    "FPERIOD," +
                                    "FSTORAGEORGUNITID," +
                                    "FADMINORGUNITID," +
                                    "FSTOCKERID," +
                                    "FTOTALQTY," +
                                    "FTOTALAMOUNT," +
                                    "FFIVOUCHERED," +
                                    "FTOTALSTANDARDCOST," +
                                    "FTOTALACTUALCOST," +
                                    "FISREVERSED," +
                                    "FTRANSACTIONTYPEID," +
                                    "FISINITBILL," +
                                    "FMODIFIERID," +
                                    "FMODIFICATIONTIME," +
                                    "FCOSTCENTERORGUNITID," +
                                    "FISBACKFLUSHSUCCEED," +
                                    "FMONTH," +
                                    "FDAY," +
                                    "FPROCESSORGUNITID)  " +

                                    "Values( " +
                                    ":FID," +
                                    ":FCREATORID," +
                                    ":FCREATETIME," +
                                    ":FLASTUPDATEUSERID," +
                                    ":FLASTUPDATETIME," +
                                    ":FCONTROLUNITID," +
                                    ":FNUMBER," +
                                    ":FBIZDATE," +
                                    ":FAUDITORID," +
                                    ":FSOURCEBILLID," +
                                    ":FSOURCEFUNCTION," +
                                    ":FAUDITTIME," +
                                    ":FBASESTATUS," +
                                    ":FBIZTYPEID," +
                                    ":FSOURCEBILLTYPEID," +
                                    ":FBILLTYPEID," +
                                    ":FYEAR," +
                                    ":FPERIOD," +
                                    ":FSTORAGEORGUNITID," +
                                    ":FADMINORGUNITID," +
                                    ":FSTOCKERID," +
                                    ":FTOTALQTY," +
                                    ":FTOTALAMOUNT," +
                                    ":FFIVOUCHERED," +
                                    ":FTOTALSTANDARDCOST," +
                                    ":FTOTALACTUALCOST," +
                                    ":FISREVERSED," +
                                    ":FTRANSACTIONTYPEID," +
                                    ":FISINITBILL," +
                                    ":FMODIFIERID," +
                                    ":FMODIFICATIONTIME," +
                                    ":FCOSTCENTERORGUNITID," +
                                    ":FISBACKFLUSHSUCCEED," +
                                    ":FMONTH," +
                                    ":FDAY," +
                                    ":FPROCESSORGUNITID)";
        #endregion


        #region 写入生产入库子表

        private string BillEntryCmdStr = "Insert into T_IM_ManufactureRecBillEntry(" +
                                         "FID," +
                                         "FSEQ," +
                                         "FSOURCEBILLID," +
                                         "FSOURCEBILLNUMBER," +
                                         "FSOURCEBILLENTRYID," +
                                         "FSOURCEBILLENTRYSEQ," +
                                         "FASSCOEFFICIENT," +
                                         "FBASESTATUS," +
                                         "FASSOCIATEQTY," +
                                         "FSOURCEBILLTYPEID," +
                                         "FMATERIALID," +
                                         "FUNITID," +
                                         "FBASEUNITID," +
                                         "FSTORAGEORGUNITID," +
                                         "FCOMPANYORGUNITID," +
                                         "FWAREHOUSEID," +
                                         "FLOT," +
                                         "FQTY," +
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
                                         "FMANUBILLID," +
                                         "FREVERSEBASEQTY," +
                                         "FRETURNBASEQTY," +
                                         "FCOSTOBJECTID," +
                                         "FRECQTY," +
                                         "FBASERECQTY," +
                                         "FMANUBILLNUMBER," +
                                         "FRECEIVEQTY," +
                                         "FMANUBILLENTRYSEQ," +
                                         "FSALEORDERENTRYSEQ," +
                                         "FBIZDATE," +
                                         "FCOSTCENTERORGUNITID," +
                                         "FADMINORGUNITID)  " +

                                         "Values(" +
                                         ":FID," +
                                         ":FSEQ," +
                                         ":FSOURCEBILLID," +
                                         ":FSOURCEBILLNUMBER," +
                                         ":FSOURCEBILLENTRYID," +
                                         ":FSOURCEBILLENTRYSEQ," +
                                         ":FASSCOEFFICIENT," +
                                         ":FBASESTATUS," +
                                         ":FASSOCIATEQTY," +
                                         ":FSOURCEBILLTYPEID," +
                                         ":FMATERIALID," +
                                         ":FUNITID," +
                                         ":FBASEUNITID," +
                                         ":FSTORAGEORGUNITID," +
                                         ":FCOMPANYORGUNITID," +
                                         ":FWAREHOUSEID," +
                                         ":FLOT," +
                                         ":FQTY," +
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
                                         ":FMANUBILLID," +
                                         ":FREVERSEBASEQTY," +
                                         ":FRETURNBASEQTY," +
                                         ":FCOSTOBJECTID," +
                                         ":FRECQTY," +
                                         ":FBASERECQTY," +
                                         ":FMANUBILLNUMBER," +
                                         ":FRECEIVEQTY," +
                                         ":FMANUBILLENTRYSEQ," +
                                         ":FSALEORDERENTRYSEQ," +
                                         ":FBIZDATE," +
                                         ":FCOSTCENTERORGUNITID," +
                                         ":FADMINORGUNITID)";


        #endregion

        /// <summary>
        /// 写上下游关系表
        /// </summary>
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


        /// <summary>
        /// 给写入主表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", mrbill.FID);
            ocmd.Parameters.Add(":FCREATORID", mrbill.FCREATORID);
            ocmd.Parameters.Add(":FCREATETIME", mrbill.FCREATETIME);
            ocmd.Parameters.Add(":FLASTUPDATEUSERID", mrbill.FLASTUPDATEUSERID);
            ocmd.Parameters.Add(":FLASTUPDATETIME", mrbill.FLASTUPDATETIME);
            ocmd.Parameters.Add(":FCONTROLUNITID", mrbill.FCONTROLUNITID);
            ocmd.Parameters.Add(":FNUMBER", mrbill.FNUMBER);
            ocmd.Parameters.Add(":FBIZDATE", mrbill.FBIZDATE);
            ocmd.Parameters.Add(":FAUDITORID", mrbill.FAUDITORID);
            ocmd.Parameters.Add(":FSOURCEBILLID", mrbill.FSOURCEBILLID);
            ocmd.Parameters.Add(":FSOURCEFUNCTION", mrbill.FSOURCEFUNCTION);
            ocmd.Parameters.Add(":FAUDITTIME", mrbill.FAUDITTIME);
            ocmd.Parameters.Add(":FBASESTATUS", mrbill.FBASESTATUS);
            ocmd.Parameters.Add(":FBIZTYPEID", mrbill.FBIZTYPEID);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", mrbill.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FBILLTYPEID", mrbill.FBILLTYPEID);
            ocmd.Parameters.Add(":FYEAR", mrbill.FYEAR);
            ocmd.Parameters.Add(":FPERIOD", mrbill.FPERIOD);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", mrbill.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FADMINORGUNITID", mrbill.FADMINORGUNITID);
            ocmd.Parameters.Add(":FSTOCKERID", mrbill.FSTOCKERID);
            ocmd.Parameters.Add(":FTOTALQTY", mrbill.FTOTALQTY);
            ocmd.Parameters.Add(":FTOTALAMOUNT", mrbill.FTOTALAMOUNT);
            ocmd.Parameters.Add(":FFIVOUCHERED", mrbill.FFIVOUCHERED);
            ocmd.Parameters.Add(":FTOTALSTANDARDCOST", mrbill.FTOTALSTANDARDCOST);
            ocmd.Parameters.Add(":FTOTALACTUALCOST", mrbill.FTOTALACTUALCOST);
            ocmd.Parameters.Add(":FISREVERSED", mrbill.FISREVERSED);
            ocmd.Parameters.Add(":FTRANSACTIONTYPEID", mrbill.FTRANSACTIONTYPEID);
            ocmd.Parameters.Add(":FISINITBILL", mrbill.FISINITBILL);
            ocmd.Parameters.Add(":FMODIFIERID", mrbill.FMODIFIERID);
            ocmd.Parameters.Add(":FMODIFICATIONTIME", mrbill.FMODIFICATIONTIME);
            ocmd.Parameters.Add(":FCOSTCENTERORGUNITID", mrbill.FCOSTCENTERORGUNITID);
            ocmd.Parameters.Add(":FISBACKFLUSHSUCCEED", mrbill.FISBACKFLUSHSUCCEED);
            ocmd.Parameters.Add(":FMONTH", mrbill.FMONTH);
            ocmd.Parameters.Add(":FDAY", mrbill.FDAY);
            ocmd.Parameters.Add(":FPROCESSORGUNITID", mrbill.FPROCESSORGUNITID);


        }


        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillEntryPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", mrbillEntry.FID);
            ocmd.Parameters.Add(":FSEQ", mrbillEntry.FSEQ);
            ocmd.Parameters.Add(":FSOURCEBILLID", mrbillEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FSOURCEBILLNUMBER", mrbillEntry.FSOURCEBILLNUMBER);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYID", mrbillEntry.FSOURCEBILLENTRYID);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYSEQ", mrbillEntry.FSOURCEBILLENTRYSEQ);
            ocmd.Parameters.Add(":FASSCOEFFICIENT", mrbillEntry.FASSCOEFFICIENT);
            ocmd.Parameters.Add(":FBASESTATUS", mrbillEntry.FBASESTATUS);
            ocmd.Parameters.Add(":FASSOCIATEQTY", mrbillEntry.FASSOCIATEQTY);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", mrbillEntry.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FMATERIALID", mrbillEntry.FMATERIALID);
            ocmd.Parameters.Add(":FUNITID", mrbillEntry.FUNITID);
            ocmd.Parameters.Add(":FBASEUNITID", mrbillEntry.FBASEUNITID);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", mrbillEntry.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FCOMPANYORGUNITID", mrbillEntry.FCOMPANYORGUNITID);
            ocmd.Parameters.Add(":FWAREHOUSEID", mrbillEntry.FWAREHOUSEID);
            ocmd.Parameters.Add(":FLOT", mrbillEntry.FLOT);
            ocmd.Parameters.Add(":FQTY", mrbillEntry.FQTY);
            ocmd.Parameters.Add(":FASSISTQTY", mrbillEntry.FASSISTQTY);
            ocmd.Parameters.Add(":FBASEQTY", mrbillEntry.FBASEQTY);
            ocmd.Parameters.Add(":FREVERSEQTY", mrbillEntry.FREVERSEQTY);
            ocmd.Parameters.Add(":FRETURNSQTY", mrbillEntry.FRETURNSQTY);
            ocmd.Parameters.Add(":FPRICE", mrbillEntry.FPRICE);
            ocmd.Parameters.Add(":FAMOUNT", mrbillEntry.FAMOUNT);
            ocmd.Parameters.Add(":FUNITSTANDARDCOST", mrbillEntry.FUNITSTANDARDCOST);
            ocmd.Parameters.Add(":FSTANDARDCOST", mrbillEntry.FSTANDARDCOST);
            ocmd.Parameters.Add(":FUNITACTUALCOST", mrbillEntry.FUNITACTUALCOST);
            ocmd.Parameters.Add(":FACTUALCOST", mrbillEntry.FACTUALCOST);
            ocmd.Parameters.Add(":FISPRESENT", mrbillEntry.FISPRESENT);
            ocmd.Parameters.Add(":FPARENTID", mrbillEntry.FPARENTID);
            ocmd.Parameters.Add(":FMANUBILLID", mrbillEntry.FMANUBILLID);
            ocmd.Parameters.Add(":FREVERSEBASEQTY", mrbillEntry.FREVERSEBASEQTY);
            ocmd.Parameters.Add(":FRETURNBASEQTY", mrbillEntry.FRETURNBASEQTY);
            ocmd.Parameters.Add(":FCOSTOBJECTID", mrbillEntry.FCOSTOBJECTID);
            ocmd.Parameters.Add(":FRECQTY", mrbillEntry.FRECQTY);
            ocmd.Parameters.Add(":FBASERECQTY", mrbillEntry.FBASERECQTY);
            ocmd.Parameters.Add(":FMANUBILLNUMBER", mrbillEntry.FMANUBILLNUMBER);
            ocmd.Parameters.Add(":FRECEIVEQTY", mrbillEntry.FRECEIVEQTY);
            ocmd.Parameters.Add(":FMANUBILLENTRYSEQ", mrbillEntry.FMANUBILLENTRYSEQ);
            ocmd.Parameters.Add(":FSALEORDERENTRYSEQ", mrbillEntry.FSALEORDERENTRYSEQ);
            ocmd.Parameters.Add(":FBIZDATE", mrbillEntry.FBIZDATE);
            ocmd.Parameters.Add(":FCOSTCENTERORGUNITID", mrbillEntry.FCOSTCENTERORGUNITID);
            ocmd.Parameters.Add(":FADMINORGUNITID", mrbillEntry.FADMINORGUNITID);

        }


        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenRelationPara(OracleCommand ocmd)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            ocmd.Parameters.Add(":FID", iof.GetFID("59302EC6"));
            ocmd.Parameters.Add(":FSRCENTITYID", "F2901DDD");
            ocmd.Parameters.Add(":FDESTENTITYID", "FA1292B4");
            ocmd.Parameters.Add(":FSRCOBJECTID", mrbillEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FDESTOBJECTID", mrbill.FID);
            ocmd.Parameters.Add(":FDATE", DateTime.Now);
            ocmd.Parameters.Add(":FOPERATORID", "yofoto");
            ocmd.Parameters.Add(":FISEFFECTED", "1");
            ocmd.Parameters.Add(":FBOTMAPPINGID", "+3X6yHlmQkeD/jXY/So0RARRIsQ=");
            ocmd.Parameters.Add(":FTYPE", "1");

        }


        /// <summary>
        /// 填充主表数据
        /// </summary>
        /// <returns></returns>
        private void FillBill(string cOrderNumber, string cNewEasOrder)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            mrbill.FID = iof.GetFID("FA1292B4");

            //制单人取生产订单审核人
            var cProductId = iof.GetProductOrderID(cOrderNumber);
            var cUserId = iof.GetUserIDByOrderNumber(cProductId, "T_MM_ProductionOrder");
            mrbill.FCREATORID = string.IsNullOrEmpty(cUserId) ? "K7Li625bRC6r8uAH5mlIDRO33n8=" : cUserId;
            
            mrbill.FCREATETIME = DateTime.Now;
            //mrbill.FLASTUPDATEUSERID = "OWRO3YImRBq4cK8lmqmQ/RO33n8=";
            //mrbill.FLASTUPDATETIME = ;
            _storageUnit = iof.GetStorageUnitByOrderNumber(cOrderNumber, "T_MM_FinishedRpt");
            mrbill.FCONTROLUNITID = _storageUnit;
            mrbill.FNUMBER = cNewEasOrder;

            var dDate = iof.ReturnBizDate();
            mrbill.FBIZDATE = dDate;
            mrbill.FAUDITORID = "";
            mrbill.FSOURCEBILLID = iof.GetSourIDByOrderNumber(cOrderNumber, "T_MM_FinishedRpt"); 
            //mrbill.FSOURCEFUNCTION = "";
            //mrbill.FAUDITTIME = "";
           //单据状态为保存状态
            mrbill.FBASESTATUS = "1";
            mrbill.FBIZTYPEID = "Nz878AEgEADgAABFwKg/GiQHQ1w=";
            mrbill.FSOURCEBILLTYPEID = "e3soUQaBR8un8D2R7UpNwkY+1VI=";
            mrbill.FBILLTYPEID = "50957179-0105-1000-e000-0167c0a812fd463ED552";
            mrbill.FYEAR = int.Parse(dDate.ToString("yyyy"));
            mrbill.FPERIOD = int.Parse(dDate.ToString("MM"));
            mrbill.FSTORAGEORGUNITID = _storageUnit;
            mrbill.FADMINORGUNITID = iof.GetWorkShopIDByOrderNumber(cOrderNumber, "T_MM_FinishedRpt");
            mrbill.FSTOCKERID = "";
            mrbill.FTOTALQTY = 0;
            mrbill.FTOTALAMOUNT = 0;
            mrbill.FFIVOUCHERED = 0;
            mrbill.FTOTALSTANDARDCOST = 0;
            mrbill.FTOTALACTUALCOST = 0;
            mrbill.FISREVERSED = 0;
            mrbill.FTRANSACTIONTYPEID = "DawAAAAPoCqwCNyn";
            mrbill.FISINITBILL = 0;
            //mrbill.FMODIFIERID = "OWRO3YImRBq4cK8lmqmQ/RO33n8=";
            //mrbill.FMODIFICATIONTIME = "03-7月 -14 04.25.49.939000000 下午";
            mrbill.FCOSTCENTERORGUNITID = mrbill.FADMINORGUNITID;
            mrbill.FISBACKFLUSHSUCCEED = "5";
            mrbill.FMONTH = int.Parse(dDate.ToString("yyyyMM"));
            mrbill.FDAY = int.Parse(dDate.ToString("yyyyMMdd"));
            mrbill.FPROCESSORGUNITID = _storageUnit;

        }


        /// <summary>
        /// 填充子表数据
        /// </summary>
        /// <returns></returns>
        private void FillBillEntry(string cOrderNumber, string cInvCode, string iQuantity, string cInvName, string cLotNo, int iRowIndex)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            mrbillEntry.FID = iof.GetFID("DBE1161E");
            mrbillEntry.FSEQ = iRowIndex;
            mrbillEntry.FSOURCEBILLID = iof.GetSourIDByOrderNumber(cOrderNumber, "T_MM_FinishedRpt"); 
            mrbillEntry.FSOURCEBILLNUMBER = cOrderNumber;
            //物料ID
            mrbillEntry.FMATERIALID = iof.GetInvCode(cInvCode);

            mrbillEntry.FSOURCEBILLENTRYID = iof.GetEntrySourIDByOrderNumber(mrbillEntry.FSOURCEBILLID, mrbillEntry.FMATERIALID, "T_MM_FinishedRptEntry");
            var cSeq = iof.GetEntrySeqByEntryFid(mrbillEntry.FSOURCEBILLENTRYID, "T_MM_FinishedRptEntry");
            int iSeq;
            if (!int.TryParse(cSeq, out iSeq))
            {
                iSeq = 1;
            }

            mrbillEntry.FSOURCEBILLENTRYSEQ = iSeq;
            mrbillEntry.FASSCOEFFICIENT = 0;
            mrbillEntry.FBASESTATUS = 2;

            //数量
            var cQty = iQuantity;
            decimal iQty;
            if (!decimal.TryParse(cQty, out iQty))
            {
                iQty = 0;
            }
            mrbillEntry.FASSOCIATEQTY = iQty;
            mrbillEntry.FSOURCEBILLTYPEID = "e3soUQaBR8un8D2R7UpNwkY+1VI=";

            mrbillEntry.FUNITID = iof.GetInvUnit(mrbillEntry.FMATERIALID);
            mrbillEntry.FBASEUNITID = mrbillEntry.FUNITID;
            mrbillEntry.FSTORAGEORGUNITID = _storageUnit;
            mrbillEntry.FCOMPANYORGUNITID = _storageUnit;
            mrbillEntry.FWAREHOUSEID = iof.GetWarehouseIDByfID(mrbillEntry.FSOURCEBILLENTRYID,"T_MM_FinishedRptEntry");
            //是否批次管理
            //var bLot = iof.GetBLotById(mrbillEntry.FMATERIALID);
            var bLot = iof.GetBLotById(mrbillEntry.FMATERIALID, mrbillEntry.FSTORAGEORGUNITID);
            if (bLot.Equals("1"))
            {
                mrbillEntry.FLOT = cLotNo;
            }
            else
            {
                mrbillEntry.FLOT = "";
            }
            
            mrbillEntry.FQTY = iQty;
            mrbillEntry.FASSISTQTY = 0;
            mrbillEntry.FBASEQTY = iQty;
            mrbillEntry.FREVERSEQTY = 0;
            mrbillEntry.FRETURNSQTY = 0;
            mrbillEntry.FPRICE = 0;
            mrbillEntry.FAMOUNT = 0;
            mrbillEntry.FUNITSTANDARDCOST = 0;
            mrbillEntry.FSTANDARDCOST = 0;
            mrbillEntry.FUNITACTUALCOST = 0;
            mrbillEntry.FACTUALCOST = 0;
            mrbillEntry.FISPRESENT = 0;
            mrbillEntry.FPARENTID = mrbill.FID;
            mrbillEntry.FMANUBILLID = iof.GetFProductionOrderID(mrbill.FSOURCEBILLID);
            mrbillEntry.FREVERSEBASEQTY = 0;
            mrbillEntry.FRETURNBASEQTY = 0;
            mrbillEntry.FCOSTOBJECTID = iof.GetCostByID(mrbillEntry.FMATERIALID, _storageUnit);//iof.GetCostByID(mrbillEntry.FMATERIALID)
            mrbillEntry.FRECQTY = 0;
            mrbillEntry.FBASERECQTY = 0;
            mrbillEntry.FMANUBILLNUMBER = iof.GetWorkOrder(mrbillEntry.FMANUBILLID);
            mrbillEntry.FRECEIVEQTY = iQty;
            mrbillEntry.FMANUBILLENTRYSEQ = 0;
            mrbillEntry.FSALEORDERENTRYSEQ = 0;

            var dDate = iof.ReturnBizDate();
            mrbillEntry.FBIZDATE = dDate;
            mrbillEntry.FCOSTCENTERORGUNITID = iof.GetWorkShopIDByOrderNumber(cOrderNumber);;
            mrbillEntry.FADMINORGUNITID = mrbillEntry.FCOSTCENTERORGUNITID;

        }

        /// <summary>
        /// 传递WMS要与EAS同步的单据
        /// </summary>
        /// <param name="cOrderNumber">单据号</param>
        /// <param name="cEasNewOrder"></param>
        /// <param name="cGuid">单据GUID</param>
        /// <param name="iCount">行数</param>
        /// <returns></returns>
        [WebMethod]
        public string SyncOrder(string cOrderNumber, string cEasNewOrder, string cGuid, int iCount)
        {
            //获取要同步的内容明细
            var dtProStore = GetImportDataTable(cGuid);
            if (dtProStore.Rows.Count < 1)
                return "无内容";
            using (var ocon = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                ocon.Open();
                {
                    //用事务提交
                    using (var otran = ocon.BeginTransaction())
                    {
                        OracleCommand ocmd;
                        using (ocmd = new OracleCommand())
                        {
                            ocmd.Connection = ocon;
                            try
                            {
                                ocmd.CommandText = "select FNUMBER from T_IM_ManufactureRecBill where FNUMBER=:FNUMBER";
                                ocmd.Parameters.Add(":FNUMBER",cEasNewOrder);
                                if (ocmd.ExecuteReader().Read())
                                    return "OK";
                                ocmd.Parameters.Clear();



                                //执行主表写入
                                ocmd.CommandText = BillCmdStr;
                                //给主表类赋值
                                FillBill(cOrderNumber, cEasNewOrder);
                                //给主表的参数赋值
                                GenBillPara(ocmd);

                                //执行写入
                                ocmd.ExecuteNonQuery();

                                //执行子表写入，先填充，再写入
                                ocmd.CommandText = BillEntryCmdStr;
                                //var dtProStore = GetImportDataTable(cGuid);
                                for (var i = 0; i < dtProStore.Rows.Count; i++)
                                {
                                    ocmd.Parameters.Clear();
                                    var cInvCode = dtProStore.Rows[i]["cInvCode"].ToString();
                                    var cInvName = dtProStore.Rows[i]["cInvName"].ToString();
                                    var iQuantity = dtProStore.Rows[i]["iQuantity"].ToString();
                                    var cLotNo = dtProStore.Rows[i]["cLotNo"].ToString();
                                    FillBillEntry(cOrderNumber, cInvCode, iQuantity, cInvName, cLotNo, i + 1);
                                    GenBillEntryPara(ocmd);
                                    ocmd.ExecuteNonQuery();
                                }
                                //写上下游单据
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
                using (var cmd = new SqlCommand("select * from  View_Compare_ProStore  where cGuid=@cGuid", con))
                {
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable("ProStore");
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
