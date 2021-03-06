﻿using System;
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
    /// 销售出库单同步
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class SyncSaleIssueBill : System.Web.Services.WebService
    {
        private SaleIssueBill sibill = new SaleIssueBill();
        private SaleIssueBillEntry sibillEntry = new SaleIssueBillEntry();

        /// <summary>
        /// 仓库
        /// </summary>
        private string _cWhareHouse;

        private string _cCusomer;

        private bool _bReturn ;
       #region 写入销售主表语句

        private string BillCmdStr = "insert into T_IM_SaleIssueBill( " +
                                    "FID, " +
                                    "FCREATORID, " +
                                    "FCREATETIME, " +
                                    "FLASTUPDATETIME, " +
                                    "FLASTUPDATEUSERID, " +
                                    "FCONTROLUNITID, " +
                                    "FNUMBER, " +
                                    "FBIZDATE, " +
                                    "FHANDLERID, " +
                                    "FDESCRIPTION, " +
                                    "FHASEFFECTED, " +
                                    "FAUDITORID, " +
                                    "FSOURCEBILLID, " +
                                    "FSOURCEFUNCTION, " +
                                    "FAUDITTIME, " +
                                    "FBASESTATUS, " +
                                    "FBIZTYPEID, " +
                                    "FSOURCEBILLTYPEID, " +
                                    "FBILLTYPEID, " +
                                    "FYEAR, " +
                                    "FPERIOD, " +
                                    "FSTORAGEORGUNITID, " +
                                    "FADMINORGUNITID, " +
                                    "FSTOCKERID, " +
                                    "FVOUCHERID, " +
                                    "FTOTALQTY, " +
                                    "FTOTALAMOUNT, " +
                                    "FFIVOUCHERED, " +
                                    "FTOTALSTANDARDCOST, " +
                                    "FTOTALACTUALCOST, " +
                                    "FISREVERSED, " +
                                    "FTRANSACTIONTYPEID, " +
                                    "FISINITBILL, " +
                                    "FCUSTOMERID, " +
                                    "FCURRENCYID, " +
                                    "FEXCHANGERATE, " +
                                    "FMODIFIERID, " +
                                    "FMODIFICATIONTIME, " +
                                    "FPaymentTypeID,"+
                                    "FCONVERTMODE, " +
                                    "FISSYSBILL, " +
                                    "FTOTALLOCALAMOUNT, " +
                                    "FACTBIZDATE, " +
                                    "FIsGenBizAR, " +
                                    "FISINTAX, " +
                                    "FMONTH, " +
                                    "FDAY, " +
                                    "FBILLRELATIONOPTION, " +
                                    "FCOSTCENTERORGUNITID) " +
                                    "Values( " +
                                    ":FID, " +
                                    ":FCREATORID, " +
                                    ":FCREATETIME, " +
                                    ":FLASTUPDATETIME, " +
                                    ":FLASTUPDATEUSERID, " +
                                    ":FCONTROLUNITID, " +
                                    ":FNUMBER, " +
                                    ":FBIZDATE, " +
                                    ":FHANDLERID, " +
                                    ":FDESCRIPTION, " +
                                    ":FHASEFFECTED, " +
                                    ":FAUDITORID, " +
                                    ":FSOURCEBILLID, " +
                                    ":FSOURCEFUNCTION, " +
                                    ":FAUDITTIME, " +
                                    ":FBASESTATUS, " +
                                    ":FBIZTYPEID, " +
                                    ":FSOURCEBILLTYPEID, " +
                                    ":FBILLTYPEID, " +
                                    ":FYEAR, " +
                                    ":FPERIOD, " +
                                    ":FSTORAGEORGUNITID, " +
                                    ":FADMINORGUNITID, " +
                                    ":FSTOCKERID, " +
                                    ":FVOUCHERID, " +
                                    ":FTOTALQTY, " +
                                    ":FTOTALAMOUNT, " +
                                    ":FFIVOUCHERED, " +
                                    ":FTOTALSTANDARDCOST, " +
                                    ":FTOTALACTUALCOST, " +
                                    ":FISREVERSED, " +
                                    ":FTRANSACTIONTYPEID, " +
                                    ":FISINITBILL, " +
                                    ":FCUSTOMERID, " +
                                    ":FCURRENCYID, " +
                                    ":FEXCHANGERATE, " +
                                    ":FMODIFIERID, " +
                                    ":FMODIFICATIONTIME, " +
                                    ":FPaymentTypeID," +
                                    ":FCONVERTMODE, " +
                                    ":FISSYSBILL, " +
                                    ":FTOTALLOCALAMOUNT, " +
                                    ":FACTBIZDATE, " +
                                    ":FIsGenBizAR, " +
                                    ":FISINTAX, " +
                                    ":FMONTH, " +
                                    ":FDAY, " +
                                    ":FBILLRELATIONOPTION, " +
                                    ":FCOSTCENTERORGUNITID) ";
         #endregion
         #region 写入销售出库子表语句

        private string BillEntryCmdStr = "insert into T_IM_SaleIssueEntry( " +
                                         "FID, " +
                                         "FSEQ, " +
                                         "FSOURCEBILLID, " +
                                         "FSOURCEBILLNUMBER, " +
                                         "FSOURCEBILLTYPEID, " +
                                         "FSOURCEBILLENTRYID, " +
                                         "FSOURCEBILLENTRYSEQ, " +
                                         "FASSCOEFFICIENT, " +
                                         "FBASESTATUS, " +
                                         "FMATERIALID, " +
                                         "FUNITID, " +
                                         "FBASEUNITID, " +
                                         "FASSISTUNITID, " +
                                         "FREASONCODEID, " +
                                         "FASSOCIATEQTY, " +
                                         "FSTORAGEORGUNITID, " +
                                         "FCOMPANYORGUNITID, " +
                                         "FWAREHOUSEID, " +
                                         "FLOCATIONID, " +
                                         "FSTOCKERID, " +
                                         "FLOT, " +
                                         "FQTY, " +
                                         "FASSISTQTY, " +
                                         "FBASEQTY, " +
                                         "FREVERSEQTY, " +
                                         "FRETURNSQTY, " +
                                         "FPRICE, " +
                                         "FAMOUNT, " +
                                         "FUNITSTANDARDCOST, " +
                                         "FSTANDARDCOST, " +
                                         "FUNITACTUALCOST, " +
                                         "FACTUALCOST, " +
                                         "FISPRESENT, " +
                                         "FPARENTID, " +
                                         "FSALEORDERID, " +
                                         "FSALEORDERENTRYID, " +
                                         "FWRITTENOFFQTY, " +
                                         "FWRITTENOFFAMOUNT, " +
                                         "FUNWRITEOFFQTY, " +
                                         "FUNWRITEOFFAMOUNT, " +
                                         "FORDERNUMBER, " +
                                         "FSALEORDERNUMBER, " +
                                         "FSALEORDERENTRYSEQ, " +
                                         "FTAXRATE, " +
                                         "FTAX, " +
                                         "FLOCALTAX, " +
                                         "FLOCALPRICE, " +
                                         "FLOCALAMOUNT, " +
                                         "FNONTAXAMOUNT, " +
                                         "FLOCALNONTAXAMOUNT, " +
                                         "FDREWQTY, " +
                                         "FASSISTPROPERTYID, " +
                                         "FMFG, " +
                                         "FEXP, " +
                                         "FREMARK, " +
                                         "FREVERSEBASEQTY, " +
                                         "FRETURNBASEQTY, " +
                                         "FWRITTENOFFBASEQTY, " +
                                         "FUNWRITEOFFBASEQTY, " +
                                         "FDREWBASEQTY, " +
                                         "FCOREBILLTYPEID, " +
                                         "FUNRETURNEDBASEQTY, " +
                                         "FISLOCKED, " +
                                         "FINVENTORYID, " +
                                         "FORDERPRICE, " +
                                         "FTAXPRICE, " +
                                         "FACTUALPRICE, " +
                                         "FSALEORGUNITID, " +
                                         "FSALEGROUPID, " +
                                         "FSALEPERSONID, " +
                                         "FBASEUNITACTUALCOST, " +
                                         "FUNDELIVERQTY, " +
                                         "FUNDELIVERBASEQTY, " +
                                         "FUNINQTY, " +
                                         "FUNINBASEQTY, " +
                                         "FBALANCECUSTOMERID, " +
                                         "FISCENTERBALANCE, " +
                                         "FISBETWEENCOMPANYSEND, " +
                                         "FTOTALINWAREHSQTY, " +
                                         "FPAYMENTCUSTOMERID, " +
                                         "FORDERCUSTOMERID, " +
                                         "FCONFIRMQTY, " +
                                         "FCONFIRMBASEQTY, " +
                                         "FASSOCIATEBASEQTY, " +
                                         "FCONFIRMDATE, " +
                                         "FSENDADDRESS, " +
                                         "FNETORDERBILLNUMBER, " +
                                         "FNETORDERBILLID, " +
                                         "FNETORDERBILLENTRYID, " +
                                         "FISSQUAREBALANCE, " +
                                         "FPROJECTID, " +
                                         "FTRACKNUMBERID, " +
                                         "FCONTRACTNUMBER, " +
                                         "FSUPPLIERID, " +
                                         "FSALEPRICE, " +
                                         "FDISCOUNTTYPE, " +
                                         "FDISCOUNTAMOUNT, " +
                                         "FDISCOUNT, " +
                                         "FUNSETTLEQTY, " +
                                         "FUNSETTLEBASEQTY, " +
                                         "FCURSETTLEBILLID, " +
                                         "FCURSETTLEBILLENTRYID, " +
                                         "FCURSETTLEQTY, " +
                                         "FTOTALSETTLEQTY, " +
                                         "FB2CBILLTYPE, " +
                                         "FBIZDATE, " +
                                         "FISFULLWRITEOFF) " +
                                         "Values( " +
                                         ":FID, " +
                                         ":FSEQ, " +
                                         ":FSOURCEBILLID, " +
                                         ":FSOURCEBILLNUMBER, " +
                                         ":FSOURCEBILLTYPEID, " +
                                         ":FSOURCEBILLENTRYID, " +
                                         ":FSOURCEBILLENTRYSEQ, " +
                                         ":FASSCOEFFICIENT, " +
                                         ":FBASESTATUS, " +
                                         ":FMATERIALID, " +
                                         ":FUNITID, " +
                                         ":FBASEUNITID, " +
                                         ":FASSISTUNITID, " +
                                         ":FREASONCODEID, " +
                                         ":FASSOCIATEQTY, " +
                                         ":FSTORAGEORGUNITID, " +
                                         ":FCOMPANYORGUNITID, " +
                                         ":FWAREHOUSEID, " +
                                         ":FLOCATIONID, " +
                                         ":FSTOCKERID, " +
                                         ":FLOT, " +
                                         ":FQTY, " +
                                         ":FASSISTQTY, " +
                                         ":FBASEQTY, " +
                                         ":FREVERSEQTY, " +
                                         ":FRETURNSQTY, " +
                                         ":FPRICE, " +
                                         ":FAMOUNT, " +
                                         ":FUNITSTANDARDCOST, " +
                                         ":FSTANDARDCOST, " +
                                         ":FUNITACTUALCOST, " +
                                         ":FACTUALCOST, " +
                                         ":FISPRESENT, " +
                                         ":FPARENTID, " +
                                         ":FSALEORDERID, " +
                                         ":FSALEORDERENTRYID, " +
                                         ":FWRITTENOFFQTY, " +
                                         ":FWRITTENOFFAMOUNT, " +
                                         ":FUNWRITEOFFQTY, " +
                                         ":FUNWRITEOFFAMOUNT, " +
                                         ":FORDERNUMBER, " +
                                         ":FSALEORDERNUMBER, " +
                                         ":FSALEORDERENTRYSEQ, " +
                                         ":FTAXRATE, " +
                                         ":FTAX, " +
                                         ":FLOCALTAX, " +
                                         ":FLOCALPRICE, " +
                                         ":FLOCALAMOUNT, " +
                                         ":FNONTAXAMOUNT, " +
                                         ":FLOCALNONTAXAMOUNT, " +
                                         ":FDREWQTY, " +
                                         ":FASSISTPROPERTYID, " +
                                         ":FMFG, " +
                                         ":FEXP, " +
                                         ":FREMARK, " +
                                         ":FREVERSEBASEQTY, " +
                                         ":FRETURNBASEQTY, " +
                                         ":FWRITTENOFFBASEQTY, " +
                                         ":FUNWRITEOFFBASEQTY, " +
                                         ":FDREWBASEQTY, " +
                                         ":FCOREBILLTYPEID, " +
                                         ":FUNRETURNEDBASEQTY, " +
                                         ":FISLOCKED, " +
                                         ":FINVENTORYID, " +
                                         ":FORDERPRICE, " +
                                         ":FTAXPRICE, " +
                                         ":FACTUALPRICE, " +
                                         ":FSALEORGUNITID, " +
                                         ":FSALEGROUPID, " +
                                         ":FSALEPERSONID, " +
                                         ":FBASEUNITACTUALCOST, " +
                                         ":FUNDELIVERQTY, " +
                                         ":FUNDELIVERBASEQTY, " +
                                         ":FUNINQTY, " +
                                         ":FUNINBASEQTY, " +
                                         ":FBALANCECUSTOMERID, " +
                                         ":FISCENTERBALANCE, " +
                                         ":FISBETWEENCOMPANYSEND, " +
                                         ":FTOTALINWAREHSQTY, " +
                                         ":FPAYMENTCUSTOMERID, " +
                                         ":FORDERCUSTOMERID, " +
                                         ":FCONFIRMQTY, " +
                                         ":FCONFIRMBASEQTY, " +
                                         ":FASSOCIATEBASEQTY, " +
                                         ":FCONFIRMDATE, " +
                                         ":FSENDADDRESS, " +
                                         ":FNETORDERBILLNUMBER, " +
                                         ":FNETORDERBILLID, " +
                                         ":FNETORDERBILLENTRYID, " +
                                         ":FISSQUAREBALANCE, " +
                                         ":FPROJECTID, " +
                                         ":FTRACKNUMBERID, " +
                                         ":FCONTRACTNUMBER, " +
                                         ":FSUPPLIERID, " +
                                         ":FSALEPRICE, " +
                                         ":FDISCOUNTTYPE, " +
                                         ":FDISCOUNTAMOUNT, " +
                                         ":FDISCOUNT, " +
                                         ":FUNSETTLEQTY, " +
                                         ":FUNSETTLEBASEQTY, " +
                                         ":FCURSETTLEBILLID, " +
                                         ":FCURSETTLEBILLENTRYID, " +
                                         ":FCURSETTLEQTY, " +
                                         ":FTOTALSETTLEQTY, " +
                                         ":FB2CBILLTYPE, " +
                                         ":FBIZDATE, " +
                                         ":FISFULLWRITEOFF) ";
#endregion

        /// <summary>
        /// 填充主表数据
        /// </summary>
        /// <returns></returns>
        private void FillBill(string cOrderNumber, string cNewEasOrder)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            sibill.FID = iof.GetFID("CC3E933B");
            sibill.FCREATORID = "9htALWzQRaGIR4lDJ2tNuRO33n8=";
            sibill.FCREATETIME=DateTime.Now;
            //sibill.FLASTUPDATETIME= ;
            //sibill.FLASTUPDATEUSERID="K7Li625bRC6r8uAH5mlIDRO33n8=";
            sibill.FCONTROLUNITID="riQAAAAAAD7M567U";
            sibill.FNUMBER = cNewEasOrder;
            var dDate = iof.ReturnBizDate();

            sibill.FBIZDATE = dDate;

            sibill.FHANDLERID="00000000-0000-0000-0000-00000000000013B7DE7F";
            //sibill.FDESCRIPTION="0";
            sibill.FHASEFFECTED= 0;
            //sibill.FAUDITORID="K7Li625bRC6r8uAH5mlIDRO33n8=";
            sibill.FSOURCEBILLID="0";
            sibill.FSOURCEFUNCTION="310";
            //sibill.FAUDITTIME="15-1月 -15 03.48.56.424000000 下午";
            sibill.FBASESTATUS=2;
            if (_bReturn)
            {
                sibill.FBIZTYPEID = "d8e80652-0110-1000-e000-04c5c0a812202407435C";
            }
            else
            {
                sibill.FBIZTYPEID = "d8e80652-010e-1000-e000-04c5c0a812202407435C";
            }
            
            sibill.FSOURCEBILLTYPEID="0";
            sibill.FBILLTYPEID="50957179-0105-1000-e000-015bc0a812fd463ED552";
            sibill.FYEAR = int.Parse(DateTime.Now.ToString("yyyy"));
            sibill.FPERIOD = int.Parse(DateTime.Now.ToString("MM"));
            sibill.FSTORAGEORGUNITID="riQAAAAAAD7M567U";
            sibill.FADMINORGUNITID="riQAAAAAAgbM567U";
            sibill.FSTOCKERID="0";
            sibill.FVOUCHERID="0";
            sibill.FTOTALQTY=0;
            sibill.FTOTALAMOUNT=(decimal)18381.1966;
            sibill.FFIVOUCHERED=0;
            sibill.FTOTALSTANDARDCOST=0;
            sibill.FTOTALACTUALCOST=0;
            sibill.FISREVERSED=0;
            
            sibill.FISINITBILL=0;
            sibill.FCUSTOMERID = string.IsNullOrEmpty(_cCusomer) ? "riQAAAADPwC/DAQO" : _cCusomer;
            
            sibill.FCURRENCYID="dfd38d11-00fd-1000-e000-1ebdc0a8100dDEB58FDC";
            sibill.FEXCHANGERATE=1;
            //sibill.FMODIFIERID = ;
            //sibill.FMODIFICATIONTIME="0";
            sibill.FCONVERTMODE=0;
            sibill.FISSYSBILL=0;
            sibill.FTOTALLOCALAMOUNT=0;
            sibill.FACTBIZDATE=null;
            sibill.FIsGenBizAR=0;
            sibill.FISINTAX=1;
            sibill.FMONTH = int.Parse(DateTime.Now.ToString("yyyyMM"));
            sibill.FDAY = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            //修改值 2015-10-12
            sibill.FBILLRELATIONOPTION=null;
            sibill.FCOSTCENTERORGUNITID=null;

            sibill.FPaymentTypeID = "cd54aa9f-03a4-459c-9c5a-5489dce5f0676BCA0AB5";
            //sibill.FAUDITORID = "9htALWzQRaGIR4lDJ2tNuRO33n8=";
            sibill.FLASTUPDATEUSERID = null;
            //sibill.FLASTUPDATETIME = DateTime.Now;
            //sibill.FAUDITTIME = DateTime.Now;
            sibill.FSTOCKERID = null;
            sibill.FVOUCHERID = null;
            sibill.FCOSTCENTERORGUNITID = null;
            sibill.FSOURCEBILLTYPEID = null;
            sibill.FDESCRIPTION = null;
            sibill.FHASEFFECTED = 0;
            sibill.FMODIFICATIONTIME = DateTime.Now;

        }

        /*
         * 
         update T_IM_SaleIssueBill 
set FlastupdateUserid='K7Li625bRC6r8uAH5mlIDRO33n8=',FauditorID='K7Li625bRC6r8uAH5mlIDRO33n8=',fpaymenttypeid='cd54aa9f-03a4-459c-9c5a-5489dce5f0676BCA0AB5',
flastupdatetime=fcreatetime,faudittime=fcreatetime,fstockerid=null,fvoucherid=null,fcostcenterorgunitid=null,fsourcebilltypeid=null,fdescription=null,fhaseffected=0
,fmodificationtime=null,fbasestatus=2
where fid in ('1d2xZMr2TAidqncU9Sam48w+kzs=','fL0QaL95SkyRu0Osx071w8w+kzs=')

update T_IM_SaleIssueEntry
set fsourcebillid=null,fsourcebillnumber=null,fsourcebillentryid=null,fassistunitid=null,freasoncodeid=null,flocationid=null,fstockerid=null
,fordernumber=null,fassistpropertyid=null,fconfirmdate=null,fbizdate=null,fInventoryID=null
where fparentid in ('1d2xZMr2TAidqncU9Sam48w+kzs=','fL0QaL95SkyRu0Osx071w8w+kzs=') 
         * 
         */
        /// <summary>
        /// 填充子表数据
        /// </summary>
        /// <returns></returns>
        private void FillBillEntry(string cOrderNumber, string cInvCode, string iQuantity, string cInvName, string cLotNo, int iRowIndex,string cWhCode)
        {
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            sibillEntry.FID = iof.GetFID("BBC07FBE"); 
            sibillEntry.FSEQ = iRowIndex;
            sibillEntry.FSOURCEBILLID = "0";
            sibillEntry.FSOURCEBILLNUMBER = "0";
            sibillEntry.FSOURCEBILLTYPEID = "510b6503-0105-1000-e000-0113c0a812fd463ED552";
            sibillEntry.FSOURCEBILLENTRYID = "0";
            sibillEntry.FSOURCEBILLENTRYSEQ = 1;
            sibillEntry.FASSCOEFFICIENT = 0;
            sibillEntry.FBASESTATUS = 2;

            sibillEntry.FMATERIALID = iof.GetInvCode(cInvCode);
            sibillEntry.FUNITID = iof.GetInvUnit(sibillEntry.FMATERIALID);
            sibillEntry.FBASEUNITID = sibillEntry.FUNITID;
            sibillEntry.FASSISTUNITID = "0";
            sibillEntry.FREASONCODEID = "0";


            //数量
            var cQty = iQuantity;
            decimal iQty;
            if (!decimal.TryParse(cQty, out iQty))
            {
                iQty = 0;
            }
            sibillEntry.FASSOCIATEQTY = iQty;
            sibillEntry.FSTORAGEORGUNITID = "riQAAAAAAD7M567U";
            sibillEntry.FCOMPANYORGUNITID = "riQAAAAAAD7M567U";
            //sibillEntry.FWAREHOUSEID = "riQAAAAALQy76fiu";
            //销售组织
            sibillEntry.FSALEORGUNITID = sibillEntry.FSTORAGEORGUNITID;
            if (!string.IsNullOrEmpty(cWhCode))
            {
                _cWhareHouse = iof.GetWareHouse(cWhCode);
                
            }
            sibillEntry.FWAREHOUSEID = _cWhareHouse;
            sibillEntry.FLOCATIONID = "0";
            sibillEntry.FSTOCKERID = "0";
            //是否批次管理
            //var bLot = iof.GetBLotById(sibillEntry.FMATERIALID);
            var bLot = iof.GetBLotById(sibillEntry.FMATERIALID, sibillEntry.FSTORAGEORGUNITID);
            if (bLot.Equals("1"))
            {
                sibillEntry.FLOT = cLotNo;
            }
            else
            {
                sibillEntry.FLOT = "";
            }
            sibillEntry.FQTY = iQty;
            sibillEntry.FASSISTQTY = 0;
            sibillEntry.FBASEQTY = iQty;
            sibillEntry.FREVERSEQTY = 0;
            sibillEntry.FRETURNSQTY = 0;
            sibillEntry.FPRICE = 0;
            sibillEntry.FAMOUNT = 0;
            sibillEntry.FUNITSTANDARDCOST = 0;
            sibillEntry.FSTANDARDCOST = 0;
            sibillEntry.FUNITACTUALCOST = 0;
            sibillEntry.FACTUALCOST =0;
            sibillEntry.FISPRESENT = 0;
            sibillEntry.FPARENTID = sibill.FID;
            sibillEntry.FSALEORDERID = "i9w2uDCkTfysCbxkwfbwHcSKQjo=";
            sibillEntry.FSALEORDERENTRYID = "B7oiTFWdT1ejG02+E903LYiIKlg=";
            sibillEntry.FWRITTENOFFQTY = iQty;
            sibillEntry.FWRITTENOFFAMOUNT = 0;
            sibillEntry.FUNWRITEOFFQTY = 0;
            sibillEntry.FUNWRITEOFFAMOUNT = 0;
            sibillEntry.FORDERNUMBER = "0";
            sibillEntry.FSALEORDERNUMBER = cOrderNumber;
            sibillEntry.FSALEORDERENTRYSEQ = 1;
            sibillEntry.FTAXRATE = 17;
            sibillEntry.FTAX = 0;
            sibillEntry.FLOCALTAX = 0;
            sibillEntry.FLOCALPRICE = 0;
            sibillEntry.FLOCALAMOUNT = 0;
            sibillEntry.FNONTAXAMOUNT =0;
            sibillEntry.FLOCALNONTAXAMOUNT = 0;
            sibillEntry.FDREWQTY = 0;
            sibillEntry.FASSISTPROPERTYID = "0";
            if(!string.IsNullOrEmpty(sibillEntry.FLOT))
            {
                var cFMFG = iof.GetProductDate(sibillEntry.FMATERIALID, sibillEntry.FLOT);
                var cFEXP = iof.GetProductExpDate(sibillEntry.FMATERIALID, sibillEntry.FLOT);
                DateTime dFm, dFe;
                if (!string.IsNullOrEmpty(cFMFG) && DateTime.TryParse(cFMFG, out dFm))
                    sibillEntry.FMFG = dFm;
                if (!string.IsNullOrEmpty(cFEXP) && DateTime.TryParse(cFEXP, out dFe))
                    sibillEntry.FEXP = dFe;
            }
            

            //生产日期、失效日期不传
            //sibillEntry.FMFG = DateTime.Now; ;
            //sibillEntry.FEXP = DateTime.Now; ;
            sibillEntry.FREMARK = "0";
            sibillEntry.FREVERSEBASEQTY = 0;
            sibillEntry.FRETURNBASEQTY = 0;
            sibillEntry.FWRITTENOFFBASEQTY = 0;
            sibillEntry.FUNWRITEOFFBASEQTY = 0;
            sibillEntry.FDREWBASEQTY = 0;
            //sibillEntry.FCOREBILLTYPEID = "510b6503-0105-1000-e000-0113c0a812fd463ED552";
            sibillEntry.FCOREBILLTYPEID = "";
            sibillEntry.FUNRETURNEDBASEQTY = iQty;
            sibillEntry.FISLOCKED = 0;
            sibillEntry.FINVENTORYID = "0";
            sibillEntry.FORDERPRICE = 0;
            sibillEntry.FTAXPRICE = 0;
            //修改值 2015-10-12

            sibillEntry.FSOURCEBILLID = null;
            sibillEntry.FSOURCEBILLNUMBER = null;
            sibillEntry.FSOURCEBILLENTRYID = null;
            sibillEntry.FASSISTUNITID = null;
            sibillEntry.FREASONCODEID = null;
            sibillEntry.FLOCATIONID = null;
            sibillEntry.FSTOCKERID = null;
            sibillEntry.FORDERNUMBER = null;
            sibillEntry.FASSISTPROPERTYID = null;
            //sibillEntry.FCONFIRMDATE = null;
            //sibillEntry.FBIZDATE = null;
            sibillEntry.FINVENTORYID = null;

            //20160125
            if (string.IsNullOrEmpty(_cCusomer))
            {
                sibillEntry.FBALANCECUSTOMERID = "riQAAAADPwC/DAQO";
                sibillEntry.FPAYMENTCUSTOMERID = "riQAAAADPwC/DAQO";
                sibillEntry.FORDERCUSTOMERID = "riQAAAADPwC/DAQO";
            }
            else
            {
                sibillEntry.FBALANCECUSTOMERID =_cCusomer;
                sibillEntry.FPAYMENTCUSTOMERID =_cCusomer;
                sibillEntry.FORDERCUSTOMERID = _cCusomer;
            }
        }

        /*
update T_IM_SaleIssueEntry
set fsourcebillid=null,fsourcebillnumber=null,fsourcebillentryid=null,fassistunitid=null,freasoncodeid=null,flocationid=null,fstockerid=null
,fordernumber=null,fassistpropertyid=null,fconfirmdate=null,fbizdate=null,fInventoryID=null
where fparentid in ('1d2xZMr2TAidqncU9Sam48w+kzs=','fL0QaL95SkyRu0Osx071w8w+kzs=') 
 * 
 */

        /// <summary>
        /// 给写入主表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", sibill.FID);
            ocmd.Parameters.Add(":FCREATORID", sibill.FCREATORID);
            ocmd.Parameters.Add(":FCREATETIME", sibill.FCREATETIME);
            ocmd.Parameters.Add(":FLASTUPDATETIME", sibill.FLASTUPDATETIME);
            ocmd.Parameters.Add(":FLASTUPDATEUSERID", sibill.FLASTUPDATEUSERID);
            ocmd.Parameters.Add(":FCONTROLUNITID", sibill.FCONTROLUNITID);
            ocmd.Parameters.Add(":FNUMBER", sibill.FNUMBER);
            ocmd.Parameters.Add(":FBIZDATE", sibill.FBIZDATE);
            ocmd.Parameters.Add(":FHANDLERID", sibill.FHANDLERID);
            ocmd.Parameters.Add(":FDESCRIPTION", sibill.FDESCRIPTION);
            ocmd.Parameters.Add(":FHASEFFECTED", sibill.FHASEFFECTED);
            ocmd.Parameters.Add(":FAUDITORID", sibill.FAUDITORID);
            ocmd.Parameters.Add(":FSOURCEBILLID", sibill.FSOURCEBILLID);
            ocmd.Parameters.Add(":FSOURCEFUNCTION", sibill.FSOURCEFUNCTION);
            ocmd.Parameters.Add(":FAUDITTIME", sibill.FAUDITTIME);
            ocmd.Parameters.Add(":FBASESTATUS", sibill.FBASESTATUS);
            ocmd.Parameters.Add(":FBIZTYPEID", sibill.FBIZTYPEID);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", sibill.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FBILLTYPEID", sibill.FBILLTYPEID);
            ocmd.Parameters.Add(":FYEAR", sibill.FYEAR);
            ocmd.Parameters.Add(":FPERIOD", sibill.FPERIOD);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", sibill.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FADMINORGUNITID", sibill.FADMINORGUNITID);
            ocmd.Parameters.Add(":FSTOCKERID", sibill.FSTOCKERID);
            ocmd.Parameters.Add(":FVOUCHERID", sibill.FVOUCHERID);
            ocmd.Parameters.Add(":FTOTALQTY", sibill.FTOTALQTY);
            ocmd.Parameters.Add(":FTOTALAMOUNT", sibill.FTOTALAMOUNT);
            ocmd.Parameters.Add(":FFIVOUCHERED", sibill.FFIVOUCHERED);
            ocmd.Parameters.Add(":FTOTALSTANDARDCOST", sibill.FTOTALSTANDARDCOST);
            ocmd.Parameters.Add(":FTOTALACTUALCOST", sibill.FTOTALACTUALCOST);
            ocmd.Parameters.Add(":FISREVERSED", sibill.FISREVERSED);
            ocmd.Parameters.Add(":FTRANSACTIONTYPEID", sibill.FTRANSACTIONTYPEID);
            ocmd.Parameters.Add(":FISINITBILL", sibill.FISINITBILL);
            ocmd.Parameters.Add(":FCUSTOMERID", sibill.FCUSTOMERID);
            ocmd.Parameters.Add(":FCURRENCYID", sibill.FCURRENCYID);
            ocmd.Parameters.Add(":FEXCHANGERATE", sibill.FEXCHANGERATE);
            ocmd.Parameters.Add(":FMODIFIERID", sibill.FMODIFIERID);
            ocmd.Parameters.Add(":FMODIFICATIONTIME", sibill.FMODIFICATIONTIME);
            ocmd.Parameters.Add(":FPaymentTypeID", sibill.FPaymentTypeID);
            ocmd.Parameters.Add(":FCONVERTMODE", sibill.FCONVERTMODE);
            ocmd.Parameters.Add(":FISSYSBILL", sibill.FISSYSBILL);
            ocmd.Parameters.Add(":FTOTALLOCALAMOUNT", sibill.FTOTALLOCALAMOUNT);
            ocmd.Parameters.Add(":FACTBIZDATE", sibill.FACTBIZDATE);
            ocmd.Parameters.Add(":FIsGenBizAR", sibill.FIsGenBizAR);
            ocmd.Parameters.Add(":FISINTAX", sibill.FISINTAX);
            ocmd.Parameters.Add(":FMONTH", sibill.FMONTH);
            ocmd.Parameters.Add(":FDAY", sibill.FDAY);
            ocmd.Parameters.Add(":FBILLRELATIONOPTION", sibill.FBILLRELATIONOPTION);
            ocmd.Parameters.Add(":FCOSTCENTERORGUNITID", sibill.FCOSTCENTERORGUNITID);


        }


        /// <summary>
        /// 给写入子表的SQL参数传值
        /// </summary>
        /// <returns></returns>
        private void GenBillEntryPara(OracleCommand ocmd)
        {
            ocmd.Parameters.Add(":FID", sibillEntry.FID);
            ocmd.Parameters.Add(":FSEQ", sibillEntry.FSEQ);
            ocmd.Parameters.Add(":FSOURCEBILLID", sibillEntry.FSOURCEBILLID);
            ocmd.Parameters.Add(":FSOURCEBILLNUMBER", sibillEntry.FSOURCEBILLNUMBER);
            ocmd.Parameters.Add(":FSOURCEBILLTYPEID", sibillEntry.FSOURCEBILLTYPEID);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYID", sibillEntry.FSOURCEBILLENTRYID);
            ocmd.Parameters.Add(":FSOURCEBILLENTRYSEQ", sibillEntry.FSOURCEBILLENTRYSEQ);
            ocmd.Parameters.Add(":FASSCOEFFICIENT", sibillEntry.FASSCOEFFICIENT);
            ocmd.Parameters.Add(":FBASESTATUS", sibillEntry.FBASESTATUS);
            ocmd.Parameters.Add(":FMATERIALID", sibillEntry.FMATERIALID);
            ocmd.Parameters.Add(":FUNITID", sibillEntry.FUNITID);
            ocmd.Parameters.Add(":FBASEUNITID", sibillEntry.FBASEUNITID);
            ocmd.Parameters.Add(":FASSISTUNITID", sibillEntry.FASSISTUNITID);
            ocmd.Parameters.Add(":FREASONCODEID", sibillEntry.FREASONCODEID);
            ocmd.Parameters.Add(":FASSOCIATEQTY", sibillEntry.FASSOCIATEQTY);
            ocmd.Parameters.Add(":FSTORAGEORGUNITID", sibillEntry.FSTORAGEORGUNITID);
            ocmd.Parameters.Add(":FCOMPANYORGUNITID", sibillEntry.FCOMPANYORGUNITID);
            ocmd.Parameters.Add(":FWAREHOUSEID", sibillEntry.FWAREHOUSEID);
            ocmd.Parameters.Add(":FLOCATIONID", sibillEntry.FLOCATIONID);
            ocmd.Parameters.Add(":FSTOCKERID", sibillEntry.FSTOCKERID);
            ocmd.Parameters.Add(":FLOT", sibillEntry.FLOT);
            ocmd.Parameters.Add(":FQTY", sibillEntry.FQTY);
            ocmd.Parameters.Add(":FASSISTQTY", sibillEntry.FASSISTQTY);
            ocmd.Parameters.Add(":FBASEQTY", sibillEntry.FBASEQTY);
            ocmd.Parameters.Add(":FREVERSEQTY", sibillEntry.FREVERSEQTY);
            ocmd.Parameters.Add(":FRETURNSQTY", sibillEntry.FRETURNSQTY);
            ocmd.Parameters.Add(":FPRICE", sibillEntry.FPRICE);
            ocmd.Parameters.Add(":FAMOUNT", sibillEntry.FAMOUNT);
            ocmd.Parameters.Add(":FUNITSTANDARDCOST", sibillEntry.FUNITSTANDARDCOST);
            ocmd.Parameters.Add(":FSTANDARDCOST", sibillEntry.FSTANDARDCOST);
            ocmd.Parameters.Add(":FUNITACTUALCOST", sibillEntry.FUNITACTUALCOST);
            ocmd.Parameters.Add(":FACTUALCOST", sibillEntry.FACTUALCOST);
            ocmd.Parameters.Add(":FISPRESENT", sibillEntry.FISPRESENT);
            ocmd.Parameters.Add(":FPARENTID", sibillEntry.FPARENTID);
            ocmd.Parameters.Add(":FSALEORDERID", sibillEntry.FSALEORDERID);
            ocmd.Parameters.Add(":FSALEORDERENTRYID", sibillEntry.FSALEORDERENTRYID);
            ocmd.Parameters.Add(":FWRITTENOFFQTY", sibillEntry.FWRITTENOFFQTY);
            ocmd.Parameters.Add(":FWRITTENOFFAMOUNT", sibillEntry.FWRITTENOFFAMOUNT);
            ocmd.Parameters.Add(":FUNWRITEOFFQTY", sibillEntry.FUNWRITEOFFQTY);
            ocmd.Parameters.Add(":FUNWRITEOFFAMOUNT", sibillEntry.FUNWRITEOFFAMOUNT);
            ocmd.Parameters.Add(":FORDERNUMBER", sibillEntry.FORDERNUMBER);
            ocmd.Parameters.Add(":FSALEORDERNUMBER", sibillEntry.FSALEORDERNUMBER);
            ocmd.Parameters.Add(":FSALEORDERENTRYSEQ", sibillEntry.FSALEORDERENTRYSEQ);
            ocmd.Parameters.Add(":FTAXRATE", sibillEntry.FTAXRATE);
            ocmd.Parameters.Add(":FTAX", sibillEntry.FTAX);
            ocmd.Parameters.Add(":FLOCALTAX", sibillEntry.FLOCALTAX);
            ocmd.Parameters.Add(":FLOCALPRICE", sibillEntry.FLOCALPRICE);
            ocmd.Parameters.Add(":FLOCALAMOUNT", sibillEntry.FLOCALAMOUNT);
            ocmd.Parameters.Add(":FNONTAXAMOUNT", sibillEntry.FNONTAXAMOUNT);
            ocmd.Parameters.Add(":FLOCALNONTAXAMOUNT", sibillEntry.FLOCALNONTAXAMOUNT);
            ocmd.Parameters.Add(":FDREWQTY", sibillEntry.FDREWQTY);
            ocmd.Parameters.Add(":FASSISTPROPERTYID", sibillEntry.FASSISTPROPERTYID);
            ocmd.Parameters.Add(":FMFG", sibillEntry.FMFG);
            ocmd.Parameters.Add(":FEXP", sibillEntry.FEXP);
            ocmd.Parameters.Add(":FREMARK", sibillEntry.FREMARK);
            ocmd.Parameters.Add(":FREVERSEBASEQTY", sibillEntry.FREVERSEBASEQTY);
            ocmd.Parameters.Add(":FRETURNBASEQTY", sibillEntry.FRETURNBASEQTY);
            ocmd.Parameters.Add(":FWRITTENOFFBASEQTY", sibillEntry.FWRITTENOFFBASEQTY);
            ocmd.Parameters.Add(":FUNWRITEOFFBASEQTY", sibillEntry.FUNWRITEOFFBASEQTY);
            ocmd.Parameters.Add(":FDREWBASEQTY", sibillEntry.FDREWBASEQTY);
            ocmd.Parameters.Add(":FCOREBILLTYPEID", sibillEntry.FCOREBILLTYPEID);
            ocmd.Parameters.Add(":FUNRETURNEDBASEQTY", sibillEntry.FUNRETURNEDBASEQTY);
            ocmd.Parameters.Add(":FISLOCKED", sibillEntry.FISLOCKED);
            ocmd.Parameters.Add(":FINVENTORYID", sibillEntry.FINVENTORYID);
            ocmd.Parameters.Add(":FORDERPRICE", sibillEntry.FORDERPRICE);
            ocmd.Parameters.Add(":FTAXPRICE", sibillEntry.FTAXPRICE);
            ocmd.Parameters.Add(":FACTUALPRICE", sibillEntry.FACTUALPRICE);
            ocmd.Parameters.Add(":FSALEORGUNITID", sibillEntry.FSALEORGUNITID);
            ocmd.Parameters.Add(":FSALEGROUPID", sibillEntry.FSALEGROUPID);
            ocmd.Parameters.Add(":FSALEPERSONID", sibillEntry.FSALEPERSONID);
            ocmd.Parameters.Add(":FBASEUNITACTUALCOST", sibillEntry.FBASEUNITACTUALCOST);
            ocmd.Parameters.Add(":FUNDELIVERQTY", sibillEntry.FUNDELIVERQTY);
            ocmd.Parameters.Add(":FUNDELIVERBASEQTY", sibillEntry.FUNDELIVERBASEQTY);
            ocmd.Parameters.Add(":FUNINQTY", sibillEntry.FUNINQTY);
            ocmd.Parameters.Add(":FUNINBASEQTY", sibillEntry.FUNINBASEQTY);
            ocmd.Parameters.Add(":FBALANCECUSTOMERID", sibillEntry.FBALANCECUSTOMERID);
            ocmd.Parameters.Add(":FISCENTERBALANCE", sibillEntry.FISCENTERBALANCE);
            ocmd.Parameters.Add(":FISBETWEENCOMPANYSEND", sibillEntry.FISBETWEENCOMPANYSEND);
            ocmd.Parameters.Add(":FTOTALINWAREHSQTY", sibillEntry.FTOTALINWAREHSQTY);
            ocmd.Parameters.Add(":FPAYMENTCUSTOMERID", sibillEntry.FPAYMENTCUSTOMERID);
            ocmd.Parameters.Add(":FORDERCUSTOMERID", sibillEntry.FORDERCUSTOMERID);
            ocmd.Parameters.Add(":FCONFIRMQTY", sibillEntry.FCONFIRMQTY);
            ocmd.Parameters.Add(":FCONFIRMBASEQTY", sibillEntry.FCONFIRMBASEQTY);
            ocmd.Parameters.Add(":FASSOCIATEBASEQTY", sibillEntry.FASSOCIATEBASEQTY);
            ocmd.Parameters.Add(":FCONFIRMDATE", sibillEntry.FCONFIRMDATE);
            ocmd.Parameters.Add(":FSENDADDRESS", sibillEntry.FSENDADDRESS);
            ocmd.Parameters.Add(":FNETORDERBILLNUMBER", sibillEntry.FNETORDERBILLNUMBER);
            ocmd.Parameters.Add(":FNETORDERBILLID", sibillEntry.FNETORDERBILLID);
            ocmd.Parameters.Add(":FNETORDERBILLENTRYID", sibillEntry.FNETORDERBILLENTRYID);
            ocmd.Parameters.Add(":FISSQUAREBALANCE", sibillEntry.FISSQUAREBALANCE);
            ocmd.Parameters.Add(":FPROJECTID", sibillEntry.FPROJECTID);
            ocmd.Parameters.Add(":FTRACKNUMBERID", sibillEntry.FTRACKNUMBERID);
            ocmd.Parameters.Add(":FCONTRACTNUMBER", sibillEntry.FCONTRACTNUMBER);
            ocmd.Parameters.Add(":FSUPPLIERID", sibillEntry.FSUPPLIERID);
            ocmd.Parameters.Add(":FSALEPRICE", sibillEntry.FSALEPRICE);
            ocmd.Parameters.Add(":FDISCOUNTTYPE", sibillEntry.FDISCOUNTTYPE);
            ocmd.Parameters.Add(":FDISCOUNTAMOUNT", sibillEntry.FDISCOUNTAMOUNT);
            ocmd.Parameters.Add(":FDISCOUNT", sibillEntry.FDISCOUNT);
            ocmd.Parameters.Add(":FUNSETTLEQTY", sibillEntry.FUNSETTLEQTY);
            ocmd.Parameters.Add(":FUNSETTLEBASEQTY", sibillEntry.FUNSETTLEBASEQTY);
            ocmd.Parameters.Add(":FCURSETTLEBILLID", sibillEntry.FCURSETTLEBILLID);
            ocmd.Parameters.Add(":FCURSETTLEBILLENTRYID", sibillEntry.FCURSETTLEBILLENTRYID);
            ocmd.Parameters.Add(":FCURSETTLEQTY", sibillEntry.FCURSETTLEQTY);
            ocmd.Parameters.Add(":FTOTALSETTLEQTY", sibillEntry.FTOTALSETTLEQTY);
            ocmd.Parameters.Add(":FB2CBILLTYPE", sibillEntry.FB2CBILLTYPE);
            ocmd.Parameters.Add(":FBIZDATE", sibillEntry.FBIZDATE);
            ocmd.Parameters.Add(":FISFULLWRITEOFF", sibillEntry.FISFULLWRITEOFF);

        }




        /// <summary>
        /// 传递WMS要与EAS同步的单据
        /// </summary>
        /// <param name="cOrderNumber">单据号</param>
        /// <param name="cGuid">单据GUID</param>
        /// <param name="iCount">行数</param>
        /// <returns></returns>
        [WebMethod]
        public string SyncOrder(string cOrderNumber, string cEasNewOrder, string cGuid, int iCount,string cMemo)
        {
            DataTable dtSsDetail;
            var iof = new InterfaceOracleFunction(Properties.Settings.Default.EasCon);
            //根据iCount判断是否是销售出库还是销售退货
            if (iCount == 1)
            {
                sibill.FTRANSACTIONTYPEID = "DawAAAAPoAywCNyn";

                dtSsDetail = GetImportDataTable(cOrderNumber);
                //如果是销售出库则是固定仓库
                _cWhareHouse = "riQAAAAALQy76fiu";

                var cCusCode = GetCustomerAddress(cOrderNumber);
                if (!string.IsNullOrEmpty(cCusCode))
                {
                    _cCusomer = iof.GetCustomer(cCusCode);
                }

            }
            else
            {
                sibill.FTRANSACTIONTYPEID = "DawAAAAPoA2wCNyn";
                dtSsDetail = GetImportReturnDataTable(cOrderNumber);
                _bReturn = true;
                //退货则使用FNumber查询库存
                _cWhareHouse = iof.GetWareHouse(cGuid);
            }
            
            if (dtSsDetail.Rows.Count < 1)
                return "无内容";

            //验证SS_Detail和SS_Delivery的数量是否一致
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                //using (var cmd = new SqlCommand("select cInvCode,iQuantity,cLotNo,'' cWhCode from SS_DeliveryReturn  where cOrderNumber=@cOrderNumber group by cInvCode,iQuantity,cLotNo", con))
                string sql = @"select (SELECT isnull(SUM(iquantity),0)  FROM SS_Detail  where cordernumber = @cOrderNumber ) as [SS_Detail_iquantity]
                ,(SELECT isnull(SUM(iquantity),0)  FROM SS_Delivery  where cordernumber = @cOrderNumber ) as [SS_Delivery_iquantity]";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
                    var da = new SqlDataAdapter(cmd);
                    var dtCompare = new DataTable("SSDetail");
                    da.Fill(dtCompare);

                    if (Convert.ToInt32(dtCompare.Rows[0]["SS_Detail_iquantity"]) != Convert.ToInt32(dtCompare.Rows[0]["SS_Delivery_iquantity"]))
                    {
                        return string.Format("单据数量不一致,cOrderNumber[{0}],SS_Detail_iquantity[{1}],SS_Delivery_iquantity[{2}]"
                            , cOrderNumber, dtCompare.Rows[0]["SS_Detail_iquantity"], dtCompare.Rows[0]["SS_Delivery_iquantity"]);
                    }
                }
            }

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
                                

                                //执行主表写入
                                ocmd.CommandText = "select FNUMBER from T_IM_SaleIssueBill where FNUMBER=:FNUMBER";
                                ocmd.Parameters.Add(":FNUMBER", cEasNewOrder);
                                if (ocmd.ExecuteReader().Read())
                                    return "单据已经存在";
                                ocmd.Parameters.Clear();

                                ocmd.CommandText = BillCmdStr;
                                FillBill(cOrderNumber,cEasNewOrder);
                                //备注字段
                                sibill.FDESCRIPTION = cMemo;
                                
                                GenBillPara(ocmd);
                                ocmd.ExecuteNonQuery();
                                ocmd.CommandText = BillEntryCmdStr;
                                //获取要导入行的仓库
                                string cWhCode = string.Empty;
                                for (var i = 0; i < dtSsDetail.Rows.Count; i++)
                                {
                                    ocmd.Parameters.Clear();

                                    cWhCode= dtSsDetail.Rows[i]["cWhCode"].ToString();
                                   
                                    var cInvCode = dtSsDetail.Rows[i]["cInvCode"].ToString();
                                    var cInvName = "";
                                    var iQuantity = dtSsDetail.Rows[i]["iQuantity"].ToString();
                                    var cLotNo = dtSsDetail.Rows[i]["cLotNo"].ToString();
                                    FillBillEntry(cOrderNumber, cInvCode, iQuantity, cInvName, cLotNo, i + 1,cWhCode);
                                    sibillEntry.FREMARK = dtSsDetail.Rows[i]["remarks"].ToString();
                                    InterfaceOracleFunction.VLogDebug(string.Format("执行[销售出库或退货SyncOrder],参数cOrderNumber[{0}],cEasNewOrder[{1}],cGuid[{2}],iCount[{3}],cMemo[{4}]"
                                        , cOrderNumber, cEasNewOrder, cGuid, iCount, cMemo)
                                    , string.Format("仓库fNumber:{0},FWAREHOUSEID:{1},审核人FAUDITORID:{2},FLASTUPDATEUSERID:{3},FREMARK:{4}"
                                    , cWhCode, sibillEntry.FWAREHOUSEID, sibill.FAUDITORID, sibill.FLASTUPDATEUSERID, sibillEntry.FREMARK));
                                    //sibillEntry.FWAREHOUSEID = _cWhareHouse;
                                    //sibill.FAUDITORID = "9htALWzQRaGIR4lDJ2tNuRO33n8=";
                                    //sibill.FLASTUPDATEUSERID = "9htALWzQRaGIR4lDJ2tNuRO33n8=";
                                    //sibill.FLASTUPDATETIME = DateTime.Now;
                                    //sibill.FAUDITTIME = DateTime.Now;
                                    GenBillEntryPara(ocmd);
                                    ocmd.ExecuteNonQuery();
                                }

                                otran.Commit();
                                return "OK";
                            }

                            catch (OracleException ex)
                            {
                                string erString = string.Empty;
                                erString = ocmd.CommandText;
                                otran.Rollback();
                                return erString+ex.Message;
                            }
                        }
                    }
                }
            }
        }

        private DataTable GetImportDataTable(string cOrderNumber)
        {
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                //using (var cmd = new SqlCommand("select cInvCode,iQuantity,cLotNo,cWhCode from SS_Detail  where cOrderNumber=@cOrderNumber group by cInvCode,iQuantity,cLotNo,cWhCode", con))
                //改成cInvCode 产品编码,cLotNo 批次,cWhCode 仓库,合计数量
                using (var cmd = new SqlCommand("select cInvCode,sum(iQuantity) as iQuantity,cLotNo,cWhCode,'' [remarks] from SS_Detail  where cOrderNumber=@cOrderNumber group by cInvCode,cLotNo,cWhCode", con))
                {
                    cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable("SSDetail");
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        private DataTable GetImportReturnDataTable(string cOrderNumber)
        {
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                //using (var cmd = new SqlCommand("select cInvCode,iQuantity,cLotNo,'' cWhCode from SS_DeliveryReturn  where cOrderNumber=@cOrderNumber group by cInvCode,iQuantity,cLotNo", con))
                using (var cmd = new SqlCommand("select cInvCode,-sum(iQuantity) as iQuantity,cLotNo,'' cWhCode,case when isnull(max(cCusName),'')='' then isnull(max(cMemo),'') else isnull(max(cCusName),'')+'/'+isnull(max(cMemo),'') end [remarks]  from SS_DeliveryReturn where cOrderNumber=@cOrderNumber  group by cInvCode,cLotNo", con))
                {
                    cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable("SSDetail");
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        private string GetCustomerAddress(string cOrderNumber)
        {
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                using (var cmd = new SqlCommand("select top 1 cCusAddress from SS_Delivery  where cOrderNumber=@cOrderNumber ", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@cOrderNumber", cOrderNumber);
                    var dReturn = cmd.ExecuteScalar();
                    if (dReturn == null || dReturn.ToString().IndexOf(".", StringComparison.Ordinal) < 0)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return dReturn.ToString()
                            .Substring(0, dReturn.ToString().IndexOf(".", StringComparison.Ordinal));
                    }
                }
            }
        }
    }
}
