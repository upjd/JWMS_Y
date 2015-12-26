using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace JWMSY.UpjdControl
{
    /// <summary>
    /// 标题栏自定义控件
    /// </summary>
    public partial class lblTitle : UserControl
    {
        /// <summary>
        /// 标题名
        /// </summary>
        public string CTitle { get; set; }

        /// <summary>
        /// 标题栏自定义控制的存储过程
        /// </summary>
        public lblTitle()
        {
            InitializeComponent();
            
        }

        private void lblTitle_Resize(object sender, EventArgs e)
        {
            //重新设置Label显示的位置
            lText.Location = new Point(Convert.ToInt32(Width - lText.Width) / 2,
Convert.ToInt32(Height - lText.Height) / 2);
        }

        private void lblTitle_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CTitle))
            {
                if (Parent != null) lText.Text = Parent.Text;
            }
            else
            {
                lText.Text = CTitle;
            }
            
        }
    }
}
