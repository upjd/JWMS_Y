using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


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
    }
}
