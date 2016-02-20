using System.Globalization;
using JWMSY.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.Misc;

namespace JWMSY
{
    /// <summary>
    /// 打印箱条码标签界面
    /// </summary>
    public partial class WorkProPrintLabelBoxVIP : Form
    {
        /// <summary>
        /// 进行记录跳转用ID
        /// </summary>
        private string _lid;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cTempletPath;

        /// <summary>
        /// 打印模版路径
        /// </summary>
        private string _cCaption;

        /// <summary>
        /// 打印机
        /// </summary>
        private string _cPrinter;

        /// <summary>
        /// Guid
        /// </summary>
        private string _cGuid;

        /// <summary>
        /// 打印周转箱条码标签界面构造函数
        /// </summary>
        public WorkProPrintLabelBoxVIP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打印周转箱条码标签界面构造函数
        /// </summary>
        public WorkProPrintLabelBoxVIP(string lid)
        {
            _lid = lid;
            InitializeComponent();
        }

        private void WorkProPrintLabelBox_Load(object sender, EventArgs e)
        {
            GetRawMaterial();

            pageChange.Constr = BaseStructure.WmsCon;

            if (string.IsNullOrEmpty(_lid))
            {
                SetPanelVlaue("", "btnLast");
            }
            else
            {
                SetPanelVlaue(_lid);
            }

            lblTitleMain.btnFirst.Click += btnFirst_Click;
            lblTitleMain.btnNext.Click += btnFirst_Click;
            lblTitleMain.btnPre.Click += btnFirst_Click;
            lblTitleMain.btnLast.Click += btnFirst_Click;

            DllWorkPrintLabel.GetTemplet("产成品礼包标签", ref _cCaption, ref _cPrinter, ref _cTempletPath);

            biEditPrinter.Caption = _cPrinter;
            biEditTemplet.Caption = _cCaption;

            //初始化表格功能控件
            tsgfMain.FormId = Name.GetHashCode().ToString(CultureInfo.CurrentCulture);
            tsgfMain.FormName = Text;
            tsgfMain.Constr = BaseStructure.WmsCon;
            tsgfMain.GetGridStyle(tsgfMain.FormId);
        }

        private void biSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //判断什么未填写
            var nullstr = CheckNull();
            if (!string.IsNullOrEmpty(nullstr))
            {
                MessageBox.Show(nullstr + @"必填,请填写完成!", @"必填", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!WmsFunction.IsNumAndEnCh(txtcLotNo.Text))
            {
                MessageBox.Show(@"请输入正确的批次格式，只允许有数字与字母");
                return;
            }

            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                using (var cmd = new SqlCommand { CommandType = CommandType.StoredProcedure, Connection = con,CommandTimeout=180 })
                {
                    if (string.IsNullOrEmpty(lblTitleMain.lblAutoID.Text))
                    {
                        int iSerialQty;
                        if (beiSerialQty.EditValue == null)
                        {
                            MessageBox.Show(@"输入的列序数不正确,请输入正整数");
                            return;
                        }
                        if (!int.TryParse(beiSerialQty.EditValue.ToString(), out iSerialQty))
                        {
                            MessageBox.Show(@"输入的列序数不正确,请输入正整数");
                            return;
                        }
                        if (iSerialQty < 1 || iSerialQty>100000)
                        {
                            MessageBox.Show(@"输入的列序数不能小于1，并且不能大于10万");
                            return;
                        }
                        cmd.CommandText = "proc_Bar_Product_BoxInsert";
                        var idParameter = new SqlParameter("@AutoID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        var cBoNoParameter = new SqlParameter("@cBoxNumber", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };

                        //获取id的返回值和采购订单号的返回值
                        cmd.Parameters.Add(idParameter);
                        cmd.Parameters.Add(cBoNoParameter);
                        _cGuid = Guid.NewGuid().ToString();
                        cmd.Parameters.AddWithValue("@cGuid", _cGuid);
                        cmd.Parameters.AddWithValue("@iSerialQty", iSerialQty);

                    }
                    else
                    {
                        cmd.CommandText = "proc_Bar_Product_BoxUpdate";
                        cmd.Parameters.AddWithValue("@AutoID", lblTitleMain.lblAutoID.Text);
                    }

                    //赋参数
                    cmd.Parameters.AddWithValue("@cLotNo", txtcLotNo.Text);
                    cmd.Parameters.AddWithValue("@iQuantity", uneiQuantity.Value);
                    cmd.Parameters.AddWithValue("@dDate", dtpdDate.Value);
                    cmd.Parameters.AddWithValue("@cInvCode", txtcInvCode.Text);
                    cmd.Parameters.AddWithValue("@cInvName", utecInvName.Text);
                    cmd.Parameters.AddWithValue("@cInvPackStd", txtcInvPackStd.Text);
                    cmd.Parameters.AddWithValue("@cInvStd", txtcInvStd.Text);
                    cmd.Parameters.AddWithValue("@cInvPackStyle", txtcInvPackStyle.Text);
                    cmd.Parameters.AddWithValue("@cDefaultVendor", txtcVendor.Text);
                    cmd.Parameters.AddWithValue("@cMassUnit", lblcMassUnit.Text);
                    cmd.Parameters.AddWithValue("@iMassDate", uneiMassDate.Value);
                    cmd.Parameters.AddWithValue("@cKeepRequire", txtcKeepRequire.Text);
                    cmd.Parameters.AddWithValue("@cProperty", "");
                    cmd.Parameters.AddWithValue("@cMemo", txtcMemo.Text);
                    con.Open();

                    try
                    {
                        var ieffect = cmd.ExecuteNonQuery();
                        //判断是否是真的完成了主表的写入
                        if (ieffect > 0)
                        {
                            if (string.IsNullOrEmpty(lblTitleMain.lblAutoID.Text))
                            {
                                lblTitleMain.lblAutoID.Text = cmd.Parameters["@AutoID"].Value.ToString();
                                lblTitleMain.lblcSerialNumber.Text = cmd.Parameters["@cBoxNumber"].Value.ToString();
                            }
                        }

                        MessageBox.Show(@"保存成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetControlDisable();
                        pageChange.WhereStr = string.Format("cGuid ='{0}'", _cGuid);
                        pageChange.GetRecord();
                        var bPrint = MessageBox.Show(@"是否立即打印", @"是否", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes;
                        if (bPrint)
                        {
                            PrinterDone();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void PrinterDone()
        {
            var strDate = DllWmsMain.GetPrintLog(_cGuid);
            if (!string.IsNullOrEmpty(strDate))
            {
                MessageBox.Show(@"已经打印过，不允许再打印! 打印时间:" + strDate, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dt = GetPrintTable();
            if (dt.Rows.Count < 1)
                return;
            short iCopies=1;
            if (beiCopies.EditValue == null)
            {
                iCopies = 1;
            }
            else if (!short.TryParse(beiCopies.EditValue.ToString(), out iCopies))
            {
                iCopies = 1;
            }
            DllWorkPrintLabel.Copies = iCopies;
            DllWorkPrintLabel.ProBoxPrintCodeSoft(dt,iCopies, _cTempletPath, _cPrinter);
        }

        private DataTable GetPrintTable()
        {
            var cmd = new SqlCommand(" select * from View_Bar_Product_Box_SerialNumber where cGuid=@cGuid order by autoid desc");
            cmd.Parameters.AddWithValue("@cGuid", _cGuid);
            var wf = new WmsFunction(BaseStructure.WmsCon);
            return wf.GetSqlTable(cmd);
        }

        private void txtcInvCode_RowSelected(object sender, RowSelectedEventArgs e)
        {
            var uRow = e.Row;

            SetDefaultValue(uRow);
        }


        /// <summary>
        /// 设置GroupBox中对应控件的值；
        /// </summary>
        /// <param name="uRow"></param>
        private void SetDefaultValue(UltraGridRow uRow)
        {
            if (uRow == null || uRow.Index <= -1) return;
            txtcInvCode.Text = uRow.Cells["cInvCode"].Value.ToString();
            utecInvName.Text = uRow.Cells["cInvName"].Value.ToString();
            txtcInvPackStd.Text = uRow.Cells["cInvPackStd"].Value.ToString();
            txtcInvStd.Text = uRow.Cells["cInvStd"].Value.ToString();
            txtcInvPackStyle.Text = uRow.Cells["cInvPackStyle"].Value.ToString();
            txtcVendor.Text = uRow.Cells["cDefaultVendor"].Value.ToString();
            lblcMassUnit.Text = uRow.Cells["cMassUnit"].Value.ToString();
            uneiMassDate.Value = string.IsNullOrEmpty(uRow.Cells["iMassDate"].Value.ToString()) ? 0 : uRow.Cells["iMassDate"].Value;
            txtcKeepRequire.Text = uRow.Cells["cKeepRequire"].Value.ToString();

            txtcMemo.Text = uRow.Cells["cMemo"].Value.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (biSave.Enabled)
            {
                MessageBox.Show(@"请取消编辑后再翻页!", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var btn = (Button)sender;
            SetPanelVlaue(lblTitleMain.lblAutoID.Text, btn.Name);
        }


        /// <summary>
        /// 获取原料基础档案
        /// </summary>
        private void GetRawMaterial()
        {
            iT_ProductTableAdapter.Connection.ConnectionString = BaseStructure.WmsCon;
            iT_ProductTableAdapter.Fill(dataInventory.IT_Product, true);
        }

        private void biAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DllWorkPrintLabel.ResetNull(ugbxMain);
            lblTitleMain.lblAutoID.Text = "";
            lblTitleMain.lblcSerialNumber.Text = "";
            SetControlEnable();
        }



        /// <summary>
        /// 启用所有新增和更新控件时使用的输入和保存按钮
        /// </summary>
        private void SetControlEnable()
        {
            foreach (Control ctrl in ugbxMain.Controls)
            {
                if (ctrl is Label || ctrl is UltraLabel)
                {
                    continue;
                }
                ctrl.Enabled = true;
            }
            biSave.Enabled = true; //在可编辑下保存按钮可用
            biGiveup.Enabled = true; //在可编辑下取消按钮可用
            biAddNew.Enabled = false; //在可编辑下新增按钮不可用
            biEdit.Enabled = false; //在可编辑下修改按钮不可用
            biDelete.Enabled = false;

        }

        /// <summary>
        /// 禁用所有输入框和保存按钮
        /// </summary>
        private void SetControlDisable()
        {
            foreach (Control ctrl in ugbxMain.Controls)
            {
                if (ctrl is Label || ctrl is UltraLabel)
                {
                    continue;
                }
                ctrl.Enabled = false;
            }

            biSave.Enabled = false;//在不可编辑下保存按钮不可用
            biGiveup.Enabled = false;//在不可编辑下取消按钮不可用
            biAddNew.Enabled = true;//在不可编辑下新增按钮可用
            biEdit.Enabled = true;//在不可编辑下修改按钮可用
            biDelete.Enabled = true;
        }

        private void utecInvName_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            using (var brm = new Base_Product(true))
            {
                if (brm.ShowDialog() == DialogResult.Yes)
                {
                    SetDefaultValue(brm.URow);
                }
            }
        }

        private void biEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(lblTitleMain.lblAutoID.Text))
            {
                var strDate = DllWmsMain.GetPrintLog(_cGuid);
                if (!string.IsNullOrEmpty(strDate))
                {
                    MessageBox.Show(@"已经打印过，不允许修改! 打印时间:" + strDate, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SetControlEnable();//启用所有输入框和保存按钮
            }
            else
            {
                MessageBox.Show(@"未指定单据，请检查后再试!", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void biGiveup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetControlDisable();//取消就是撤消此次修改。
            if (string.IsNullOrEmpty(lblTitleMain.lblAutoID.Text))
            {
                SetPanelVlaue("", "btnLast");
            }
            else
            {
                SetPanelVlaue(lblTitleMain.lblAutoID.Text);
            }
        }


        /// <summary>
        /// 进行数据库数据定位显示
        /// </summary>
        /// <param name="lId"></param>
        /// <param name="llocation"></param>
        public void SetPanelVlaue(string lId, string llocation = "")
        {
            var sqlcmd = new SqlCommand();
            switch (llocation)
            {
                case "btnLast":
                    sqlcmd.CommandText = "select top 1 * from Bar_Product_Box order by AutoID desc";
                    break;
                case "btnFirst":
                    sqlcmd.CommandText = "select top 1 * from Bar_Product_Box order by AutoID";
                    break;
                case "btnPre":
                    if (string.IsNullOrEmpty(lId))
                    {
                        MessageBox.Show(@"已到首页");
                        return;
                    }
                    sqlcmd.CommandText = "select top 1 * from Bar_Product_Box where AutoID<@AutoID order by AutoID desc";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
                case "btnNext":
                    if (string.IsNullOrEmpty(lId))
                    {
                        MessageBox.Show(@"已到末页");
                        return;
                    }
                    sqlcmd.CommandText = "select top 1 * from Bar_Product_Box where AutoID>@AutoID order by AutoID";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
                case "":
                    sqlcmd.CommandText = "select top 1 * from Bar_Product_Box where AutoID=@AutoID";
                    sqlcmd.Parameters.AddWithValue("@AutoID", lId);
                    break;
            }

            using (var con = new SqlConnection(BaseStructure.WmsCon))
            {
                sqlcmd.Connection = con;
                con.Open();
                #region 读取数据库中数据
                using (var dr = sqlcmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        //获取所有取得的数据并显示
                        lblTitleMain.lblAutoID.Text = dr["AutoID"].ToString();
                        lblTitleMain.lblcSerialNumber.Text = dr["cBoxNumber"].ToString();
                        txtcLotNo.Text = dr["cLotNo"].ToString();
                        uneiQuantity.Text = dr["iQuantity"].ToString();
                        if (string.IsNullOrEmpty(dr["dDate"].ToString()))
                        {
                            dtpdDate.Checked = false;
                            dtpdDate.Value = DateTime.Now;
                        }
                        else
                        {
                            dtpdDate.Checked = true;
                            dtpdDate.Value = (DateTime)dr["dDate"];
                        }
                        txtcInvCode.Text = dr["cInvCode"].ToString();
                        utecInvName.Text = dr["cInvName"].ToString();
                        txtcInvPackStd.Text = dr["cInvPackStd"].ToString();

                        txtcInvStd.Text = dr["cInvStd"].ToString();
                        txtcInvPackStyle.Text = dr["cInvPackStyle"].ToString();
                        lblcMassUnit.Text = dr["cMassUnit"].ToString();
                        uneiMassDate.Text = dr["iMassDate"].ToString();
                        txtcKeepRequire.Text = dr["cKeepRequire"].ToString();
                        _cGuid = dr["cGuid"].ToString();
                        txtcMemo.Text = dr["cMemo"].ToString();
                        pageChange.WhereStr = string.Format("cGuid ='{0}'", _cGuid);
                        pageChange.GetRecord();
                    }
                    else
                    {
                        switch (llocation)
                        {
                            case "btnPre":
                                MessageBox.Show(@"已经是首页");
                                break;
                            case "btnNext":
                                MessageBox.Show(@"已经是末页");
                                break;
                            default:
                                MessageBox.Show(@"无记录");
                                //ResetNull();
                                //SetControlDisable();
                                break;
                        }

                    }
                #endregion
                }
            }

        }



        /// <summary>
        /// 判断什么未填写,返回对应的标签
        /// </summary>
        /// <returns></returns>
        private string CheckNull()
        {
            if (string.IsNullOrEmpty(txtcInvCode.Text)||txtcInvCode.Text.Length<7)
                return "产品编码";
            if (string.IsNullOrEmpty(txtcLotNo.Text))
                return "批号";
            if(beiSerialQty.EditValue==null)
                return "列序数";
            return uneiQuantity.Value == null || string.IsNullOrEmpty(uneiQuantity.Value.ToString()) ? "数量" : string.Empty;
        }

        private void biPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void biDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void biPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrinterDone();
        }

        private void biExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void uGridProBoxBarCode_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (e.Cell.Row.Index < 0)
                return;
            if (biSave.Enabled)
            {
                MessageBox.Show(@"在编辑状态下，不允许选择！");
                return;
            }
            SetPanelVlaue(e.Cell.Row.Cells["AutoID"].Value.ToString());
        }

        private void biEditTemplet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var st = new Base_Templet(true, "产成品礼包标签"))
            {
                if (st.ShowDialog() == DialogResult.Yes)
                {
                    biEditTemplet.Caption = st.URow.Cells["cCaption"].Value.ToString();
                    _cCaption = st.URow.Cells["cCaption"].Value.ToString();
                    _cTempletPath = st.URow.Cells["cTempletPath"].Value.ToString();
                    biEditPrinter.Caption = st.URow.Cells["cPrinter"].Value.ToString();
                    _cPrinter = st.URow.Cells["cPrinter"].Value.ToString();
                }
            }
        }


        





    }
}
