using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 采购收货单子表
    /// </summary>
    public class PurReceivalEntry
    {
        /// <summary>
        /// ID
        /// </summary>
        public string FID;      //ID

        /// <summary>
        /// 单据分录序列号
        /// </summary>
        public int FSEQ;      //单据分录序列号

        /// <summary>
        /// 源单据Id
        /// </summary>
        public string FSOURCEBILLID;      //源单据Id


        /// <summary>
        /// 来源单据编号
        /// </summary>
        public string FSOURCEBILLNUMBER;      //来源单据编号

        /// <summary>
        /// 来源单据类型
        /// </summary>
        public string FSOURCEBILLTYPEID;      //来源单据类型
        /// <summary>
        /// 来源单据分录的Id
        /// </summary>
        public string FSOURCEBILLENTRYID;      //来源单据分录的Id

        /// <summary>
        /// 来源单据分录序号
        /// </summary>
        public int FSOURCEBILLENTRYSEQ;      //来源单据分录序号

        /// <summary>
        /// 辅助计量单位换算系数
        /// </summary>
        public int FASSCOEFFICIENT;      //辅助计量单位换算系数

        /// <summary>
        /// 基本状态 2
        /// </summary>
        public int FBASESTATUS;      //基本状态

        /// <summary>
        /// 物料
        /// </summary>
        public string FMATERIALID;      //物料

        /// <summary>
        /// 计量单位
        /// </summary>
        public string FUNITID;      //计量单位

        /// <summary>
        /// 基本计量单位
        /// </summary>
        public string FBASEUNITID;      //基本计量单位

        /// <summary>
        /// 未关联数量
        /// </summary>
        public decimal FASSOCIATEQTY;      //未关联数量

        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;      //库存组织

        /// <summary>
        /// 财务组织
        /// </summary>
        public string FCOMPANYORGUNITID;      //财务组织
        /// <summary>
        /// 仓库
        /// </summary>
        public string FWAREHOUSEID;      //仓库

        /// <summary>
        /// 数量
        /// </summary>
        public decimal FQTY;      //数量

        /// <summary>
        /// 批次
        /// </summary>
        public string FLOT;
        /// <summary>
        /// 辅助数量
        /// </summary>
        public decimal FASSISTQTY;      //辅助数量

        /// <summary>
        /// 基本单位数量
        /// </summary>
        public decimal FBASEQTY;      //基本单位数量


        /// <summary>
        /// 冲销数量
        /// </summary>
        public decimal FREVERSEQTY;      //冲销数量


        /// <summary>
        /// /退货数量
        /// </summary>
        public decimal FRETURNSQTY;      //退货数量


        /// <summary>
        /// 单价
        /// </summary>
        public decimal FPRICE;      //单价


        /// <summary>
        /// 金额
        /// </summary>
        public decimal FAMOUNT;      //金额

        /// <summary>
        /// /单位标准成本
        /// </summary>
        public decimal FUNITSTANDARDCOST;      //单位标准成本

        /// <summary>
        /// 标准成本
        /// </summary>
        public decimal FSTANDARDCOST;      //标准成本

        /// <summary>
        /// 单位实际成本
        /// </summary>
        public decimal FUNITACTUALCOST;      //单位实际成本

        /// <summary>
        /// 实际成本
        /// </summary>
        public decimal FACTUALCOST;      //实际成本
        /// <summary>
        /// 是否赠品
        /// </summary>
        public int FISPRESENT;      //是否赠品
        /// <summary>
        /// 采购收货单头
        /// </summary>
        public string FPARENTID;      //采购收货单头

        /// <summary>
        /// 采购订单
        /// </summary>
        public string FPURORDERID;      //采购订单

        /// <summary>
        /// 采购订单行
        /// </summary>
        public string FPURORDERENTRYID;      //采购订单行

        /// <summary>
        /// 累计入库数量
        /// </summary>
        public int FRECEIPTQTY;      //累计入库数量

        /// <summary>
        /// 采购订单号
        /// </summary>
        public string FPURORDERNUM;      //采购订单号

        /// <summary>
        /// 采购订单行行号
        /// </summary>
        public int FPURORDERENTRYSEQ;      //采购订单行行号

        /// <summary>
        /// 采购订单行行号
        /// </summary>
        public int FREVERSEBASEQTY;      //冲销基本数量

        /// <summary>
        /// 累计入库基本数量
        /// </summary>
        public int FRECEIPTBASEQTY;      //累计入库基本数量


        /// <summary>
        /// 退货基本数量
        /// </summary>
        public int FRETURNBASEQTY;      //退货基本数量


        /// <summary>
        /// 订单单价
        /// </summary>
        public decimal FORDERPRICE;      //订单单价

        /// <summary>
        /// 含税单价
        /// </summary>
        public decimal FTAXPRICE;      //含税单价


        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal FACTUALPRICE;      //实际单价

        /// <summary>
        /// /申请财务组织是否等于收货财务组织
        /// </summary>
        public int FISREQUESTTORECEIVED;      //申请财务组织是否等于收货财务组织
        
        
        /// <summary>
        /// 合格数量
        /// </summary>
        public int FQUALIFIEDQTY;      //合格数量

        /// <summary>
        /// 不合格数量
        /// </summary>
        public int FUNQUALIFIEDQTY;      //不合格数量

        /// <summary>
        /// 让步接收数量
        /// </summary>
        public int FCONCESSIVERECQTY;      //让步接收数量


        /// <summary>
        /// 合格基本数量
        /// </summary>
        public int FQUALIFIEDBASEQTY;      //合格基本数量


        /// <summary>
        /// 不合格基本数量
        /// </summary>
        public int FUNQUALIFIEDBASEQTY;      //不合格基本数量

        /// <summary>
        /// /让步接收基本数量
        /// </summary>
        public int FCONCESSIVERECBASEQTY;      //让步接收基本数量


        /// <summary>
        /// 行类型
        /// </summary>
        public string FBILLROWTYPEID;      //行类型

        /// <summary>
        /// 物料名称
        /// </summary>
        public string FNONUMMATERIALNAME;      //物料名称
        /// <summary>
        /// 已转卡片数量
        /// </summary>
        public int FTOFIXASSETSQTY;      //已转卡片数量


        /// <summary>
        /// 末转卡片数量
        /// </summary>
        public int FUNTOFIXASSETSQTY;      //末转卡片数量

        /// <summary>
        /// 核心单据ID
        /// </summary>
        public string FCOREBILLID;      //核心单据ID


        /// <summary>
        /// 核心单据分录ID
        /// </summary>
        public string FCOREBILLENTRYID;      //核心单据分录ID


        /// <summary>
        /// 退回数量
        /// </summary>
        public int FCHECKRETURNEDQTY;      //退回数量

        /// <summary>
        /// 退回基本数量
        /// </summary>
        public int FCHECKRETURNEDBASEQTY;      //退回基本数量

        /// <summary>
        /// 采购组织
        /// </summary>
        public string FPURCHASEORGUNITID;      //采购组织

        /// <summary>
        /// 质检组织
        /// </summary>
        public string FQUALITYORGUNITID;      //质检组织

        /// <summary>
        /// 是否检验
        /// </summary>
        public int FISCHECK;      //是否检验


        /// <summary>
        /// 紧急放行
        /// </summary>
        public int FISURGENTPASS;      //紧急放行


        /// <summary>
        /// 送检数量
        /// </summary>
        public int FCHECKQTY;      //送检数量

        /// <summary>
        /// 未送检数量
        /// </summary>
        public decimal FUNCHECKQTY;      //未送检数量

        /// <summary>
        /// 送检基本数量
        /// </summary>
        public int FCHECKBASEQTY;      //送检基本数量

        /// <summary>
        /// 未送检基本数量
        /// </summary>
        public decimal FUNCHECKBASEQTY;      //未送检基本数量


        /// <summary>
        /// 采购合同行号
        /// </summary>
        public int FPURCONTRACTSEQ;      //采购合同行号

    }
}