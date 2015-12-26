using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SerialDebug
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 报单系统用加盐加密
        /// </summary>
        /// <param name="sDataIn"></param>
        /// <returns></returns>
        public static string GetMd5OrderService(String sDataIn)
        {
            //加盐  "@abc*i"
            sDataIn = sDataIn + "pvgi2eb8HD";
            //初始化System.Security.Cryptography.MD5CryptoServiceProvider的新实例
            var md5 = new MD5CryptoServiceProvider();
            //将String.String字符串中的字符编码为一个字节序列 返回byte[]
            var bytValue = Encoding.UTF8.GetBytes(sDataIn);
            //计算指定字节数组的Hash值 返回byte[]
            var bytHash = md5.ComputeHash(bytValue);
            //释放资源
            md5.Clear();
            var sTemp = "";
            for (var i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strOrder = string.Empty;
            string strHeader = string.Empty;
            string strBody = string.Empty;

            //var ckNo = "NBCK201501010062";
            var ckNo = textBox1.Text;
            var ckNoMd5 = GetMd5OrderService(ckNo);

            //var batchNo = "NB-2015-01-23-17";
            var batchNo = textBox2.Text;
            var batchMd5 = GetMd5OrderService(batchNo);
            //通过WebService获取报单系统数据
            var js = new OrderServices.WMS();

            DataTable dtHeader;
            DataTable dtBody;
            try
            {
                strOrder = js.GetProductDetail2(ckNo, ckNoMd5);
                //var straa = js.GetProductDetail1(batchNo, batchMd5);
                //var dtTemp = CXmlFileToDataSet(straa).Tables[0];
                //var iRow = dtTemp.Rows.Count;
                strHeader = strOrder.Substring(strOrder.IndexOf("<head>"), strOrder.IndexOf("</head>") - strOrder.IndexOf("<head>") + 7);
                strBody = strOrder.Remove(strOrder.IndexOf("<head>"), strOrder.IndexOf("</head>") - strOrder.IndexOf("<head>") + 7);
                var dtTempTemp = CXmlFileToDataSet(strBody).Tables[0];
                var iRow = dtTempTemp.Rows.Count;
                MessageBox.Show(iRow.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + strOrder, @"Warning");
                return;
            }
        }

        public static DataSet CXmlFileToDataSet(string xmlStr)
        {
            if (!string.IsNullOrEmpty(xmlStr) && !xmlStr.Equals("-1"))
            {

                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {


                    DataSet ds = new DataSet();
                    //读取文件中的字符流
                    StrStream = new StringReader(xmlStr);
                    //获取StrStream中的数据
                    Xmlrdr = new XmlTextReader(StrStream);
                    //ds获取Xmlrdr中的数据
                    ds.ReadXml(Xmlrdr);
                    return ds;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //释放资源
                    if (Xmlrdr != null)
                    {
                        Xmlrdr.Close();
                        StrStream.Close();
                        StrStream.Dispose();
                    }
                }
            }
            return null;
        }

    }
}
