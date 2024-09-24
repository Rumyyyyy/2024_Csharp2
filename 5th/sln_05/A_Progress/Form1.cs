using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Num = 0;
        string OrgStr = "";

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Num > 0)
            {
                Num = 0;
                this.Timer.Enabled=false;
                this.pbStatus.Value = Num;
                this.lblStatus.Text = OrgStr + Num.ToString() + "%";
            }
            else
            {
                this.Timer.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if(Num > 100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = Num;
            this.lblStatus.Text  = OrgStr + Num.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblStatus.Text;
        }
    }
}
