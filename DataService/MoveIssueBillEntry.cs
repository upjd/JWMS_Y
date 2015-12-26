using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    public class MoveIssueBillEntry
    {

        /// <summary>
        /// 调拨出库单头    VARCHAR2(44)
        /// </summary>
        public string FPARENTID;      //调拨出库单头    VARCHAR2(44)


        /// <summary>
        /// 库存类型    VARCHAR2(44)
        /// </summary>
        public string FSTORETYPEID;      //库存类型    VARCHAR2(44)

        /// <summary>
        /// 业务日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;      //业务日期    TIMESTAMP(6)(11)


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
        /// 数量    NUMBER(22)
        /// </summary>
        public decimal FQTY;      //数量    NUMBER(22)




        /// <summary>
        /// 基本单位数量    NUMBER(22)
        /// </summary>
        public decimal FBASEQTY;      //基本单位数量    NUMBER(22)


        /// <summary>
        /// 计量单位    VARCHAR2(44)
        /// </summary>
        public string FUNITID;      //计量单位    VARCHAR2(44)

        /// <summary>
        /// 基本计量单位    VARCHAR2(44)
        /// </summary>
        public string FBASEUNITID;      //基本计量单位    VARCHAR2(44)

        /// <summary>
        /// 单据分录序列号    NUMBER(22)
        /// </summary>
        public int FSEQ;      //单据分录序列号    NUMBER(22)

        /// <summary>
        /// 单据内码    VARCHAR2(44)
        /// </summary>
        public string FID;      //单据内码    VARCHAR2(44)

        /// <summary>
        /// 物料    VARCHAR2(44)
        /// </summary>
        public string FMATERIALID;      //物料    VARCHAR2(44)

        /// <summary>
        /// 调拨单头    VARCHAR2(44)
        /// </summary>
        public string FSTOCKTRANSFERBILLID;      //调拨单头    VARCHAR2(44)

        /// <summary>
        /// 调拨单分录    VARCHAR2(44)
        /// </summary>
        public string FSTOCKTRANSBILLENTRYID;      //调拨单分录    VARCHAR2(44)


        /// <summary>
        /// 调拨单单号    NVARCHAR2(240)
        /// </summary>
        public string FSTOCKTRANSFERBILLNUM;      //调拨单单号    NVARCHAR2(240)

        /// <summary>
        /// 调拨单行号    NUMBER(22)
        /// </summary>
        public int FSTOCKTRANSFERBILLENTRYSEQ;      //调拨单行号    NUMBER(22)

        /// <summary>
        /// 累计入库数量    NUMBER(22)
        /// </summary>
        public decimal FTOTALINWAREHSQTY;      //累计入库数量    NUMBER(22)

        /// <summary>
        /// 可入库基本数量    NUMBER(22)
        /// </summary>
        public decimal FCANINWAREHSBASEQTY;      //可入库基本数量    NUMBER(22)


        /// <summary>
        /// 基本单位实际成本    NUMBER(22)
        /// </summary>
        public decimal FBASEUNITACTUALCOST;      //基本单位实际成本    NUMBER(22)


        /// <summary>
        /// 客户    VARCHAR2(44)
        /// </summary>
        public string FCUSTOMERID;      //客户    VARCHAR2(44)


        /// <summary>
        /// 供应商    VARCHAR2(44)
        /// </summary>
        public string FSUPPLIERID;      //供应商    VARCHAR2(44)


        /// <summary>
        /// 单价    NUMBER(22)
        /// </summary>
        public decimal FPRICE;      //单价    NUMBER(22)

        /// <summary>
        /// 金额    NUMBER(22)
        /// </summary>
        public decimal FAMOUNT;      //金额    NUMBER(22)


        /// <summary>
        /// /库位    VARCHAR2(44)
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
        /// /辅助数量    NUMBER(22)
        /// </summary>
        public decimal FASSISTQTY;      //辅助数量    NUMBER(22)

        /// <summary>
        /// 冲销数量    NUMBER(22)
        /// </summary>
        public decimal FREVERSEQTY;      //冲销数量    NUMBER(22)

        /// <summary>
        /// 退货数量    NUMBER(22)
        /// </summary>
        public decimal FRETURNSQTY;      //退货数量    NUMBER(22)


        /// <summary>
        /// 单位标准成本    NUMBER(22)
        /// </summary>
        public decimal FUNITSTANDARDCOST;      //单位标准成本    NUMBER(22)


        /// <summary>
        /// 标准成本    NUMBER(22)
        /// </summary>
        public decimal FSTANDARDCOST;      //标准成本    NUMBER(22)


        /// <summary>
        /// 单位实际成本    NUMBER(22)
        /// </summary>
        public decimal FUNITACTUALCOST;      //单位实际成本    NUMBER(22)



        /// <summary>
        /// 实际成本    NUMBER(22)
        /// </summary>
        public decimal FACTUALCOST;      //实际成本    NUMBER(22)

        /// <summary>
        /// 是否赠品    NUMBER(22)
        /// </summary>
        public int FISPRESENT;      //是否赠品    NUMBER(22)


        /// <summary>
        /// 生产日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FMFG;      //生产日期    TIMESTAMP(6)(11)

        /// <summary>
        /// 到期日期    TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FEXP;      //到期日期    TIMESTAMP(6)(11)


        /// <summary>
        /// 冲销基本数量    NUMBER(22)
        /// </summary>
        public decimal FREVERSEBASEQTY;      //冲销基本数量    NUMBER(22)


        /// <summary>
        /// 退货基本数量    NUMBER(22)
        /// </summary>
        public decimal FRETURNBASEQTY;      //退货基本数量    NUMBER(22)

        /// <summary>
        /// 项目号    VARCHAR2(44)
        /// </summary>
        public string FPROJECTID;      //项目号    VARCHAR2(44)

        /// <summary>
        /// 跟踪号    VARCHAR2(44)
        /// </summary>
        public string FTRACKNUMBERID;      //跟踪号    VARCHAR2(44)


        /// <summary>
        /// 辅助属性    VARCHAR2(44)
        /// </summary>
        public string FASSISTPROPERTYID;      //辅助属性    VARCHAR2(44)


        /// <summary>
        /// 源单据Id    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLID;      //源单据Id    NVARCHAR2(240)


        /// <summary>
        /// 来源单据编号    NVARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLNUMBER;      //来源单据编号    NVARCHAR2(240)


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
        public decimal FASSCOEFFICIENT;      //辅助计量单位换算系数    NUMBER(22)

        /// <summary>
        /// 基本状态    NUMBER(22)
        /// </summary>
        public int FBASESTATUS;      //基本状态    NUMBER(22)

        /// <summary>
        /// 未关联数量    NUMBER(22)
        /// </summary>
        public decimal FASSOCIATEQTY;      //未关联数量    NUMBER(22)


        /// <summary>
        /// 来源单据类型    NUMBER(22)FSOURCEBILLTYPEID
        /// </summary>
        public string FSOURCEBILLTYPEID;      //未关联数量    NUMBER(22)

    }
}