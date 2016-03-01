using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Import.Doc;


namespace JWMSY.DLL
{
    class DllWmsMain
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cKey"></param>
        /// <returns></returns>
        public static string GetMenuClass(string cKey)
        {
            using (var cmd = new SqlCommand(@"select cClass from BFunction WHERE cFunction=@cFunction"))
            {
                cmd.Parameters.AddWithValue("@cFunction", cKey);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ReturnFirstSingle(cmd);
            }
        }


        public static string GetPrintLog(string cGuid)
        {
            using (var cmd = new SqlCommand(@"select dAddTime from BLogPrint WHERE cGuid=@cGuid"))
            {
                cmd.Parameters.AddWithValue("@cGuid", cGuid);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ReturnFirstSingle(cmd);
            }
        }


        public static bool RecordPrintLog(string cGuid)
        {
            using (var cmd = new SqlCommand(@"INSERT INTO  BLogPrint (cGuid,cOperator) Values(@cGuid,@cOperator)"))
            { 
                cmd.Parameters.AddWithValue("@cGuid", cGuid);
                cmd.Parameters.AddWithValue("@cOperator", BaseStructure.LoginName);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ExecSqlCmd(cmd);
            }
        }
        
        public static bool RecordLogAction(string cFunction,string cDescription)
        {
            using (var logCmd = new SqlCommand(@"AddLogAction"))
            {
                logCmd.CommandType = CommandType.StoredProcedure;
                logCmd.Parameters.AddWithValue("@cFunction", cFunction);
                logCmd.Parameters.AddWithValue("@cDescription", cDescription);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ExecSqlCmd(logCmd);
            }
        }


        public static string GetBarCodeBySerialNumber(string cSerialNumber)
        {
            using (var logCmd = new SqlCommand(@"GetBarCodeBySerialNumber"))
            {
                logCmd.CommandType = CommandType.StoredProcedure;
                logCmd.Parameters.AddWithValue("@cSerialNumber", cSerialNumber);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ReturnFirstSingle(logCmd);
            }
        }


        public static string GetBoxWeight(string cBoxNumber)
        {
            using (var cmd = new SqlCommand(@"select isnull(iWeight,0) from SS_Box where cBoxNumber=@cBoxNumber"))
            {
                cmd.Parameters.AddWithValue("@cBoxNumber", cBoxNumber);
                var wf = new WmsFunction(BaseStructure.WmsCon);
                return wf.ReturnFirstSingle(cmd);
            }
        }
         
    }
}
