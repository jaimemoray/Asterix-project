//----------------------------------------------------------------ASTERIX INSPECTOR CODE-----------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DECODEclass;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public static Main main;
        public List<CAT10> myListCAT10=new List<CAT10>();
        public List<CAT21> myListCAT21=new List<CAT21>();
        Form currentForm;
       
       
        public Main()
        {
            InitializeComponent();
            main = this;
            subDataPanel.Visible = false; //Invisible subpanel
        }



        private void openChildForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            if (panelChildForm.Controls.Count > 0)
            {
                panelChildForm.Controls.RemoveAt(0);
            }
            currentForm = form;
            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(f);
            panelChildForm.Tag = f;
           
            f.Show();
        }


        private void LoadButton_Click(object sender, EventArgs e)
        {

            subDataPanel.Visible = false;
            myListCAT10.Clear();
            myListCAT21.Clear();
            LoadForm LF = new LoadForm();
            openChildForm(LF);
            //LF.ShowDialog();
            //myListCAT10=LF.GetCAT10();
            //myListCAT21=LF.GetCAT21();
            




        }

        private void Databutton_Click(object sender, EventArgs e)
        {
            subDataPanel.Visible = subDataPanel.Visible == false ?  true : false;
        }

        private void CAT10button_Click(object sender, EventArgs e)
        {
            if (myListCAT10.Count!=0)
            {
                DataForm DF10 = new DataForm(0);
                openChildForm(DF10);
            }
            else
            {
                MessageBox.Show("you must load file with CAT10");
            }
            //DF10.ShowDialog();
        }

        private void CAT21button_Click(object sender, EventArgs e)
        {
            if (myListCAT21.Count != 0)
            {
                DataForm DF21 = new DataForm(1);
            openChildForm(DF21);
            }
            else
            {
                MessageBox.Show("you must load file with CAT21");
            }
        }

        private void simulationButton_Click(object sender, EventArgs e)
        {
            if (myListCAT10.Count>0 || myListCAT21.Count>0)
            {
                Simulation MapView = new Simulation();
                openChildForm(MapView);
            }
            else
            {
                MessageBox.Show("Must be loaded file!");
            }

        }


    }
}