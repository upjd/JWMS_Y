using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JWMSY
{
    /// <summary>
    /// WMS系统基础结构
    /// </summary>
    class BaseStructure
    {
        /// <summary>
        /// Wms系统连接字符串
        /// </summary>
        public static string WmsCon ;


        /// <summary>
        /// 登录ID
        /// </summary>
        public static string LoginId;

        /// <summary>
        /// 登录名
        /// </summary>
        public static string LoginName;

        /// <summary>
        /// 登录角色ID
        /// </summary>
        public static string LoginRoleId;


        /// <summary>
        /// 登录角色名
        /// </summary>
        public static string LoginRoleName;


        /// <summary>
        /// 登录角时间
        /// </summary>
        public static DateTime LoginDate;


        /// <summary>
        /// WmsWebService服务所在地址
        /// </summary>
        public static string WmsServiceUri;


        /// <summary>
        /// 报单系统WebService服务所在地址
        /// </summary>
        public static string OrderServiceUri;


        /// <summary>
        /// Wms服务器
        /// </summary>
        public static string WmsServer;
    }
}
