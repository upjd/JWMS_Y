using JWMSY.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JWMSY
{
    /// <summary>
    /// 三生物流-件数自定义打印
    /// </summary>
    public partial class WorkTempBox : Form
    {

        /// <summary>
        /// 进行记录跳转用ID
        /// </summary>
        private string _lid;

        /// <summary>
        /// Guid
        /// </summary>
        private string _cGuid;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cTempletFileName;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cCaption;

        /// <summary>
        /// 打印机
        /// </summary>
        private string _cPrinter;
        /// <summary>
        /// 三生物流-件数自定义打印
        /// </summary>
        public WorkTempBox(string cPrinter)
        {
            InitializeComponent();
            biPrint.Caption = cPrinter;
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcAddress.Text))
            {
                MessageBox.Show(@"地址必填", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrEmpty(txtcName.Text))
            {
                MessageBox.Show(@"收货人必填", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrEmpty(uneiNum.Value.ToString()))
            {
                MessageBox.Show(@"总件数必填", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrEmpty(biPrinter.Caption))
            {
                MessageBox.Show(@"打印机不正确", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrEmpty(biTemplet.Caption))
            {
                MessageBox.Show(@"模版不正确", @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            int iNum;
            if (int.TryParse(uneiNum.Value.ToString(), out iNum))
            {
                DllWorkPrintLabel.ProTempBoxPrintCodeSoft(_cTempletFileName, _cPrinter, iNum, txtcAddress.Text,
                    txtcName.Text, txtcMemo.Text);
            }

            
        }

        private void WorkTempBox_Load(object sender, EventArgs e)
        {
            DllWorkPrintLabel.GetTemplet("件数标签", ref _cCaption, ref _cPrinter, ref _cTempletFileName);
            biPrinter.Caption = _cPrinter;
            biTemplet.Caption = _cCaption;
        }

        private void biTemplet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var st = new Base_Templet(true, "件数标签"))
            {
                if (st.ShowDialog() == DialogResult.Yes)
                {
                    biTemplet.Caption = st.URow.Cells["cCaption"].Value.ToString();
                    _cCaption = st.URow.Cells["cCaption"].Value.ToString();
                    _cTempletFileName = st.URow.Cells["cTempletPath"].Value.ToString();
                    biPrinter.Caption = st.URow.Cells["cPrinter"].Value.ToString();
                    _cPrinter = st.URow.Cells["cPrinter"].Value.ToString();
                }
            }
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtcAddress.Text = "";
            txtcName.Text = "";
            txtcMemo.Text = "";
            uneiNum.Value = 2;
        }
    }
}
