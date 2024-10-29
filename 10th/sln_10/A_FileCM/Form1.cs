using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A_FileCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string FileSrc = "";
        string FileDest = "";

        private void btnSrc_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvSrc.Items.Clear();
                this.txtSrc.Text = this.fbdFolder.SelectedPath;
                FileSrc = this.fbdFolder.SelectedPath;

                DirectoryInfo di = new DirectoryInfo(this.txtSrc.Text);
                foreach (var fs in di.GetFiles()) 
                {
                    this.lvSrc.Items.Add(new ListViewItem(new string[] { fs.Name })); 
                }
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK) 
            {
                this.lvDest.Items.Clear();
                this.txtDest.Text = this.fbdFolder.SelectedPath;
                FileDest = this.fbdFolder.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(FileDest);
                foreach (var fs in di.GetFiles()) {

                    this.lvDest.Items.Add(new ListViewItem(new string[] { fs.Name })); 
                } 
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
