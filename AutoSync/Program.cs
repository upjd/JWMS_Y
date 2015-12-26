using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoSync
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
	        bool bCreate;  
	        System.Threading.Mutex mutex = new System.Threading.Mutex(false, "SINGILE_INSTANCE_MUTEX", out bCreate);
            if(bCreate)
            {
                Application.Run(new AutoSync());
            }
            else
            {
                Application.Exit();
            }

            
        }
    }
}
