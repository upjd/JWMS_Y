using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMSM
{
    public partial class BaseRoleFunction : Form
    {
        public BaseRoleFunction()
        {
            InitializeComponent();
        }

        ///// <summary>
        ///// 设置GridView中的下拉列表
        ///// </summary>
        //private void SetRoleDropDownList()
        //{
        //    uGridRole_Function.DisplayLayout.ValueLists["roleList"].ValueListItems.Clear();
        //    //对用户管理界面的角色名的下拉列表添加选项
        //    foreach (DataRow dtr in baseDs.BRole.Rows)
        //    {
        //        uGridRole_Function.DisplayLayout.ValueLists["roleList"].ValueListItems.Add(dtr["cCode"].ToString(), dtr["cName"].ToString());
        //    }
        //    uGridRole_Function.DisplayLayout.Bands[0].Columns["rCode"].ValueList = uGridRole_Function.DisplayLayout.ValueLists["roleList"];
        //}

        /// <summary>
        /// 设置GridView中的下拉列表
        /// </summary>
        private void SetFunctionDropDownList()
        {
            uGridRole_Function.DisplayLayout.ValueLists["functionList"].ValueListItems.Clear();
            //对用户管理界面的角色名的下拉列表添加选项
            foreach (DataRow dtr in baseDs.BFunction.Rows.Cast<DataRow>().Where(dtr => dtr.RowState != DataRowState.Deleted))
            {
                uGridRole_Function.DisplayLayout.ValueLists["functionList"].ValueListItems.Add(dtr["cFunction"].ToString(), dtr["cFunction"].ToString());
            }
            uGridRole_Function.DisplayLayout.Bands[0].Columns["fCode"].ValueList = uGridRole_Function.DisplayLayout.ValueLists["functionList"];
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (uGridRole_Function.ActiveRow == null)
                return;
            if (MessageBox.Show(@"确定删除吗？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uGridRole_Function.ActiveRow.Delete(false);
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveRoleFunctionData();
        }
        /// <summary>
        /// 保存功能角色对应档案资料
        /// </summary>
        private void SaveRoleFunctionData()
        {
            var btemp = false;
            foreach (DataRow dtr in baseDs.BRoleFunction.Rows.Cast<DataRow>().Where(dtr => dtr.RowState != DataRowState.Deleted))
            {
                if (string.IsNullOrEmpty(dtr["rCode"].ToString()) || string.IsNullOrEmpty(dtr["fCode"].ToString()))
                {
                    btemp = true;
                    break;
                }
                for (var i = 0; i < baseDs.BRoleFunction.Rows.Count; i++)
                {
                    if (baseDs.BRoleFunction.Rows[i].RowState == DataRowState.Deleted)
                        continue;
                    if (!baseDs.BRoleFunction.Rows[i]["rCode"].ToString().Equals(dtr["rCode"].ToString()) ||
                        !baseDs.BRoleFunction.Rows[i]["fCode"].ToString().Equals(dtr["fCode"].ToString()) ||
                        baseDs.BRoleFunction.Rows[i] == dtr) continue;
                    MessageBox.Show(@"角色名和功能不能同时重复", @"错误，请检查后再提交", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (btemp)
            {
                MessageBox.Show(@"角色名和功能必填？", @"未填写完全，请检查？", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    uGridRole_Function.UpdateData();
                    roleFunctionTableAdapter.Update(baseDs.BRoleFunction);
                    MessageBox.Show(@"操作成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"发生异常：" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }



        private void tsbFDelete_Click(object sender, EventArgs e)
        {
            if (uGridFunction.ActiveRow == null)
                return;
            if (MessageBox.Show(@"确定删除吗？", @"确定删除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uGridFunction.ActiveRow.Delete(false);
            }
        }

        private void tsbFunctionManager_Click(object sender, EventArgs e)
        {
            uSplitterRight.Collapsed = !uSplitterRight.Collapsed;
        }

        private void BaseRoleFunction_Load(object sender, EventArgs e)
        {

            uGridRole_Function.DisplayLayout.ValueLists.Add("roleList");
            uGridRole_Function.DisplayLayout.ValueLists.Add("functionList");
            //设置连接并载入数据
            roleFunctionTableAdapter.Connection.ConnectionString = MaLogin.WmsCon;
            bFunctionTableAdapter.Connection.ConnectionString = MaLogin.WmsCon;
            bRoleTableAdapter.Connection.ConnectionString = MaLogin.WmsCon;
            bFunctionTableAdapter.Fill(baseDs.BFunction);
            bRoleTableAdapter.Fill(baseDs.BRole);

            SetFunctionDropDownList();
            //SetRoleDropDownList();
        }


        private void tsbFSave_Click(object sender, EventArgs e)
        {
            SaveFunctionData();
            bFunctionTableAdapter.Fill(baseDs.BFunction);
            SetFunctionDropDownList();
        }
        /// <summary>
        /// 保存功能档案资料
        /// </summary>
        private void SaveFunctionData()
        {
            var btemp = baseDs.BFunction.Rows.Cast<DataRow>().Where(dtr => dtr.RowState != DataRowState.Deleted).Any(dtr => string.IsNullOrEmpty(dtr["cFunction"].ToString()));
            if (btemp)
            {
                MessageBox.Show(@"功能名必输", @"未填写完全，请检查？", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    uGridFunction.UpdateData();
                    bFunctionTableAdapter.Update(baseDs.BFunction);
                    MessageBox.Show(@"操作成功", @"成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"发生异常：" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }



        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bFunctionTableAdapter.Fill(baseDs.BFunction);
        }

        private void uGridRole_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            var cCode = e.Cell.Row.Cells["cCode"].Value.ToString();
            using (var con = new SqlConnection(MaLogin.WmsCon))
            {
                using (var cmd = new SqlCommand("GenRoleFunction",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rCode", cCode);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            roleFunctionTableAdapter.Fill(baseDs.BRoleFunction, cCode);
            
            
        }
    }
}
