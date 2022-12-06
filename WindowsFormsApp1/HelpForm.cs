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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void buttonStep1_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = System.Drawing.Image.FromFile("Step1.png");
        }

        private void buttonStep2_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = System.Drawing.Image.FromFile("Step2.png");
        }

        private void buttonStep3_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = System.Drawing.Image.FromFile("Step3.png");
        }

        private void buttonStep4_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = System.Drawing.Image.FromFile("Step4.png");
        }

        private void buttonStep5_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = System.Drawing.Image.FromFile("Step5.png");
        }
    }
}
