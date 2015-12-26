using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 采购收货单主表
    /// </summary>
    public class PurReceivalBill
    {
        /// <summary>
        ///ID   BOSUuid
        /// </summary>
        public string FID;


        /// <summary>
        ///创建者   string
        /// </summary>
        public string FCREATORID;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime FCREATETIME;

        /// <summary>
        /// 控制单元
        /// </summary>
        public string FCONTROLUNITID;

        /// <summary>
        /// 单据编号
        /// </summary>
        public string FNUMBER;


        /// <summary>
        /// 业务日期
        /// </summary>
        public DateTime FBIZDATE;

        /// <summary>
        /// 单据状态 2提交
        /// </summary>
        public int FBASESTATUS;

        /// <summary>
        /// 业务类型
        /// </summary>
        public string FBIZTYPEID;

        /// <summary>
        /// 来源单据类型
        /// </summary>
        public string FSOURCEBILLTYPEID;

        /// <summary>
        /// 单据类型
        /// </summary>
        public string FBILLTYPEID;

        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;

        /// <summary>
        /// 事务类型
        /// </summary>
        public string FTRANSACTIONTYPEID;

        /// <summary>
        /// 是否初始化单据
        /// </summary>
        public int FISINITBILL;

        /// <summary>
        /// 供应商
        /// </summary>
        public string FSUPPLIERID;

        /// <summary>
        /// 折算方式
        /// </summary>
        public int FCONVERTMODE;

        /// <summary>
        /// 是否集中结算
        /// </summary>
        public int FISCENTRALBALANCE;

        /// <summary>
        /// 采购类别 0
        /// </summary>
        public int FPURCHASETYPE;

        /// <summary>
        /// 月 201501
        /// </summary>
        public int FMONTH;
        /// <summary>
        /// 日 20150120
        /// </summary>
        public int FDAY;
    }
}