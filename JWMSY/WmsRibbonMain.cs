using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Painters;
using Infragistics.Win.UltraWinExplorerBar;
using JWMSY.DLL;

namespace JWMSY
{
    /// <summary>
    /// 主界面
    /// </summary>
    public partial class WmsRibbonMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        /// <summary>
        /// 表示是否弹出提示关闭当前应用程序
        /// 1表示不弹出.
        /// </summary>
        public static int Iclose;

        /// <summary>
        /// 实例化BaseClass
        /// </summary>
        private BaseClass BaseCs = new BaseClass();
        /// <summary>
        /// 主界面构造函数
        /// </summary>
        public WmsRibbonMain()
        {
            InitializeComponent();
        }



        private void bbiSecondVersion_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void WmsRibbonMain_Load(object sender, EventArgs e)
        {
            ToUpdateNoMessage();
            //设置状态栏显示内容
            uStatusBar.Panels[4].MarqueeInfo.Start();
            uStatusBar.Panels["tssl_Lname"].Text = @"操作员：" + BaseStructure.LoginName;
            uStatusBar.Panels["tssl_Lserver"].Text = @"Server：" + BaseStructure.WmsServer;
            var wmc = new WmsMainChild {MdiParent = this};
            wmc.Show();

            WmsFunction.GridFilter_Customizer();
            GetMenuAuthority();

        }


        /// <summary>
        /// 获取登录用户角色权限
        /// </summary>
        private void GetMenuAuthority()
        {
            //开始读取权限,先显示Group再显示Items
            foreach (var iGroup in uExplorerBar.Groups)
            {
                foreach (var eItem in iGroup.Items)
                {
                    eItem.Visible = CanOperator(eItem.Key);
                }
            }
        }

        /// <summary>
        /// 是否有权限操作
        /// </summary>
        /// <returns></returns>
        private bool CanOperator(string cKey)
        {
            var cmd = new SqlCommand("select * from BRoleFunction where rCode=@rCode and fCode=@fCode and isnull(bRight,0)=1");
            cmd.Parameters.AddWithValue("@rCode", BaseStructure.LoginRoleId);
            cmd.Parameters.AddWithValue("@fCode", cKey);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            return wf.BoolExistTable(cmd);
        }

        public void ToUpdateNoMessage()
        {
            var bcs = new WmsService.BaseConService();
            bcs.Url = BaseStructure.WmsServiceUri;
            var serverVersion = bcs.GetVer();
            var clientVersion = uStatusBar.Panels["tssbtnVersion"].Text;
            if (String.Compare(clientVersion, serverVersion, StringComparison.Ordinal) >= 0) return;
            //var doc = new XmlDocument();
            //var node = bcs.GetUpdateData().OuterXml;
            ////doc.ImportNode(node, true);
            //doc.LoadXml(node);
            //doc.Save(Application.StartupPath + @"\\update.xml");
            System.Diagnostics.Process.Start(Application.StartupPath + @"\\Update.exe");
            Iclose = 1;
            Application.Exit();
            //Close();
            //Application.Exit();
        }

        private void biMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            uSplitterLeft.Collapsed = !uSplitterLeft.Collapsed;
        }

        private void WmsRibbonMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Iclose == 1)
                return;
            e.Cancel = MessageBox.Show(@"确定退出吗？", @"是否退出？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
            
            try { BaseCs.DeleteOnline(); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void WmsRibbonMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tm_OnlineManage_Tick(object sender, EventArgs e)
        {
            try
            {
                tm_OnlineManage.Enabled = false;
                if (BaseCs.BCanOnline())
                {
                    tm_OnlineManage.Enabled = true;
                    return;
                }
                MessageBox.Show(@"同一用户被他人登录！请重新登录！", @"提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                Iclose = 1;
                Application.Restart();
            }
            catch (Exception ex)
            {
                tm_OnlineManage.Stop();
                tm_OnlineManage.Enabled = false;
                MessageBox.Show(@"请求有误！
" + ex.Message+@"请重新登录！", @"提示");
                Iclose = 1;
                Application.Restart();
            }
        }

        private void uExplorerBar_ItemClick(object sender, ItemEventArgs e)
        {
            var cClass = DllWmsMain.GetMenuClass(e.Item.Key);
            if (string.IsNullOrEmpty(cClass))
            {
                return;
            }
            var f = ExistForm(e.Item.Key);
            if (f == null) MenuDoubleClick(cClass);
            else f.Activate();
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

        /// <summary>
        /// 判断对应窗体是否已经打开
        /// </summary>
        /// <param name="str">传入当前查询的窗体的名称</param>
        /// <returns>返回已经存在的窗体</returns>
        private Form ExistForm(string str)
        {
            return MdiChildren.FirstOrDefault(f => f.Text == str);
        }

        private void biExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void MdiManager_InitializeContextMenu(object sender, Infragistics.Win.UltraWinTabbedMdi.MdiTabContextMenuEventArgs e)
        {
            foreach (Infragistics.Win.IGControls.IGMenuItem item in e.ContextMenu.MenuItems)
            {
                switch (item.Text)
                {
                    case "&Close":
                        item.Text = @"关闭";
                        break;
                    case "New Hori&zontal Tab Group":
                        item.Text = @"新建横向分组";
                        break;
                    case "New &Vertical Tab Group":
                        item.Text = @"新建坚向分组";
                        break;
                    case "Move to Ne&xt Tab Group":
                        item.Text = @"下一分组";
                        break;
                    case "Move to P&revious Tab Group":
                        item.Text = @"上一分组";
                        break;
                    case "C&ancel":
                        item.Text = @"取消";
                        break;
                }
            }
        }

        private void uStatusBar_ButtonClick(object sender, Infragistics.Win.UltraWinStatusBar.PanelEventArgs e)
        {
            using (var ab = new AboutVersion())
            {
                ab.ShowDialog();
            }
        }

        private void MdiManager_TabClosing(object sender, Infragistics.Win.UltraWinTabbedMdi.CancelableMdiTabEventArgs e)
        {
            if (e.Tab.Form.Text == @"主界面")
            {
                e.Cancel = true;
            }
        }

        private void btnCalc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"异常错误！");
            }
        }

        private void bbtnFreshFunction_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetMenuAuthority();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }


    }
}