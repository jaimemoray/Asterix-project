﻿using System;
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
        Form currentForm = null;
        List<CAT10> myListCAT10=new List<CAT10>();
        List<CAT21> myListCAT21=new List<CAT21>();
       
        public Main()
        {
            InitializeComponent();
            subDataPanel.Visible = false; //Invisible subpanel
        }

  

 


        //private void OpenChildForm(Form childForm) //Open adapted form in panel 
        //{
        //    if (currentForm != null)
        //    {
        //        currentForm.Close();
        //    }

        //    currentForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
            
        //}


        private void LoadButton_Click(object sender, EventArgs e)
        {
            myListCAT10.Clear();
            myListCAT21.Clear();
            subDataPanel.Visible = false;
            LoadForm LF = new LoadForm();
            LF.ShowDialog();
            myListCAT10=LF.GetCAT10();
            myListCAT21=LF.GetCAT21();
            




        }

        private void Databutton_Click(object sender, EventArgs e)
        {
            subDataPanel.Visible = subDataPanel.Visible == false ?  true : false;
        }

        private void CAT10button_Click(object sender, EventArgs e)
        {
            DataForm DF10 = new DataForm(myListCAT10);
            DF10.ShowDialog();
        }

        private void CAT21button_Click(object sender, EventArgs e)
        {
            DataForm DF21 = new DataForm(myListCAT21);
            DF21.ShowDialog();
        }
    }
}