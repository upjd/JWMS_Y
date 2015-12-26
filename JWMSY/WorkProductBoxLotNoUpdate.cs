using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JWMSY
{
    public partial class WorkProductBoxLotNoUpdate : Form
    {
        public WorkProductBoxLotNoUpdate()
        {
            InitializeComponent();
        }

        private void WorkProductBoxLotNoUpdate_Load(object sender, EventArgs e)
        {
            pageChange.Constr = BaseStructure.WmsCon;
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            pageChange.WhereStr = "cSerialNumber>='" + tstxtStart.Text + "' and cSerialNumber<='" + tstxtEnd.Text + "' ";
            pageChange.GetRecord();
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            if (!WmsFunction.IsNumAndEnCh(tstxtLotNo.Text))
            {
                MessageBox.Show(@"请输入正确的批次格式，只允许有数字与字母");
                return;
            }
            var cmd = new SqlCommand("update Bar_Product_Box_SerialNumber set cLotNo='"+tstxtLotNo.Text+"' where " + pageChange.WhereStr);
            
            var wf = new WmsFunction(BaseStructure.WmsCon);
            wf.ExecSqlCmd(cmd);
            pageChange.GetRecord();
        }
    }
}
