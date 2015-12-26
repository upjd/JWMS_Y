using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JWMSY
{
    /// <summary>
    /// 获取数量及对应的重量
    /// </summary>
    public partial class PdaGetIntQuantity : Form
    {
        public int IQuantity;
        public decimal IWeight;

        public string cNewLotNo;
        private bool _OneGoods;

        /// <summary>
        /// 理论重量
        /// </summary>
        private int _iTheoryWeight;

        public bool bLotMgr;

        /// <summary>
        /// 理论条规
        /// </summary>
        private int _iBoxFormat;
        /// <summary>
        /// 获取数量及对应重量构造函数
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <param name="cInvName"></param>
        /// <param name="cLotNo"></param>
        /// <param name="oneGoods"></param>
        /// <param name="iRemainQuantity"></param>
        public PdaGetIntQuantity(string cInvCode, string cInvName, string cLotNo, bool oneGoods, int iRemainQuantity, int iTheoryWeight, int iBoxFormat,string cSerialNumber)
        {
            InitializeComponent();
            lblcInvCode.Text = cInvCode;
            lblcInvName.Text = cInvName;
            lblcLotNo.Text = cLotNo;
            lblRquantity.Text = iRemainQuantity.ToString();
            _iTheoryWeight = iTheoryWeight;
            _iBoxFormat = iBoxFormat;
            lblcBoxFormat.Text = iBoxFormat.ToString();
            if (iRemainQuantity == 1)
            {
                txtiNum.Text = @"1";
                lblTheoryWeight.Text = ((decimal) _iTheoryWeight/1000).ToString();
            }
            else
            {
                lblTheoryWeight.Text = (((decimal)_iTheoryWeight*iRemainQuantity) / 1000).ToString();
            }

            //判断是否是点选的产品
            lblcLotNo.Enabled = string.IsNullOrEmpty(cLotNo);
            
            
            //if (_OneGoods)
            //{
            //    txtiNum.Text = "1";
            //    txtiNum.Enabled = false;
            //}

            if (_iBoxFormat>0)
            {
                lblBoxNum.Text = iRemainQuantity/iBoxFormat + @"箱" + iRemainQuantity%iBoxFormat + @"个";
                
            }
            if (cSerialNumber.StartsWith("ZZ"))
            {
                txtiNum.Text = _iBoxFormat.ToString();
            }
            else
            {
                txtiNum.Text = iRemainQuantity.ToString();
            }

            txtiNum.TextChanged += txtiNum_TextChanged;
        }

        private bool GetLotMgr()
        {
            var wf = new WmsFunction(BaseStructure.WmsCon);
            var bOutAllCmd = new SqlCommand("select isnull(bLotMgr,0) bLotMgr from IT_Product where cInvCode=@cInvCode");
            bOutAllCmd.Parameters.AddWithValue("@cInvCode", lblcInvCode.Text);
            bool bLotMgr;
            var cLotMgr = wf.ReturnFirstSingle(bOutAllCmd);
            if (bool.TryParse(cLotMgr, out bLotMgr))
            {
                return bLotMgr;
            }
            return false;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        DialogResult=DialogResult.Cancel;//esc关闭窗体
                        break;
                }
            }
            return false;
        }



        private void PdaGetQuantity_Load(object sender, EventArgs e)
        {
            
            txtiNum.Focus();
            bLotMgr = GetLotMgr();
            if (bLotMgr)
            {
                lblLotMgr.Text = @"有批次管理";
            }
            else
            {
                lblLotMgr.Text = @"无批次管理";
            }
            if (spMain == null)
                return;
            if (spMain.IsOpen)
            {
                return;
            }
            try
            {
                spMain.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Com1口打开失败
" + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtiNum.Text))
                return;
            if (bLotMgr&&string.IsNullOrEmpty(lblcLotNo.Text.Trim()))
            {
                MessageBox.Show(@"此产品有批次管理要求，必需输入批次！");
                return;
            }
            
            try
            {
                IQuantity = int.Parse(txtiNum.Text);
                decimal iiWeight;
                if (decimal.TryParse(uteiWeight.Value.ToString(), out iiWeight))
                {
                    uteiWeight.Value = iiWeight;
                }
                IWeight = iiWeight;
                cNewLotNo=lblcLotNo.Text;
                DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                MessageBox.Show(@"数量请输入正确的数值，重量必输");
            }
        }

        private void txtiNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrEmpty(txtiNum.Text))
                return;

            if (bLotMgr && string.IsNullOrEmpty(lblcLotNo.Text.Trim()))
            {
                MessageBox.Show(@"此产品有批次管理要求，必需输入批次！");
                return;
            }
            try
            {
                IQuantity = int.Parse(txtiNum.Text);
                decimal iiWeight;
                if (decimal.TryParse(uteiWeight.Value.ToString(), out iiWeight))
                {
                    uteiWeight.Value = iiWeight;
                }
                IWeight = iiWeight;
                cNewLotNo = lblcLotNo.Text;
                DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                MessageBox.Show(@"请输入正确的数值");
            }
        }

        private void spMain_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //判断Com口是否打开
                if (spMain == null)
                    return;
                if (!spMain.IsOpen) return;
                Thread.Sleep(200);
                var bytes = spMain.BytesToRead;
                var buffer = new byte[bytes];
                spMain.Read(buffer, 0, bytes);
                var strbuffer = Encoding.ASCII.GetString(buffer);

                //判断获取的值是否正常

              if (strbuffer.Length < 5)
                    return;
                var strWeight = strbuffer.Substring(2, 5);
                decimal iWeight;
                if (decimal.TryParse(strWeight, out iWeight))
                {
                    uteiWeight.Value = iWeight;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void PdaGetIntQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!spMain.IsOpen) return;
            spMain.Close();
            spMain.Dispose();
        }

        private void txtiNum_TextChanged(object sender, EventArgs e)
        {
            var cNum = txtiNum.Text;
            decimal iNum;
            if (decimal.TryParse(cNum, out iNum))
            {
                lblTheoryWeight.Text = (iNum*_iTheoryWeight/1000).ToString("F2");
            }
            else
            {
                lblTheoryWeight.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lblcLotNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrEmpty(txtiNum.Text))
                return;

            if (bLotMgr && string.IsNullOrEmpty(lblcLotNo.Text.Trim()))
            {
                MessageBox.Show(@"此产品有批次管理要求，必需输入批次！");
                return;
            }
            try
            {
                IQuantity = int.Parse(txtiNum.Text);
                decimal iiWeight;
                if (decimal.TryParse(uteiWeight.Value.ToString(), out iiWeight))
                {
                    uteiWeight.Value = iiWeight;
                }
                IWeight = iiWeight;
                cNewLotNo = lblcLotNo.Text;
                DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                MessageBox.Show(@"请输入正确的数值");
            }
        }
    }
}