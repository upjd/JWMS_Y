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
    /// 领料出库单同步
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class SyncMaterialReqBill : System.Web.Services.WebService
    {
        /// <summary>
        /// 领料出库单静养
        /// </summary>
        private MaterialReqBill mrbill = new MaterialReqBill();
        
        /// <summary>
        /// 领料出库单表体
        /// </summary>
        private MaterialReqBillEntry mrbillEntry = new MaterialReqBillEntry();


        private string cProProduct="";
        /// <summary>
        /// 库存组织
        /// </summary>
        private string _storageUnit;

        #region 写入领料出库主表语句

        private string BillCmdStr = "insert into T_IM_MaterialReqBill( " +
                                    "FID," +
                                    "FCREATORID," +
                                    "FCREATETIME," +
                                    "FLASTUPDATEUSERID," +
                                    "FLASTUPDATETIME," +
                                    "FCONTROLUNITID," +
                                    "FNUMBER," +
                                    "FBIZDATE," +
                                    "FAUDITORID," +
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
                                    "FPURCHASETYPE," +
                                    "FISBACKFLUSH," +
                                    "FMONTH," +
                                    "FDAY," +
                                    "FSUPPLYSTOREORGUNITID," +
                                    "FSUPPLYCOMPANYORGUNITID," +
                                    "FDEMANDCOMPANYORGUNITID)  " +

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
                                    ":FPURCHASETYPE," +
                                    ":FISBACKFLUSH," +
                                    ":FMONTH," +
                                    ":FDAY," +
                                    ":FSUPPLYSTOREORGUNITID," +
                                    ":FSUPPLYCOMPANYORGUNITID," +
                                    ":FDEMANDCOMPANYORGUNITID)";

        #endregion

        #region 写入领料出库子表语句

        private string BillEntryCmdStr = "insert into T_IM_MaterialReqBillEntry( " +
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
                                         "FLOCATIONID," +
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
                                         "FPRODUCTIDID," +
                                         "FORDERNUMBER," +
                                         "FPOBILLENTRYID," +
                                         "FEXP," +
                                         "FMFG," +
                                         "FREVERSEBASEQTY," +
                                         "FRETURNBASEQTY," +
                                         "FBASEUNITACTUALCOST," +
                                         "FCOSTOBJECTID," +
                                         "FUNRETURNEDBASEQTY," +
                                         "FORDERBILLID," +
                                         "FPRODUCTLINEID," +
                                         "FISSUEQTY," +
                                         "FBASEISSUEQTY," +
                                         "FPRODUCTLINEWPID," +
                                         "FFACARDQTY," +
                                         "FSUBWRITTENOFFQTY," +
                                         "FSUBWRITTENOFFBASEQTY," +
                                         "FSUBUNWRITEOFFQTY," +
                                         "FSUBUNWRITEOFFBASEQTY," +
                                         "FCOREBILLTYPEID," +
                                         "FCOREORDERENTRYSEQ," +
                                         "FCOREBILLNUMBER," +
                                         "FCOREBILLID," +
                                         "FCOREBILLENTRYID," +
                                         "FCOREBILLENTRYSE," +
                                         "FOPERATIONNO," +
                                         "FISADMEASURE," +
                                         "FISREWORK," +
                                         "FSCWRITTENOFFAMOUNT," +
                                         "FSCUNWRITTENOFFAMOUNT," +
                                         "FSUPPLYWAREHOUSEID," +
                                         "FSETTLEPRICE," +
                                         "FBIZDATE," +
                                         "FADMINORGUNITID," +
                                         "FCOSTCENTERORGUNITID)  " +

                                         "Values( " +
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
                                         ":FLOCATIONID," +
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
                                         ":FPRODUCTIDID," +
                                         ":FORDERNUMBER," +
                                         ":FPOBILLENTRYID," +
                                         ":FEXP," +
                                         ":FMFG," +
                                         ":FREVERSEBASEQTY," +
                                         ":FRETURNBASEQTY," +
                                         ":FBASEUNITACTUALCOST," +
                                         ":FCOSTOBJECTID," +
                                         ":FUNRETURNEDBASEQTY," +
                                         ":FORDERBILLID," +
                                         ":FPRODUCTLINEID," +
                                         ":FISSUEQTY," +
                                         ":FBASEISSUEQTY," +
                                         ":FPRODUCTLINEWPID," +
                                         ":FFACARDQTY," +
                                         ":FSUBWRITTENOFFQTY," +
                                         ":FSUBWRITTENOFFBASEQTY," +
                                         ":FSUBUNWRITEOFFQTY," +
                                         ":FSUBUNWRITEOFFBASEQTY," +
                                         ":FCOREBILLTYPEID," +
                                         ":FCOREORDERENTRYSEQ," +
                                         ":FCOREBILLNUMBER," +
                                         ":FCOREBILLID," +
                                         ":FCOREBILLENTRYID," +
                                         ":FCOREBILLENTRYSE," +
                                         ":FOPERATIONNO," +
                                         ":FISADMEASURE," +
                                         ":FISREWORK," +
                                         ":FSCWRITTENOFFAMOUNT," +
                                         ":FSCUNWRITTENOFFAMOUNT," +
                                         ":FSUPPLYWAREHOUSEID," +
                                         ":FSETTLEPRICE," +
                                         ":FBIZDATE," +
                                         ":FADMINORGUNITID," +
                                         ":FCOSTCENTERORGUNITID)";


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
        /// 填充主表数据
        /// </summary>
        /// <returns></returns>
        private void FillBill(string cOrderNumber, string cNewEasOrder)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            mrbill.FID = iof.GetFID("500AB75E");
            //制单人取生产订单审核人
            var cUserId = iof.GetUserIDByOrderNumber(cOrderNumber, "T_MM_ProductionOrder");
            mrbill.FCREATORID = string.IsNullOrEmpty(cUserId) ? "K7Li625bRC6r8uAH5mlIDRO33n8=" : cUserId;

            mrbill.FCREATETIME = DateTime.Now;
            //mrbill.FLASTUPDATEUSERID = "OWRO3YImRBq4cK8lmqmQ/RO33n8=";
            //mrbill.FLASTUPDATETIME =  ;

            _storageUnit = iof.GetStorageUnitByOrderNumber(cOrderNumber, "T_MM_ProductionOrder");
            mrbill.FCONTROLUNITID = _storageUnit;
            mrbill.FNUMBER = cNewEasOrder;
            var dDate = iof.ReturnBizDate();

            mrbill.FBIZDATE = dDate;
            //审核信息不传
            //mrbill.FAUDITORID = "OWRO3YImRBq4cK8lmqmQ/RO33n8=";
            //mrbill.FAUDITTIME = "03-7月 -14 04.31.20.079000000 下午";
            //获取生产什么东西
            cProProduct = iof.GetProProduct(cOrderNumber, "T_MM_ProductionOrder");

            mrbill.FBASESTATUS = 1;
            mrbill.FBIZTYPEID = "0rSFjAEeEADgAAyMwKgSQiQHQ1w=";
            mrbill.FSOURCEBILLTYPEID = "ejIZHXXTQliYCQJg9t4Re0Y+1VI=";
            mrbill.FBILLTYPEID = "50957179-0105-1000-e000-0163c0a812fd463ED552";
            mrbill.FYEAR = dDate.Year;
            mrbill.FPERIOD = dDate.Month;
            mrbill.FSTORAGEORGUNITID = _storageUnit;
            mrbill.FADMINORGUNITID = iof.GetWorkShopIDByOrderNumber(cOrderNumber, "T_MM_ProductionOrder");
            mrbill.FSTOCKERID = "";
            mrbill.FTOTALQTY = 0;
            mrbill.FTOTALAMOUNT = 0;
            mrbill.FFIVOUCHERED = 0;
            mrbill.FTOTALSTANDARDCOST = 0;
            mrbill.FTOTALACTUALCOST = 0;
            mrbill.FISREVERSED = 0;
            mrbill.FTRANSACTIONTYPEID = "DawAAAAPoCuwCNyn";
            mrbill.FISINITBILL = 0;
            //mrbill.FMODIFIERID = "OWRO3YImRBq4cK8lmqmQ/RO33n8=";
            //mrbill.FMODIFICATIONTIME = ;
            mrbill.FCOSTCENTERORGUNITID = iof.GetWorkShopIDByProductOrderNumber(cOrderNumber);
            mrbill.FPURCHASETYPE = "0";
            mrbill.FISBACKFLUSH = 0;
            mrbill.FMONTH = int.Parse(dDate.ToString("yyyyMM"));
            mrbill.FDAY = int.Parse(dDate.ToString("yyyyMMdd"));
            mrbill.FSUPPLYSTOREORGUNITID = _storageUnit;
            mrbill.FSUPPLYCOMPANYORGUNITID = _storageUnit;
            mrbill.FDEMANDCOMPANYORGUNITID = _storageUnit;

        }


        /// <summary>
        /// 填充子表数据
        /// </summary>
        /// <returns></returns>
        private void FillBillEntry(string cOrderNumber, string cInvCode, string iQuantity, string cInvName, string cLotNo, int iRowIndex)
        {

            

            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);

            var dDate = iof.ReturnBizDate();

            mrbillEntry.FID = iof.GetFID("11774BB4");
            mrbillEntry.FSEQ = iRowIndex;
            mrbillEntry.FMATERIALID = iof.GetInvCode(cInvCode);

            mrbillEntry.FSOURCEBILLID = iof.GetSourIDByOrderNumber(cOrderNumber, "T_MM_ProductionOrder");
            mrbillEntry.FSOURCEBILLNUMBER = cOrderNumber;
            mrbillEntry.FSOURCEBILLENTRYID = iof.GetEntrySourIDByOrderNumber(mrbillEntry.FSOURCEBILLID, mrbillEntry.FMATERIALID, "T_MM_ProductionOrderSEntry");
            mrbillEntry.FSOURCEBILLENTRYSEQ = 0;
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
            mrbillEntry.FSOURCEBILLTYPEID = "ejIZHXXTQliYCQJg9t4Re0Y+1VI=";

            mrbillEntry.FUNITID = iof.GetInvUnit(mrbillEntry.FMATERIALID);
            mrbillEntry.FBASEUNITID = mrbillEntry.FUNITID;
            mrbillEntry.FSTORAGEORGUNITID = _storageUnit;
            mrbillEntry.FCOMPANYORGUNITID = _storageUnit;
            mrbillEntry.FWAREHOUSEID = iof.GetDefaultWarehouseIDByfID(mrbillEntry.FSOURCEBILLENTRYID, "T_MM_ProductionOrderSEntry");
            mrbillEntry.FLOCATIONID = "";
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
            mrbillEntry.FUNITSTANDARDCOST =0;
            mrbillEntry.FSTANDARDCOST = 0;
            mrbillEntry.FUNITACTUALCOST = 0;
            mrbillEntry.FACTUALCOST = 0;
            mrbillEntry.FISPRESENT = 0;
            mrbillEntry.FPARENTID = mrbill.FID;
            mrbillEntry.FPRODUCTIDID = "";
            mrbillEntry.FORDERNUMBER = cOrderNumber;
            mrbillEntry.FPOBILLENTRYID = "";
            //生产日期、失效日期
            //mrbillEntry.FEXP = "25-12月-16 12.00.00.000000000 上午";
            //mrbillEntry.FMFG = "10-1月 -14 12.00.00.000000000 上午";
            mrbillEntry.FREVERSEBASEQTY = 0;
            mrbillEntry.FRETURNBASEQTY = 0;
            mrbillEntry.FBASEUNITACTUALCOST = 0;
            mrbillEntry.FCOSTOBJECTID = iof.GetCostByOrderNumber(cOrderNumber,_storageUnit);
            mrbillEntry.FUNRETURNEDBASEQTY = iQty;
            mrbillEntry.FORDERBILLID = mrbillEntry.FSOURCEBILLID;
            //生产线
            //mrbillEntry.FPRODUCTLINEID = "riQAAAAALs1tMiVM";
            mrbillEntry.FISSUEQTY = 0;
            mrbillEntry.FBASEISSUEQTY = 0;
            mrbillEntry.FPRODUCTLINEWPID = "";
            mrbillEntry.FFACARDQTY = 0;
            mrbillEntry.FSUBWRITTENOFFQTY = 0;
            mrbillEntry.FSUBWRITTENOFFBASEQTY = 0;
            mrbillEntry.FSUBUNWRITEOFFQTY = iQty;
            mrbillEntry.FSUBUNWRITEOFFBASEQTY = iQty;
            mrbillEntry.FCOREBILLTYPEID = "ejIZHXXTQliYCQJg9t4Re0Y+1VI=";
            mrbillEntry.FCOREORDERENTRYSEQ = 0;
            mrbillEntry.FCOREBILLNUMBER = cOrderNumber;
            mrbillEntry.FCOREBILLID = mrbillEntry.FSOURCEBILLID;
            mrbillEntry.FCOREBILLENTRYID = mrbillEntry.FSOURCEBILLENTRYID;
            mrbillEntry.FCOREBILLENTRYSE = 0;
            mrbillEntry.FOPERATIONNO = 0;
            mrbillEntry.FISADMEASURE = 0;
            //根据流程生产订单，判断是否返工
            if (mrbillEntry.FMATERIALID.Equals(cProProduct))
            {
                var cProductType = iof.GetProductType(cOrderNumber, "T_MM_ProductionOrder");
                mrbillEntry.FISREWORK = cProductType.Equals("20") ? 1 : 0;
            }
            else
            {
                mrbillEntry.FISREWORK =  0;
            }
            
            
            mrbillEntry.FSCWRITTENOFFAMOUNT = 0;
            mrbillEntry.FSCUNWRITTENOFFAMOUNT = 0;
            mrbillEntry.FSUPPLYWAREHOUSEID = "";
            mrbillEntry.FSETTLEPRICE = 0;
            mrbillEntry.FBIZDATE = dDate;

            mrbillEntry.FCOSTCENTERORGUNITID = mrbill.FCOSTCENTERORGUNITID;
            mrbillEntry.FADMINORGUNITID = mrbill.FCOSTCENTERORGUNITID;

        }



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
            ocmd.Parameters.Add(":FPURCHASETYPE", mrbill.FPURCHASETYPE);
            ocmd.Parameters.Add(":FISBACKFLUSH", mrbill.FISBACKFLUSH);
            ocmd.Parameters.Add(":FMONTH", mrbill.FMONTH);
            ocmd.Parameters.Add(":FDAY", mrbill.FDAY);
            ocmd.Parameters.Add(":FSUPPLYSTOREORGUNITID", mrbill.FSUPPLYSTOREORGUNITID);
            ocmd.Parameters.Add(":FSUPPLYCOMPANYORGUNITID", mrbill.FSUPPLYCOMPANYORGUNITID);
            ocmd.Parameters.Add(":FDEMANDCOMPANYORGUNITID", mrbill.FDEMANDCOMPANYORGUNITID);


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
            ocmd.Parameters.Add(":FLOCATIONID", mrbillEntry.FLOCATIONID);
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
            ocmd.Parameters.Add(":FPRODUCTIDID", mrbillEntry.FPRODUCTIDID);
            ocmd.Parameters.Add(":FORDERNUMBER", mrbillEntry.FORDERNUMBER);
            ocmd.Parameters.Add(":FPOBILLENTRYID", mrbillEntry.FPOBILLENTRYID);
            ocmd.Parameters.Add(":FEXP", mrbillEntry.FEXP);
            ocmd.Parameters.Add(":FMFG", mrbillEntry.FMFG);
            ocmd.Parameters.Add(":FREVERSEBASEQTY", mrbillEntry.FREVERSEBASEQTY);
            ocmd.Parameters.Add(":FRETURNBASEQTY", mrbillEntry.FRETURNBASEQTY);
            ocmd.Parameters.Add(":FBASEUNITACTUALCOST", mrbillEntry.FBASEUNITACTUALCOST);
            ocmd.Parameters.Add(":FCOSTOBJECTID", mrbillEntry.FCOSTOBJECTID);
            ocmd.Parameters.Add(":FUNRETURNEDBASEQTY", mrbillEntry.FUNRETURNEDBASEQTY);
            ocmd.Parameters.Add(":FORDERBILLID", mrbillEntry.FORDERBILLID);
            ocmd.Parameters.Add(":FPRODUCTLINEID", mrbillEntry.FPRODUCTLINEID);
            ocmd.Parameters.Add(":FISSUEQTY", mrbillEntry.FISSUEQTY);
            ocmd.Parameters.Add(":FBASEISSUEQTY", mrbillEntry.FBASEISSUEQTY);
            ocmd.Parameters.Add(":FPRODUCTLINEWPID", mrbillEntry.FPRODUCTLINEWPID);
            ocmd.Parameters.Add(":FFACARDQTY", mrbillEntry.FFACARDQTY);
            ocmd.Parameters.Add(":FSUBWRITTENOFFQTY", mrbillEntry.FSUBWRITTENOFFQTY);
            ocmd.Parameters.Add(":FSUBWRITTENOFFBASEQTY", mrbillEntry.FSUBWRITTENOFFBASEQTY);
            ocmd.Parameters.Add(":FSUBUNWRITEOFFQTY", mrbillEntry.FSUBUNWRITEOFFQTY);
            ocmd.Parameters.Add(":FSUBUNWRITEOFFBASEQTY", mrbillEntry.FSUBUNWRITEOFFBASEQTY);
            ocmd.Parameters.Add(":FCOREBILLTYPEID", mrbillEntry.FCOREBILLTYPEID);
            ocmd.Parameters.Add(":FCOREORDERENTRYSEQ", mrbillEntry.FCOREORDERENTRYSEQ);
            ocmd.Parameters.Add(":FCOREBILLNUMBER", mrbillEntry.FCOREBILLNUMBER);
            ocmd.Parameters.Add(":FCOREBILLID", mrbillEntry.FCOREBILLID);
            ocmd.Parameters.Add(":FCOREBILLENTRYID", mrbillEntry.FCOREBILLENTRYID);
            ocmd.Parameters.Add(":FCOREBILLENTRYSE", mrbillEntry.FCOREBILLENTRYSE);
            ocmd.Parameters.Add(":FOPERATIONNO", mrbillEntry.FOPERATIONNO);
            ocmd.Parameters.Add(":FISADMEASURE", mrbillEntry.FISADMEASURE);
            ocmd.Parameters.Add(":FISREWORK", mrbillEntry.FISREWORK);
            ocmd.Parameters.Add(":FSCWRITTENOFFAMOUNT", mrbillEntry.FSCWRITTENOFFAMOUNT);
            ocmd.Parameters.Add(":FSCUNWRITTENOFFAMOUNT", mrbillEntry.FSCUNWRITTENOFFAMOUNT);
            ocmd.Parameters.Add(":FSUPPLYWAREHOUSEID", mrbillEntry.FSUPPLYWAREHOUSEID);
            ocmd.Parameters.Add(":FSETTLEPRICE", mrbillEntry.FSETTLEPRICE);
            ocmd.Parameters.Add(":FBIZDATE", mrbillEntry.FBIZDATE);
            ocmd.Parameters.Add(":FADMINORGUNITID", mrbillEntry.FADMINORGUNITID);
            ocmd.Parameters.Add(":FCOSTCENTERORGUNITID", mrbillEntry.FCOSTCENTERORGUNITID);


        }

        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenRelationPara(OracleCommand ocmd)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            ocmd.Parameters.Add(":FID", iof.GetFID("59302EC6"));
            ocmd.Parameters.Add(":FSRCENTITYID", "1F66774E");
            ocmd.Parameters.Add(":FDESTENTITYID", "500AB75E");
            ocmd.Parameters.Add(":FSRCOBJECTID", mrbillEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FDESTOBJECTID", mrbill.FID);
            ocmd.Parameters.Add(":FDATE", DateTime.Now);
            ocmd.Parameters.Add(":FOPERATORID", "yofoto");
            ocmd.Parameters.Add(":FISEFFECTED", "1");
            ocmd.Parameters.Add(":FBOTMAPPINGID", "NO7rbo51RK2KZrWhTMuM2ARRIsQ=");
            ocmd.Parameters.Add(":FTYPE", 1);

        }


        /// <summary>
        /// 传递WMS要与EAS同步的单据
        /// </summary>
        /// <param name="cOrderNumber">单据号</param>
        /// <param name="cGuid">单据GUID</param>
        /// <param name="iCount">行数</param>
        /// <returns></returns>
        [WebMethod]
        public string SyncOrder(string cOrderNumber, string cEasNewOrder, string cGuid, int iCount)
        {
            var dtProduce = GetImportDataTable(cGuid);
            if (dtProduce.Rows.Count < 1)
                return "无内容";
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
                                ocmd.CommandText = "select FNUMBER from T_IM_MaterialReqBill where FNUMBER=:FNUMBER";
                                ocmd.Parameters.Add(":FNUMBER", cEasNewOrder);
                                if (ocmd.ExecuteReader().Read())
                                    return "OK";
                                ocmd.Parameters.Clear();


                                //执行主表写入
                                ocmd.CommandText = BillCmdStr;
                                FillBill(cOrderNumber, cEasNewOrder);
                                GenBillPara(ocmd);
                                ocmd.ExecuteNonQuery();

                                //执行子表写入，先填充，再写入
                                ocmd.CommandText = BillEntryCmdStr;
                                for (var i = 0; i < dtProduce.Rows.Count; i++)
                                {
                                    ocmd.Parameters.Clear();
                                    var cInvCode = dtProduce.Rows[i]["cInvCode"].ToString();
                                    var cInvName = dtProduce.Rows[i]["cInvName"].ToString();
                                    var iQuantity = dtProduce.Rows[i]["iQuantity"].ToString();
                                    var cLotNo = dtProduce.Rows[i]["cLotNo"].ToString();
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
                using (var cmd = new SqlCommand("select * from View_Compare_Produce where cGuid=@cGuid", con))
                {
                    cmd.Parameters.AddWithValue("@cGuid", cGuid);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable("Produce");
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
