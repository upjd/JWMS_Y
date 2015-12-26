using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 调拨入库单子表
    /// </summary>
    public class MoveInWarehsBillEntry
    {

        /// <summary>
        /// 调拨入库主表
        /// </summary>
        public string FPARENTID;
        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;


        /// <summary>
        /// 财务组织
        /// </summary>
        public string FCOMPANYORGUNITID;


        /// <summary>
        /// 仓库
        /// </summary>
        public string FWAREHOUSEID;

        /// <summary>
        /// 数量 NUMBER(22)
        /// </summary>
        public decimal FQTY;

        /// <summary>
        /// 基本单位数量 NUMBER(22)
        /// </summary>
        public decimal FBASEQTY;

        /// <summary>
        /// 物料
        /// </summary>
        public string FMATERIALID;


        /// <summary>
        /// 基本计量单位
        /// </summary>
        public string FBASEUNITID;


        /// <summary>
        /// 单据分录序号 NUMBER(22)
        /// </summary>
        public int FSEQ;


        /// <summary>
        /// 单据内码
        /// </summary>
        public string FID;

        /// <summary>
        /// 单据类型
        /// </summary>
        public string FSTORETYPEID;


        /// <summary>
        /// 调拨单头
        /// </summary>
        public string FSTOCKTRANSFERBILLID;



        /// <summary>
        /// 调拨单分录ID
        /// </summary>
        public string FSTOCKTRANSBILLENTRYID;


        /// <summary>
        /// 调拨单号
        /// </summary>
        public string FSTOCKTRANSFERNUM;

        /// <summary>
        /// 调拨单序号 NUMBER(22)
        /// </summary>
        public int FSTOCKTRANSFERBILLENTRYSEQ;


        /// <summary>
        ///   NUMBER(22)
        /// </summary>
        public decimal FBASEUNITACTUALCOST;


        /// <summary>
        /// 客户 VARCHAR2(44)
        /// </summary>
        public string FCUSTOMERID;

        /// <summary>
        /// 供应商 VARCHAR2(44)
        /// </summary>
        public string FSUPPLIERID;


        /// <summary>
        /// 单价 NUMBER(22)
        /// </summary>
        public decimal FPRICE;

        /// <summary>
        /// 金额 NUMBER(22)
        /// </summary>
        public decimal FAMOUNT;



        /// <summary>
        /// 业务日期 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FBIZDATE;


        /// <summary>
        /// 库位 VARCHAR2(44)
        /// </summary>
        public string FLOCATIONID;



        /// <summary>
        /// 仓管员 VARCHAR2(44)
        /// </summary>
        public string FSTOCKERID;


        /// <summary>
        /// 批次 VARCHAR2(240)
        /// </summary>
        public string FLOT;



        /// <summary>
        /// 辅助数量(22)
        /// </summary>
        public decimal FASSISTQTY;


        /// <summary>
        /// 冲销数量 NUMBER(22)
        /// </summary>
        public decimal FREVERSEQTY;




        /// <summary>
        /// 退货数量 NUMBER(22)
        /// </summary>
        public decimal FRETURNSQTY;


        /// <summary>
        /// 单位标准成本 NUMBER(22)
        /// </summary>
        public decimal FUNITSTANDARDCOST;


        /// <summary>
        /// 标准成本 NUMBER(22)
        /// </summary>
        public decimal FSTANDARDCOST;




        /// <summary>
        /// 单位实际成本 NUMBER(22)
        /// </summary>
        public decimal FUNITACTUALCOST;


        /// <summary>
        /// 实际成本 NUMBER(22)
        /// </summary>
        public decimal FACTUALCOST;



        /// <summary>
        /// 是否赠品 NUMBER(22)
        /// </summary>
        public int FISPRESENT;



        /// <summary>
        /// 生产日期 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FMFG;

        /// <summary>
        /// 到期日期 TIMESTAMP(6)(11)
        /// </summary>
        public DateTime FEXP;
        /// <summary>
        /// 冲销基本数量 NUMBER(22)
        /// </summary>
        public decimal FREVERSEBASEQTY;



        /// <summary>
        /// 退货基本数量 NUMBER(22)
        /// </summary>
        public decimal FRETURNBASEQTY;





        /// <summary>
        /// 项目号 VARCHAR2(44)
        /// </summary>
        public string FPROJECTID;


        /// <summary>
        ///跟踪号 VARCHAR2(44)
        /// </summary>
        public string FTRACKNUMBERID;

        /// <summary>
        ///辅助属性 VARCHAR2(44)
        /// </summary>
        public string FASSISTPROPERTYID;



        /// <summary>
        ///计量单位 VARCHAR2(44)
        /// </summary>
        public string FUNITID;


        /// <summary>
        ///源单据Id VARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLID;



        /// <summary>
        ///来源单据编号 VARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLNUMBER;



        /// <summary>
        ///来源单据分录的Id VARCHAR2(240)
        /// </summary>
        public string FSOURCEBILLENTRYID;




        /// <summary>
        ///来源单据分录序号 NUMBER(22)
        /// </summary>
        public int FSOURCEBILLENTRYSEQ;


        /// <summary>
        ///辅助计量单位换算系数 NUMBER(22)
        /// </summary>
        public decimal FASSCOEFFICIENT;



        /// <summary>
        ///基本状态 NUMBER(22)
        /// </summary>
        public int FBASESTATUS;




        /// <summary>
        ///未关联数量 NUMBER(22)
        /// </summary>
        public decimal FASSOCIATEQTY;

        /// <summary>
        /// 来源单据类型    NUMBER(22)FSOURCEBILLTYPEID
        /// </summary>
        public string FSOURCEBILLTYPEID;      //未关联数量    NUMBER(22)

        
    }
}