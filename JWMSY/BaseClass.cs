using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace JWMSY
{
    /// <summary>
    /// 登录时获取的基础类
    /// </summary>
    internal class BaseClass
    {
        /// <summary>
        /// 在线编号
        /// </summary>
        public static string LonlineID;

        /// <summary>
        /// 判断是否登录成功
        /// </summary>
        /// <returns></returns>
        public static bool OkLogin(string uName, string uPassword)
        {
            
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd=new SqlCommand {Connection = con})
                {
                    cmd.CommandText = "select * from View_BUserRole where (cCode=@cCode or cName=@cCode) and cPwd=@cPwd";
                    cmd.Parameters.AddWithValue("@cCode", uName);
                    cmd.Parameters.AddWithValue("@cPwd", WmsFunction.GetMd5Hash(uPassword));
                    con.Open();
                    using (var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read()) //直接登陆
                        {

                            BaseStructure.LoginId = dr["cCode"].ToString(); //把登陆名和登陆服务器保存到静态变量中
                            BaseStructure.LoginName = dr["cName"].ToString();
                            BaseStructure.LoginRoleId = dr["rCode"].ToString();
                            BaseStructure.LoginRoleName = dr["rName"].ToString();
                            return true;
                        }
                        MessageBox.Show(@"用户名或密码错误，请联系管理员！", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                
            }
        }


        /// <summary>
        /// 判断在线状态是否正常
        /// </summary>
        /// <returns></returns>
        public bool BCanOnline()
        {
                using (var conn = new SqlConnection(BaseStructure.WmsCon))
                {
                    var sql =
                        "update BOnlineNumber set oUpdateTime = GETDATE() where uCode = @uCode and columns1=@onlineID";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uCode", BaseStructure.LoginId);
                        cmd.Parameters.AddWithValue("@onlineID", LonlineID);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
        }

        /// <summary>
        /// 退出清除登录信息
        /// </summary>
        public void DeleteOnline()
        {
            try
            {
                using (var conn = new SqlConnection(BaseStructure.WmsCon))
                {
                    var sql = "delete BOnlineNumber where uCode = @uCode";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uCode", BaseStructure.LoginId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        /// <summary>
        /// 判断是否已经超过在线人数
        /// </summary>
        /// <returns></returns>
        public bool CheckOnlineNumber()
        {
            var isok = false;
            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                SqlParameter count;
                SqlParameter allcount;
                SqlParameter oCode;
                using (var cmd = new SqlCommand
                {
                    Connection = con, CommandType = CommandType.StoredProcedure, CommandText = "CheckOnlineNumber"
                })
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@uCode", BaseStructure.LoginId);
                    count = cmd.Parameters.Add("@count", SqlDbType.Int);
                    count.Direction = ParameterDirection.Output;
                    allcount = cmd.Parameters.Add("@allcount", SqlDbType.Int);
                    allcount.Direction = ParameterDirection.Output;
                    oCode = cmd.Parameters.Add("@oCode", SqlDbType.VarChar, 200);
                    oCode.Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                var number = Convert.ToInt32(GetDecryptedValue(oCode.Value.ToString()));

                if (number <= Convert.ToInt32(allcount.Value)) MessageBox.Show("在线使用人数已满！", "提示");
                else if (Convert.ToInt32(count.Value) > 0)
                {
                    var ok = MessageBox.Show(@"该用户已登录！
是否继续登录？", @"提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (ok == DialogResult.OK)
                    {
                        if ((isok = UpdateOnlineNumber()) == false) MessageBox.Show("登录失败,请重新登录！", "提示");
                    }
                }
                else
                {
                    if ((isok = AddOnlineNumber()) == false) MessageBox.Show("登录失败,请重新登录！", "提示");
                }
            }
            return isok;
        }


        /// <summary>
        /// 添加在线纪录
        /// </summary>
        /// <returns></returns>
        private bool AddOnlineNumber()
        {
            var isok = false;
            try
            {
                using (var con = new SqlConnection(BaseStructure.WmsCon))
                {
                    string sql = "insert into BOnlineNumber(uCode,oUpdateTime,columns1) values(@uCode , GETDATE(),@onlineID)";
                    var cmd = new SqlCommand
                    {
                        Connection = con,
                        CommandText = sql
                    };
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@uCode", BaseStructure.LoginId);
                    cmd.Parameters.AddWithValue("@onlineID", LonlineID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0) isok = true;
                };

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return isok;
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



        // <summary>
        /// 跟新用户在线编号
        /// </summary>
        /// <returns></returns>
        private bool UpdateOnlineNumber()
        {
            bool isok = false;
            try
            {
                using (var con = new SqlConnection(BaseStructure.WmsCon))
                {
                    string sql = "update BOnlineNumber set oUpdateTime=GETDATE(),columns1=@onlineID where uCode = @uCode ";
                    var cmd = new SqlCommand
                    {
                        Connection = con,
                        CommandText = sql
                    };
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@uCode", BaseStructure.LoginId);
                    cmd.Parameters.AddWithValue("@onlineID", LonlineID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0) isok = true;
                };

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return isok;
        }
    }

}
