using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.Barcode2;

namespace SPDA
{
    public partial class SSReplaceBox : Form
    {
        public string cBoxOne;
        public string cBoxTwo;


        public SSReplaceBox()
        {
            InitializeComponent();
        }

        private void mBc2_OnScan(Symbol.Barcode2.ScanDataCollection scanDataCollection)
        {
            ScanData sData = scanDataCollection.GetFirst;
            var str = sData.Text;
            var sType = sData.Type.ToString();
            byte[] by = Encoding.Default.GetBytes(str);
            string sText = Encoding.GetEncoding(65001).GetString(by, 0, by.Length);

            scan_OnDecodeEvent(sText);
        }

        private void scan_OnDecodeEvent(string sText)
        {
            if (string.IsNullOrEmpty(lblBoxOne.Text))
            {
                lblBoxOne.Text = sText;
            }
            else
            {
                lblBoxTwo.Text = sText;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblBoxOne.Text)||string.IsNullOrEmpty(lblBoxTwo.Text))
            {
                MessageBox.Show("换箱数据不正确");
                return;
            }
            DialogResult = DialogResult.Yes;
            cBoxOne = lblBoxTwo.Text;
            cBoxTwo = lblBoxTwo.Text;
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SSReplaceBox_Load(object sender, EventArgs e)
        {
            mBc2.EnableScanner = true;
        }

        private void SSReplaceBox_Closing(object sender, CancelEventArgs e)
        {
            mBc2.EnableScanner = false; ;
        }
    }
}