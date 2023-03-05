using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_HW1_T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo("notepad.exe");
        }

        public void BtnStart_Click(object sender, EventArgs e)
        {
            Service.StartMyProcess(myProcess);
            btnStarnWait.Enabled = false;
            btnStop.Enabled = true;
        }

        public void BtnStarnWait_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Service.StartMyProcessAndWait(myProcess);
            Close();
        }

        public void BtnStop_Click(object sender, EventArgs e)
        {
            myProcess.CloseMainWindow();
            myProcess.Close();
            this.Close();
        }
    }
}
