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
    public partial class LoadForm : Form
    {

        string path;
        
        
       
        public LoadForm()
        {
            InitializeComponent();
            openFileDialog1.Filter=".ast Files(*.ast)|*.ast"; //Show only  .ast files
            LoadButton.Visible = false;
            Loadlabel.Text = "";
            Filelabel.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.path = openFileDialog1.FileName;
                //MessageBox.Show("File selected");
                LoadButton.Visible = true;
                Filelabel.Text = openFileDialog1.FileName;
                Loadlabel.Text = "Ready to decode!";

            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
           

            if (path == null)
            {
                MessageBox.Show("You must select File!!!");
            }
            else
            {

                try
                {


                    Fichero myFile = new Fichero(path);
                    myFile.readFile();
                    myFile.classifyMessage();
                    Main.main.myListCAT10 = myFile.GetListCAT10();
                    Main.main.myListCAT21 = myFile.GetListCAT21();

                    Loadlabel.Text = "File loaded successfully";


                }
                catch (FormatException)
                {
                    MessageBox.Show("There is an error during process");
                }
            }

            //if (Main.main.myListCAT10.Count != 0 || Main.main.myListCAT21.Count != 0)
            //{
            
            //}
        }





    }
}
