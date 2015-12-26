using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 生产领料主表
    /// </summary>
    public class MaterialReqBill
    {
        /// <summary>
        /// ID
        /// </summary>
        public string FID;     //ID
        /// <summary>
        /// 创建者
        /// </summary>
        public string FCREATORID;     //创建者
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime FCREATETIME;     //创建时间
        /// <summary>
        /// /最后修改者
        /// </summary>
        public string FLASTUPDATEUSERID;     //最后修改者

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime FLASTUPDATETIME;     //最后修改时间
        /// <summary>
        /// 控制单元
        /// </summary>
        public string FCONTROLUNITID;     //控制单元

        /// <summary>
        /// 单据编号
        /// </summary>
        public string FNUMBER;     //单据编号

        /// <summary>
        /// 业务日期
        /// </summary>
        public DateTime FBIZDATE;     //业务日期


        /// <summary>
        /// 审核人
        /// </summary>
        public string FAUDITORID;     //审核人

        /// <summary>
        /// 审核时间
        /// </summary>
        public string FAUDITTIME;     //审核时间

        /// <summary>
        /// 单据状态
        /// </summary>
        public int FBASESTATUS;     //单据状态

        /// <summary>
        /// 业务类型
        /// </summary>
        public string FBIZTYPEID;     //业务类型

        /// <summary>
        /// 来源单据类型
        /// </summary>
        public string FSOURCEBILLTYPEID;     //来源单据类型

        /// <summary>
        /// 单据类型
        /// </summary>
        public string FBILLTYPEID;     //单据类型

        /// <summary>
        /// 业务年度
        /// </summary>
        public int FYEAR;     //业务年度
        /// <summary>
        /// 业务期间
        /// </summary>
        public int FPERIOD;     //业务期间
        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;     //库存组织

        /// <summary>
        /// 部门
        /// </summary>
        public string FADMINORGUNITID;     //部门

        /// <summary>
        /// 库管员
        /// </summary>
        public string FSTOCKERID;     //库管员

        /// <summary>
        /// 总数量
        /// </summary>
        public decimal FTOTALQTY;     //总数量
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal FTOTALAMOUNT;     //总金额
        /// <summary>
        /// 是否生成凭证
        /// </summary>
        public int  FFIVOUCHERED;     //是否生成凭证
        /// <summary>
        /// 总标准成本
        /// </summary>
        public decimal FTOTALSTANDARDCOST;     //总标准成本
        /// <summary>
        /// 总实际成本
        /// </summary>
        public decimal FTOTALACTUALCOST;     //总实际成本

        /// <summary>
        /// 是否冲销
        /// </summary>
        public int FISREVERSED;     //是否冲销

        /// <summary>
        /// 事务类型
        /// </summary>
        public string FTRANSACTIONTYPEID;     //事务类型

        /// <summary>
        /// 是否是初始化单
        /// </summary>
        public int FISINITBILL;     //是否是初始化单

        /// <summary>
        /// 修改人
        /// </summary>
        public string FMODIFIERID;     //修改人

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime FMODIFICATIONTIME;     //修改时间

        /// <summary>
        /// 成本中心
        /// </summary>
        public string FCOSTCENTERORGUNITID;     //成本中心

        /// <summary>
        /// 采购类别
        /// </summary>
        public string FPURCHASETYPE;     //采购类别

        /// <summary>
        /// 倒冲标识
        /// </summary>
        public int FISBACKFLUSH;     //倒冲标识
        public int FMONTH;     //月
        public int FDAY;     //日
        /// <summary>
        /// 供应方库存组织
        /// </summary>
        public string FSUPPLYSTOREORGUNITID;     //供应方库存组织
        /// <summary>
        /// 供应方财务组织
        /// </summary>
        public string FSUPPLYCOMPANYORGUNITID;     //供应方财务组织
        /// <summary>
        /// 需求方财务组织
        /// </summary>
        public string FDEMANDCOMPANYORGUNITID;     //需求方财务组织


    }
}