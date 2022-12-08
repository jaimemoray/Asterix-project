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
        DataTable PIdt = new DataTable();
        public MOPForm()
        {
            InitializeComponent();
        }

        private void MOPForm_Load(object sender, EventArgs e)
        {
            PIdt.Columns.Add("Track Number");
            PIdt.Columns.Add("Probability of Identification");
            List<double[]> PIList = ProbIdentification();


            for (int i = 0; i < PIList.Count; i++)
            {
                DataRow row = PIdt.NewRow();
                row["Track Number"] = PIList[i][0];
                row["Probability of Identification"] = PIList[i][1];

                PIdt.Rows.Add(row);
            }
            probIdentdataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            probIdentdataGrid.ReadOnly = true;
            probIdentdataGrid.RowHeadersVisible = false;
            probIdentdataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            probIdentdataGrid.DataSource = PIdt;
        }

        private List<double[]> ProbIdentification()
        {
            // Prob Identificación: Para identificar un mensaje con un ICAO Address incorrecto utilizaremos el campo “Track Number”. A cada blanco se le asigna un numero de pista(Track
            // number) independientemente de su ICAO Address y lo conserva durante todo el recorrido dentro del rango de la antena. Este número de pista no se asigna
            // según el identificador del vehículo, sino por su posición relativa a la anterior posición.Este número nos permite compara todos los ICAO Address de un
            //mismo número de pista y ver si para un mismo número de pista hay algún ICAO Address diferente al resto(erróneo).
            //Eurocontrol define en las especificaciones ASTERIX el item Track Number como: “Valor entero que representa una referencia única a una trayectoria
            //dentro de un mismo fichero. Nos basamos en eso para suponer que no hay dos aviones a lo largo de la grabación con un Track Number igual, lo cual daría como resultado un gran
            //error en los cálculos del código. Aún así esto no es del todo cierto, ya que la asignación de Track Number depende del fabricante del MLAT.Podría asignarse un número nuevo a cada
            //objetivo hasta llegar al valor máximo y volver a empezar en 0, o podrían reasignarse los números de pista que vayan quedando libres.En LEBL, para un muestreo de unos 100.000 paquetes este
            //hecho no supone un problema. EUROCAE no especifica en que zonas se requiere este mínimo, por lo que se aplica a todo el tráfico y se desglosa de igual manera que en Update Rate.
            //Los casos totales son el número de paquetes que contienen Track Number, y los casos correctos son aquellos en que ICAO Address es el mismo que la
            //mayoría de ICAO Address que se encuentran junto a ese Track Number.

            List<double[]> allProbIdent = new List<double[]>();

            List<CAT10> allAircrafts = Main.main.myListCAT10.FindAll(p => p.SIC == 107 && p.TOT == "Aircraft");
            

            while (allAircrafts.Count != 0)
            {
                double correctTI = 0;
                int id = allAircrafts[0].trackNumber;
                string ta= allAircrafts[0].targetAddress;

                List<CAT10> myFlight = allAircrafts.FindAll(p=>p.trackNumber==id);

                for (int i=0;i<myFlight.Count;i++)
                {
                    if (myFlight[i].targetAddress==ta)
                    {
                        correctTI++;
                    }
                }
                double PI= correctTI / myFlight.Count;
                allProbIdent.Add(new double[] {id,PI});
                allAircrafts.RemoveAll(p => p.trackNumber== id);
            }

            return allProbIdent;
        }
    }
}
