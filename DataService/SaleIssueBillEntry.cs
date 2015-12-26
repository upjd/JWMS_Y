using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 销售出库子表
    /// </summary>
    public class SaleIssueBillEntry
    {
        /// <summary>
        /// //单据内码    VARCHAR2(44)
        /// </summary>
        public string FID;      //单据内码    VARCHAR2(44)

        /// <summary>
        /// 单据分录序列号    NUMBER(22)
        /// </summary>
        public int FSEQ;      //单据分录序列号    NUMBER(22)


        /// <summary>
        /// /源单据Id    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLID;      //源单据Id    NVARCHAR2(240)

        /// <summary>
        /// 来源单据编号    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLNUMBER;      //来源单据编号    NVARCHAR2(240)

        /// <summary>
        /// /来源单据类型    VARCHAR2(44)
        /// </summary>
        public string FSOURCEBILLTYPEID;      //来源单据类型    VARCHAR2(44)

        /// <summary>
        /// 来源单据分录的Id    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLENTRYID;      //来源单据分录的Id    NVARCHAR2(240)

        /// <summary>
        /// 来源单据分录序号    NUMBER(22)
        /// </summary>
        public int FSOURCEBILLENTRYSEQ;      //来源单据分录序号    NUMBER(22)

        /// <summary>
        /// 辅助计量单位换算系数    NUMBER(22)
        /// </summary>
        public int FASSCOEFFICIENT;      //辅助计量单位换算系数    NUMBER(22)

        /// <summary>
        /// 基本状态    NUMBER(22)
        /// </summary>
        public int FBASESTATUS;      //基本状态    NUMBER(22)

        /// <summary>
        /// 物料    VARCHAR2(44)
        /// </summary>
        public string FMATERIALID;      //物料    VARCHAR2(44)


        /// <summary>
        /// 计量单位    VARCHAR2(44)
        /// </summary>
        public string FUNITID;      //计量单位    VARCHAR2(44)

        /// <summary>
        /// 基本计量单位    VARCHAR2(44)
        /// </summary>
        public string FBASEUNITID;      //基本计量单位    VARCHAR2(44)

        /// <summary>
        /// 辅助计量单位    VARCHAR2(44)
        /// </summary>
        public string FASSISTUNITID;      //辅助计量单位    VARCHAR2(44)


        /// <summary>
        /// 原因代码    VARCHAR2(44)
        /// </summary>
        public string FREASONCODEID;      //原因代码    VARCHAR2(44)

        /// <summary>
        /// 未关联数量    NUMBER(22)
        /// </summary>
        public decimal FASSOCIATEQTY;      //未关联数量    NUMBER(22)

        /// <summary>
        /// 库存组织    VARCHAR2(44)
        /// </summary>
        public string FSTORAGEORGUNITID;      //库存组织    VARCHAR2(44)

        /// <summary>
        /// 财务组织    VARCHAR2(44)
        /// </summary>
        public string FCOMPANYORGUNITID;      //财务组织    VARCHAR2(44)

        /// <summary>
        /// 仓库    VARCHAR2(44)
        /// </summary>
        public string FWAREHOUSEID;      //仓库    VARCHAR2(44)
        /// <summary>
        /// 库位    VARCHAR2(44)
        /// </summary>
        public string FLOCATIONID;      //库位    VARCHAR2(44)


        /// <summary>
        /// 仓管员    VARCHAR2(44)
        /// </summary>
        public string FSTOCKERID;      //仓管员    VARCHAR2(44)

        /// <summary>
        /// 批次    NVARCHAR2(240)
        /// </summary>
        public string FLOT;      //批次    NVARCHAR2(240)

        /// <summary>
        /// //数量    NUMBER(22)
        /// </summary>
        public decimal FQTY;      //数量    NUMBER(22)

        /// <summary>
        /// 辅助数量    NUMBER(22)
        /// </summary>
        public decimal FASSISTQTY;      //辅助数量    NUMBER(22)


        /// <summary>
        /// ///基本单位数量    NUMBER(22)
        /// </summary>
        public decimal FBASEQTY;      //基本单位数量    NUMBER(22)

        /// <summary>
        /// //冲销数量    NUMBER(22)
        /// </summary>
        public decimal FREVERSEQTY;      //冲销数量    NUMBER(22)

        /// <summary>
        /// //退货数量    NUMBER(22)
        /// </summary>
        public decimal FRETURNSQTY;      //退货数量    NUMBER(22)


        /// <summary>
        /// //实际含税单价    NUMBER(22)
        /// </summary>
        public decimal FPRICE;      //实际含税单价    NUMBER(22)

        /// <summary>
        /// //价税合计    NUMBER(22)
        /// </summary>
        public decimal FAMOUNT;      //价税合计    NUMBER(22)

        /// <summary>
        /// //单位标准成本    NUMBER(22)
        /// </summary>
        public decimal FUNITSTANDARDCOST;      //单位标准成本    NUMBER(22)


        /// <summary>
        /// //标准成本    NUMBER(22)
        /// </summary>
        public decimal FSTANDARDCOST;      //标准成本    NUMBER(22)

        /// <summary>
        /// //单位实际成本    NUMBER(22)
        /// </summary>
        public decimal FUNITACTUALCOST;      //单位实际成本    NUMBER(22)

        /// <summary>
        /// //实际成本    NUMBER(22)
        /// </summary>
        public int FACTUALCOST;      //实际成本    NUMBER(22)

        /// <summary>
        /// //是否赠品    NUMBER(22)
        /// </summary>
        public int FISPRESENT;      //是否赠品    NUMBER(22)

        /// <summary>
        /// //销售出库单    VARCHAR2(44)
        /// </summary>
        public string FPARENTID;      //销售出库单    VARCHAR2(44)

        /// <summary>
        /// //核心单据ID    VARCHAR2(44)
        /// </summary>
        public string FSALEORDERID;      //核心单据ID    VARCHAR2(44)

        /// <summary>
        /// //核心单据行ID    VARCHAR2(44)
        /// </summary>
        public string FSALEORDERENTRYID;      //核心单据行ID    VARCHAR2(44)

        /// <summary>
        /// //已核销数量    NUMBER(22)
        /// </summary>
        public decimal FWRITTENOFFQTY;      //已核销数量    NUMBER(22)

        /// <summary>
        /// //已核销金额    NUMBER(22)
        /// </summary>
        public decimal FWRITTENOFFAMOUNT;      //已核销金额    NUMBER(22)

        /// <summary>
        /// //未核销数量    NUMBER(22)
        /// </summary>
        public decimal FUNWRITEOFFQTY;      //未核销数量    NUMBER(22)

        /// <summary>
        /// //未核销金额    NUMBER(22)
        /// </summary>
        public decimal FUNWRITEOFFAMOUNT;      //未核销金额    NUMBER(22)

        /// <summary>
        /// //客户订单号    NVARCHAR2(240)
        /// </summary>
        public string FORDERNUMBER;      //客户订单号    NVARCHAR2(240)

        /// <summary>
        /// //核心单据号    NVARCHAR2(240)
        /// </summary>
        public string FSALEORDERNUMBER;      //核心单据号    NVARCHAR2(240)

        /// <summary>
        /// //核心单据行行号    NUMBER(22)
        /// </summary>
        public int FSALEORDERENTRYSEQ;      //核心单据行行号    NUMBER(22)

        /// <summary>
        /// //税率    NUMBER(22)
        /// </summary>
        public decimal FTAXRATE;      //税率    NUMBER(22)

        /// <summary>
        /// //税额    NUMBER(22)
        /// </summary>
        public decimal FTAX;      //税额    NUMBER(22)

        /// <summary>
        /// //本位币税额    NUMBER(22)
        /// </summary>
        public decimal FLOCALTAX;      //本位币税额    NUMBER(22)

        /// <summary>
        /// //本位币单价    NUMBER(22)
        /// </summary>
        public decimal FLOCALPRICE;      //本位币单价    NUMBER(22)

        /// <summary>
        /// //价税合计本位币    NUMBER(22)
        /// </summary>
        public decimal FLOCALAMOUNT;      //价税合计本位币    NUMBER(22)

        /// <summary>
        /// //金额    NUMBER(22)
        /// </summary>
        public decimal FNONTAXAMOUNT;      //金额    NUMBER(22)

        /// <summary>
        /// //金额本位币    NUMBER(22)
        /// </summary>
        public decimal FLOCALNONTAXAMOUNT;      //金额本位币    NUMBER(22)

        /// <summary>
        /// //已开票数量    NUMBER(22)
        /// </summary>
        public decimal FDREWQTY;      //已开票数量    NUMBER(22)

        /// <summary>
        /// //辅助属性    VARCHAR2(44)
        /// </summary>
        public string FASSISTPROPERTYID;      //辅助属性    VARCHAR2(44)

        /// <summary>
        /// //生产日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FMFG;      //生产日期    TIMESTAMP(6)(11)

        /// <summary>
        /// //到期日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FEXP;      //到期日期    TIMESTAMP(6)(11)

        /// <summary>
        /// //备注    NVARCHAR2(765)
        /// </summary>
        public string FREMARK;      //备注    NVARCHAR2(765)

        /// <summary>
        /// //冲销基本数量    NUMBER(22)
        /// </summary>
        public decimal FREVERSEBASEQTY;      //冲销基本数量    NUMBER(22)

        /// <summary>
        /// //退货基本数量    NUMBER(22)
        /// </summary>
        public decimal FRETURNBASEQTY;      //退货基本数量    NUMBER(22)

        /// <summary>
        /// ///已核销基本数量    NUMBER(22)
        /// </summary>
        public decimal FWRITTENOFFBASEQTY;      //已核销基本数量    NUMBER(22)


        /// <summary>
        /// //未核销基本数量    NUMBER(22)
        /// </summary>
        public decimal FUNWRITEOFFBASEQTY;      //未核销基本数量    NUMBER(22)

        /// <summary>
        /// //已开票基本数量    NUMBER(22)
        /// </summary>
        public decimal FDREWBASEQTY;      //已开票基本数量    NUMBER(22)

        /// <summary>
        /// ///核心单据类型    VARCHAR2(44)
        /// </summary>
        public string FCOREBILLTYPEID;      //核心单据类型    VARCHAR2(44)


        /// <summary>
        /// //可退货基本数量    NUMBER(22)
        /// </summary>
        public decimal FUNRETURNEDBASEQTY;      //可退货基本数量    NUMBER(22)

        /// <summary>
        /// //是否锁库    NUMBER(22)
        /// </summary>
        public int FISLOCKED;      //是否锁库    NUMBER(22)

        /// <summary>
        /// //库存台账ID    VARCHAR2(44)
        /// </summary>
        public string FINVENTORYID;      //库存台账ID    VARCHAR2(44)


        /// <summary>
        /// //订单单价    NUMBER(22)
        /// </summary>
        public decimal FORDERPRICE;      //订单单价    NUMBER(22)

        /// <summary>
        /// //含税单价    NUMBER(22)
        /// </summary>
        public decimal FTAXPRICE;      //含税单价    NUMBER(22)

        /// <summary>
        /// //实际单价    NUMBER(22)
        /// </summary>
        public decimal FACTUALPRICE;      //实际单价    NUMBER(22)


        /// <summary>
        /// //销售组织    VARCHAR2(44)
        /// </summary>
        public string FSALEORGUNITID;      //销售组织    VARCHAR2(44)

        /// <summary>
        /// //销售组    VARCHAR2(44)
        /// </summary>
        public string FSALEGROUPID;      //销售组    VARCHAR2(44)

        /// <summary>
        /// //销售员    VARCHAR2(44)
        /// </summary>
        public string FSALEPERSONID;      //销售员    VARCHAR2(44)

        /// <summary>
        /// //基本单位实际成本    NUMBER(22)
        /// </summary>
        public decimal FBASEUNITACTUALCOST;      //基本单位实际成本    NUMBER(22)

        /// <summary>
        /// //待发可出库数量    NUMBER(22)
        /// </summary>
        public decimal FUNDELIVERQTY;      //待发可出库数量    NUMBER(22)

        /// <summary>
        /// //待发可出库基本数量    NUMBER(22)
        /// </summary>
        public decimal FUNDELIVERBASEQTY;      //待发可出库基本数量    NUMBER(22)

        /// <summary>
        /// //对方未入库数量    NUMBER(22)
        /// </summary>
        public decimal FUNINQTY;      //对方未入库数量    NUMBER(22)

        /// <summary>
        /// //对方未入库基本数量    NUMBER(22)
        /// </summary>
        public decimal FUNINBASEQTY;      //对方未入库基本数量    NUMBER(22)

        /// <summary>
        ///  //应收客户    VARCHAR2(44)
        /// </summary>
        public string FBALANCECUSTOMERID;      //应收客户    VARCHAR2(44)


        /// <summary>
        /// //集中结算    NUMBER(22)
        /// </summary>
        public int FISCENTERBALANCE;      //集中结算    NUMBER(22)

        /// <summary>
        /// //跨公司发货    NUMBER(22)
        /// </summary>
        public int FISBETWEENCOMPANYSEND;      //跨公司发货    NUMBER(22)

        /// <summary>
        /// //累计入库数量    NUMBER(22)
        /// </summary>
        public decimal FTOTALINWAREHSQTY;      //累计入库数量    NUMBER(22)

        /// <summary>
        /// //收款客户    VARCHAR2(44)
        /// </summary>
        public string FPAYMENTCUSTOMERID;      //收款客户    VARCHAR2(44)


        /// <summary>
        /// ///订货客户    VARCHAR2(44)
        /// </summary>
        public string FORDERCUSTOMERID;      //订货客户    VARCHAR2(44)

        /// <summary>
        /// //确认签收数量    NUMBER(22)
        /// </summary>
        public decimal FCONFIRMQTY;      //确认签收数量    NUMBER(22)

        /// <summary>
        /// //确认签收基本数量    NUMBER(22)
        /// </summary>
        public decimal FCONFIRMBASEQTY;      //确认签收基本数量    NUMBER(22)

        /// <summary>
        ///  //签收未关联基本数量    NUMBER(22)
        /// </summary>
        public decimal FASSOCIATEBASEQTY;      //签收未关联基本数量    NUMBER(22)

        /// <summary>
        /// //确认签收时间    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FCONFIRMDATE;      //确认签收时间    TIMESTAMP(6)(11)
        /// <summary>
        ///  //送货地址    NVARCHAR2(765)
        /// </summary>
        public string FSENDADDRESS;      //送货地址    NVARCHAR2(765)


        /// <summary>
        /// //协同单据编号    NVARCHAR2(240)
        /// </summary>
        public string FNETORDERBILLNUMBER;      //协同单据编号    NVARCHAR2(240)

        /// <summary>
        ///  //协同单据ID    NVARCHAR2(132)
        /// </summary>
        public string FNETORDERBILLID;      //协同单据ID    NVARCHAR2(132)

        /// <summary>
        ///  //协同单据分录ID    NVARCHAR2(132)
        /// </summary>
        public string FNETORDERBILLENTRYID;      //协同单据分录ID    NVARCHAR2(132)

        /// <summary>
        /// //四方结算    NUMBER(22)
        /// </summary>
        public int FISSQUAREBALANCE;      //四方结算    NUMBER(22)

        /// <summary>
        /// //项目号    VARCHAR2(44)
        /// </summary>
        public string FPROJECTID;      //项目号    VARCHAR2(44)

        /// <summary>
        /// //跟踪号    VARCHAR2(44)
        /// </summary>
        public string FTRACKNUMBERID;      //跟踪号    VARCHAR2(44)

        /// <summary>
        /// //合同号    VARCHAR2(255)
        /// </summary>
        public string FCONTRACTNUMBER;      //合同号    VARCHAR2(255)

        /// <summary>
        /// //供应商    VARCHAR2(44)
        /// </summary>
        public string FSUPPLIERID;      //供应商    VARCHAR2(44)

        /// <summary>
        /// //单价    NUMBER(22)
        /// </summary>
        public decimal FSALEPRICE;      //单价    NUMBER(22)

        /// <summary>
        /// //折扣方式    NUMBER(22)
        /// </summary>
        public int FDISCOUNTTYPE;      //折扣方式    NUMBER(22)

        /// <summary>
        /// //折扣额    NUMBER(22)
        /// </summary>
        public decimal FDISCOUNTAMOUNT;      //折扣额    NUMBER(22)

        /// <summary>
        /// //单位折扣率    NUMBER(22)
        /// </summary>
        public decimal FDISCOUNT;      //单位折扣率    NUMBER(22)

        /// <summary>
        /// //未结算数量    NUMBER(22)
        /// </summary>
        public decimal FUNSETTLEQTY;      //未结算数量    NUMBER(22)

        /// <summary>
        /// //未结算基本数量    NUMBER(22)
        /// </summary>
        public decimal FUNSETTLEBASEQTY;      //未结算基本数量    NUMBER(22)

        /// <summary>
        /// /本次结算记录ID    VARCHAR2(44)
        /// </summary>
        public string FCURSETTLEBILLID;      //本次结算记录ID    VARCHAR2(44)

        /// <summary>
        /// //本次结算记录分录ID    VARCHAR2(44)
        /// </summary>
        public string FCURSETTLEBILLENTRYID;      //本次结算记录分录ID    VARCHAR2(44)


        /// <summary>
        /// ///本次结算数量    NUMBER(22)
        /// </summary>
        public decimal FCURSETTLEQTY;      //本次结算数量    NUMBER(22)

        /// <summary>
        /// //累计结算数量    NUMBER(22)
        /// </summary>
        public decimal FTOTALSETTLEQTY;      //累计结算数量    NUMBER(22)

        /// <summary>
        ///  //协同单据类型    VARCHAR2(44)
        /// </summary>
        public string FB2CBILLTYPE;      //协同单据类型    VARCHAR2(44)


        /// <summary>
        /// //业务日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;      //业务日期    TIMESTAMP(6)(11)


        /// <summary>
        /// //是否完全核销    NUMBER(22)
        /// </summary>
        public string FISFULLWRITEOFF;      //是否完全核销    NUMBER(22)

    }
}