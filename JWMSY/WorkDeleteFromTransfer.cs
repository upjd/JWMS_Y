using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JWMSY
{
    public partial class WorkDeleteFromTransfer : Form
    {
        public WorkDeleteFromTransfer()
        {
            InitializeComponent();
        }

        private void btnRmStore_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Rm_TransferStore");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);

        }

        private void btnRmDelivery_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Rm_TransferDelivery");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);
        }

        private void btnSemiStore_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Semi_TransferStore");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);
        }

        private void btnSemiDelivery_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Semi_TransferDelivery");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);
        }

        private void btnProStore_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Pro_TransferStore");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);
        }

        private void btnProDelivery_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("DeleteFromTransfer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cOrderNumber", txtcOrderNumber.Text);
            cmd.Parameters.AddWithValue("@cOrderType", "Pro_TransferDelivery");
            var wfun = new WmsFunction(BaseStructure.WmsCon);
            wfun.ExecSqlCmd(cmd);
        }
    }
}
