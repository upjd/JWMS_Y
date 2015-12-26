using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SearchFilter;

namespace AutoSync
{
    class SyncFunction
    {
        /// BMS功能集合

        public string Constr;

        /// <summary>
        /// BMS功能信息构造函数，传入连接字符串
        /// </summary>
        /// <param name="str"></param>
        public SyncFunction(string str)
        {
            Constr = str;
        }



        /// <summary>
        /// 打印条码
        /// </summary>
        /// <param name="templet"></param>
        /// <param name="items"></param>
        /// <param name="count"></param>
        //public void CreateBarCode(string templet, Dictionary<string, string> items, int count)
        //{
        //    var btApp = new BarTender.Application();
        //    var btFormat = btApp.Formats.Open(templet, false, "");
        //    btFormat.PrintSetup.IdenticalCopiesOfLabel = count;
        //    foreach (string item in items.Keys)
        //    {
        //        btFormat.SetNamedSubStringValue(item, items[item]);
        //    }
        //    btFormat.PrintOut(false, false);
        //}


        /// <summary>
        /// 把SQl数据库里面的数据查询到Datagridview中
        /// </summary>
        /// <param name="str">参数Str:查询命令</param>
        /// <returns>成功执行返回数据集,否则返回null</returns>
        public DataTable GetSqlTable(string str)
        {
            using (var con = new SqlConnection { ConnectionString = Constr })
            {
                var dt = new DataTable("sqlTable");
                try
                {
                    using (var da = new SqlDataAdapter(str, con))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        

        /// <summary>
        /// 重载的从数据库里面绑定数据，返回Dataset
        /// </summary>
        /// <param name="scmd">参数：Sqlcommand 类型的数据库查询命令</param>
        /// <returns>成功执行返回数据集Dataset,失败返回null</returns>
        public DataTable GetSqlTable(SqlCommand scmd)
        {
            using (var con = new SqlConnection { ConnectionString = Constr })
            {
                using (var da = new SqlDataAdapter())
                {
                    var dt = new DataTable("sqlTable");
                    try
                    {
                        da.SelectCommand = scmd;
                        da.SelectCommand.Connection = con;
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        public bool BoolExistTable(SqlCommand cmd)
        {
            using (var con = new SqlConnection(Constr))
            {
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteReader().Read();
            }
        }

        /// <summary>
        /// 执行数据库命令
        /// </summary>
        public bool ExecSqlCmd(SqlCommand cmd)
        {
            using (var con = new SqlConnection(Constr))
            {
                con.Open();
                cmd.Connection = con;
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public static string ExchangeUper(decimal discountAmount)
        {

            var s = discountAmount.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");//d + "\n" +

            var d = Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");

            var s2 = Regex.Replace(d, ".", m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - '-'].ToString(CultureInfo.InvariantCulture));
            return s2;
        }
        /// <summary>
        /// 重载的执行SQL语句的函数，需要一个SqlCommand命令
        /// </summary>
        /// <param name="sqlcmd">传入的Sqlcommand命令</param>
        /// <returns>返回真表示，执行成功，并变更了数据，如果为假，则可能没有影响任何数据</returns>
        public Boolean Sqlexcuate(SqlCommand sqlcmd)
        {
            //声明并初始化一SQL连接
            using (var con = new SqlConnection { ConnectionString = Constr })
            {
                using (sqlcmd)
                {
                    sqlcmd.Connection = con;
                    try
                    {
                        con.Open();
                        return sqlcmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }

            }
        }




        

        /// <summary>
        /// 自定义筛选界面汉化
        /// </summary>
        public static void GridFilter_Customizer()
        {

            var rc = Infragistics.Win.UltraWinGrid.Resources.Customizer;
            rc.SetCustomizedString("RowFilterDropDownAllItem", "所有");
            rc.SetCustomizedString("RowFilterDropDownBlanksItem", "空");
            rc.SetCustomizedString("RowFilterDropDownCustomItem", "自定义");
            rc.SetCustomizedString("RowFilterDropDownNonBlanksItem", "非空");
            rc.SetCustomizedString("RowFilterDropDownAllItem", "所有");
            rc.SetCustomizedString("RowFilterDialogTitlePrefix", "输入过滤准则为");
            rc.SetCustomizedString("FilterDialogAndRadioText", "并且");
            rc.SetCustomizedString("FilterDialogOrRadioText", "或者");
            rc.SetCustomizedString("FilterDialogAddConditionButtonText", "增加一个条件(&N)");
            rc.SetCustomizedString("FilterDialogDeleteButtonText", "删除一个条件");
            rc.SetCustomizedString("FilterDialogOkButtonText", "确定(&O)");
            rc.SetCustomizedString("FilterDialogCancelButtonText", "取消(&C)");
            rc.SetCustomizedString("FilterDialogOkButtonNoFiltersText", "不过滤");
            rc.SetCustomizedString("RowFilterDialogOperatorHeaderCaption", "比较运算符");
            rc.SetCustomizedString("RowFilterDialogOperandHeaderCaption", "准则");
            rc.SetCustomizedString("RowFilterDropDownEquals", "等于");
            rc.SetCustomizedString("RowFilterDropDownNotEquals", "不等于");
            rc.SetCustomizedString("RowFilterDropDownLessThan", "小于");
            rc.SetCustomizedString("RowFilterDropDownLessThanOrEqualTo", "小于等于");
            rc.SetCustomizedString("RowFilterDropDownGreaterThan", "大于");
            rc.SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo", "大于等于");
            rc.SetCustomizedString("RowFilterDropDownMatch", "自定义规则表达式");
            rc.SetCustomizedString("RowFilterDropDownLike", "模糊查找");

            rc.SetCustomizedString("RowFilterDialogBlanksItem", "空白");
            rc.SetCustomizedString("RowFilterDialogDBNullItem", "无值");
            rc.SetCustomizedString("RowFilterDialogEmptyTextItem", "空字符");

            rc.SetCustomizedString("RowFilterDropDown_Operator_Equals", "等于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_NotEquals", "不等于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_LessThan", "小于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_LessThanOrEqualTo", "小于等于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThan", "大于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThanOrEqualTo", "大于等于");
            rc.SetCustomizedString("RowFilterDropDown_Operator_Match", "自定义规则表达式");
            rc.SetCustomizedString("RowFilterDropDown_Operator_Like", "模糊查找");
            rc.SetCustomizedString("RowFilterDropDown_Operator_NotLike", "排除查找");
            rc.SetCustomizedString("RowFilterDropDown_Operator_Contains", "包含");
            rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotContain", "不包含");
            rc.SetCustomizedString("RowFilterDropDown_Operator_EndsWith", "以什么结尾");
            rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotEndWith", "不以什么结尾");
            rc.SetCustomizedString("RowFilterDropDown_Operator_Match", "自定义表达式");
            rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotMatch", "排除自定义表达式");
            rc.SetCustomizedString("RowFilterDropDown_Operator_StartsWith", "以什么开始");
            rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotStartWith", "不以什么开始");


            rc.SetCustomizedString("RowFilterPatternCaption", "无效查找模式");
            rc.SetCustomizedString("RowFilterPatternError", "错误的解析模式{0}. 请输入一个有效的表达式");
            rc.SetCustomizedString("RowFilterPatternException", "无效查找模式{0}");
            rc.SetCustomizedString("RowFilterRegexError", "无效的规则表达式{0}.请输入一个有效的表达式");
            rc.SetCustomizedString("RowFilterRegexErrorCaption", "无效规则表达式");
            rc.SetCustomizedString("RowFilterRegexException", "无效规则表达式{0}");
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
        /// 自定义查询条件
        /// </summary>
        /// <returns>返回查询的条件</returns>
        /// <param name="tbName">查询的表名</param>
        public string GetWhereSqlStr(string tbName)
        {
            var cmd = new SqlCommand("select * from Tb_Collect where tName=@tName");
            cmd.Parameters.AddWithValue("@tName", tbName);
            var dt = GetSqlTable(cmd);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show(@"未初始化该记录的列名,请联系管理员", @"Warning");
                return "";
            }
            IFilterString fs = new FilterString(dt.Rows.Count);
            for (var i = 0; i <= dt.Rows.Count - 1; i++)
            {
                switch (dt.Rows[i]["cType"].ToString())
                {
                    case "DataType.Number":
                        fs[i] = new Filter(dt.Rows[i]["eKey"].ToString(), dt.Rows[i]["cName"].ToString(), DataType.Number);
                        break;
                    case "DataType.DataTime":
                        fs[i] = new Filter(dt.Rows[i]["eKey"].ToString(), dt.Rows[i]["cName"].ToString(), DataType.DataTime);
                        break;
                    case "DataType.String":
                        fs[i] = new Filter(dt.Rows[i]["eKey"].ToString(), dt.Rows[i]["cName"].ToString(), DataType.String);
                        break;

                }

            }
            Form frm = new SearchFilter.SearchFilter(fs);
            frm.ShowDialog();
            var s = fs.FilterText;
            return s;
        }


        public string ReturnFirstSingle(string strsql)
        {
            //定义并初始化一个SQL连接
            var con = new SqlConnection { ConnectionString = Constr };
            var cmd = con.CreateCommand();
            cmd.CommandText = strsql;
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    var rstr = dr[0].ToString();
                    dr.Close();
                    return rstr;

                }
                else
                {
                    dr.Close();
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                return "falsefalse";
            }
            finally
            {
                con.Close();
            }
        }



        

        /// <summary>
        /// 返回第一个单元格的值,以字符串的形式
        /// </summary>
        /// <param name="cmd">执行查询的sql命令</param>
        /// <returns>结果集中的第一个单元格的内容;无结果时,返回empty;异常则返回falsefalse字符串.</returns>
        public string ReturnFirstSingle(SqlCommand cmd)
        {
            using (var con = new SqlConnection {ConnectionString = Constr})
            {
                cmd.Connection = con;
                try
                {
                    con.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            var rstr = dr[0].ToString();
                            return rstr;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return string.Empty;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
