using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using LabelManager2;
using Application = System.Windows.Forms.Application;

namespace JWMSY.DLL
{
    class DllWorkPrintLabel
    {
        /// <summary>
        /// 打印份数
        /// </summary>
        public static short Copies=1;



        public static string UriString;

        /// <summary>
        /// 重置内容
        /// </summary>
        public static void ResetNull(UltraGroupBox ugbxMain)
        {
            foreach (Control ctrl in ugbxMain.Controls)
            {
                if (ctrl is TextBox || ctrl is UltraComboEditor || ctrl is UltraTextEditor||ctrl is UltraCombo)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is UltraNumericEditor)
                {
                    var uctr = ctrl as UltraNumericEditor;
                    uctr.Value = null;

                }
                else
                {
                    var picker = ctrl as DateTimePicker;
                    if (picker != null)
                    {
                        var dtp = picker;
                        dtp.Value = System.DateTime.Now;
                        dtp.Checked = false;
                    }
                }
            }
        }


        public static string GetUri()
        {
            var cmd = new SqlCommand("select top 1 cValue from BSetting where cName=@cName");
            cmd.Parameters.AddWithValue("@cName", "WYI");
            var wf = new WmsFunction(BaseStructure.WmsCon);
            UriString=wf.ReturnFirstSingle(cmd);
            return UriString;
        }

        /// <summary>
        /// 获取当前界面的设置的默认打印机与默认打印模版
        /// </summary>
        /// <param name="cFunction">当前的界面</param>
        /// <param name="cCaption">打印模版标题</param>
        /// <param name="cPrinter">打印机</param>
        /// <param name="cTempletPath">打印模版的路径</param>
        public static void GetTemplet(string cFunction, ref string cCaption, ref string cPrinter, ref string cTempletPath)
        {
            var cmd = new SqlCommand("select * from [dbo].[BTempletList] where cFunction =@cFunction and bDefault=1");
            cmd.Parameters.AddWithValue("@cFunction", cFunction);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var dt = wf.GetSqlTable(cmd);
            if (dt != null && dt.Rows.Count > 0)
            {
                cCaption = dt.Rows[0]["cCaption"].ToString();
                cPrinter = dt.Rows[0]["cPrinter"].ToString();
                cTempletPath = dt.Rows[0]["cTempletPath"].ToString();
            }
        }

        /// <summary>
        /// 给打印模版赋值
        /// </summary>
        /// <param name="xtreport">打印模版</param>
        /// <param name="key">对应的key</param>
        /// <param name="value">赋的值</param>
        public static void SetParametersValue(XtraReport xtreport, string key, object value)
        {
            if (xtreport.Parameters.Contains(xtreport.Parameters[key]))
                xtreport.Parameters[key].Value = value;
            else
            {
                var xtrp = new DevExpress.XtraReports.Parameters.Parameter { Name = key, Value = value };
                xtreport.Parameters.Add(xtrp);
            }
        }


        /// <summary>
        /// 调用报表控件打印条码
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="cFileName"></param>
        /// <param name="cPrinter"></param>
        /// <param name="pList"></param>
        //public static void PrintDialog(string operation, string cFileName, string cPrinter, List<List<string>> pList)
        //{
        //    //判断当前打印模版路径是否存在
        //     var xtreport=new XtraReport();
        //     var cTempletPath = string.Format("{0}\\Label\\{1}", Application.StartupPath, cFileName);
        //    if (!File.Exists(cTempletPath))
        //    {
        //        MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        //xtreport.ShowDesigner();
        //        return;
        //    }
        //    xtreport.LoadLayout(cTempletPath);
        //    xtreport.PrinterName = cPrinter;
        //    xtreport.RequestParameters = false;
        //    xtreport.ShowPrintStatusDialog = false;
        //    xtreport.ShowPrintMarginsWarning = false;
        //    //模板赋值
        //    for (var i = 0; i < pList.Count; i++)
        //    {
        //        SetParametersValue(xtreport, pList[i][0], pList[i][1]);
        //    }
        //    switch (operation)
        //    {
        //        case "print":
        //            xtreport.PrintingSystem.StartPrint += PrintingSystem_StartPrint;
        //            xtreport.Print();
        //            break;
        //        case "design":
        //            xtreport.ShowDesigner();
        //            break;
        //        case "preview":
        //            xtreport.ShowPreview();
        //            break;
        //    }
        //}


        //private static void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        //{
        //    e.PrintDocument.PrinterSettings.Copies = Copies;
        //}

        /// <summary>
        /// 原料打印标签
        /// </summary>
        /// <param name="iNum"></param>
        /// <param name="cTempletName"></param>
        /// <param name="cPrinter"></param>
        /// <param name="pList"></param>
        public static void RmPrintCodeSoft(int iNum, string cTempletName, string cPrinter, List<List<string>> pList)
        {
            try
            {
                var lbl = new ApplicationClass();
                var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);

                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false);//调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < pList.Count)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;
                
                //模板赋值
                for (var i = 0; i < pList.Count; i++)
                {
                    
                    doc.Variables.FormVariables.Item("Var"+i).Value = pList[i][1];
                }
                
                doc.PrintDocument(iNum);
                lbl.Documents.CloseAll(false);
                lbl.Quit();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 原料打印标签
        /// </summary>
        /// <param name="iNum"></param>
        /// <param name="cTempletName"></param>
        /// <param name="cPrinter"></param>
        /// <param name="pList"></param>
        public static void ProBoxPrintCodeSoft(DataTable dt,int iNum, string cTempletName, string cPrinter)
        {
            var lbl = new ApplicationClass();
            var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);

            try
            {
               
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count > dt.Columns.Count)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;
                if (dt != null && dt.Rows.Count > 0)
                {
                    DllWmsMain.RecordPrintLog(dt.Rows[0]["cGuid"].ToString());
                    foreach (DataRow dr in dt.Rows)
                    {
                        var cSerialNumber = dr["cSerialNumber"].ToString();
                        var cBarCode = String.Format(@"I*{0}*C*{1}*L*{2}", dt.Rows[0]["cInvCode"],
                            cSerialNumber, dt.Rows[0]["cLotNo"]);
                        doc.Variables.FormVariables.Item("Var0").Value = cBarCode;
                        doc.Variables.FormVariables.Item("Var1").Value = cSerialNumber;
                        doc.Variables.FormVariables.Item("Var2").Value = dt.Rows[0]["cLotNo"].ToString();
                        doc.Variables.FormVariables.Item("Var3").Value = dt.Rows[0]["iQuantity"].ToString();
                        doc.Variables.FormVariables.Item("Var4").Value = dt.Rows[0]["dDate"].ToString();
                        doc.Variables.FormVariables.Item("Var5").Value = dt.Rows[0]["cInvCode"].ToString();
                        doc.Variables.FormVariables.Item("Var6").Value = dt.Rows[0]["cInvName"].ToString();
                        doc.PrintLabel(1, iNum, 1, 1, doc.Format.RowCount - 1, "");
                    }
                }

                //标签批量连续打印。FormFeed（）必须等参数变量输出后才执行，输出给打印机。
                    doc.FormFeed();
                    //doc.PrintDocument();
                    lbl.Documents.CloseAll(false);
                    lbl.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 产成品批量打印用CodeSoft
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="cTempletName"></param>
        /// <param name="cPrinter"></param>
        public static void ProPrintCodeSoft(DataTable dt,string cTempletName,string cPrinter)
        {
            
            var lbl = new ApplicationClass();
            var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);
            try
            {
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < 2)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;
                if (dt != null && dt.Rows.Count > 0)
                {

                    DllWmsMain.RecordPrintLog(dt.Rows[0]["cGuid"].ToString());
                    foreach (DataRow dr in dt.Rows)
                    {
                        //codesoft模板中标签变量
                        doc.Variables.FormVariables.Item("var0").Value = String.Format(@"I*{0}*C*{1}*L*{2}",
                            dr["cInvCode"], dr["cSerialNumber"], dr["cLotNo"]);
                        doc.Variables.FormVariables.Item("var1").Value = dr["cSerialNumber"].ToString();
                        //  doc.PrintDocument(3);
                        doc.PrintLabel(1, 1, 1, 1, doc.Format.RowCount - 1, "");
                    }
                    //标签批量连续打印。FormFeed（）必须等参数变量输出后才执行，输出给打印机。
                    doc.FormFeed();
                    lbl.Documents.CloseAll(false);
                    lbl.Quit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 物流箱标签的批量打印
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="cTempletName"></param>
        /// <param name="cPrinter"></param>
        /// <param name="cUri"></param>
        public static void ProBoxPrintCodeSoft(DataTable dt, string cTempletName, string cPrinter,string cUri)
        {
            try
            {
                var lbl = new ApplicationClass();

                var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < 3)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //codesoft模板中标签变量
                        doc.Variables.FormVariables.Item("var0").Value = string.Format("{0}?boxnumber={1}", cUri,
                            dr["cBoxNumber"]);
                        doc.Variables.FormVariables.Item("var1").Value = dr["cBoxNumber"].ToString();
                        doc.Variables.FormVariables.Item("var2").Value = dr["cMemo"].ToString();
                        //  doc.PrintDocument(3);

                        doc.PrintLabel(1, 1, 1, 1, doc.Format.RowCount - 1, "");
                    }

                    //标签批量连续打印。FormFeed（）必须等参数变量输出后才执行，输出给打印机。
                    doc.FormFeed();
                    //doc.PrintDocument();
                    lbl.Documents.CloseAll(false);
                    lbl.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }

        public static void ProTempBoxPrintCodeSoft( string cTempletName, string cPrinter, int iNum,string cAddress,string cName,string cMemo)
        {
            try
            {
                var lbl = new ApplicationClass();

                var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < 5)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;

                if (iNum > 0)
                {
                    for (var i=1;i<=iNum;i++)
                    {
                        //codesoft模板中标签变量
                        doc.Variables.FormVariables.Item("cAddress").Value = cAddress;
                        doc.Variables.FormVariables.Item("cName").Value =cName;
                        doc.Variables.FormVariables.Item("cMemo").Value =cMemo;
                        doc.Variables.FormVariables.Item("iCurrent").Value = i.ToString();
                        doc.Variables.FormVariables.Item("iNum").Value = iNum.ToString();
                        //  doc.PrintDocument(3);

                        doc.PrintLabel(1, 1, 1, 1, doc.Format.RowCount - 1, "");
                    }

                    //标签批量连续打印。FormFeed（）必须等参数变量输出后才执行，输出给打印机。
                    doc.FormFeed();
                    //doc.PrintDocument();
                    lbl.Documents.CloseAll(false);
                    lbl.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        public static void ProTempVipBoxPrintCodeSoft(string cTempletName, string cPrinter,int iNum, string cInvName, string cMemo)
        {
            try
            {
                var lbl = new ApplicationClass();

                var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < 2)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;
                //codesoft模板中标签变量
                 doc.Variables.FormVariables.Item("cInvName").Value = cInvName;
                 doc.Variables.FormVariables.Item("cMemo").Value = cMemo;
                 doc.PrintDocument(iNum);
                //doc.PrintDocument();
                lbl.Documents.CloseAll(false);
                lbl.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
