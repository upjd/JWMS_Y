using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OrderServices
{
    /// <summary>
    /// WMS 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WMS : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetBatchRunno(string batchNo, string keys)
        {
            return "Hello World";
        }


        [WebMethod]
        public string GetProductDetail1(string batchNo, string keys)
        {
            return "";
        }

        [WebMethod]
        public string GetProductDetail2(string ckNo, string keys)
        {
            return "";
        }

        [WebMethod]
        public int IsExists(string ckno, string keys)
        {
            return 1;
        }
    }
}
