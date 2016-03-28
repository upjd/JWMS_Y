using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace DataService
{
    /// <summary>
    /// 接口的Oracle操作类
    /// </summary>
    public class InterfaceOracleFunction
    {
        /// <summary>
        /// Oracle连接字符串
        /// </summary>
        public string Constr;

        public InterfaceOracleFunction(string oracleCon)
        {
            Constr = oracleCon;
        }

        /// <summary>
        /// 获取对应BosType对应的FID
        /// </summary>
        /// <param name="BosType"></param>
        /// <returns></returns>
        public string GetFID(string BosType)
        {
            var cmd = new OracleCommand("select newbosid(:BosType) from dual ");
            cmd.Parameters.Add(":BosType", BosType);
            return ExecOracleScale(cmd, "获取FID");
        }

        /// <summary>
        /// 客户业务日期计算逻辑
        /// </summary>
        /// <returns></returns>
        public DateTime ReturnBizDate()
        {
            var cDate = Properties.Settings.Default.CloseDate;
            DateTime dCloseDate;
            int iCloseDate;
            if (DateTime.TryParse(cDate, out dCloseDate))
            {
                iCloseDate = dCloseDate.Day;
            }
            else
            {
                iCloseDate = 23;
            }
            var dDate = DateTime.Now.Day >= iCloseDate ? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1) : DateTime.Now.Date;
            return dDate;
        }

        /// <summary>
        /// 获取对应BosType对应的FID
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        public string GetInvCode(string fNumber)
        {
            var cmd = new OracleCommand("select FID from T_BD_Material where fNumber=:fNumber");
            cmd.Parameters.Add(":fNumber", fNumber);
            return ExecOracleScale(cmd, "获取物料FID");
        }


        /// <summary>
        /// 获取对应BosType对应的FID
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        public string GetWareHouse(string cInvCode)
        {
            var cmd = new OracleCommand("select FID from T_DB_WAREHOUSE where fNumber=:fNumber");
            cmd.Parameters.Add(":fNumber", cInvCode);
            return ExecOracleScale(cmd, "获取仓库FID" + cInvCode);
        }


        /// <summary>
        /// 获取对应BosType对应的FID
        /// </summary>
        /// <param name="cCusCode"></param>
        /// <returns></returns>
        public string GetCustomer(string cCusCode)
        {
            var cmd = new OracleCommand("select FID from  T_BD_Customer where fNumber=:fNumber");
            cmd.Parameters.Add(":fNumber", cCusCode);
            return ExecOracleScale(cmd, "获取客户FID" + cCusCode);
        }

        /// <summary>
        /// 获取完工汇报的生产订单FID
        /// </summary>
        /// <param name="cFID">完工汇报单FID</param>
        /// <returns></returns>
        public string GetFProductionOrderID(string cFID)
        {
            var cmd = new OracleCommand("select FProductionOrderID from T_MM_FinishedRpt where FID=:FID");
            cmd.Parameters.Add(":FID", cFID);
            return ExecOracleScale(cmd, "获取完工汇报对应的生产订单FID");
        }

        /// <summary>
        /// 获取生产订单单号
        /// </summary>
        /// <param name="cFID">完工汇报单FID</param>
        /// <returns></returns>
        public string GetWorkOrder(string cFID)
        {
            var cmd = new OracleCommand("select fnumber from T_MM_ProductionOrder where FID=:FID");
            cmd.Parameters.Add(":FID", cFID);
            return ExecOracleScale(cmd, "获取生产订单Fnumber");
        }


        /// <summary>
        /// 获取对应物料FID对应的单位
        /// </summary>
        /// <param name="cFID"></param>
        /// <returns></returns>
        public string GetInvUnit(string cFID)
        {
            var cmd = new OracleCommand("select b.FID from T_BD_Material a left join T_BD_MeasureUnit b on a.FBaseUnit=b.FID where a.FID=:FID");
            cmd.Parameters.Add(":FID", cFID);
            return ExecOracleScale(cmd, "获取物料单位" + cFID);
        }


        /// <summary>
        /// 获取对应单据对应的FID
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetSourIDByOrderNumber(string cOrderNumber,string cBillName)
        {
            var cmdstr = string.Format("select FID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取单据FID"+cBillName);
        }


        /// <summary>
        /// 根据生产订单号，获取生产类型-1:;10:普通;20:返工;30:返修;40:其他;
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetProductType(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FMmBizType from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取生产类型" + cBillName);
        }

        /// <summary>
        /// 通过生产订单，获取生产了什么东西
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetProProduct(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FMaterialID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取生产订单生产的物料" + cBillName);
        }

        
        /// <summary>
        /// 获取对应单据对应的库存组织
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetStorageUnitByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FStorageOrgUnitID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取源单据库存组织" + cBillName);
        }

        /// <summary>
        /// 获取对应单据对应的FID
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetControlIDByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FControlUnitID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取源单据控制" + cBillName);
        }

        /// <summary>
        /// 获取对应单据对应的调出
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetOutDepartmetByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FIssueAdminOrgUnitID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取调出部门" + cBillName);
        }



        /// <summary>
        /// 获取对应单据对应的调出
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetInDepartmetByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FReceiptAdminOrgUnitID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取调出部门" + cBillName);
        }

        /// <summary>
        /// 获取对应生产部门
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetWorkShopIDByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FWorkShopID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取生产部门" + cBillName);
        }
        

        /// <summary>
        /// 获取对应调拨单单据对应的调入财务组织
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetReceiptStorageByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FRECEIPTSTORAGEORGUNITID from {0} where fNumber=:fNumber", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取调入" + cBillName);
        }


        /// <summary>
        /// 获取调出仓库
        /// </summary>
        /// <param name="cFid"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetFIssueWarehouseIDByFID(string cFid, string cBillName)
        {
            var cmdstr = string.Format("select FIssueWarehouseID from {0} where FID=:FID", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFid);
            return ExecOracleScale(cmd, "获取调出仓库" + cFid);
        }

        /// <summary>
        /// 获取调出仓库
        /// </summary>
        /// <param name="cFid"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetFReceiptWarehouseIDByfID(string cFid, string cBillName)
        {
            var cmdstr = string.Format("select FReceiptWarehouseID from {0} where FID=:FID", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFid);
            return ExecOracleScale(cmd, "获取调入仓库" + cBillName);
        }


        /// <summary>
        /// 获取源单仓库ID
        /// </summary>
        /// <param name="cFid"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetWarehouseIDByfID(string cFid, string cBillName)
        {
            var cmdstr = string.Format("select FwarehouseID from {0} where FID=:FID", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFid);
            return ExecOracleScale(cmd, "获取源单仓库" + cBillName);
        }


        /// <summary>
        /// 获取备料仓库
        /// </summary>
        /// <param name="cFid"></param>
        /// <param name="cBillName"></param>
        /// <returns></returns>
        public string GetDefaultWarehouseIDByfID(string cFid, string cBillName)
        {
            var cmdstr = string.Format("select FDefaultWarehouseID from {0} where FID=:FID", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFid);
            return ExecOracleScale(cmd, "获取备料仓库" + cBillName);
        }

        /// <summary>
        /// 获取成本中心通过生产订单单号
        /// </summary>
        /// <param name="cOrdernumber"></param>
        /// <returns></returns>
        public string GetCostByOrderNumber(string cOrdernumber, string cOrgId)
        {
            var cmdstr = string.Format("select FID from T_BD_CostObject where FStdProductIDID in (select FMaterialID  from T_MM_ProductionOrder where fnumber=:fnumber) and FCompanyID=:FCompanyID");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrdernumber);
            cmd.Parameters.Add(":FCompanyID", cOrgId);
            return ExecOracleScale(cmd, "获取成本中心" + cOrdernumber);
        }



        /// <summary>
        /// 生产入库获取完工入库的FWorkShopID做为成本中心
        /// </summary>
        /// <param name="cOrdernumber"></param>
        /// <returns></returns>
        public string GetWorkShopIDByOrderNumber(string cOrdernumber)
        {
            var cmdstr = string.Format("select FWorkShopID from T_MM_FinishedRpt where Fnumber=:Fnumber");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrdernumber);
            return ExecOracleScale(cmd, "获取成本中心" + cOrdernumber);
        }

        /// <summary>
        /// 生产入库获取完工入库的FWorkShopID做为成本中心
        /// </summary>
        /// <param name="cOrdernumber"></param>
        /// <returns></returns>
        public string GetWorkShopIDByProductOrderNumber(string cOrdernumber)
        {
            var cmdstr = string.Format("select FWorkShopID from T_MM_ProductionOrder where Fnumber=:Fnumber");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrdernumber);
            return ExecOracleScale(cmd, "获取成本中心" + cOrdernumber);
        }
        /// <summary>
        /// 获取成本中心，通过完工汇报单对应的源单单号
        /// </summary>
        /// <param name="cFID"></param>
        /// <returns></returns>
        public string GetCostByOrderID(string cFID, string cOrgId)
        {
            var cmdstr = string.Format("select FID from T_BD_CostObject where FStdProductIDID in (select FMaterialID  from T_MM_ProductionOrder where FID=:FID  ) and  FCompanyID=:FCompanyID ");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFID);
            cmd.Parameters.Add(":FCompanyID", cOrgId);
            return ExecOracleScale(cmd, "获取成本中心" + cFID);
        }


        /// <summary>
        /// 通过完工汇报获取生产订单号
        /// </summary>
        /// <param name="cOrderNumber"></param>
        /// <returns></returns>
        public string GetProductOrderID(string cOrderNumber)
        {
            var cmdstr = string.Format("select FProductionOrderID from T_MM_FinishedRpt where FNumber=:FNumber");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FNumber", cOrderNumber);
            return ExecOracleScale(cmd, "获取生产订单ID" + cOrderNumber);
        }

        /// <summary>
        /// 获取成本中心，通过完工汇报单对应的源单单号
        /// </summary>
        /// <param name="cFID"></param>
        /// <returns></returns>
        public string GetCostByID(string cFID, string cOrgId)
        {
            var cmdstr = string.Format("select FID from T_BD_CostObject where FStdProductIDID=:FStdProductIDID and FCompanyID=:FCompanyID ");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FStdProductIDID", cFID);
            cmd.Parameters.Add(":FCompanyID", cOrgId);
            return ExecOracleScale(cmd, "获取成本中心" + cFID);
        }


        /// <summary>
        /// 获取成本中心，通过生产订单号、库存组织
        /// </summary>
        /// <param name="cProductID"></param>
        /// <param name="cGroupID"></param>
        /// <returns></returns>
        public string GetCostByProductAndGroupID(string cProductID,string cGroupID)
        {
            var cmdstr = string.Format("select FID from T_BD_CostObject where FStdProductIDID in (select FMaterialID  from T_MM_ProductionOrder where FID=:FID) and FCONTROLUNITID=:FCONTROLUNITID");
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cProductID);
            cmd.Parameters.Add(":FCONTROLUNITID", cGroupID);
            return ExecOracleScale(cmd, "获取成本中心" + cProductID + "Group" + cGroupID);
        }

        /// <summary>
        /// 获取成本中心，通过完工汇报单对应的源单单号(获取是否进行批次管理) -- 16-3-28 修改
        /// </summary>
        /// <param name="cFMaterialID"></param>
        /// <param name="forgunit">库存组织</param>
        /// <returns></returns>
        public string GetBLotById(string cFMaterialID, string forgunit)
        {
            var cmdstr = "select FIsLotNumber from T_BD_MaterialInventory where FMaterialID=:FMaterialID and forgunit=:forgunit";//'riQAAAAAAD7M567U'
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FMaterialID", cFMaterialID);
            cmd.Parameters.Add(":forgunit", forgunit);
            return ExecOracleScale(cmd, "获取批次管理" + cFMaterialID + forgunit);
        }


        /// <summary>
        /// 获取生产日期
        /// </summary>
        /// <param name="cFMaterialID"></param>
        /// <returns></returns>
        public string GetProductDate(string cFMaterialID, string FLOT)
        {
            var cmdstr = "select FMFG from T_IM_DateOfMinDurability where FMaterialID =:FMaterialID AND FLOT =:FLOT AND FCONTROLUNITID = 'riQAAAAAAD7M567U'";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FMaterialID", cFMaterialID);
            cmd.Parameters.Add(":FLOT", FLOT);
            return ExecOracleScale(cmd, "获取生产日期" + cFMaterialID + FLOT);
        }


        /// <summary>
        /// 获取失效日期
        /// </summary>
        /// <param name="cFMaterialID"></param>
        /// <returns></returns>
        public string GetProductExpDate(string cFMaterialID, string FLOT)
        {
            var cmdstr = "select FEXP from T_IM_DateOfMinDurability where FMaterialID =:FMaterialID AND FLOT =:FLOT AND FCONTROLUNITID = 'riQAAAAAAD7M567U'";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FMaterialID", cFMaterialID);
            cmd.Parameters.Add(":FLOT", FLOT);
            return ExecOracleScale(cmd, "获取失效" + cFMaterialID);
        }

        /// <summary>
        /// 获取供应商
        /// </summary>
        /// <param name="cOrdernumber"></param>
        /// <returns></returns>
        public string GetSupplyByOrderNumber(string cOrdernumber)
        {
            var cmdstr =  "select FSupplierID from T_SM_PurOrder where fNumber=:fNumber";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrdernumber);
            return ExecOracleScale(cmd, "获取供应商" + cOrdernumber);
        }


        /// <summary>
        /// 获取供应商
        /// </summary>
        /// <param name="cOrdernumber"></param>
        /// <returns></returns>
        public string GetSupplyByOemOrderNumber(string cOrdernumber)
        {
            var cmdstr = "select FSupplierID from T_SM_SubContractOrder where fNumber=:fNumber";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fNumber", cOrdernumber);
            return ExecOracleScale(cmd, "获取供应商" + cOrdernumber);
        }


        /// <summary>
        /// 获取供应商操作员对应ID
        /// </summary>
        /// <param name="cUserName"></param>
        /// <returns></returns>
        public string GetUserIDbyUserName(string cUserName)
        {
            var cmdstr = "select FID from T_PM_User where fname_L2=:fname_L2";
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":fname_L2", cUserName);
            return ExecOracleScale(cmd, "获取制单人" + cUserName);
        }

        /// <summary>
        /// 获取源单对应的审核人
        /// </summary>
        /// <param name="cOrderNumber">源单子表表FID</param>
        /// <param name="cBillName">哪张单据</param>
        /// <returns></returns>
        public string GetUserIDByOrderNumber(string cOrderNumber, string cBillName)
        {
            var cmdstr = string.Format("select FAuditorID from {0} where FNUMBER=:FNUMBER or FID=:FNUMBER", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FNUMBER", cOrderNumber);
            return ExecOracleScale(cmd, "获取源单据审核人" + cBillName);
        }

        /// <summary>
        /// 获取源单对应的行FID
        /// </summary>
        /// <param name="cParentId">源单主表FID</param>
        /// <param name="cFMaterialID">物料ID</param>
        /// <param name="cBillName">单据</param>
        /// <returns></returns>
        public string GetEntrySourIDByOrderNumber(string cParentId, string cFMaterialID, string cBillName)
        {
            var cmdstr = string.Format("select FID from {0} where FParentID=:FParentID  and FMaterialID=:FMaterialID", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FParentID", cParentId);
            cmd.Parameters.Add(":FMaterialID", cFMaterialID);
            return ExecOracleScale(cmd, "获取源单据行FID" + cBillName);
        }

        /// <summary>
        /// 获取源单对应的行FID
        /// </summary>
        /// <param name="cParentId">源单主表FID</param>
        /// <param name="cFMaterialID">物料ID</param>
        /// <param name="cBillName">单据</param>
        /// <param name="cLotNo">批号</param>
        /// <returns></returns>
        public string GetEntrySourIDByOrderNumberAndLotNo(string cParentId, string cFMaterialID, string cBillName,string cLotNo)
        {
            var cmdstr = string.Format("select FID from {0} where FParentID=:FParentID  and FMaterialID=:FMaterialID and FLot=:FLot and FLot is not null", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FParentID", cParentId);
            cmd.Parameters.Add(":FMaterialID", cFMaterialID);
            cmd.Parameters.Add(":FLot", cLotNo);
            return ExecOracleScale(cmd, "获取源单据行FID" + cBillName+"  物料"+cFMaterialID+" 批号"+cLotNo);
        }

        

        /// <summary>
        /// 获取源单对应的行号
        /// </summary>
        /// <param name="cFID">源单子表表FID</param>
        /// <param name="cBillName">哪张单据</param>
        /// <returns></returns>
        public string GetEntrySeqByEntryFid(string cFID, string cBillName)
        {
            var cmdstr = string.Format("select FSEQ from {0} where FID=:FID ", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFID);
            return ExecOracleScale(cmd, "获取源单据行号" + cBillName);
        }

        /// <summary>
        /// 获取源单对应的单价
        /// </summary>
        /// <param name="cFID">源单子表FID</param>
        /// <param name="cBillName">哪张单据</param>
        /// <returns></returns>
        public string GetEntryPriceByEntryFid(string cFID, string cBillName)
        {
            var cmdstr = string.Format("select FPrice from {0} where FID=:FID ", cBillName);
            var cmd = new OracleCommand(cmdstr);
            cmd.Parameters.Add(":FID", cFID);
            return ExecOracleScale(cmd, "获取源单据行号" + cBillName);
        }

        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="cFunction"></param>
        /// <param name="cDescription"></param>
        public void LogAction(string cFunction,string cDescription)
        {
            using (var con = new SqlConnection(Properties.Settings.Default.WmsCon))
            {
                using (var cmd = new SqlCommand("AddLogAction",con){CommandType = System.Data.CommandType.StoredProcedure})
                {
                    con.Open();
                    {
                        cmd.Parameters.AddWithValue("@cFunction", cFunction);
                        cmd.Parameters.AddWithValue("@cDescription", cDescription);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        /// <summary>
        /// 执行Oracle语句
        /// </summary>
        /// <param name="ocmd"></param>
        /// <param name="cFunction"></param>
        /// <returns></returns>
        public bool ExecOracleCmd(OracleCommand ocmd,OracleConnection ocon,string cFunction)
        {
            using (ocmd)
            {
                ocmd.Connection = ocon;
                try
                {
                    return ocmd.ExecuteNonQuery() >= 0;
                }
                catch (Exception ex)
                {
                    LogAction(cFunction,"写入失败："+ex.Message);
                    return false;
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
            using (var ocon = new OracleConnection(Constr))
            {
                using (ocmd)
                {
                    ocmd.Connection = ocon;
                    try
                    {
                        ocon.Open();
                        var rValue= ocmd.ExecuteScalar();
                        if (rValue == null)
                        {
                            LogAction(cFunction, "查询无结果：" + ocmd.CommandText);
                            return "";
                        }return rValue.ToString();
                    }
                    catch (Exception ex)
                    {
                        LogAction(cFunction, "查询失败：" + ex.Message);
                        return "";
                    }
                }
            }
        }



    }
}