using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Oracle.DataAccess.Client;

namespace DataService
{
    /// <summary>
    /// EasAndWmsCompareReport 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class EasAndWmsCompareReport : System.Web.Services.WebService
    {

        /// <summary>
        /// 获取采购收货明细
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetPurReceivalDetail(DateTime dDate)
        {
            var strGetPoDetail = "select c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit " +
                        "from T_IM_PurReceivalBill a inner join " +
                        "T_IM_PurReceivalEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "where trunc(FBIZDATE)=trunc(:dDate) and a.FBaseStatus=4  " +
                        "group by c.fnumber,c.fname_l2";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetPoDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasPurReceival");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        /// <summary>
        /// 调拨出库明细
        /// </summary>
        /// <param name="dDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetMoveIssue(DateTime dDate)
        {
            var strGetDetail = "select c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit,b.FSourceBillNumber cOrderNumber " +
                        "from T_IM_MoveIssueBill a inner join " +
                        "T_IM_MoveIssueBillEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "left join T_DB_WAREHOUSE e on b.FWarehouseID=e.fid " +
                        "where trunc(a.fcreatetime)=trunc(:dDate) and e.fname_l2!='3期半成品待检库'" +
                        "group by c.fnumber,c.fname_l2,b.FSourceBillNumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasMoveIssue");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        /// <summary>
        /// 调拨入库明细
        /// </summary>
        /// <param name="dDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetMoveInWarehs(DateTime dDate)
        {
            var strGetDetail = "select c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit,b.FSourceBillNumber cOrderNumber " +
                        "from T_IM_MoveInWarehsBill a inner join " +
                        "T_IM_MoveInWarehsBillEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "left join T_DB_WAREHOUSE e on b.FWarehouseID=e.fid "+
                        "where trunc(a.fcreatetime)=trunc(:dDate) " +
                        "and e.fname_l2!='3期半成品库'  and a.FBaseStatus=4 and b.FSourceBillNumber not like '%TR%' and c.Fnumber not like 'N%' " +
                        "group by c.fnumber,c.fname_l2,b.FSourceBillNumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasMoveInWarehs");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        /// <summary>
        /// 生产领料
        /// </summary>
        /// <param name="dDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetMoveMaterialReq(DateTime dDate)
        {
            var strGetDetail = "select c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit,FOrderNumber cOrderNumber " +
                        "from T_IM_MaterialReqBill a inner join " +
                        "T_IM_MaterialReqBillEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "where trunc(a.fcreatetime)=trunc(:dDate) and ftransactiontypeid!='DawAAAAPoCywCNyn' " +
                        "and a.FBaseStatus=4 and c.Fnumber not like 'N%' " +
                        "group by c.fnumber,c.fname_l2,FOrderNumber";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasMoveMaterialReq");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



        /// <summary>
        /// 产成品完工入库
        /// </summary>
        /// <param name="dDate"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetManufactureRec(DateTime dDate)
        {
            var strGetDetail = "select c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit " +
                        "from T_IM_ManufactureRecBill a inner join " +
                        "T_IM_ManufactureRecBillEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "where trunc(a.fcreatetime)=trunc(:dDate) and c.fNumber not like '%NBS%' " +
                        "group by c.fnumber,c.fname_l2";
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasManufactureRec");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 销售出库 --2016-3-29 加入订单前缀筛选条件,用来筛选对应分仓订单
        /// </summary>
        /// <param name="dDate">查询日期</param>
        /// <param name="strOrderPrefix">订单前缀</param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetSaleIssue(DateTime dDate, string strOrderPrefix="")
        {
            var strGetDetail = string.Format(
                        "select a.fnumber as cOrderNumber,c.fnumber cInvCode,c.fname_l2 cInvName,sum(b.fqty) iSumQuantity,max(d.fname_l2) cUnit " +
                        "from T_IM_SaleIssueBill a inner join " +
                        "T_IM_SaleIssueEntry b on a.FID=b.FparentID " +
                        "inner join T_BD_Material c on b.fmaterialid=c.fid " +
                        "left join T_BD_MeasureUnit d on b.FUNITID=d.fid " +
                        "where trunc(a.fcreatetime)=trunc(:dDate) {0} and a.ftransactiontypeid='DawAAAAPoAywCNyn' and b.fsalegroupid is not null " +
                        "group by a.fnumber,c.fnumber,c.fname_l2"
                        , string.IsNullOrEmpty(strOrderPrefix) ? "" : "and a.fnumber like :FNumber||'%'");
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dDate", dDate);
                    cmd.Parameters.Add(":FNumber", strOrderPrefix);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasSaleIssue");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }




        /// <summary>
        /// 销售出库 --2016-3-29 加入订单前缀筛选条件,用来筛选对应分仓订单
        /// </summary>
        /// <param name="dStartDate"></param>
        /// <param name="dEndDate"></param>
        /// <param name="strOrderPrefix">订单前缀</param>
        /// <returns></returns>
        [WebMethod]
        public DataTable GetSaleOrder(DateTime dStartDate, DateTime dEndDate, string strOrderPrefix="")
        {
            var strGetDetail = string.Format(
                        "select fnumber as cOrderNumber from T_IM_SaleIssueBill " +
                        "where trunc(fcreatetime)>=trunc(:dStartDate) and trunc(fcreatetime)<=trunc(:dEndDate) {0} and ftransactiontypeid='DawAAAAPoAywCNyn' "
                        , string.IsNullOrEmpty(strOrderPrefix) ? "" : "and a.fnumber like :FNumber||'%'");
            using (var con = new OracleConnection(Properties.Settings.Default.EasCon))
            {
                using (var cmd = new OracleCommand(strGetDetail, con))
                {
                    cmd.Parameters.Add(":dStartDate", dStartDate);
                    cmd.Parameters.Add(":dEndDate", dEndDate);
                    cmd.Parameters.Add(":FNumber", strOrderPrefix);
                    using (var da = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable("EasSaleIssue");
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
