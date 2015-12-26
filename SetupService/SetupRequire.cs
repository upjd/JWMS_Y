using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LabelManager2;

namespace SetupService
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckCodeSoft();
        }

        private void CheckCodeSoft()
        {
            try
            {
                var lbl = new ApplicationClass();
                lbl.Documents.Open(System.Windows.Forms.Application.StartupPath + @"\1.Lab"); // 调用设计好的label文件
                var doc = lbl.ActiveDocument;
                lbl.Quit();
                var dPath = txtCodeSoftPath.Text + @"\CsUtil.dll";
                var sPath = System.Windows.Forms.Application.StartupPath + @"\CsUtil.dll";
                if (File.Exists(dPath))
                {
                    File.Delete(dPath);
                    File.Move(sPath,dPath);
                }
                else
                {
                    MessageBox.Show(@"CodeSoft未安装在默认路径，请修改");
                    return;
                }
                btnCodeSoft.Text = @"OK";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnCodeSoft.Text = @"NG";
                MessageBox.Show(@"未安装CodeSoft,请先安装CodeSoft");
                var cPath= System.Windows.Forms.Application.StartupPath + @"\setup.exe";
                System.Diagnostics.Process.Start(cPath);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (btnCodeSoft.Text.Equals("OK"))
                System.Windows.Forms.Application.Exit();
        }

        private void btnCodeSoft_Click(object sender, EventArgs e)
        {
            if (ofCodeSoft.ShowDialog() == DialogResult.OK)
            {
                txtCodeSoftPath.Text = Path.GetDirectoryName(ofCodeSoft.FileName);
            }
        }
    }
}
