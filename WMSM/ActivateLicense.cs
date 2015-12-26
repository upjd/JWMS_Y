using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WMSM
{
    public partial class ActivateLicense : Form
    {
        public ActivateLicense()
        {
            InitializeComponent();
        }
        string number = "", code = "";
        private void btnChannel_Click(object sender, EventArgs e)
        {
            this.btnActivate.Enabled = false;
            if (ofdFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                try
                {
                    if (string.IsNullOrEmpty(ofdFile.FileName)) return;
                    this.txtFilePath.Text = ofdFile.FileName;
                    ReadXmlFile(ofdFile.FileName, ref number, ref code);
                    if (Convert.ToInt32(number) == Convert.ToInt32(GetDecryptedValue(code)))
                    {
                        this.txtActionInfo.Text = "\n许可信息正确！，请点击“激活”按钮激活。";
                        this.btnActivate.Enabled = true;
                    }
                    else this.txtActionInfo.Text += "\n许可信息有误，无法激活\t\t" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                }
                catch (Exception ex)
                {
                    this.txtActionInfo.Text += "\n许可信息有误，无法激活"+ex.Message+"\t\t" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                }
            }
        }

        /// <summary>
        /// 激活许可
        /// </summary>
        /// <param name="numbelr"></param>
        /// <param name="code"></param>
        private void Activation(string numbelr, string code)
        {
            Dictionary<string, SqlParameter[]> pars = new Dictionary<string, SqlParameter[]>();
            pars.Add("update BOnlineLicense set oEnabled = '0' where oEnabled = '1';", new SqlParameter[] { });
            pars.Add("insert into BOnlineLicense(oNumber,oCode,oActivationTime,oEnabled) values(@oNumber,@oCode,GETDATE(),'1');",
                new SqlParameter[] { new SqlParameter("@oNumber", numbelr), new SqlParameter("@oCode", code) });
            DBHelp.wmsConnStr = MaLogin.WmsCon;
            if (DBHelp.SqlTran(pars))
            {
                MessageBox.Show(@"激活成功！", @"提示");
                this.Close();
            }
            else MessageBox.Show(@"激活失败!", @"提示");
        }


        /// <summary>
        /// 读取xml文件
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="number"></param>
        /// <param name="code"></param>
        private void ReadXmlFile(string filepath, ref string number, ref string code)
        {
            XmlTextReader reader = new XmlTextReader(filepath);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "Number") number = reader.ReadElementString().Trim();
                    if (reader.Name == "Code") code = reader.ReadElementString().Trim();
                }
            }

        }

        /// <summary>
        /// 解析在线许可编号（解密字符）
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        private string GetDecryptedValue(string inputValue)
        {
            var provider = new TripleDESCryptoServiceProvider
            {
                IV = Convert.FromBase64String("SuFjcEmp/TE="),
                Key = Convert.FromBase64String("KIPSToILGp6fl+3gXJvMsN4IajizYBBT")
            };
            byte[] inputEquivalent = Convert.FromBase64String(inputValue);
            // 创建内存流保存解密后的数据
            MemoryStream msDecrypt = new MemoryStream();
            // 创建转换流。
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
            provider.CreateDecryptor(),
            CryptoStreamMode.Write);
            csDecrypt.Write(inputEquivalent, 0, inputEquivalent.Length);
            csDecrypt.FlushFinalBlock();
            csDecrypt.Close();
            //获取字符串。
            return new UTF8Encoding().GetString(msDecrypt.ToArray());
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            Activation(number, code);
        }
    }
}
