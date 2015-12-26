using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialDebug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(50);
                int bytes = serialPort1.BytesToRead;
                byte[] buffer = new byte[bytes];

                serialPort1.Read(buffer, 0, bytes);
                string strbuffer = Encoding.ASCII.GetString(buffer);
                string romovestartchar = strbuffer.Substring(2);

                textBox1.Text = textBox1.Text + strbuffer + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            


        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
        }
    }
}
