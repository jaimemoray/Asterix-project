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
    public partial class MOPForm : Form
    {
        
        public MOPForm()
        {
            InitializeComponent();
        }

        private void MOPForm_Load(object sender, EventArgs e)
        {
            ProbIdentlabel.Text = Convert.ToString(ProbIdentification());

        }

        private double ProbIdentification()
        {
            //Prob Identificación: Se trata de observar si el target identificator de cada
            //tráfico detectado por la mlat es el mismo durante toda la cadena desde tiempo
            //inicial al tiempo final

            List<CAT10> allAircrafts = Main.main.myListCAT10.FindAll(p => p.SIC == 107 && p.TOT == "Aircraft");
            List<double> allProbIdent = new List<double>();

            while (allAircrafts.Count != 0)
            {
                double correctTI = 0;
                string id = allAircrafts[0].targetAddress;
                string ti= allAircrafts[0].targetIdentification;

                List<CAT10> myFlight = allAircrafts.FindAll(p=>p.targetAddress==id);

                for (int i=0;i<myFlight.Count;i++)
                {
                    if (myFlight[i].targetIdentification==ti)
                    {
                        correctTI++;
                    }
                }
                double PI= correctTI / myFlight.Count;
                allProbIdent.Add(PI);
                allAircrafts.RemoveAll(p => p.targetAddress == id);
            }

            double sum=0;

            for(int i = 0; i < allProbIdent.Count; i++)
            {
                sum = sum + allProbIdent[i];
            }

            
            return sum / allProbIdent.Count;
        }
    }
}
