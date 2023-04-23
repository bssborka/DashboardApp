using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

   

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            prbCPU.Value = (int)fcpu;
            prbCPU.Text = string.Format("{0:0} %", fcpu);

            float dram = RAM.NextValue();
            //prbRAM.Value = (int)dram;
            prbRAM.Text = string.Format("{0:0} MB", dram);
        }
    }
}
