using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JWMSY
{
    public partial class WorkLotReApprove : Form
    {
        public WorkLotReApprove()
        {
            InitializeComponent();
        }

        private void WorkLotReApprove_Load(object sender, EventArgs e)
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var getConfig = new SqlCommand("select cValue EasUser,cMemo EasUserPwd,cDefine1 EasDataCenter from  BSetting where cName='EasInterface'");
            var dt = wf.GetSqlTable(getConfig);
            if (dt == null||dt.Rows.Count<1)
            {
                txtUser.Text = @"yofoto";
                txtPwd.Text = @"000000";
                txtDataCenter.Text = @"eas750test20151226";
            }
            else
            {
                txtUser.Text = dt.Rows[0]["EasUser"].ToString();
                txtPwd.Text = dt.Rows[0]["EasUserPwd"].ToString();
                txtDataCenter.Text = dt.Rows[0]["EasDataCenter"].ToString();
            }
        }

        private void SyncApprove(string cOrderNumber,int i)
        {
            //VLogError(@"销售出库" + cOrderNumber, "开始调用easWebservices" + DateTime.Now);
            var cName = txtUser.Text;
            var cPwd = txtPwd.Text;
            var easDataCenter = txtDataCenter.Text;
            var easproxy = new EASLoginProxyService();
            //proxy.Url = Global.oaUrl + "/ormrpc/services/EASLogin?wsdl";
            //WSContext ctx = easproxy.login(name, pwd, "eas", "a", "L2", 2, "BaseDB");
            var ctx = easproxy.login(cName, cPwd, "eas", easDataCenter, "L2", 2, "BaseDB");
            if (ctx.sessionId != null)
            {
                //正确登录
            }
            else
            {
                //VLogError(@"销售出库", cOrderNumber + "::用户名或密码错误!!");
                uGridOutBox.Rows[i].Cells["cResult"].Value = "用户名或密码错误";
            }

            var proxy = new WSWSYofotoFacadeSrvProxyService();
            var msg = proxy.auditSaleIssueBill("S.01", cOrderNumber);
            uGridOutBox.Rows[i].Cells["cResult"].Value = msg;
            //VLogError(@"销售出库" + cOrderNumber, "调用easWebservices结束" + DateTime.Now);
            //VLogError(@"销售出库", cOrderNumber + "::" + msg);
        }

        private void biApprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var InputList = txtInput.Text.Split(',');

            for (var i = 0; i < InputList.Length; i++)
            {
                var nRow = dataProductMain.DataInput.NewDataInputRow();
                nRow.cOrderNumber = InputList[i];
                dataProductMain.DataInput.Rows.Add(nRow);
            }
            pgBarMain.Maximum = uGridOutBox.Rows.Count;
            for (var i = 0; i < uGridOutBox.Rows.Count; i++)
            {
                try
                {
                    SyncApprove(uGridOutBox.Rows[i].Cells["cOrderNumber"].Value.ToString(), i);
                }
                catch (Exception ex)
                {
                    uGridOutBox.Rows[i].Cells["cResult"].Value=ex.Message;
                }
                
                pgBarMain.Value = i;
                Application.DoEvents();
            }
        }



    }
}
