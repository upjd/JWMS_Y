using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    public class MoveIssueBill
    {
        /// <summary>
        /// 单据内码    VARCHAR2(44)
        /// </summary>
        public string FID;      //单据内码    VARCHAR2(44)
        
        /// <summary>
        /// 库存组织    VARCHAR2(44)
        /// </summary>
        public string FSTORAGEORGUNITID;      //库存组织    VARCHAR2(44)
        
        /// <summary>
        /// 审核时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FAUDITTIME;      //审核时间    TIMESTAMP(6)(11)

        /// <summary>
        /// //单据状态    NUMBER(22)
        /// </summary>
        public int FBASESTATUS;      //单据状态    NUMBER(22)


        /// <summary>
        /// 业务类型    VARCHAR2(44)
        /// </summary>
        public string FBIZTYPEID;      //业务类型    VARCHAR2(44)

        /// <summary>
        /// /单据编号    NVARCHAR2(240)
        /// </summary>
        public string FNUMBER;      //单据编号    NVARCHAR2(240)


        /// <summary>
        /// 业务日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;      //业务日期    TIMESTAMP(6)(11)


        /// <summary>
        /// 创建者    VARCHAR2(44)
        /// </summary>
        public string FCREATORID;      //创建者    VARCHAR2(44)

        /// <summary>
        /// 创建时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FCREATETIME;      //创建时间    TIMESTAMP(6)(11)

        /// <summary>
        /// /调入库存组织    VARCHAR2(44)
        /// </summary>
        public string FRECEIPTSTORAGEORGUNITID;      //调入库存组织    VARCHAR2(44)

        /// <summary>
        /// 调出财务组织    VARCHAR2(44)
        /// </summary>
        public string FISSUECOMPANYORGUNITID;      //调出财务组织    VARCHAR2(44)



        /// <summary>
        /// 调入财务组织    VARCHAR2(44)
        /// </summary>
        public string FRECEIPTCOMPANYORGUNITID;      //调入财务组织    VARCHAR2(44)


        /// <summary>
        /// 是否系统单据
        /// </summary>
        public int FISSYSBILL;      //isSysBill    NUMBER(22)


        /// <summary>
        /// 部门    VARCHAR2(44)
        /// </summary>
        public string FADMINORGUNITID;      //部门    VARCHAR2(44)


        /// <summary>
        /// /库管员    VARCHAR2(44)
        /// </summary>
        public string FSTOCKERID;      //库管员    VARCHAR2(44)


        /// <summary>
        /// /凭证    VARCHAR2(44)
        /// </summary>
        public string FVOUCHERID;      //凭证    VARCHAR2(44)


        /// <summary>
        /// /总数量    NUMBER(22)
        /// </summary>
        public decimal FTOTALQTY;      //总数量    NUMBER(22)

        /// <summary>
        /// 总金额    NUMBER(22)
        /// </summary>
        public decimal FTOTALAMOUNT;      //总金额    NUMBER(22)


        /// <summary>
        /// FFIVOUCHERED;      //是否生成凭证    NUMBER(22)
        /// </summary>
        public int FFIVOUCHERED;      //是否生成凭证    NUMBER(22)


        /// <summary>
        /// 总标准成本    NUMBER(22)
        /// </summary>
        public decimal FTOTALSTANDARDCOST;      //总标准成本    NUMBER(22)


        /// <summary>
        /// 总实际成本
        /// </summary>
        public decimal FTOTALACTUALCOST;      //总实际成本    NUMBER(22)


        /// <summary>
        /// 是否冲销
        /// </summary>
        public int FISREVERSED;      //是否冲销    NUMBER(22)


        /// <summary>
        /// 事务类型
        /// </summary>
        public string FTRANSACTIONTYPEID;      //事务类型    VARCHAR2(44)


        /// <summary>
        /// 是否是初始化单
        /// </summary>
        public int FISINITBILL;      //是否是初始化单    NUMBER(22)


        /// <summary>
        /// 月    NUMBER(22)
        /// </summary>
        public int FMONTH;      //月    NUMBER(22)


        /// <summary>
        /// 日    NUMBER(22)
        /// </summary>
        public int FDAY;      //日    NUMBER(22)


       /// <summary>
        /// 成本中心    VARCHAR2(44)
       /// </summary>
        public string FCOSTCENTERORGUNITID;      //成本中心    VARCHAR2(44)


        /// <summary>
        /// /来源单据类型    VARCHAR2(44)
        /// </summary>
        public string FSOURCEBILLTYPEID;      //来源单据类型    VARCHAR2(44)


        /// <summary>
        ///单据类型    VARCHAR2(44)
        /// </summary>
        public string FBILLTYPEID;      //单据类型    VARCHAR2(44)


        /// <summary>
        /// 业务年度    NUMBER(22)
        /// </summary>
        public int FYEAR;      //业务年度    NUMBER(22)


        /// <summary>
        /// 业务期间    NUMBER(22)
        /// </summary>
        public int FPERIOD;      //业务期间    NUMBER(22)

        /// <summary>
        /// 修改人    VARCHAR2(44)
        /// </summary>
        public string FMODIFIERID;      //修改人    VARCHAR2(44)


        /// <summary>
        /// 修改时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FMODIFICATIONTIME;      //修改时间    TIMESTAMP(6)(11)


        /// <summary>
        /// 经手人    VARCHAR2(44)
        /// </summary>
        public string FHANDLERID;      //经手人    VARCHAR2(44)

        /// <summary>
        /// 参考信息    NVARCHAR2(765)
        /// </summary>
        public string FDESCRIPTION;      //参考信息    NVARCHAR2(765)


        /// <summary>
        /// 是否曾经生效    NUMBER(22)
        /// </summary>
        public int FHASEFFECTED;      //是否曾经生效    NUMBER(22)


        /// <summary>
        /// 审核人    VARCHAR2(44)
        /// </summary>
        public string FAUDITORID;      //审核人    VARCHAR2(44)



        /// <summary>
        /// /原始单据ID    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLID;      //原始单据ID    NVARCHAR2(240)


        /// <summary>
        /// 来源功能    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEFUNCTION;      //来源功能    NVARCHAR2(240)

        /// <summary>
        /// 最后修改者    VARCHAR2(44)
        /// </summary>
        public string FLASTUPDATEUSERID;      //最后修改者    VARCHAR2(44)


        /// <summary>
        /// /最后修改时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FLASTUPDATETIME;      //最后修改时间    TIMESTAMP(6)(11)


        /// <summary>
        /// 控制单元    VARCHAR2(44)
        /// </summary>
        public string FCONTROLUNITID;      //控制单元    VARCHAR2(44)



    }
}