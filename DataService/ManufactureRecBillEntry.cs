using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataService
{
    /// <summary>
    /// 生产入库子表
    /// </summary>
    public class ManufactureRecBillEntry
    {
        /// <summary>
        /// ID
        /// </summary>
        public string FID;//ID
        /// <summary>
        /// 单据分录序列号
        /// </summary>
        public int FSEQ;//单据分录序列号
        /// <summary>
        /// 源单据Id
        /// </summary>
        public string FSOURCEBILLID;//源单据Id
        /// <summary>
        /// 来源单据编号
        /// </summary>
        public string FSOURCEBILLNUMBER;//来源单据编号
        /// <summary>
        /// 来源单据分录的Id
        /// </summary>
        public string FSOURCEBILLENTRYID;//来源单据分录的Id
        /// <summary>
        /// 来源单据分录序号
        /// </summary>
        public int FSOURCEBILLENTRYSEQ;//来源单据分录序号
        /// <summary>
        /// 辅助计量单位换算系数 0
        /// </summary>
        public decimal FASSCOEFFICIENT;//辅助计量单位换算系数
        /// <summary>
        /// 基本状态
        /// </summary>
        public int FBASESTATUS;//基本状态
        /// <summary>
        /// 未关联数量
        /// </summary>
        public decimal FASSOCIATEQTY;//未关联数量
        /// <summary>
        /// 来源单据类型
        /// </summary>
        public string FSOURCEBILLTYPEID;//来源单据类型
        /// <summary>
        /// 物料
        /// </summary>
        public string FMATERIALID;//物料
        /// <summary>
        /// 计量单位
        /// </summary>
        public string FUNITID;//计量单位
        /// <summary>
        /// 基本计量单位
        /// </summary>
        public string FBASEUNITID;//基本计量单位
        /// <summary>
        /// 库存组织
        /// </summary>
        public string FSTORAGEORGUNITID;//库存组织
        /// <summary>
        /// 财务组织
        /// </summary>
        public string FCOMPANYORGUNITID;//财务组织
        /// <summary>
        /// 仓库
        /// </summary>
        public string FWAREHOUSEID;//仓库
        /// <summary>
        /// 批次
        /// </summary>
        public string FLOT;//批次
        /// <summary>
        /// 数量
        /// </summary>
        public decimal FQTY;//数量
        /// <summary>
        /// 辅助数量
        /// </summary>
        public decimal FASSISTQTY;//辅助数量
        /// <summary>
        /// 基本单位数量
        /// </summary>
        public decimal FBASEQTY;//基本单位数量
        /// <summary>
        /// 冲销数量
        /// </summary>
        public decimal FREVERSEQTY;//冲销数量
        /// <summary>
        /// 退货数量
        /// </summary>
        public decimal FRETURNSQTY;//退货数量
        /// <summary>
        /// 单价
        /// </summary>
        public decimal FPRICE;//单价
        /// <summary>
        /// 金额
        /// </summary>
        public decimal FAMOUNT;//金额
        /// <summary>
        /// 单位标准成本
        /// </summary>
        public decimal FUNITSTANDARDCOST;//单位标准成本

        /// <summary>
        /// 标准成本
        /// </summary>
        public decimal FSTANDARDCOST;//标准成本

        /// <summary>
        /// /单位实际成本
        /// </summary>
        public decimal FUNITACTUALCOST;//单位实际成本


        /// <summary>
        /// 实际成本
        /// </summary>
        public decimal FACTUALCOST;//实际成本
        /// <summary>
        /// 是否赠品
        /// </summary>
        public int FISPRESENT;//是否赠品
        /// <summary>
        /// 生产入库单头
        /// </summary>
        public string FPARENTID;//生产入库单头
        /// <summary>
        /// 生产订单ID
        /// </summary>
        public string FMANUBILLID;//生产订单ID
        /// <summary>
        /// 冲销基本数量
        /// </summary>
        public decimal FREVERSEBASEQTY;//冲销基本数量
        /// <summary>
        /// 退货基本数量
        /// </summary>
        public decimal FRETURNBASEQTY;//退货基本数量

        /// <summary>
        /// 成本对象
        /// </summary>
        public string FCOSTOBJECTID;//成本对象

        /// <summary>
        /// 接受数量
        /// </summary>
        public decimal FRECQTY;//接受数量

        /// <summary>
        /// 接收基本数量
        /// </summary>
        public decimal FBASERECQTY;//接收基本数量

        /// <summary>
        /// 生产订单单号
        /// </summary>
        public string FMANUBILLNUMBER;//生产订单单号

        /// <summary>
        /// 应收数量
        /// </summary>
        public decimal FRECEIVEQTY;//应收数量

        /// <summary>
        /// 生产订单行号
        /// </summary>
        public int FMANUBILLENTRYSEQ;//生产订单行号

        /// <summary>
        /// 销售订单行号
        /// </summary>
        public int FSALEORDERENTRYSEQ;//销售订单行号

        /// <summary>
        /// 业务日期
        /// </summary>
        public DateTime FBIZDATE;//

        /// <summary>
        /// 成本中心
        /// </summary>
        public string FCOSTCENTERORGUNITID;//
        /// <summary>
        /// 主制部门
        /// </summary>
        public string FADMINORGUNITID;//

    }
}