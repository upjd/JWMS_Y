using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WMSM
{
    public partial class MaMain : Form
    {
        public MaMain()
        {
            InitializeComponent();
        }

        private void uExplorerBar_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            var cClass = e.Item.Key;
            if (string.IsNullOrEmpty(cClass))
            {
                return;
            }
            var f = ExistForm(e.Item.Text);
            if (f == null) MenuDoubleClick(cClass);
            else f.Activate();
        }


        /// <summary>
        /// 判断对应窗体是否已经打开
        /// </summary>
        /// <param name="str">传入当前查询的窗体的名称</param>
        /// <returns>返回已经存在的窗体</returns>
        private Form ExistForm(string str)
        {
            return MdiChildren.FirstOrDefault(f => f.Text == str);
        }

        /// <summary>
        /// 通过点击的菜单来显示窗体
        /// </summary>
        /// <param name="cClass">str是表示当前点击的菜单对于的类名</param>
        public void MenuDoubleClick(string cClass)
        {
            var t = Type.GetType(cClass);
            if (t == null) return;
            try
            {
                var obj = Activator.CreateInstance(t);
                t.InvokeMember("MdiParent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, obj, new object[] { this });
                t.InvokeMember("Show", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void MaMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
