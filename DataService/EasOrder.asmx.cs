using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace DataService
{
    /// <summary>
    /// EasOrder 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class EasOrder : System.Web.Services.WebService
    {
        /// <summary>
        /// 获取采购订单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetPo2(string cOrderNumber="")
        {
            var strPo = "select * from (select RowNum,"+
                "a.FNumber as cOrderNumber, "+
                "b.Fname_l2 as cOrderType, "+
                "a.FCreateTime as dAddTime, "+
                "a.FBizDate as dDate, "+
                "c.Fname_l2 as cVendor, "+
                "d.Fname_l2 as cCompany, "+
                "e.Fname_l2 as cBuyer, "+
                "e.FOfficePhone as cBuyerTax, "+
                "e.FHomePhone as cBuyerPhone, "+
                "e.FCell as cBuyerCell, "+
                "case when FIsInTax=1 then '是' else '否' end as bTax, "+
                "f.Fname_l2 as cCurrency, "+
                "g.Fname_l2 as cPaymentType, "+
                "h.Fname_l2 as cDepartment, "+
                "i.Fname_l2 as cOperator " +
                "from T_SM_PurOrder a  " +
                "inner join T_SCM_BizType b on a.FBizTypeID=b.FID " +
                "left join T_BD_Supplier c on a.FSupplierID=c.FID " +
                "left join T_ORG_Purchase d on a.FPurchaseOrgUnitID=d.FID " +
                "left join T_BD_Person e on a.FPurchasePersonID=e.FID " +
                "left join T_BD_Currency f on a.FCurrencyID=f.FID " +
                "left join T_BD_PaymentType g on a.FPaymentTypeID=g.FID " +
                "left join T_ORG_Admin h on a.FAdminOrgUnitID=h.FID  " +
                "left join T_PM_User i on a.FCreatorID=i.FID where  a.FNumber like '%'||:FNumber||'%'" +
                "  order by FBizDate desc) where rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasPo");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取采购订单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetPo()
        {
            var strPo = "select * from (select RowNum," +
                "a.FNumber as cOrderNumber, " +
                "b.Fname_l2 as cOrderType, " +
                "a.FCreateTime as dAddTime, " +
                "a.FBizDate as dDate, " +
                "c.Fname_l2 as cVendor, " +
                "d.Fname_l2 as cCompany, " +
                "e.Fname_l2 as cBuyer, " +
                "e.FOfficePhone as cBuyerTax, " +
                "e.FHomePhone as cBuyerPhone, " +
                "e.FCell as cBuyerCell, " +
                "case when FIsInTax=1 then '是' else '否' end as bTax, " +
                "f.Fname_l2 as cCurrency, " +
                "g.Fname_l2 as cPaymentType, " +
                "h.Fname_l2 as cDepartment, " +
                "i.Fname_l2 as cOperator " +
                "from T_SM_PurOrder a  " +
                "left join T_SCM_BizType b on a.FBizTypeID=b.FID " +
                "left join T_BD_Supplier c on a.FSupplierID=c.FID " +
                "left join T_ORG_Purchase d on a.FPurchaseOrgUnitID=d.FID " +
                "left join T_BD_Person e on a.FPurchasePersonID=e.FID " +
                "left join T_BD_Currency f on a.FCurrencyID=f.FID " +
                "left join T_BD_PaymentType g on a.FPaymentTypeID=g.FID " +
                "left join T_ORG_Admin h on a.FAdminOrgUnitID=h.FID  " +
                "left join T_PM_User i on a.FCreatorID=i.FID " +
                "  order by FBizDate desc) where rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPo, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasPo");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



        [WebMethod]
        public DataTable GetPoDetail(string cOrderNumber)
        {
            const string strPoDetail = "select  RowNum, " +
                                       "a.FNumber as cOrderNumber, " +
                                       "a.FBizDate as dDate,   " +
                                       "c.Fname_l2 as cVendor, " +
                                       "d.FNumber as cInvCode, " +
                                       "d.Fname_l2 as cInvName, " +
                                       "d.FModel as cInvStd, " +
                                       "e.Fname_l2 as cUnit, " +
                                       "b.Fqty-nvl(b.FTotalReceiveQty,0) as iQuantity, " +//-nvl(b.FTotalReceiveQty,0) 
                                       "b.FQTY, " +
                                       "b.FPrice, " +
                                       "b.FTaxRate, " +
                                       "b.FAmount, " +
                                       "b.FDeliveryDate, " +
                                       "f.Fname_l2 as cWareHouse, " +
                                       "b.FRemark as cMemo " +
                                       "from T_SM_PurOrder a left join T_SM_PurOrderEntry b on a.FID=b.FParentID " +
                                       "left join T_BD_Supplier c on a.FSupplierID=c.FID " +
                                       "left join T_BD_Material d on b.FMaterialID=d.FID    " +
                                       "left  join T_BD_MeasureUnit e on d.FBaseUnit=e.FID " +
                                       "left  join T_DB_WAREHOUSE f on b.FWareHouseID=f.FID " +
                                       "where a.Fnumber=:Fnumber";

            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    cmd.Parameters.Add(":Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasPoDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        [WebMethod]
        public DataTable GetTransfer2(string cOrderNumber = "")
        {
            var strPoDetail = "select * from (select RowNum, " +
                                       "a.FNumber cOrderNumber, "+
                                       "a.FBizDate dDate, "+
                                       "c.fname_l2 cOrderType, "+
                                       "b.Fname_l2 cUser, " +
                                       "d.FName_L2 cDepartment, "+
                                       "case FBaseStatus when 0 then '新增' when 1 then '保存'  "+
                                       "                when 2 then '提交' when 3 then '作废' when 4 then '审核'  "+
                                       "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus  "+
                                       "from T_IM_StockTransferBill a  "+
                                       "left join T_PM_User b on a.FCreatorID=b.FID   " +
                                       "left join T_SCM_BizType c on a.FBizTypeID=c.FID  " +
                                       "left join T_ORG_Admin d on a.FIssueAdminOrgUnitID=d.FID where  a.FNumber like '%'||:FNumber||'%'   " +
                                       " order by FBizDate desc) where rownum<100";

            if (cOrderNumber.Contains("TR"))
            {
                strPoDetail = "select * from (select RowNum, " +
                                       "a.FNumber cOrderNumber, " +
                                       "a.FBizDate dDate, " +
                                       "c.fname_l2 cOrderType, " +
                                       "b.FNumber cUser, " +
                                       "d.FName_L2 cDepartment, " +
                                       "case FBaseStatus when 0 then '新增' when 1 then '保存'  " +
                                       "                when 2 then '提交' when 3 then '作废' when 4 then '审核'  " +
                                       "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus  " +
                                       "from T_IM_TransferOrderBill a  " +
                                       "left join T_PM_User b on a.FCreatorID=b.FID   " +
                                       "left join T_SCM_BizType c on a.FBizTypeID=c.FID  " +
                                       "left join T_ORG_Admin d on a.FIssueAdminOrgUnitID=d.FID where  a.FNumber like '%'||:FNumber||'%'  " +
                                       " order by FBizDate desc) where rownum<100";
            }
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransfer");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取调拨单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetTransfer()
        {
            const string strPoDetail = "select * from ( "+
                                        "select * from (select RowNum, "+
                                      " a.FNumber cOrderNumber, "+
                                      " a.FBizDate dDate, "+
                                      " c.fname_l2 cOrderType, "+
                                      " b.fname_l2 cUser, "+
                                      " d.FName_L2 cDepartment, "+
                                      " case FBaseStatus when 0 then '新增' when 1 then '保存' "+
                                      "                 when 2 then '提交' when 3 then '作废' when 4 then '审核' "+
                                      "                 when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus "+
                                      " from T_IM_StockTransferBill a  "+
                                      " left join T_PM_User b on a.FCreatorID=b.FID  " +
                                      " left join T_SCM_BizType c on a.FBizTypeID=c.FID  " +
                                      " left join T_ORG_Admin d on a.FIssueAdminOrgUnitID=d.FID "+
                                   " union all "+
                                   " select RowNum,  "+
                                     "  a.FNumber cOrderNumber, "+
                                     "  a.FBizDate dDate, "+
                                     "  c.fname_l2 cOrderType, "+
                                     "  b.fname_l2 cUser, "+
                                     "  d.FName_L2 cDepartment, "+
                                     "  case FBaseStatus when 0 then '新增' when 1 then '保存' "+
                                     "                  when 2 then '提交' when 3 then '作废' when 4 then '审核' "+
                                     "                  when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus "+
                                     "  from T_IM_TransferOrderBill a  "+
                                     "  left join T_PM_User b on a.FCreatorID=b.FID  "+
                                     "  left join T_SCM_BizType c on a.FBizTypeID=c.FID  "+
                                     "  left join T_ORG_Admin d on a.FIssueAdminOrgUnitID=d.FID " +
                            ") a order by dDate desc "+
                            ")where rownum<100";

            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransfer");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



        [WebMethod]
        public DataTable GetTransferDelivery2(string cOrderNumber = "")
        {
            var strPoDetail = "select * from (select RowNum, " +
                                       "a.FNumber cOrderNumber, " +
                                       "a.FBizDate dDate, " +
                                       "c.fname_l2 cOrderType, " +
                                       "b.Fname_l2 cUser, " +
                                       "d.FName_L2 cDepartment, " +
                                       "case FBaseStatus when 0 then '新增' when 1 then '保存'  " +
                                       "                when 2 then '提交' when 3 then '作废' when 4 then '审核'  " +
                                       "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus  " +
                                       "from T_IM_MoveIssueBill a  " +
                                       "left join T_PM_User b on a.FCreatorID=b.FID   " +
                                       "left join T_SCM_BizType c on a.FBizTypeID=c.FID  " +
                                       "left join T_ORG_Admin d on a.FAdminOrgUnitID=d.FID where  a.FNumber like '%'||:FNumber||'%'  " +
                                       " order by FBizDate desc) where rownum<100";

            
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransfer");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 根据调拨单号，获取单据类型-3:历史版本;-2:变更中;-1:;0:新增;1:保存;2:提交;3:作废;4:审核;5:下达;6:冻结;7:关闭;8:完工;90:完成;10:发布;11:结案;
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
         [WebMethod]
        public string GetTransferType(string cOrderNumber)
        {
            var cmdstr = "select FBaseStatus from T_IM_StockTransferBill where fNumber=:fNumber";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取调拨单类型" );
        }
        /// <summary>
        /// 获取调拨出库
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetTransferDelivery()
        {
            const string strPoDetail = "select * from ( " +
                                        "select * from (select RowNum, " +
                                      " a.FNumber cOrderNumber, " +
                                      " a.FBizDate dDate, " +
                                      " c.fname_l2 cOrderType, " +
                                      " b.fname_l2 cUser, " +
                                      " d.FName_L2 cDepartment, " +
                                      " case FBaseStatus when 0 then '新增' when 1 then '保存' " +
                                      "                 when 2 then '提交' when 3 then '作废' when 4 then '审核' " +
                                      "                 when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus " +
                                      " from T_IM_MoveIssueBill a  " +
                                      " left join T_PM_User b on a.FCreatorID=b.FID  " +
                                      " left join T_SCM_BizType c on a.FBizTypeID=c.FID  " +
                                      " left join T_ORG_Admin d on a.FAdminOrgUnitID=d.FID " +
                                  
                            ") a order by dDate desc " +
                            ")where rownum<100";

            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransfer");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        /// <summary>
        /// 根据调拨单号获取EAS调拨单明细
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetTransferDeliveryDetail(string cOrderNumber)
        {
            string strPoDetail = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                       "c.FName_L2 cInvName,c.FModel cInvStd,g.FName_L2 cUnit,b.FSeq,e.FName_L2 cWareHouseFrom,f.FName_L2 cWareHouseTo,b.FLot cLotNo " +
                                       "from T_IM_MoveIssueBill a " +
                                       "inner join T_IM_MoveIssueBillEntry b on a.FID=b.FParentID " +
                                       "inner join T_BD_Material c on b.FMaterialID=c.fid " +
                                       "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                       "left join T_DB_WAREHOUSE e on b.FWarehouseID=e.FID " +
                                       "left join T_DB_WAREHOUSE f on b.FWarehouseID=f.FID " +
                                       "left join T_BD_MeasureUnit g on c.FBaseUnit=g.FID " +
                                       "where a.Fnumber=:Fnumber";
            
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransferDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        /// <summary>
        /// 根据调拨单号获取EAS调拨单明细
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetTransferDetail(string cOrderNumber)
        {
            string strPoDetail = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                       "c.FName_L2 cInvName,c.FModel cInvStd,g.FName_L2 cUnit,b.FSeq,e.FName_L2 cWareHouseFrom,f.FName_L2 cWareHouseTo,b.FLot cLotNo " +
                                       "from T_IM_StockTransferBill a "+
                                       "inner join T_IM_StockTransferBillEntry b on a.FID=b.FParentID "+
                                       "inner join T_BD_Material c on b.FMaterialID=c.fid "+
                                       "inner join T_PM_User d on a.FCreatorID=d.FID "+
                                       "left join T_DB_WAREHOUSE e on b.FIssueWarehouseID=e.FID "+
                                       "left join T_DB_WAREHOUSE f on b.FReceiptWarehouseID=f.FID "+
                                       "left join T_BD_MeasureUnit g on c.FBaseUnit=g.FID "+
                                       "where a.Fnumber=:Fnumber";
            if (cOrderNumber.Contains("TR"))
            {
                strPoDetail = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                       "c.FName_L2 cInvName,c.FModel cInvStd,g.FName_L2 cUnit,b.FSeq,e.FName_L2 cWareHouseFrom,f.FName_L2 cWareHouseTo,b.FLot cLotNo " +
                                       "from T_IM_TransferOrderBill a " +
                                       "inner join T_IM_TransferOrderBillEntry b on a.FID=b.FParentID " +
                                       "inner join T_BD_Material c on b.FMaterialID=c.fid " +
                                       "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                       "left join T_DB_WAREHOUSE e on b.FIssueWarehouseID=e.FID " +
                                       "left join T_DB_WAREHOUSE f on b.FReceiptWarehouseID=f.FID " +
                                       "left join T_BD_MeasureUnit g on c.FBaseUnit=g.FID " +
                                       "where a.Fnumber=:Fnumber";
            }
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPoDetail, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasTransferDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        [WebMethod]
        public DataTable GetOem2(string cOrderNumber = "")
        {
            const string strOem = "select * from (select RowNum, " +
                                  "a.FNumber as cOrderNumber, "+
                                  "b.Fname_l2 as cOrderType, "+
                                  "a.FCreateTime as dAddTime, "+
                                  "a.FBizDate as dDate,  "+
                                  "case FBaseStatus when 0 then '新增' when 1 then '保存'   "+
                                  "                when 2 then '提交' when 3 then '作废' when 4 then '审核'   "+
                                  "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus,  "+
                                  " h.Fname_l2 as cDepartment,  "+
                                  "c.Fname_l2 as cVendor, "+
                                  "d.Fname_l2 as cCompany,  "+
                                  "j.Fname_l2 as cGroup,   "+
                                  "e.Fname_l2 as cBuyer,   "+
                                  "case when FIsInTax=1 then '是' else '否' end as bTax,  "+
                                  "f.Fname_l2 as cCurrency,  "+
                                  "g.Fname_l2 as cPaymentType,   "+
                                  "k.Fname_l2 as cSettleType,  "+
                                  "a.FPrepaymentAmount as FPrepaymentAmount,  "+
                                  "a.FPrepaymentRate as FPrepaymentRate,  "+
                                  "l.Fname_l2 as cDisCount,  "+
                                  "i.Fname_l2 as cOperator "+
                                  "from T_SM_SubContractOrder a   "+
                                  "inner join T_SCM_BizType b on a.FBizTypeID=b.FID  "+
                                  "left join T_BD_Supplier c on a.FSupplierID=c.FID  " +
                                  "left join T_ORG_Purchase d on a.FPurchaseOrgUnitID=d.FID  " +
                                  "left join T_BD_Person e on a.FPurchasePersonID=e.FID  " +
                                  "left join T_BD_Currency f on a.FCurrencyID=f.FID " +
                                  "left join T_BD_PaymentType g on a.FPaymentTypeID=g.FID " +
                                  "left join T_ORG_Admin h on a.FAdminOrgUnitID=h.FID  " +
                                  "left join T_PM_User i on a.FCreatorID=i.FID " +
                                  "left join T_BD_PurchaseGroup j on a.FPurchaseGroupID=j.FID " +
                                  "left join T_BD_SettlementType k on a.FSettlementTypeID=k.FID " +
                                  "left join T_BD_CashDiscount l on a.FCashDiscountID=l.FID where  a.FNumber like '%'||:FNumber||'%' " +
                                  " order by FBizDate desc) where rownum<100";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strOem, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasOem");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetOem()
        {
            const string strOem = "select * from (select RowNum, " +
                                  "a.FNumber as cOrderNumber, " +
                                  "b.Fname_l2 as cOrderType, " +
                                  "a.FCreateTime as dAddTime, " +
                                  "a.FBizDate as dDate,  " +
                                  "case FBaseStatus when 0 then '新增' when 1 then '保存'   " +
                                  "                when 2 then '提交' when 3 then '作废' when 4 then '审核'   " +
                                  "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus,  " +
                                  " h.Fname_l2 as cDepartment,  " +
                                  "c.Fname_l2 as cVendor, " +
                                  "d.Fname_l2 as cCompany,  " +
                                  "j.Fname_l2 as cGroup,   " +
                                  "e.Fname_l2 as cBuyer,   " +
                                  "case when FIsInTax=1 then '是' else '否' end as bTax,  " +
                                  "f.Fname_l2 as cCurrency,  " +
                                  "g.Fname_l2 as cPaymentType,   " +
                                  "k.Fname_l2 as cSettleType,  " +
                                  "a.FPrepaymentAmount as FPrepaymentAmount,  " +
                                  "a.FPrepaymentRate as FPrepaymentRate,  " +
                                  "l.Fname_l2 as cDisCount,  " +
                                  "i.Fname_l2 as cOperator " +
                                  "from T_SM_SubContractOrder a   " +
                                  "inner join T_SCM_BizType b on a.FBizTypeID=b.FID  " +
                                  "left join T_BD_Supplier c on a.FSupplierID=c.FID  " +
                                  "left join T_ORG_Purchase d on a.FPurchaseOrgUnitID=d.FID  " +
                                  "left join T_BD_Person e on a.FPurchasePersonID=e.FID  " +
                                  "left join T_BD_Currency f on a.FCurrencyID=f.FID " +
                                  "left join T_BD_PaymentType g on a.FPaymentTypeID=g.FID " +
                                  "left join T_ORG_Admin h on a.FAdminOrgUnitID=h.FID  " +
                                  "left join T_PM_User i on a.FCreatorID=i.FID " +
                                  "left join T_BD_PurchaseGroup j on a.FPurchaseGroupID=j.FID " +
                                  "left join T_BD_SettlementType k on a.FSettlementTypeID=k.FID " +
                                  "left join T_BD_CashDiscount l on a.FCashDiscountID=l.FID  " +
                                  " order by FBizDate desc) where rownum<100";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strOem, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasOem");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        [WebMethod]
        public DataTable GetOemDetail(string cOrderNumber)
        {
            const string strOemDetail = "select  RowNum, " +
                                        "a.FNumber as cOrderNumber, " +
                                        "a.FBizDate as dDate,   " +
                                        "c.Fname_l2 as cVendor, " +
                                        "d.FNumber as cInvCode, " +
                                        "d.Fname_l2 as cInvName, " +
                                        "d.FModel as cInvStd, " +
                                        "e.Fname_l2 as cUnit, " +
                                        "b.Fqty as iQuantity, " +//-nvl(b.FTotalReceiveQty,0)
                                        "b.FQTY, " +
                                        "b.FPrice, " +
                                        "b.FTaxRate, " +
                                        "b.FAmount, " +
                                        "b.FDeliveryDate, " +
                                        "'' FProcessRequirement, " +
                                        "b.FRemark as cMemo " +
                                        "from T_SM_SubContractOrder a inner join T_SM_SubContractOrderEntry b on a.FID=b.FParentID " +
                                        "left join T_BD_Supplier c on a.FSupplierID=c.FID " +
                                        "left join T_BD_Material d on b.FMaterialID=d.FID    " +
                                        "left  join T_BD_MeasureUnit e on d.FBaseUnit=e.FID " +
                                        "where a.Fnumber=:Fnumber";

            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strOemDetail, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasOemDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetWo2(string cOrderNumber = "")
        {
            const string strPo = "select * from (select RowNum, " +
                                 "a.FNumber as cOrderNumber,g.Fname_l2 as cInvName, " +
                                 "b.Fname_l2 as cOrderType, " +
                                 "e.Fname_l2 as cLine, " +
                                 "case FBaseStatus when 0 then '新增' when 1 then '保存'   " +
                                 "                when 2 then '提交' when 3 then '作废' when 4 then '审核'   " +
                                 "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus,  " +
                                 "c.fname_l2 as cDepartment, " +
                                 "a.fbizdate as dDate, " +
                                 "d .fname_l2 as cBanZu, " +
                                 "case FIsBackFlushed when 0 then '否' when 1 then '是'  end as cDaoChong, " +
                                 "'' as cMemo,  " +
                                  "h.Fname_l2 as cUser,  " +
                                   "f.FLotNo as cLotNo  " +
                                 "from T_MM_FinishedRpt a  " +
                                 "inner join T_SCM_BillType b on a.FBillTypeID=b.FID " +
                                 "inner join T_ORG_Admin c on a.FWorkshopID=c.FID  " +
                                 "left join T_MM_ClassGroup d on a.FClassGroupID=d.FID " +
                                 "left join T_MM_ProductLine e on a.FProductLineID=e.FID "+
                                 "left join T_MM_FinishedRptEntry f on a.FID=f.FParentID " +
                                 "left join T_BD_Material g on f.FMaterialID=g.FID " +
                                 "inner join T_PM_User h on a.FCreatorID=h.FID " +
                                 "where  a.FNumber like '%'||:FNumber||'%' " +
                                 "or g.Fname_l2 like '%'||:FNumber||'%'  " +
                                 "or f.FLotNo like '%'||:FNumber||'%'  " +
                                 "or h.fname_l2 like '%'||:FNumber||'%'  " +
                                 "  order by FBizDate desc) where rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasWo");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取工序完工汇报单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetWo()
        {
            const string strPo = "select * from (select RowNum, " +
                                 "a.FNumber as cOrderNumber,g.Fname_l2 as cInvName, " +
                                 "b.Fname_l2 as cOrderType, " +
                                 "e.Fname_l2 as cLine, " +
                                 "case FBaseStatus when 0 then '新增' when 1 then '保存'   " +
                                 "                when 2 then '提交' when 3 then '作废' when 4 then '审核'   " +
                                 "                when 5 then '下达' when 6 then '冻结' when 7 then '关闭' end as cStatus,  " +
                                 "c.fname_l2 as cDepartment, " +
                                 "a.fbizdate as dDate, " +
                                 "d .fname_l2 as cBanZu, " +
                                 "case FIsBackFlushed when 0 then '否' when 1 then '是'  end as cDaoChong, " +
                                 "'' as cMemo,  " +
                                 "h.Fname_l2 as cUser,  " +
                                  "f.FLotNo as cLotNo  " +
                                 "from T_MM_FinishedRpt a  " +
                                 "inner join T_SCM_BillType b on a.FBillTypeID=b.FID " +
                                 "inner join T_ORG_Admin c on a.FWorkshopID=c.FID  " +
                                 "left join T_MM_ClassGroup d on a.FClassGroupID=d.FID " +
                                 "left join T_MM_ProductLine e on a.FProductLineID=e.FID " +
                                 "left join T_MM_FinishedRptEntry f on a.FID=f.FParentID " +
                                 "left join T_BD_Material g on f.FMaterialID=g.FID " +
                                 "inner join T_PM_User h on a.FCreatorID=h.FID " +
                                 " order by FBizDate desc) where rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strPo, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasWo");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetWoDetail(string cOrderNumber)
        {
            const string strPo = "select  RowNum, " +
                                 "a.FNumber as cOrderNumber,  " +
                                 "a.FBizDate as dDate,   " +
                                 "case FOutPutType when 10710 then '主产品' " +
                                 "when 10720 then '联产品' when 10730 then '副产品' " +
                                 "when 10740 then '其他' end  as FOutPutType,   " +
                                 "d.FNumber as cInvCode,   " +
                                 "d.Fname_l2 as cInvName,   " +
                                 "d.FModel as cInvStd, " +
                                 "e.Fname_l2 as cUnit,  " +
                                 "b.FLotNo as cLotNo,   " +
                                 "b.FFinishDate as dDoneDate,  " +
                                 "b.FCommitQty as iDoneQty,   " +
                                 "b.FCommitQty as iQuantity,   " +
                                 "b.FTotalRejectQty as iUnPassQty,   " +
                                 "c.FNumber as cProOrder,   " +
                                 "FRemark as cMemo    " +
                                 "from T_MM_FinishedRpt a inner join T_MM_FinishedRptEntry b on a.FID=b.FParentID  " +
                                 "left join T_MM_ProductionOrder c on a.FProductionOrderID=c.FID " +
                                 "left join T_BD_Material d on b.FMaterialID=d.FID  " +  
                                 "left  join T_BD_MeasureUnit e on d.FBaseUnit=e.FID  " +
                                 "where a.Fnumber=:Fnumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasWoDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取生产订单
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetProduce2(string cOrderNumber = "")
        {
            const string strPo = "select * from (select RowNum,a.FNumber cOrderNumber,b.Fname_l2 as cOrderType,a.FBizDate dDate,d.Fname_l2 cUser,a.FQty iQuantity," +
                                 "a.FLotNo cLotNo,a.FStartDate,a.FEndDate,c.FNumber cInvCode, " +
                                 "c.FName_L2 cInvName,e.Fname_l2 cDepartment,'' cMemo " +
                                 "from T_MM_ProductionOrder a " +
                                 "left join T_SCM_BizType b on a.FBizTypeID=b.FID  " +
                                 "inner join T_BD_Material c on a.FMaterialID=c.fid " +
                                 "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                 "inner join T_ORG_Admin e on a.FWorkShopID=e.FID where  " +
                                 "a.FNumber like '%'||:FNumber||'%' " +
                                 "or d.Fname_l2 like '%'||:FNumber||'%'  " +
                                 "or a.FLotNo like '%'||:FNumber||'%'  " +
                                 "or c.fname_l2 like '%'||:FNumber||'%'  " +
                                 "order by FBizDate desc) where  rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasProduce");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取生产订单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetProduce()
        {
            const string strPo = "select * from (select RowNum,a.FNumber cOrderNumber,b.Fname_l2 as cOrderType,a.FBizDate dDate,d.Fname_l2 cUser,a.FQty iQuantity," +
                                 "a.FLotNo cLotNo,a.FStartDate,a.FEndDate,c.FNumber cInvCode, " +
                                 "c.FName_L2 cInvName,e.Fname_l2 cDepartment,'' cMemo " +
                                 "from T_MM_ProductionOrder a " +
                                 "left join T_SCM_BizType b on a.FBizTypeID=b.FID  " +
                                 "inner join T_BD_Material c on a.FMaterialID=c.fid " +
                                 "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                 "inner join T_ORG_Admin e on a.FWorkShopID=e.FID " +
                                 "order by FBizDate desc) where  rownum<100 ";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasProduce");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        [WebMethod]
        public DataTable GetProduceDetail(string cOrderNumber)
        {
            const string strPo = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                 "c.FName_L2 cInvName,b.FSeq cMemo " +
                                 "from T_MM_ProductionOrder a " +
                                 "inner join T_MM_ProductionOrderSEntry b on a.FID=b.FParentID " +
                                 "inner join T_BD_Material c on b.FMaterialID=c.fid " +
                                 "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                 "where a.Fnumber=:Fnumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasPo");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取EAS销售出库单
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetSale2(string cOrderNumber = "")
        {
            const string strPo = "select * from (select RowNum,a.FNumber cOrderNumber,b.Fname_l2 as cOrderType,a.FBizDate dDate,c.Fname_l2 cUser," +
                                 "'' cMemo ,d.Fname_l2 as cTranType,e.Fname_l2 as cDeliveryFrom " +
                                 "from T_IM_SaleIssueBill a " +
                                 "left join T_SCM_BizType b on a.FBizTypeID=b.FID  " +
                                 "inner join T_PM_User c on a.FCreatorID=c.FID " +
                                 "left join T_SCM_TransactionType d on a.FTransactionTypeID=d.FID " +
                                 "left join T_ORG_Storage e on a.FStorageOrgUnitID=e.FID " +
                                 "where  a.FNumber like '%'||:FNumber||'%' " +
                                 " order by FBizDate desc) where  rownum<100";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add(":FNumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {

                        var dt = new DataTable("EasSaleDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 获取EAS销售出库单
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetSale()
        {
            const string strPo = "select * from (select RowNum,a.FNumber cOrderNumber,b.Fname_l2 as cOrderType,a.FBizDate dDate,c.Fname_l2 cUser," +
                                 "'' cMemo,d.Fname_l2 as cTranType,e.Fname_l2 as cDeliveryFrom " +
                                 "from T_IM_SaleIssueBill a " +
                                 "left join T_SCM_BizType b on a.FBizTypeID=b.FID  " +
                                 "inner join T_PM_User c on a.FCreatorID=c.FID " +
                                 "left join T_SCM_TransactionType d on a.FTransactionTypeID=d.FID " +
                                 "left join T_ORG_Storage e on a.FStorageOrgUnitID=e.FID " +
                                 "where a.FTransactionTypeID='DawAAAAPoAywCNyn' and e.Fname_l2='宁波御坊堂生物科技有限公司'  " +
                                 " order by FBizDate desc) where  rownum<100";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {

                        var dt = new DataTable("EasSaleDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        [WebMethod]
        public DataTable GetSaleDetail(string cOrderNumber)
        {
            const string strPo = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                 "c.FName_L2 cInvName,b.FSeq cMemo,b.FPrice,b.FAmount,b.FLot cLotNo " +
                                 "from T_IM_SaleIssueBill a " +
                                 "inner join T_IM_SaleIssueEntry b on a.FID=b.FParentID " +
                                 "inner join T_BD_Material c on b.FMaterialID=c.fid " +
                                 "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                 "left join T_ORG_Storage e on a.FStorageOrgUnitID=e.FID  " +
                                 "where a.Fnumber=:Fnumber and e.Fname_l2='宁波御坊堂生物科技有限公司'";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasSaleDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        [WebMethod]
        public DataTable GetMaterialList(string cOrderNumber)
        {
            const string strPo = "select RowNum,a.FNumber cOrderNumber,a.FBizDate dDate,d.Fname_l2 cUser,b.FQty iQuantity,c.FNumber cInvCode, " +
                                 "c.FName_L2 cInvName,b.FSeq cMemo,b.FPrice,b.FAmount,b.FLot cLotNo " +
                                 "from T_IM_SaleIssueBill a " +
                                 "inner join T_IM_SaleIssueEntry b on a.FID=b.FParentID " +
                                 "inner join T_BD_Material c on b.FMaterialID=c.fid " +
                                 "inner join T_PM_User d on a.FCreatorID=d.FID " +
                                 "where a.Fnumber=:Fnumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strPo, con))
                {
                    cmd.Parameters.Add("@Fnumber", cOrderNumber);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasSaleDetail");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetRm()
        {
            const string strRm = "select a.fnumber cInvCode,a.FName_l2 cInvName,b.fname_l2,a.FStatus,nvl(c.FIsLotNumber,0) FIsLotNumber " +
                                 "from T_BD_Material a inner join  "+
                                 "(select fname_l2,fid,flevel from T_BD_MaterialGroup start with FID='riQAAAAAJ2vHn8BC' connect by prior FID=fparentid)  "+
                                 "b on a.fmaterialgroupid=b.FID " +
                                 "left join T_BD_MaterialInventory c on a.fid=c.fmaterialid "+
                                 "where  c.forgunit='riQAAAAAAD7M567U'";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strRm, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("Rm");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetSemi()
        {
            const string strRm = "select a.fnumber cInvCode,a.FName_l2 cInvName,b.fname_l2,a.FStatus,nvl(c.FIsLotNumber,0) FIsLotNumber " +
                                 "from T_BD_Material a inner join  " +
                                 "(select fname_l2,fid,flevel from T_BD_MaterialGroup start with FID='riQAAAAAJ6HHn8BC' connect by prior FID=fparentid)  " +
                                 "b on a.fmaterialgroupid=b.FID " +
                                 "left join T_BD_MaterialInventory c on a.fid=c.fmaterialid " +
                                 "where  c.forgunit='riQAAAAAAD7M567U'";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strRm, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("Semi");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable GetPro()
        {
            const string strRm = @"select a.fnumber cInvCode,a.FName_l2 cInvName,b.fname_l2,a.FStatus, nvl(c.FIsLotNumber,0) FIsLotNumber 
                                 from T_BD_Material a inner join 
                                 (select fname_l2,fid,flevel from T_BD_MaterialGroup start with FID='riQAAAAAJ8PHn8BC' connect by prior FID=fparentid) 
                                 b on a.fmaterialgroupid=b.FID 
                                 left join T_BD_MaterialInventory c on a.fid=c.fmaterialid 
                                 where  c.forgunit='riQAAAAAAD7M567U'"
                                 ;
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {

                using (var cmd = new OracleCommand(strRm, con))
                {
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("Pro");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



        /// <summary>
        /// 执行Oracle语句,返回第一结果
        /// </summary>
        /// <param name="ocmd"></param>
        /// <param name="cFunction"></param>
        /// <returns></returns>
        public string ExecOracleScale(OracleCommand ocmd, string cFunction)
        {
            using (var ocon = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (ocmd)
                {
                    ocmd.Connection = ocon;
                    try
                    {
                        ocon.Open();
                        var rValue = ocmd.ExecuteScalar();
                        if (rValue == null)
                        {
                            return "";
                        } return rValue.ToString();
                    }
                    catch (Exception ex)
                    {
                        return "";
                    }
                }
            }
        }
    }
}
