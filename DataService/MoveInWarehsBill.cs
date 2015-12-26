using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 调拨入库
    /// </summary>
    public class MoveInWarehsBill
    {

        /// <summary>
        /// 单据内码 VARCHAR2(44)
        /// </summary>
        public string FID;


        /// <summary>
        /// 库存组织 VARCHAR2(44)
        /// </summary>
        public string FSTORAGEORGUNITID;


        /// <summary>
        /// 事务类型 VARCHAR2(44)
        /// </summary>
        public string FTRANSACTIONTYPEID;


        /// <summary>
        /// 业务类型 VARCHAR2(44)
        /// </summary>
        public string FBIZTYPEID;


        /// <summary>
        /// 单据编号 VARCHAR2(240)
        /// </summary>
        public string FNUMBER;


        /// <summary>
        /// 业务日期 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;



        /// <summary>
        /// 创建者 VARCHAR2(44)
        /// </summary>
        public string FCREATORID;


        /// <summary>
        /// 创建时间 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FCREATETIME;

        /// <summary>
        /// 调出财务组织 VARCHAR2(44)
        /// </summary>
        public string FISSUECOMPANYORGUNITID;


        /// <summary>
        /// 调入财务组织 VARCHAR2(44)
        /// </summary>
        public string FRECEIPTCOMPANYORGUNITID;


        /// <summary>
        /// 调出库存组织 VARCHAR2(44)
        /// </summary>
        public string FISSUESTORAGEORGUNITID;

        /// <summary>
        /// 是否系统单据 NUMBER(22)
        /// </summary>
        public int FISSYSBILL;


        /// <summary>
        /// 部门 VARCHAR2(44)
        /// </summary>
        public string FADMINORGUNITID;


        /// <summary>
        /// 库管员 VARCHAR2(44)
        /// </summary>
        public string FSTOCKERID;


        /// <summary>
        /// 凭证 VARCHAR2(44)
        /// </summary>
        public string FVOUCHERID;

        /// <summary>
        /// 总数量 NUMBER(22)
        /// </summary>
        public float FTOTALQTY;

        /// <summary>
        /// 总金额 NUMBER(22)
        /// </summary>
        public float FTOTALAMOUNT;


        /// <summary>
        /// 是否生成凭证 NUMBER(22)
        /// </summary>
        public int FFIVOUCHERED;


        /// <summary>
        /// 总标准成本 NUMBER(22)
        /// </summary>
        public float FTOTALSTANDARDCOST;

        /// <summary>
        /// 总实际成本 NUMBER(22)
        /// </summary>
        public float FTOTALACTUALCOST;

        /// <summary>
        /// 是否冲销 NUMBER(22)
        /// </summary>
        public int FISREVERSED;


        // <summary>
        /// 是否初始化单 NUMBER(22)
        /// </summary>
        public int FISINITBILL;


        /// <summary>
        /// 月 NUMBER(22)
        /// </summary>
        public int FMONTH;

        /// <summary>
        /// 日 NUMBER(22)
        /// </summary>
        public int FDAY;


        /// <summary>
        /// 成本中心 VARCHAR2(44)
        /// </summary>
        public string FCOSTCENTERORGUNITID;


        /// <summary>
        /// 审核时间 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FAUDITTIME;


        // <summary>
        /// 单据状态 NUMBER(22)
        /// </summary>
        public int FBASESTATUS;



        /// <summary>
        /// 来源单据类型 VARCHAR2(44)
        /// </summary>
        public string FSOURCEBILLTYPEID;



        /// <summary>
        /// 单据类型 VARCHAR2(44)
        /// </summary>
        public string FBILLTYPEID;


        // <summary>
        /// 业务年度 NUMBER(22)
        /// </summary>
        public int FYEAR;



        // <summary>
        /// 业务期间 NUMBER(22)
        /// </summary>
        public int FPERIOD;


        /// <summary>
        /// 修改人 VARCHAR2(44)
        /// </summary>
        public string FMODIFIERID;



        /// <summary>
        /// 修改时间 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FMODIFICATIONTIME;


        /// <summary>
        /// 经手人 VARCHAR2(44)
        /// </summary>
        public string FHANDLERID;


        /// <summary>
        /// 参考信息 VARCHAR2(44)
        /// </summary>
        public string FDESCRIPTION;



        /// <summary>
        /// 是否生效 NUMBER(22)
        /// </summary>
        public int FHASEFFECTED;


        /// <summary>
        /// 审核人 VARCHAR2(44)
        /// </summary>
        public string FAUDITORID;


        /// <summary>
        /// 原始单据ID VARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLID;


        /// <summary>
        /// 来源功能 VARCHAR2(240)
        /// </summary>
        public string FSOURCEFUNCTION;



        /// <summary>
        /// 最后修改者 VARCHAR2(240)
        /// </summary>
        public string FLASTUPDATEUSERID;



        /// <summary>
        /// 最后修改时间 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FLASTUPDATETIME;


        /// <summary>
        ///  
        /// </summary>
        public string FCONTROLUNITID;
    }
}