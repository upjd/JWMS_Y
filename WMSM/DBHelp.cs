using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace WMSM
{
    public class DBHelp
    {
        public static string wmsConnStr;

        /// <summary>
        /// 得到一个SqlDataReader
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static SqlDataReader GetSqlDataReader(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                SqlConnection sqlConn = new SqlConnection(wmsConnStr);
                if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                dr = new SqlCommand(sql, sqlConn).ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return dr;
        }

        /// <summary>
        /// 得到一个SqlDataReader
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sqlParsmeters">输入参数数组</param>
        /// <returns></returns>
        public static SqlDataReader GetSqlDataReader(string sql, Dictionary<string, object> sqlParsmeters)
        {
            SqlDataReader dr = null;
            try
            {
                SqlConnection sqlConn = new SqlConnection(wmsConnStr);
                SqlCommand comm = new SqlCommand(sql, sqlConn);
                comm.Parameters.Clear();
                foreach (string item in sqlParsmeters.Keys)
                {
                    comm.Parameters.AddWithValue(item, sqlParsmeters[item]);
                }
                if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return dr;
        }

        /// <summary>
        /// 得到一个DataSet结果集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            DataSet ds;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(wmsConnStr))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(sql, sqlConn)))
                    {
                        if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                        da.Fill((ds = new DataSet("ds")));
                    };
                };
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return ds;
        }

        /// <summary>
        /// 得到一个DataSet结果集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sqlParsmeters">输入参数数组</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, Dictionary<string, object> sqlParsmeters)
        {
            DataSet ds;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(wmsConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(sql, sqlConn))
                    {
                        foreach (string item in sqlParsmeters.Keys)
                        {
                            comm.Parameters.AddWithValue(item, sqlParsmeters[item]);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(comm))
                        {
                            if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                            da.Fill((ds = new DataSet("ds")));
                        };
                    };
                };
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return ds;
        }

        /// <summary>
        /// 得到一个DataTable结果集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(wmsConnStr))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(sql, sqlConn)))
                    {
                        if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                        da.Fill((dt = new DataTable("dt")));
                    };
                };
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return dt;
        }

        /// <summary>
        /// 得到一个DataTable结果集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sqlParsmeters">输入参数数组</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, Dictionary<string, object> sqlParsmeters)
        {
            DataTable dt;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(wmsConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(sql, sqlConn))
                    {
                        foreach (string item in sqlParsmeters.Keys)
                        {
                            comm.Parameters.AddWithValue(item, sqlParsmeters[item]);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(comm))
                        {
                            if (sqlConn.State == System.Data.ConnectionState.Closed) sqlConn.Open();
                            da.Fill((dt = new DataTable("dt")));
                        };
                    };
                };
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return dt;
        }

        /// <summary>
        /// 输入一字符串返回该字符串的MD值
        /// </summary>
        /// <param name="sDataIn">输入要加密的字符串</param>
        /// <returns>返回:MD5加密后的文件</returns>
        public static string GetMd5Hash(String sDataIn)
        {
            //加盐  "@abc*i"
            sDataIn = sDataIn + "@abc*i";
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
            return sTemp.ToLower();
        }

        /// <summary>
        /// 事务执行
        /// </summary>
        /// <param name="sqlPar">sql语句和参数的集合</param>
        /// <returns></returns>
        public static bool SqlTran(Dictionary<string, SqlParameter[]> sqlPar)
        {
            SqlTransaction tran = null;
            bool isOK = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(wmsConnStr))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();
                        tran = conn.BeginTransaction();
                        comm.Transaction = tran;
                        foreach (string sql in sqlPar.Keys)
                        {
                            comm.CommandText += sql;
                            foreach (SqlParameter par in sqlPar[sql])
                            {
                                comm.Parameters.Add(par);
                            }
                        }
                        if (comm.ExecuteNonQuery() == sqlPar.Keys.Count)
                        {
                            tran.Commit();
                            isOK = true;
                        }
                        else tran.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                if (tran != null) tran.Rollback();
                throw new Exception(ex.Message);
            }
            return isOK;
        }

        /// <summary>
        /// 执行一段没有返回值的数据库
        /// </summary>
        /// <param name="sql"></param>
        public static void ExecuteNonQuery(string sql) 
        {
            try 
            {
                using(SqlConnection conn = new SqlConnection(wmsConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(sql, conn))
                     {
                         conn.Open();
                         comm.ExecuteNonQuery();
                     }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
