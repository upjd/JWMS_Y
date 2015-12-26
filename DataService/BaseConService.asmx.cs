using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace DataService
{
    /// <summary>
    /// BaseConService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.kingdee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class BaseConService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetWmsConstring()
        {
            return Properties.Settings.Default.WmsCon;
        }


        #region 软件更新

        [WebMethod(Description = "取得更新版本号")]
        public string GetVer()
        {
            var doc = new XmlDocument();
            doc.Load(Server.MapPath("update.xml"));
            var root = doc.DocumentElement;
            return root.SelectSingleNode("version").InnerText;
        }

        [WebMethod(Description = "在线更新软件")]
        public XmlDocument GetUpdateData()
        {
            //取xml模板内容
            var doc = new XmlDocument();
            doc.Load(Server.MapPath("update.xml"));
            var root = doc.DocumentElement;
            //有几个文件需要更新
            var updateNode = root.SelectSingleNode("filelist");
            var filePath = updateNode.Attributes["sourcepath"].Value;
            var count = int.Parse(updateNode.Attributes["count"].Value);
            //将xml中的value用实际内容替换
            for (var i = 0; i < count; i++)
            {
                var itemNode = updateNode.ChildNodes[i];
                var fileName = filePath + itemNode.Attributes["name"].Value;
                var fs = File.OpenRead(Server.MapPath(fileName));
                itemNode.Attributes["size"].Value = fs.Length.ToString();
                var br = new BinaryReader(fs);
                //写入文件，采用Base64String编码
                itemNode.SelectSingleNode("value").InnerText = Convert.ToBase64String(br.ReadBytes((int)fs.Length), 0, (int)fs.Length);
                br.Close();
                fs.Close();
            }
            return doc;
        }
        #endregion

        ///   <summary> 
        ///  上传文件
        ///   </summary> 
        [WebMethod(Description = " 下载文件 ", EnableSession = true)]
        public byte[] DownLoadFile(string fileName)
        {
            byte[] b;
            try
            {
                var fi = new FileInfo(Server.MapPath(string.Format(@"\\update\\{0}", fileName) ));
                b = new byte[fi.Length];
                var fs = fi.OpenRead();
                fs.Read(b, 0, Convert.ToInt32(fi.Length));
                fs.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return b;
        }
    }
}
