using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 领料出库子表
    /// </summary>
    public class MaterialReqBillEntry
    {
        /// <summary>
        /// ID
        /// </summary>
        public string FID;        //ID
        /// <summary>
        /// 单据分录序列号
        /// </summary>
        public int FSEQ;        //单据分录序列号
        /// <summary>
        /// 源单据Id
        /// </summary>
        public string FSOURCEBILLID;        //源单据Id
        /// <summary>
        /// 来源单据编号
        /// </summary>
        public string FSOURCEBILLNUMBER;        //来源单据编号
        /// <summary>
        /// 来源单据分录的Id
        /// </summary>
        public string FSOURCEBILLENTRYID;        //来源单据分录的Id
        /// <summary>
        /// 来源单据分录序号
        /// </summary>
        public int FSOURCEBILLENTRYSEQ;        //来源单据分录序号

        /// <summary>
        /// 辅助计量单位换算系数
        /// </summary>
        public decimal FASSCOEFFICIENT;        //辅助计量单位换算系数

        /// <summary>
        /// 基本状态
        /// </summary>
        public int FBASESTATUS;        //基本状态
        /// <summary>
        /// 未关联数量
        /// </summary>
        public decimal FASSOCIATEQTY;        //未关联数量
        /// <summary>
        /// 来源单据类型
        /// </summary>
        public string FSOURCEBILLTYPEID;        //来源单据类型

        /// <summary>
        /// 物料
        /// </summary>
        public string FMATERIALID;        //物料
        /// <summary>
        /// 计量单位
        /// </summary>
        public string FUNITID;        //计量单位

        /// <summary>
        /// 基本计量单位
        /// </summary>
        public string FBASEUNITID;        //基本计量单位

        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;        //库存组织

        /// <summary>
        /// 财务组织
        /// </summary>
        public string FCOMPANYORGUNITID;        //财务组织


        /// <summary>
        /// 仓库
        /// </summary>
        public string FWAREHOUSEID;        //仓库

        /// <summary>
        /// 库位
        /// </summary>
        public string FLOCATIONID;        //库位

        /// <summary>
        /// 批次
        /// </summary>
        public string FLOT;        //批次


        /// <summary>
        /// 数量
        /// </summary>
        public decimal FQTY;        //数量
        /// <summary>
        /// 辅助数量
        /// </summary>
        public decimal FASSISTQTY;        //辅助数量

        /// <summary>
        /// /基本单位数量
        /// </summary>
        public decimal FBASEQTY;        //基本单位数量

        /// <summary>
        /// 冲销数量
        /// </summary>
        public decimal FREVERSEQTY;        //冲销数量

        /// <summary>
        /// 退货数量
        /// </summary>
        public decimal FRETURNSQTY;        //退货数量

        /// <summary>
        /// 单价
        /// </summary>
        public decimal FPRICE;        //单价

        /// <summary>
        /// 金额
        /// </summary>
        public decimal FAMOUNT;        //金额

        /// <summary>
        /// 单位标准成本
        /// </summary>
        public decimal FUNITSTANDARDCOST;        //单位标准成本

        /// <summary>
        /// 标准成本
        /// </summary>
        public decimal FSTANDARDCOST;        //标准成本

        /// <summary>
        /// 单位实际成本
        /// </summary>
        public decimal FUNITACTUALCOST;        //单位实际成本

        /// <summary>
        /// /实际成本
        /// </summary>
        public decimal FACTUALCOST;        //实际成本

        /// <summary>
        /// 是否赠品
        /// </summary>
        public int FISPRESENT;        //是否赠品

        /// <summary>
        /// 领料出库单头
        /// </summary>
        public string FPARENTID;        //领料出库单头
        /// <summary>
        /// 产品编码
        /// </summary>
        public string FPRODUCTIDID;        //产品编码

        /// <summary>
        /// 生产订单单号
        /// </summary>
        public string FORDERNUMBER;        //生产订单单号

        /// <summary>
        /// 生产订单分录号
        /// </summary>
        public string FPOBILLENTRYID;        //生产订单分录号
        /// <summary>
        /// 到期日期
        /// </summary>
        public DateTime FEXP;        //到期日期
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime FMFG;        //生产日期

        /// <summary>
        /// 冲销基本数量
        /// </summary>
        public decimal FREVERSEBASEQTY;        //冲销基本数量

        /// <summary>
        /// 退货基本数量
        /// </summary>
        public decimal FRETURNBASEQTY;        //退货基本数量

        /// <summary>
        /// 0
        /// </summary>
        public decimal FBASEUNITACTUALCOST;        //

        /// <summary>
        /// 成本对象
        /// </summary>
        public string FCOSTOBJECTID;        //成本对象


        /// <summary>
        /// /可退货基本数量
        /// </summary>
        public decimal FUNRETURNEDBASEQTY;        //可退货基本数量

        /// <summary>
        /// /生产订单id
        /// </summary>
        public string FORDERBILLID;        //生产订单id

        /// <summary>
        /// /生产线
        /// </summary>
        public string FPRODUCTLINEID;        //生产线

        /// <summary>
        /// 应发数量
        /// </summary>
        public decimal FISSUEQTY;        //应发数量

        /// <summary>
        /// 应发基本数量
        /// </summary>
        public decimal FBASEISSUEQTY;        //应发基本数量


        /// <summary>
        /// 领料工序
        /// </summary>
        public string FPRODUCTLINEWPID;        //领料工序


        /// <summary>
        /// 累计关联数量
        /// </summary>
        public decimal FFACARDQTY;        //累计关联数量

        /// <summary>
        /// 委外已核销数量
        /// </summary>
        public decimal FSUBWRITTENOFFQTY;        //委外已核销数量

        /// <summary>
        /// 委外已核销基本数量
        /// </summary>
        public decimal FSUBWRITTENOFFBASEQTY;        //委外已核销基本数量

        /// <summary>
        /// 委外未核销数量
        /// </summary>
        public decimal FSUBUNWRITEOFFQTY;        //委外未核销数量

        /// <summary>
        /// 委外未核销基本数量
        /// </summary>
        public decimal FSUBUNWRITEOFFBASEQTY;        //委外未核销基本数量


        /// <summary>
        /// 核心单据类型
        /// </summary>
        public string FCOREBILLTYPEID;        //核心单据类型

        /// <summary>
        /// coreOrderEntrySeq  0
        /// </summary>
        public int FCOREORDERENTRYSEQ;        //coreOrderEntrySeq

        /// <summary>
        /// 核心单据编号
        /// </summary>
        public string FCOREBILLNUMBER;        //核心单据编号

        /// <summary>
        /// 核心单据ID
        /// </summary>
        public string FCOREBILLID;        //核心单据ID


        /// <summary>
        /// 核心单据分录ID
        /// </summary>
        public string FCOREBILLENTRYID;        //核心单据分录ID

        /// <summary>
        /// 核心单据分录序列号
        /// </summary>
        public int FCOREBILLENTRYSE;        //核心单据分录序列号

        /// <summary>
        /// 工序号
        /// </summary>
        public int FOPERATIONNO;        //工序号

        /// <summary>
        /// 分配标志
        /// </summary>
        public int  FISADMEASURE;        //分配标志
        /// <summary>
        /// 返工
        /// </summary>
        public int FISREWORK;        //返工


        /// <summary>
        /// 已核销金额
        /// </summary>
        public decimal FSCWRITTENOFFAMOUNT;        //已核销金额
        /// <summary>
        /// 未核销金额
        /// </summary>
        public decimal FSCUNWRITTENOFFAMOUNT;        //未核销金额
        /// <summary>
        /// 供方仓库
        /// </summary>
        public string FSUPPLYWAREHOUSEID;        //供方仓库

        /// <summary>
        /// 结算价
        /// </summary>
        public decimal FSETTLEPRICE;        //结算价

        /// <summary>
        /// 业务日期
        /// </summary>
        public DateTime FBIZDATE;        
        
        

        /// <summary>
        /// 
        /// </summary>
        public string FADMINORGUNITID;        

        /// <summary>
        /// riQAAAAAAh/M567U
        /// </summary>
        public string FCOSTCENTERORGUNITID;         


    }
}