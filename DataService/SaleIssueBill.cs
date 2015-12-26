using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 销售出库主表
    /// </summary>
    public class SaleIssueBill
    {
        /// <summary>
        /// 单据内码    VARCHAR2(44)
        /// </summary>
        public string FID;      //单据内码    VARCHAR2(44)

        /// <summary>
        /// 创建者    VARCHAR2(44)
        /// </summary>
        public string FCREATORID;      //创建者    VARCHAR2(44)

        /// <summary>
        /// 创建时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FCREATETIME;      //创建时间    TIMESTAMP(6)(11)
        /// <summary>
        /// 最后修改时间    TIMESTAMP(6)
        /// </summary>
        public DateTime FLASTUPDATETIME;      //最后修改时间    TIMESTAMP(6)
        /// <summary>
        /// 最后修改者    VARCHAR2
        /// </summary>
        public string FLASTUPDATEUSERID;      //最后修改者    VARCHAR2

        /// <summary>
        /// 控制单元    VARCHAR2
        /// </summary>
        public string FCONTROLUNITID;      //控制单元    VARCHAR2

        /// <summary>
        /// 单据编号    NVARCHAR2(240)
        /// </summary>
        public string FNUMBER;      //单据编号    NVARCHAR2(240)

        /// <summary>
        /// 业务日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;      //业务日期    TIMESTAMP(6)(11)


        /// <summary>
        /// 经手人    VARCHAR2
        /// </summary>
        public string FHANDLERID;      //经手人    VARCHAR2


        /// <summary>
        /// 参考信息    NVARCHAR2
        /// </summary>
        public string FDESCRIPTION;      //参考信息    NVARCHAR2


        /// <summary>
        /// 是否曾经生效    NUMBER
        /// </summary>
        public int FHASEFFECTED;      //是否曾经生效    NUMBER

        /// <summary>
        /// 审核人    VARCHAR2
        /// </summary>
        public string FAUDITORID;      //审核人    VARCHAR2

        /// <summary>
        /// 原始单据ID    NVARCHAR2
        /// </summary>
        public string FSOURCEBILLID;      //原始单据ID    NVARCHAR2
        /// <summary>
        /// /来源功能    NVARCHAR2
        /// </summary>
        public string FSOURCEFUNCTION;      //来源功能    NVARCHAR2
        /// <summary>
        /// 审核时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FAUDITTIME;      //审核时间    TIMESTAMP(6)(11)

        /// <summary>
        /// 单据状态    NUMBER(22)
        /// </summary>
        public int FBASESTATUS;      //单据状态    NUMBER(22)

        /// <summary>
        /// 业务类型    VARCHAR2(44)
        /// </summary>
        public string FBIZTYPEID;      //业务类型    VARCHAR2(44)

        /// <summary>
        /// /来源单据类型    VARCHAR2
        /// </summary>
        public string FSOURCEBILLTYPEID;      //来源单据类型    VARCHAR2

        /// <summary>
        /// 单据类型    VARCHAR2(44)
        /// </summary>
        public string FBILLTYPEID;      //单据类型    VARCHAR2(44)
        /// <summary>
        /// 业务年度    NUMBER
        /// </summary>
        public int FYEAR;      //业务年度    NUMBER

        /// <summary>
        /// 业务期间    NUMBER
        /// </summary>
        public int FPERIOD;      //业务期间    NUMBER

        /// <summary>
        /// 库存组织    VARCHAR2(44)
        /// </summary>
        public string FSTORAGEORGUNITID;      //库存组织    VARCHAR2(44)

        /// <summary>
        /// 部门    VARCHAR2
        /// </summary>
        public string FADMINORGUNITID;      //部门    VARCHAR2

        /// <summary>
        /// 库管员    VARCHAR2
        /// </summary>
        public string FSTOCKERID;      //库管员    VARCHAR2

        /// <summary>
        /// /凭证    VARCHAR2
        /// </summary>
        public string FVOUCHERID;      //凭证    VARCHAR2

        /// <summary>
        /// 总数量    NUMBER
        /// </summary>
        public decimal FTOTALQTY;      //总数量    NUMBER

        /// <summary>
        /// 总金额    NUMBER
        /// </summary>
        public decimal FTOTALAMOUNT;      //总金额    NUMBER

        /// <summary>
        /// 是否生成凭证    NUMBER
        /// </summary>
        public decimal FFIVOUCHERED;      //是否生成凭证    NUMBER

        /// <summary>
        /// 总标准成本    NUMBER
        /// </summary>
        public decimal FTOTALSTANDARDCOST;      //总标准成本    NUMBER

        /// <summary>
        /// 总实际成本    NUMBER
        /// </summary>
        public decimal FTOTALACTUALCOST;      //总实际成本    NUMBER

        /// <summary>
        /// 是否冲销    NUMBER
        /// </summary>
        public decimal FISREVERSED;      //是否冲销    NUMBER
        /// <summary>
        /// 事务类型    VARCHAR2(44)
        /// </summary>
        public string FTRANSACTIONTYPEID;      //事务类型    VARCHAR2(44)
        /// <summary>
        /// 是否是初始化单    NUMBER
        /// </summary>
        public int FISINITBILL;      //是否是初始化单    NUMBER
        /// <summary>
        /// 送货客户    VARCHAR2(44)
        /// </summary>
        public string FCUSTOMERID;      //送货客户    VARCHAR2(44)
        /// <summary>
        /// 币别    VARCHAR2(44)
        /// </summary>
        public string FCURRENCYID;      //币别    VARCHAR2(44)

        /// <summary>
        /// 汇率    NUMBER(22)
        /// </summary>
        public decimal FEXCHANGERATE;      //汇率    NUMBER(22)
        /// <summary>
        /// 修改人    VARCHAR2
        /// </summary>
        public string FMODIFIERID;      //修改人    VARCHAR2
        /// <summary>
        /// 修改时间    TIMESTAMP(6)
        /// </summary>
        public DateTime FMODIFICATIONTIME;      //修改时间    TIMESTAMP(6)

        /// <summary>
        /// 付款方式    44
        /// </summary>
        public string FPaymentTypeID;      //付款方式    44

        /// <summary>
        /// 折算方式    NUMBER(22)
        /// </summary>
        public int FCONVERTMODE;      //折算方式    NUMBER(22)

        /// <summary>
        /// 是否系统单据    NUMBER(22)
        /// </summary>
        public int FISSYSBILL;      //是否系统单据    NUMBER(22)

        /// <summary>
        /// 价税总合计本位币    NUMBER(22)
        /// </summary>
        public int FTOTALLOCALAMOUNT;      //价税总合计本位币    NUMBER(22)

        /// <summary>
        /// 实际业务日期    TIMESTAMP(6)(11)
        /// </summary>
        public string FACTBIZDATE;      //实际业务日期    TIMESTAMP(6)(11)

        /// <summary>
        /// 是否生成业务应收    NUMBER(22)
        /// </summary>
        public int FIsGenBizAR;      //是否生成业务应收    NUMBER(22)
        /// <summary>
        /// 是否含税    NUMBER(22)
        /// </summary>
        public int FISINTAX;      //是否含税    NUMBER(22)

        /// <summary>
        /// 月    NUMBER
        /// </summary>
        public int FMONTH;      //月    NUMBER
        /// <summary>
        /// 日    NUMBER
        /// </summary>
        public int FDAY;      //日    NUMBER
        /// <summary>
        /// 整单关联算法    NUMBER(22)
        /// </summary>
        public string FBILLRELATIONOPTION;      //整单关联算法    NUMBER(22)
        /// <summary>
        /// 成本中心    VARCHAR2(44)
        /// </summary>
        public string FCOSTCENTERORGUNITID;      //成本中心    VARCHAR2(44)

    }
}