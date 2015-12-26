using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using LabelManager2;
using UDLB;
using Application = System.Windows.Forms.Application;

namespace WMSM
{
    public partial class BaseUser : Form
    {
        /// <summary>
        /// 判断是否允许关闭
        /// </summary>
        bool _bclose;


        /// <summary>
        /// 打印机
        /// </summary>
        private string _cPrinter;

        public BaseUser()
        {
            InitializeComponent();
            //增加一个按键动作映射，当敲击回车时，提交修改
                uGridUser.KeyActionMappings.Add(new GridKeyActionMapping(
                Keys.Enter,                       // 按下回车键时
                UltraGridAction.CommitRow,         // 提交修改
                UltraGridState.IsCheckbox,        // 单元格不能为checkbox
                UltraGridState.Cell,              // 选中单元格时
                0,                                // 不禁止特殊键
                0                                 // 不需要特殊键
            ));
                //增加一个按键动作映射，当敲击回车时，提交修改
                uGridRole.KeyActionMappings.Add(new GridKeyActionMapping(
                Keys.Enter,                       // 按下回车键时
                UltraGridAction.CommitRow,         // 提交修改
                UltraGridState.IsCheckbox,        // 单元格不能为checkbox
                UltraGridState.Cell,              // 选中单元格时
                0,                                // 不禁止特殊键
                0                                 // 不需要特殊键
            ));
        }

        /// <summary>
        /// 设置GridView中的下拉列表
        /// </summary>
        private void SetRoleDropDownList()
        {
            uGridUser.DisplayLayout.ValueLists["roleList"].ValueListItems.Clear();
            //对用户管理界面的角色名的下拉列表添加选项
            foreach (DataRow dtr in baseDs.BRole.Rows)
            {
                uGridUser.DisplayLayout.ValueLists["roleList"].ValueListItems.Add(dtr["cCode"].ToString(), dtr["cName"].ToString());
            }
            uGridUser.DisplayLayout.Bands[0].Columns["Urole"].ValueList = uGridUser.DisplayLayout.ValueLists["roleList"];

            
            //uGridUser.DisplayLayout.ValueLists["DepartList"].ValueListItems.Clear();
            ////对用户管理界面的角色名的下拉列表添加选项
            //foreach (DataRow dtr in dtDepart)
            //{
            //    uGridUser.DisplayLayout.ValueLists["DepartList"].ValueListItems.Add(dtr["cDepCode"].ToString(), dtr["cDepName"].ToString());
            //}
            //uGridUser.DisplayLayout.Bands[0].Columns["uDepartment"].ValueList = uGridUser.DisplayLayout.ValueLists["DepartList"];
        }

        private void BaseUser_Load(object sender, EventArgs e)
        {
            uGridUser.DisplayLayout.ValueLists.Add("roleList");
            uGridUser.DisplayLayout.ValueLists.Add("DepartList");
            //加载数据库账套连接
            bUserTableAdapter.Connection.ConnectionString = MaLogin.WmsCon;
            bRoleTableAdapter.Connection.ConnectionString = MaLogin.WmsCon;
            //加载数据
            bRoleTableAdapter.Fill(baseDs.BRole);
            bUserTableAdapter.Fill(baseDs.BUser);
            SetRoleDropDownList();

            GetTemplet("产成品标签", ref _cPrinter);
        }

        /// <summary>
        /// 获取当前界面的设置的默认打印机与默认打印模版
        /// </summary>
        /// <param name="cFunction">当前的界面</param>
        /// <param name="cCaption">打印模版标题</param>
        /// <param name="cPrinter">打印机</param>
        /// <param name="cTempletPath">打印模版的路径</param>
        public static void GetTemplet(string cFunction , ref string cPrinter)
        {
            var cmd = new SqlCommand("select * from [dbo].[BTempletList] where cFunction =@cFunction and bDefault=1");
            cmd.Parameters.AddWithValue("@cFunction", cFunction);
            var wf = new WmsFunction(MaLogin.WmsCon);
            var dt = wf.GetSqlTable(cmd);
            if (dt != null && dt.Rows.Count > 0)
            {
                cPrinter = dt.Rows[0]["cPrinter"].ToString();
            }
        }


        private void tsbRoleManager_Click(object sender, EventArgs e)
        {
            uSplitterRight.Collapsed = !uSplitterRight.Collapsed;
        }

        private void tsbRsave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveRoleData();
                SetRoleDropDownList();
                MessageBox.Show(@"操作成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"发生异常：" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveUserData();
        }

        private void BaseUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_bclose)
            {
                return;
            }
            if (!baseDs.HasChanges()) return;
            if (MessageBox.Show(@"数据有修改是否保存此次修改？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SaveUserData();
            }
        }

        /// <summary>
        /// 执行保存用户数据
        /// </summary>
        private void SaveUserData()
        {
            var btemp = baseDs.BUser.Rows.Cast<DataRow>().Where(dtr => dtr.RowState != DataRowState.Deleted).Any(dtr => string.IsNullOrEmpty(dtr["uCode"].ToString()) || string.IsNullOrEmpty(dtr["uName"].ToString()));
            if (btemp)
            {
                MessageBox.Show(@"用户名和密码必输!", @"未填写完全，请检查？", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    uGridUser.UpdateData();
                    bUserTableAdapter.Update(baseDs.BUser);
                    MessageBox.Show(@"操作成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"发生异常：" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        /// <summary>
        /// 执行保存角色数据
        /// </summary>
        private void SaveRoleData()
        {
            var btemp = baseDs.BRole.Rows.Cast<DataRow>().Where(dtr => dtr.RowState != DataRowState.Deleted).Any(dtr => string.IsNullOrEmpty(dtr["cCode"].ToString()) || string.IsNullOrEmpty(dtr["cName"].ToString()));
            if (btemp)
            {
                MessageBox.Show(@"角色名,角色号必输", @"未填写完全，请检查？", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                uGridRole.UpdateData();
                bRoleTableAdapter.Update(baseDs.BRole);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            _bclose = true;
            if (baseDs.HasChanges())
            {
                if (MessageBox.Show(@"数据有修改是否保存此次修改？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveUserData();
                }
            }
            Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (uGridUser.ActiveRow == null)
                return;
            if (MessageBox.Show(@"确定删除吗？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uGridUser.ActiveRow.Delete(false);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            bRoleTableAdapter.Fill(baseDs.BRole);
            bUserTableAdapter.Fill(baseDs.BUser);
            SetRoleDropDownList();
        }

        private void tsbRdelete_Click(object sender, EventArgs e)
        {
            if (uGridRole.ActiveRow == null)
                return;
            if (MessageBox.Show(@"确定删除吗？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uGridRole.ActiveRow.Delete(false);
            }
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            uGridUser.UpdateData();
            var dt = new BaseDs().BUser;
            foreach (var uRow in uGridUser.Rows.GetFilteredInNonGroupByRows())
            {
                if ((bool)uRow.Cells["bSelect"].Value)
                {
                    var dr = dt.NewBUserRow();
                    dr.uCode = uRow.Cells["uCode"].Value.ToString();
                    dr.uName = uRow.Cells["uName"].Value.ToString();
                    dt.Rows.Add(dr);
                }
            }

            PrintUserCodeSoft(dt, "cUserLab.Lab", _cPrinter);
        }

        /// <summary>
        /// 产成品批量打印用CodeSoft
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="cTempletName"></param>
        /// <param name="cPrinter"></param>
        public static void PrintUserCodeSoft(DataTable dt, string cTempletName, string cPrinter)
        {

            var lbl = new ApplicationClass();
            var cTempletPath = string.Format("{0}\\Lab\\{1}", Application.StartupPath, cTempletName);
            try
            {
                if (!File.Exists(cTempletPath))
                {
                    MessageBox.Show(@"当前路径下的打印模版文件不存在!", @"异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl.Quit();
                    return;
                }
                lbl.Documents.Open(cTempletPath, false); //调用设好的lbl标签
                var doc = lbl.ActiveDocument;
                if (doc.Variables.FormVariables.Count < 2)
                {
                    MessageBox.Show(@"打印模版参数不正确");
                    lbl.Quit();
                    return;
                }

                doc.Printer.SwitchTo(cPrinter);
                doc.Printer.Name = cPrinter;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //codesoft模板中标签变量
                        doc.Variables.FormVariables.Item("var0").Value = dr["uCode"].ToString();
                        doc.Variables.FormVariables.Item("var1").Value = dr["uName"].ToString();
                        //  doc.PrintDocument(3);
                        doc.PrintLabel(1, 1, 1, 1, doc.Format.RowCount - 1, "");
                    }
                    //标签批量连续打印。FormFeed（）必须等参数变量输出后才执行，输出给打印机。
                    doc.FormFeed();
                    lbl.Documents.CloseAll(false);
                    lbl.Quit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void uGridUser_ClickCellButton(object sender, CellEventArgs e)
        {
            var sqlstr = "update BUser set uPassword=@uPwd where uCode=@uName";
            var con = new SqlConnection(MaLogin.WmsCon);
            var cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@uName", e.Cell.Value);
            cmd.Parameters.AddWithValue("@uPwd", WmsFunction.GetMd5Hash("123456"));
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"发生异常" + ex.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmd.ExecuteNonQuery() < 1)
            {
                MessageBox.Show(@"重置失败", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(@"重置成功", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

    }
}
