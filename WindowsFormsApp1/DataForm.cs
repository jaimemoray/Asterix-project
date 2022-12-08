using DECODEclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class DataForm : Form
    {
        //List<CAT10> l10 = new List<CAT10>();
        List<CAT10> FilterL10 = new List<CAT10>();
        List<CAT21> FilterL21 = new List<CAT21>();
        //List<CAT21> l21 = new List<CAT21>();
        bool filter = false;
        int rowMess;
        int flag;
        
        public DataForm()
        {
            InitializeComponent();

        }
        public DataForm(int f)
        {
            InitializeComponent();
            
            flag = f;
        }


        private void CreateDataGridView()
        {
            messagedataGrid.Rows.Clear();


            switch (flag)
            {

                case 0:
                            messagedataGrid.RowCount = Main.main.myListCAT10.Count; //Tendremos tantas filas como mensajes haya en nuestra lista


                            for (int i = 0; i < Main.main.myListCAT10.Count; i++)
                            {
                                Main.main.myListCAT10[i].id = i;
                                messagedataGrid.Rows[i].Cells[0].Value = i;
                                messagedataGrid.Rows[i].Cells[1].Value = 10;
                                messagedataGrid.Rows[i].Cells[2].Value = Main.main.myListCAT10[i].convert2TimeOfDay(Main.main.myListCAT10[i].TimeOfDay);
                                messagedataGrid.Rows[i].Cells[3].Value = Main.main.myListCAT10[i].GetLength();
                                messagedataGrid.Rows[i].Cells[4].Value = Main.main.myListCAT10[i].GetItemList().Count;

                                
                            }                   
 
                   
                    break;


                case 1:

                    messagedataGrid.RowCount = Main.main.myListCAT21.Count; //Tendremos tantas filas como mensajes haya en nuestra lista

                    for (int i = 0; i < Main.main.myListCAT21.Count; i++)
                    {
                        Main.main.myListCAT21[i].id = i;
                        messagedataGrid.Rows[i].Cells[0].Value = i;
                        messagedataGrid.Rows[i].Cells[1].Value = 21;
                        messagedataGrid.Rows[i].Cells[2].Value = " ";
                        messagedataGrid.Rows[i].Cells[3].Value = Main.main.myListCAT21[i].GetLength();
                        messagedataGrid.Rows[i].Cells[4].Value = Main.main.myListCAT21[i].GetItemList().Count;


                    }
                    break;

            }
           



            //
            dataItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataItemsGridView.ReadOnly = true;
            dataItemsGridView.RowHeadersVisible = false;
            dataItemsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataItemsGridView.ColumnCount = 3;
            dataItemsGridView.Columns[0].HeaderText = "FRN";
            dataItemsGridView.Columns[1].HeaderText = "Data Field";
            dataItemsGridView.Columns[2].HeaderText = "Description";
        }
        private void DataForm_Load(object sender, EventArgs e)
        {
            messagedataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            messagedataGrid.ReadOnly = true;
            messagedataGrid.RowHeadersVisible = false;
            messagedataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            messagedataGrid.ColumnCount = 5; //ID, CAT, TIME,Length
            messagedataGrid.Columns[0].HeaderText = "ID";
            messagedataGrid.Columns[1].HeaderText = "CAT";
            messagedataGrid.Columns[2].HeaderText = "Time of Day";
            messagedataGrid.Columns[3].HeaderText = "Length";
            messagedataGrid.Columns[4].HeaderText = "Data Items";
            
            CreateDataGridView();



            switch (flag)
            {
                case 0:
                    comboBoxFilter.Items.Add("MESSAGE TYPE");
                    comboBoxFilter.Items.Add("TARGET IDENTIFICATION");
                    comboBoxFilter.Items.Add("TRACK NUMBER");
                    comboBoxFilter.Items.Add("TARGET ADDRESS");
                    break;
                case 1:
                    comboBoxFilter.Items.Add("TARGET IDENTIFICATION");
                    comboBoxFilter.Items.Add("TRACK NUMBER");
                    comboBoxFilter.Items.Add("TARGET ADDRESS");
                    break;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }














        private void csvbutton_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv" };
            List<string> rows = new List<string>();
            string SEP = ";";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (flag)
                {
                    case 0:

                        string[] header10 = new string[66];
                        

                        
                        
                        header10[0] = "ID";
                        header10[1] = "CAT";
                        header10[2] = "[Data Source Identifier] SAC";
                        header10[3] = "[Data Source Identifier] SIC";
                        header10[4] = "[Message Type] ";
                        header10[5] = "[Target Report Descriptor] TYP";
                        header10[6] = "[Target Report Descriptor] DCR";
                        header10[7] = "[Target Report Descriptor] CHN";
                        header10[8] = "[Target Report Descriptor] GBS";
                        header10[9] = "[Target Report Descriptor] CRT";
                        header10[10] = "[Target Report Descriptor] SIM";
                        header10[11] = "[Target Report Descriptor] TST";
                        header10[12] = "[Target Report Descriptor] RAB";
                        header10[13] = "[Target Report Descriptor] LOP";
                        header10[14] = "[Target Report Descriptor] TOT";
                        header10[15] = "[Target Report Descriptor] SPI";
                        header10[16] = "[Time of day]";
                        header10[17] = "[WGS-84 Coordinates] Latitude (º)";
                        header10[18] = "[WGS-84 Coordinates] Longitude (º)";
                        header10[19] = "[Measured Position in Polar Coordinates] RHO (m)";
                        header10[20] = "[Measured Position in Polar Coordinates] THETA (º)";
                        header10[21] = "[Measured Position in Cartesian Coordinates] x (m)";
                        header10[22] = "[Measured Position in Cartesian Coordinates] y (m)";
                        header10[23] = "[Track Velocity in Polar Coordinates] Ground Speed (kt)";
                        header10[24] = "[Track Velocity in Polar Coordinates] Track Angle (º)";
                        header10[25] = "[Track Velocity in Cartesian Coordinates] Vx (m/s)";
                        header10[26] = "[Track Velocity in Cartesian Coordinates] Vy (m/s)";
                        header10[27] = "[Track Number]";
                        header10[28] = "[Track Status] CNF";
                        header10[29] = "[Track Status] TRE";
                        header10[30] = "[Track Status] CST";
                        header10[31] = "[Track Status] MAH";
                        header10[32] = "[Track Status] TCC";
                        header10[33] = "[Track Status] STH";
                        header10[34] = "[Track Status] TOM";
                        header10[35] = "[Track Status] DOU";
                        header10[36] = "[Track Status] MRS";
                        header10[37] = "[Track Status] GHO";
                        header10[38] = "[Mode 3/A in Octal Representation] V";
                        header10[39] = "[Mode 3/A in Octal Representation] G";
                        header10[40] = "[Mode 3/A in Octal Representation] L";
                        header10[41] = "[Mode 3/A in Octal Representation] Mode 3/A";
                        header10[42] = "[Target Address]";
                        header10[43] = "[Target Identification] STI";
                        header10[44] = "[Target Identification]";
                        header10[45] = "[Vehicle Fleet Identification]";
                        header10[46] = "[Flight Level in Binary Representation] V";
                        header10[47] = "[Flight Level in Binary Representation] G";
                        header10[48] = "[Flight Level in Binary Representation] Flight Level";
                        header10[49] = "[Measured Height] (ft)";
                        header10[50] = "[Target Size and Orientation] Target Length (m)";
                        header10[51] = "[Target Size and Orientation] Target Orientation (º)";
                        header10[52] = "[Target Size and Orientation] Target Width (m)";
                        header10[53] = "[System Status] NOGO";
                        header10[54] = "[System Status] OVL";
                        header10[55] = "[System Status] TSV";
                        header10[56] = "[System Status] DIV";
                        header10[57] = "[System Status] TTF";
                        header10[58] = "[Pre-programmed Message] TRB";
                        header10[59] = "[Pre-programmed Message] MSG";
                        header10[60] = "[Standard Deviation of Position] sigmaX (m)";
                        header10[61] = "[Standard Deviation of Position] sigmaY (m)";
                        header10[62] = "[Standard Deviation of Position] sigmaXY (m^2)";
                        header10[63] = "[Amplitude of Primary Plot]";
                        header10[64] = "[Calculated Acceleration] Ax (m/(s^2))";
                        header10[65] = "[Calculated Acceleration] Ay (m/(s^2))";


                        rows.Add(string.Join(SEP,header10));







                        for (int i = 0; i < Main.main.myListCAT10.Count; i++)
                        {
                            string[] mess10 = new string[65];
                            mess10[0] = i.ToString();
                            mess10[1] = 10.ToString();
                            mess10[2] = Main.main.myListCAT10[i].SAC.ToString();
                            mess10[3] = Main.main.myListCAT10[i].SIC.ToString();
                            mess10[4] = Main.main.myListCAT10[i].MessageType.ToString();
                            mess10[5] = Main.main.myListCAT10[i].TYP.ToString();
                            mess10[6] = Main.main.myListCAT10[i].DCR.ToString();
                            mess10[7] = Main.main.myListCAT10[i].CHN.ToString();
                            mess10[8] = Main.main.myListCAT10[i].GBS.ToString();
                            mess10[9] = Main.main.myListCAT10[i].CRT.ToString();
                            mess10[10] = Main.main.myListCAT10[i].SIM.ToString();
                            mess10[11] = Main.main.myListCAT10[i].TST.ToString();
                            mess10[12] = Main.main.myListCAT10[i].RAB.ToString();
                            mess10[13] = Main.main.myListCAT10[i].LOP.ToString();
                            mess10[14] = Main.main.myListCAT10[i].TOT.ToString();
                            mess10[15] = Main.main.myListCAT10[i].SPI.ToString();
                            mess10[16] = TimeSpan.FromSeconds(Main.main.myListCAT10[i].TimeOfDay).ToString(@"hh\:mm\:ss").ToString();
                            mess10[17] = Main.main.myListCAT10[i].latitude.ToString();
                            mess10[18] = Main.main.myListCAT10[i].longitude.ToString();
                            mess10[19] = Main.main.myListCAT10[i].rho.ToString();
                            mess10[20] = Main.main.myListCAT10[i].theta.ToString();
                            mess10[21] = Main.main.myListCAT10[i].x.ToString();
                            mess10[22] = Main.main.myListCAT10[i].y.ToString();
                            mess10[23] = Main.main.myListCAT10[i].groundSpeed.ToString();
                            mess10[24] = Main.main.myListCAT10[i].trackAngle.ToString();
                            mess10[25] = Main.main.myListCAT10[i].Vx.ToString();
                            mess10[26] = Main.main.myListCAT10[i].Vy.ToString();
                            mess10[27] = Main.main.myListCAT10[i].trackNumber.ToString();
                            mess10[28] = Main.main.myListCAT10[i].CNF.ToString();
                            mess10[29] = Main.main.myListCAT10[i].TRE.ToString();
                            mess10[30] = Main.main.myListCAT10[i].CST.ToString();
                            mess10[31] = Main.main.myListCAT10[i].MAH.ToString();
                            mess10[32] = Main.main.myListCAT10[i].TCC.ToString();
                            mess10[33] = Main.main.myListCAT10[i].STH.ToString();
                            mess10[34] = Main.main.myListCAT10[i].TOM.ToString();
                            mess10[35] = Main.main.myListCAT10[i].DOU.ToString();
                            mess10[36] = Main.main.myListCAT10[i].MSR.ToString();
                            mess10[37] = Main.main.myListCAT10[i].GHO.ToString();
                            mess10[38] = Main.main.myListCAT10[i].V_3A.ToString();
                            mess10[39] = Main.main.myListCAT10[i].G_3A.ToString();
                            mess10[40] = Main.main.myListCAT10[i].L.ToString();
                            mess10[41] = Main.main.myListCAT10[i].mode3A.ToString();
                            mess10[42] = Main.main.myListCAT10[i].targetAddress.ToString();
                            mess10[43] = Main.main.myListCAT10[i].STI.ToString();
                            mess10[44] = Main.main.myListCAT10[i].targetIdentification.ToString();
                            mess10[45] = Main.main.myListCAT10[i].V_FL.ToString();
                            mess10[46] = Main.main.myListCAT10[i].G_FL.ToString();
                            mess10[47] = Main.main.myListCAT10[i].flightLevel.ToString();
                            mess10[48] = Main.main.myListCAT10[i].height.ToString();
                            mess10[49] = Main.main.myListCAT10[i].targetLength.ToString();
                            mess10[50] = Main.main.myListCAT10[i].targetOrientation.ToString();
                            mess10[51] = Main.main.myListCAT10[i].targetWidth.ToString();
                            mess10[52] = Main.main.myListCAT10[i].NOGO.ToString();
                            mess10[53] = Main.main.myListCAT10[i].OVL.ToString();
                            mess10[54] = Main.main.myListCAT10[i].TSV.ToString();
                            mess10[55] = Main.main.myListCAT10[i].DIV.ToString();
                            mess10[56] = Main.main.myListCAT10[i].TTF.ToString();
                            mess10[57] = Main.main.myListCAT10[i].TRB.ToString();
                            mess10[58] = Main.main.myListCAT10[i].MSG.ToString();
                            mess10[59] = Main.main.myListCAT10[i].sigmax.ToString();
                            mess10[60] = Main.main.myListCAT10[i].sigmay.ToString();
                            mess10[61] = Main.main.myListCAT10[i].sigmaxy.ToString();
                            mess10[62] = Main.main.myListCAT10[i].PAM.ToString();
                            mess10[63] = Main.main.myListCAT10[i].Ax.ToString();
                            mess10[64] = Main.main.myListCAT10[i].Ay.ToString();


                            rows.Add(string.Join(SEP, mess10));

                        }



                        break;
                    case 1:

                        string[] header21 = new string[118];
                        

                        header21[0] = "ID";
                        header21[1] = "CAT";
                        header21[2] = "[Data Source Identifier] SAC";
                        header21[3] = "[Data Source Identifier] SIC";
                        header21[4] = "[Target Report Descriptor] ATP";
                        header21[5] = "[Target Report Descriptor] ARC";
                        header21[6] = "[Target Report Descriptor] RC";
                        header21[7] = "[Target Report Descriptor] RAB";
                        header21[8] = "[Target Report Descriptor] DCR";
                        header21[9] = "[Target Report Descriptor] GBS";
                        header21[10] = "[Target Report Descriptor] SIM";
                        header21[11] = "[Target Report Descriptor] TST";
                        header21[12] = "[Target Report Descriptor] SAA";
                        header21[13] = "[Target Report Descriptor] CL";
                        header21[14] = "[Target Report Descriptor] IPC";
                        header21[15] = "[Target Report Descriptor] NOGO";
                        header21[16] = "[Target Report Descriptor] CPR";
                        header21[17] = "[Target Report Descriptor] LDPJ";
                        header21[18] = "[Target Report Descriptor] RCF";
                        header21[19] = "[Track Number]";
                        header21[20] = "[Service Identification]";
                        header21[21] = "[Time of Applicability for Position]";
                        header21[22] = "[Position in WGS-84 Coordinates] Latitude (º)";
                        header21[23] = "[Position in WGS-84 Coordinates] Longitude (º)";
                        header21[24] = "[High-Resolution Position in WGS-84 Coordinates] Latitude (º)";
                        header21[25] = "[High-Resolution Position in WGS-84 Coordinates] Longitude (º)";
                        header21[26] = "[Time of Applicability for Velocity] (s)";
                        header21[27] = "[Air Speed] IM";
                        header21[28] = "[Air Speed] IAS/MACH (NM/s or Mach)";
                        header21[29] = "[True Airspeed] RE";
                        header21[30] = "[True Airspeed] (knot)";
                        header21[31] = "[Target Address]";
                        header21[32] = "[Time of Message Reception for Position]";
                        header21[33] = "[Time of Message Reception of Position–High Precision]";
                        header21[34] = "[Time of Message Reception for Velocity]";
                        header21[35] = "[Time of Message Reception of Velocity–High Precision]";
                        header21[36] = "[Geometric Height] (ft)";
                        header21[37] = "[Quality Indicators] NUCr or NACv";
                        header21[38] = "[Quality Indicators] NUCp or NIC";
                        header21[39] = "[Quality Indicators] NIC BARO";
                        header21[40] = "[Quality Indicators] SIL (I)";
                        header21[41] = "[Quality Indicators] NACp";
                        header21[42] = "[Quality Indicators] SIL (II)";
                        header21[43] = "[Quality Indicators] SDA";
                        header21[44] = "[Quality Indicators] GVA";
                        header21[45] = "[Quality Indicators] PIC";
                        header21[46] = "[MOPS Version] VNS";
                        header21[47] = "[MOPS Version] VN";
                        header21[48] = "[MOPS Version] LTT";
                        header21[49] = "[Mode 3/A Code in Octal Representation] ";
                        header21[50] = "[Roll Angle] (degree)";
                        header21[51] = "[Flight Level] (FL)";
                        header21[52] = "[Magnetic Heading] (º)";
                        header21[53] = "[Target Status] ICF";
                        header21[54] = "[Target Status] LNAV";
                        header21[55] = "[Target Status] PS";
                        header21[56] = "[Target Status] SS";
                        header21[57] = "[Barometric Vertical Rate] RE";
                        header21[58] = "[Barometric Vertical Rate] BVR (ft/min)";
                        header21[59] = "[Geometric Vertical Rate]";
                        header21[60] = "[Geometric Vertical Rate] GVR (ft/min)";
                        header21[61] = "[Airborne Ground Vector] RE";
                        header21[62] = "[Airborne Ground Vector] Ground Speed (NM/s)";
                        header21[63] = "[Airborne Ground Vector] Track Angle (degree)";
                        header21[64] = "[Track Angle Rate]  (º/s)";
                        header21[65] = "[Time of ASTERIX Report Transmission]";
                        header21[66] = "[Target Identification]";
                        header21[67] = "[Emitter Category]";
                        header21[68] = "[Met Information] Wind Speed (knot)";
                        header21[69] = "[Met Information] Wind Direction (degree)";
                        header21[70] = "[Met Information] Temperature (ºC)";
                        header21[71] = "[Met Information] Turbulence ";
                        header21[72] = "[Selected Altitude] SAS ";
                        header21[73] = "[Selected Altitude] Source ";
                        header21[74] = "[Selected Altitude] Altitude (ft) ";
                        header21[75] = "[Final State Selected Altitude] MV ";
                        header21[76] = "[Final State Selected Altitude] AH ";
                        header21[77] = "[Final State Selected Altitude] AM ";
                        header21[78] = "[Final State Selected Altitude] Altitude (ft) ";
                        header21[79] = "[Service Management] Report Period (s)";
                        header21[80] = "[Aircraft Operational Status] RA";
                        header21[81] = "[Aircraft Operational Status] TC";
                        header21[82] = "[Aircraft Operational Status] TS";
                        header21[83] = "[Aircraft Operational Status] ARV";
                        header21[84] = "[Aircraft Operational Status] CTDT/A";
                        header21[85] = "[Aircraft Operational Status] NOT CAS";
                        header21[86] = "[Aircraft Operational Status] SA";
                        header21[87] = "[Receiver ID]";
                        header21[88] = "[Message Amplitude] (dBm)";
                        header21[89] = "[Surface Capabilities and Characteristics] POA";
                        header21[90] = "[Surface Capabilities and Characteristics] CTDTI/S";
                        header21[91] = "[Surface Capabilities and Characteristics] B2 LOW";
                        header21[92] = "[Surface Capabilities and Characteristics] RAS";
                        header21[93] = "[Surface Capabilities and Characteristics] IDENT";
                        header21[94] = "[Surface Capabilities and Characteristics] L+W";
                        header21[95] = "[Data Ages] AOS(s)";
                        header21[96] = "[Data Ages] TRD(s)";
                        header21[97] = "[Data Ages] M3A(s)";
                        header21[98] = "[Data Ages] QI(s)";
                        header21[99] = "[Data Ages] TI(s)";
                        header21[100] = "[Data Ages] MAM(s)";
                        header21[101] = "[Data Ages] GH(s)";
                        header21[102] = "[Data Ages] FL(s)";
                        header21[103] = "[Data Ages] ISA(s)";
                        header21[104] = "[Data Ages] FSA(s)";
                        header21[105] = "[Data Ages] AS(s)";
                        header21[106] = "[Data Ages] TAS(s)";
                        header21[107] = "[Data Ages] MH(s)";
                        header21[108] = "[Data Ages] BVR(s)";
                        header21[109] = "[Data Ages] GVR(s)";
                        header21[110] = "[Data Ages] GV(s)";
                        header21[111] = "[Data Ages] TAR(s)";
                        header21[112] = "[Data Ages] TI(s)";
                        header21[113] = "[Data Ages] TS(s)";
                        header21[114] = "[Data Ages] MET(s)";
                        header21[115] = "[Data Ages] ROA(s)";
                        header21[116] = "[Data Ages] ARA(s)";
                        header21[117] = "[Data Ages] SCC(s)";


                        rows.Add(string.Join(SEP,header21));

                        for (int i = 0; i < Main.main.myListCAT21.Count; i++)
                        {
                            string[] mess21 = new string[118];
                            mess21[0] = i.ToString();
                            mess21[1] = 21.ToString();
                            mess21[2] = Main.main.myListCAT21[i].SAC.ToString();
                            mess21[3] = Main.main.myListCAT21[i].SIC.ToString();
                            mess21[4] = Main.main.myListCAT21[i].ATP.ToString();
                            mess21[5] = Main.main.myListCAT21[i].ARC.ToString();
                            mess21[6] = Main.main.myListCAT21[i].RC.ToString();
                            mess21[7] = Main.main.myListCAT21[i].RAB.ToString();
                            mess21[8] = Main.main.myListCAT21[i].DCR.ToString();
                            mess21[9] = Main.main.myListCAT21[i].GBS.ToString();
                            mess21[10] = Main.main.myListCAT21[i].SIM.ToString();
                            mess21[11] = Main.main.myListCAT21[i].TST.ToString();
                            mess21[12] = Main.main.myListCAT21[i].SAA.ToString();
                            mess21[13] = Main.main.myListCAT21[i].CL.ToString();
                            mess21[14] = Main.main.myListCAT21[i].IPC.ToString();
                            mess21[15] = Main.main.myListCAT21[i].NOGO.ToString();
                            mess21[16] = Main.main.myListCAT21[i].CPR.ToString();
                            mess21[17] = Main.main.myListCAT21[i].LDPJ.ToString();
                            mess21[18] = Main.main.myListCAT21[i].RCF.ToString();
                            mess21[19] = Main.main.myListCAT21[i].trackNumber.ToString();
                            mess21[20] = Main.main.myListCAT21[i].serviceIdentification.ToString();
                            mess21[21] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeOfAppPos).ToString(@"hh\:mm\:ss").ToString();
                            mess21[22] =Main.main.myListCAT21[i].latitude.ToString();
                            mess21[23] = Main.main.myListCAT21[i].longitude.ToString();
                            mess21[24] = Main.main.myListCAT21[i].HRlatitude.ToString();
                            mess21[25] = Main.main.myListCAT21[i].HRlongitude.ToString();
                            mess21[26] = Main.main.myListCAT21[i].timeOfAppVel.ToString();
                            mess21[27] = Main.main.myListCAT21[i].typeSpeed.ToString();
                            mess21[28] = Main.main.myListCAT21[i].airSpeed.ToString();
                            mess21[29] = Main.main.myListCAT21[i].RE.ToString();
                            mess21[30] = Main.main.myListCAT21[i].trueAirSpeed.ToString();
                            mess21[31] = Main.main.myListCAT21[i].targetAddress.ToString();
                            mess21[32] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeReceptPos).ToString(@"hh\:mm\:ss").ToString();
                            mess21[33] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeReceptPosHP).ToString(@"hh\:mm\:ss").ToString();
                            mess21[34] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeReceptVel).ToString(@"hh\:mm\:ss").ToString();
                            mess21[35] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeReceptVelHP).ToString(@"hh\:mm\:ss").ToString();
                            mess21[36] = Main.main.myListCAT21[i].geometricHeight.ToString();
                            mess21[37] = Main.main.myListCAT21[i].NUCr.ToString();
                            mess21[38] = Main.main.myListCAT21[i].NUCp.ToString();
                            mess21[39] = Main.main.myListCAT21[i].NICbaro.ToString();
                            mess21[40] = Main.main.myListCAT21[i].SIL1.ToString();
                            mess21[41] = Main.main.myListCAT21[i].NACp.ToString();
                            mess21[42] = Main.main.myListCAT21[i].SIL2.ToString();
                            mess21[43] = Main.main.myListCAT21[i].SDA.ToString();
                            mess21[44] = Main.main.myListCAT21[i].GVA.ToString();
                            mess21[45] = Main.main.myListCAT21[i].PIC.ToString();
                            mess21[46] = Main.main.myListCAT21[i].VNS.ToString();
                            mess21[47] = Main.main.myListCAT21[i].VN.ToString();
                            mess21[48] = Main.main.myListCAT21[i].LTT.ToString();
                            mess21[49] = Main.main.myListCAT21[i].mode3A.ToString();
                            mess21[50] = Main.main.myListCAT21[i].rollAngle.ToString();
                            mess21[51] = Main.main.myListCAT21[i].flightLevel.ToString();
                            mess21[52] = Main.main.myListCAT21[i].magneticHeading.ToString();
                            mess21[53] = Main.main.myListCAT21[i].ICF.ToString();
                            mess21[54] = Main.main.myListCAT21[i].LNAV.ToString();
                            mess21[55] = Main.main.myListCAT21[i].PS.ToString();
                            mess21[56] = Main.main.myListCAT21[i].SS.ToString();
                            mess21[57] = Main.main.myListCAT21[i].RE_BVR.ToString();
                            mess21[58] = Main.main.myListCAT21[i].barometricVerticalRate.ToString();
                            mess21[59] = Main.main.myListCAT21[i].RE_GVR.ToString();
                            mess21[60] = Main.main.myListCAT21[i].geometricVerticalRate.ToString();
                            mess21[61] = Main.main.myListCAT21[i].RE_GS.ToString();
                            mess21[62] = Main.main.myListCAT21[i].groundSpeed.ToString();
                            mess21[63] = Main.main.myListCAT21[i].trackAngle.ToString();
                            mess21[64] = Main.main.myListCAT21[i].trackAngleRate.ToString();
                            mess21[65] = TimeSpan.FromSeconds(Main.main.myListCAT21[i].timeReportTrans).ToString(@"hh\:mm\:ss").ToString();
                            mess21[66] = Main.main.myListCAT21[i].targetIdentification.ToString();
                            mess21[67] = Main.main.myListCAT21[i].ECAT.ToString();
                            mess21[68] = Main.main.myListCAT21[i].windSpeed.ToString();
                            mess21[69] = Main.main.myListCAT21[i].windDirection.ToString();
                            mess21[70] = Main.main.myListCAT21[i].temperature.ToString();
                            mess21[71] = Main.main.myListCAT21[i].turbulence.ToString();
                            mess21[72] = Main.main.myListCAT21[i].SAS.ToString();
                            mess21[73] = Main.main.myListCAT21[i].source.ToString();
                            mess21[74] = Main.main.myListCAT21[i].altitude.ToString();
                            mess21[75] = Main.main.myListCAT21[i].MV.ToString();
                            mess21[76] = Main.main.myListCAT21[i].AH.ToString();
                            mess21[77] = Main.main.myListCAT21[i].AM.ToString();
                            mess21[78] = Main.main.myListCAT21[i].altitudeFSS.ToString();
                            mess21[79] = Main.main.myListCAT21[i].reportPeriod.ToString();
                            mess21[80] = Main.main.myListCAT21[i].RA.ToString();
                            mess21[81] = Main.main.myListCAT21[i].TC.ToString();
                            mess21[82] = Main.main.myListCAT21[i].TS.ToString();
                            mess21[83] = Main.main.myListCAT21[i].ARV.ToString();
                            mess21[84] = Main.main.myListCAT21[i].CDTIA.ToString();
                            mess21[85] = Main.main.myListCAT21[i].NotTCAS.ToString();
                            mess21[86] = Main.main.myListCAT21[i].SA.ToString();
                            mess21[87] = Main.main.myListCAT21[i].RID.ToString();
                            mess21[88] = Main.main.myListCAT21[i].messageAmplitude.ToString();
                            mess21[89] = Main.main.myListCAT21[i].POA.ToString();
                            mess21[90] = Main.main.myListCAT21[i].CTDIS.ToString();
                            mess21[91] = Main.main.myListCAT21[i].B2low.ToString();
                            mess21[92] = Main.main.myListCAT21[i].RAS.ToString();
                            mess21[93] = Main.main.myListCAT21[i].IDENT.ToString();
                            mess21[94] = Main.main.myListCAT21[i].LandW.ToString();
                            mess21[95] = Main.main.myListCAT21[i].LandW.ToString();
                            mess21[96] = Main.main.myListCAT21[i].AOS_data.ToString();
                            mess21[97] = Main.main.myListCAT21[i].TRD_data.ToString();
                            mess21[98] = Main.main.myListCAT21[i].QI_data.ToString();
                            mess21[99] = Main.main.myListCAT21[i].TI1_data.ToString();
                            mess21[100] = Main.main.myListCAT21[i].MAM_data.ToString();
                            mess21[101] = Main.main.myListCAT21[i].GH_data.ToString();
                            mess21[102] = Main.main.myListCAT21[i].FL_data.ToString();
                            mess21[103] = Main.main.myListCAT21[i].ISA_data.ToString();
                            mess21[104] = Main.main.myListCAT21[i].FSA_data.ToString();
                            mess21[105] = Main.main.myListCAT21[i].AS_data.ToString();
                            mess21[106] = Main.main.myListCAT21[i].TAS_data.ToString();
                            mess21[107] = Main.main.myListCAT21[i].MH_data.ToString();
                            mess21[108] = Main.main.myListCAT21[i].BVR_data.ToString();
                            mess21[109] = Main.main.myListCAT21[i].GVR_data.ToString();
                            mess21[110] = Main.main.myListCAT21[i].GV_data.ToString();
                            mess21[111] = Main.main.myListCAT21[i].TAR_data.ToString();
                            mess21[112] = Main.main.myListCAT21[i].TI2_data.ToString();
                            mess21[113] = Main.main.myListCAT21[i].TS_data.ToString();
                            mess21[114] = Main.main.myListCAT21[i].MET_data.ToString();
                            mess21[115] = Main.main.myListCAT21[i].ROA_data.ToString();
                            mess21[116] = Main.main.myListCAT21[i].ARA_data.ToString();
                            mess21[117] = Main.main.myListCAT21[i].SCC_data.ToString();


                            rows.Add(string.Join(SEP, mess21));

                        }

                        break;
                }




   

                
                File.WriteAllLines(sfd.FileName, rows);
                MessageBox.Show(".csv created successfully!");
            }
        }




        private void buttonSearch_Click(object sender, EventArgs e)
        {
            filter = filter == false ? true : false;

            

            

            if (filter == true)
            {
                int myFilter = comboBoxFilter.SelectedIndex;



                switch (flag)
                {
                    case 0:

                        switch (myFilter)
                        {
                            case 0:
                                FilterL10 = Main.main.myListCAT10.FindAll(m => m.MessageType == textBoxSearch.Text);
                                break;
                            case 1:
                                FilterL10 = Main.main.myListCAT10.FindAll(m => m.targetIdentification == textBoxSearch.Text);
                                break;
                            case 2:
                                FilterL10 = Main.main.myListCAT10.FindAll(m => Convert.ToString(m.trackNumber) == textBoxSearch.Text);
                                break;
                            case 3:
                                FilterL10 = Main.main.myListCAT10.FindAll(m => Convert.ToString(m.targetAddress) == textBoxSearch.Text);
                                break;

                        }

                        if (FilterL10.Count != 0)
                        {
                            messagedataGrid.Rows.Clear();
                            dataItemsGridView.Rows.Clear();
                            ItemInformationTextBox.Text = "";

                            messagedataGrid.RowCount = FilterL10.Count;
                            for (int i = 0; i < FilterL10.Count; i++)
                            {
                                messagedataGrid.Rows[i].Cells[0].Value = FilterL10[i].id; /*Main.main.myListCAT10.FindIndex(m => m == FilterL10[i]);*/
                                messagedataGrid.Rows[i].Cells[1].Value = 10;
                                messagedataGrid.Rows[i].Cells[2].Value = FilterL10[i].convert2TimeOfDay(FilterL10[i].TimeOfDay);
                                messagedataGrid.Rows[i].Cells[3].Value = FilterL10[i].GetLength();
                                messagedataGrid.Rows[i].Cells[4].Value = FilterL10[i].GetItemList().Count;


                            }

                            buttonSearch.Text = "QUITAR FILTRO";
                        }
                        else
                        {
                            MessageBox.Show("No messages found");
                            filter = false;
                        }


                            break;
                    case 1:

                        switch (myFilter)
                        {
                            case 0:
                                FilterL21 = Main.main.myListCAT21.FindAll(m => m.targetIdentification == textBoxSearch.Text);
                                break;
                            case 1:
                                FilterL21 = Main.main.myListCAT21.FindAll(m => Convert.ToString(m.trackNumber) == textBoxSearch.Text);
                                break;
                            case 2:
                                FilterL21 = Main.main.myListCAT21.FindAll(m => Convert.ToString(m.targetAddress) == textBoxSearch.Text);
                                break;

                        }

                        if (FilterL21.Count!=0)
                        {
                            messagedataGrid.Rows.Clear();
                            dataItemsGridView.Rows.Clear();
                            ItemInformationTextBox.Text = "";
                            messagedataGrid.RowCount = FilterL21.Count;

                            for (int i = 0; i < FilterL21.Count; i++)
                            {
                                messagedataGrid.Rows[i].Cells[0].Value = FilterL21[i].id;
                                messagedataGrid.Rows[i].Cells[1].Value = 21;
                                messagedataGrid.Rows[i].Cells[2].Value = "";
                                messagedataGrid.Rows[i].Cells[3].Value = FilterL21[i].GetLength();
                                messagedataGrid.Rows[i].Cells[4].Value = FilterL21[i].GetItemList().Count;


                            }

                            buttonSearch.Text = "QUITAR FILTRO";
                        }
                        else
                        {
                            MessageBox.Show("No messages found");
                            filter = false;
                        }
                        break;
                }
                
            }
            else
            {
                buttonSearch.Text = "FILTRAR";
                messagedataGrid.Rows.Clear();
                CreateDataGridView();

            }


        }

        private void messagedataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowMess = messagedataGrid.CurrentCell.RowIndex;
            dataItemLabel.Text = "Data Item:";
            ItemInformationTextBox.Text = "";

            switch (flag)
            {
                case 0:


                    switch (filter)
                    {
                        case false:
                            dataItemsGridView.RowCount = Main.main.myListCAT10[rowMess].GetItemList().Count;

                            for (int i = 0; i < Main.main.myListCAT10[rowMess].GetItemList().Count; i++)
                            {
                                dataItemsGridView.Rows[i].Cells[0].Value = Main.main.myListCAT10[rowMess].GetItemList()[i][0];
                                dataItemsGridView.Rows[i].Cells[1].Value = Main.main.myListCAT10[rowMess].GetItemList()[i][1];
                                dataItemsGridView.Rows[i].Cells[2].Value = Main.main.myListCAT10[rowMess].GetItemList()[i][2];
                            }
                            break;
                        case true:
                            dataItemsGridView.RowCount = FilterL10[rowMess].GetItemList().Count;

                            for (int i = 0; i < FilterL10[rowMess].GetItemList().Count; i++)
                            {
                                dataItemsGridView.Rows[i].Cells[0].Value = FilterL10[rowMess].GetItemList()[i][0];
                                dataItemsGridView.Rows[i].Cells[1].Value = FilterL10[rowMess].GetItemList()[i][1];
                                dataItemsGridView.Rows[i].Cells[2].Value = FilterL10[rowMess].GetItemList()[i][2];
                            }
                            break;
                    }

                    break;

                case 1:

                    switch (filter)
                    {
                        case false:
                            dataItemsGridView.RowCount = Main.main.myListCAT21[rowMess].GetItemList().Count;

                            for (int i = 0; i < Main.main.myListCAT21[rowMess].GetItemList().Count; i++)
                            {
                                dataItemsGridView.Rows[i].Cells[0].Value = Main.main.myListCAT21[rowMess].GetItemList()[i][0];
                                dataItemsGridView.Rows[i].Cells[1].Value = Main.main.myListCAT21[rowMess].GetItemList()[i][1];
                                dataItemsGridView.Rows[i].Cells[2].Value = Main.main.myListCAT21[rowMess].GetItemList()[i][2];
                            }
                            break;
                        case true:
                            dataItemsGridView.RowCount = FilterL21[rowMess].GetItemList().Count;

                            for (int i = 0; i < FilterL21[rowMess].GetItemList().Count; i++)
                            {
                                dataItemsGridView.Rows[i].Cells[0].Value = FilterL21[rowMess].GetItemList()[i][0];
                                dataItemsGridView.Rows[i].Cells[1].Value = FilterL21[rowMess].GetItemList()[i][1];
                                dataItemsGridView.Rows[i].Cells[2].Value = FilterL21[rowMess].GetItemList()[i][2];
                            }
                            break;

                    }
                    break;


            }
        }

        private void dataItemsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemInformationTextBox.Text = "";
            dataItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowDItem = dataItemsGridView.CurrentCell.RowIndex;

            int FRN;



            switch (flag)
            {
                case 0:


                    List<CAT10> showI10;
                    switch (filter)
                    {
                        case true:
                            showI10 = FilterL10;
                            FRN = Convert.ToInt32(FilterL10[rowMess].GetItemList()[rowDItem][0]);
                            break;
                        default:
                            showI10 = Main.main.myListCAT10;
                            FRN = Convert.ToInt32(Main.main.myListCAT10[rowMess].GetItemList()[rowDItem][0]);
                            break;
                    }




                    switch (FRN)
                    {
                        case 1:
                            ItemInformationTextBox.Text += "SAC: " + showI10[rowMess].SAC + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIC: " + showI10[rowMess].SIC + Environment.NewLine;

                            break;
                        case 2:
                            ItemInformationTextBox.Text += "Message Type: " + showI10[rowMess].MessageType + Environment.NewLine;

                            break;
                        case 3:
                            ItemInformationTextBox.Text += "TYP: " + showI10[rowMess].TYP + Environment.NewLine;
                            ItemInformationTextBox.Text += "DCR: " + showI10[rowMess].DCR + Environment.NewLine;
                            ItemInformationTextBox.Text += "CHN: " + showI10[rowMess].CHN + Environment.NewLine;
                            ItemInformationTextBox.Text += "GBS: " + showI10[rowMess].GBS + Environment.NewLine;
                            ItemInformationTextBox.Text += "CRT: " + showI10[rowMess].CRT + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIM: " + showI10[rowMess].SIM + Environment.NewLine;
                            ItemInformationTextBox.Text += "TST: " + showI10[rowMess].TST + Environment.NewLine;
                            ItemInformationTextBox.Text += "RAB: " + showI10[rowMess].RAB + Environment.NewLine;
                            ItemInformationTextBox.Text += "LOP: " + showI10[rowMess].LOP + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOT: " + showI10[rowMess].TOT + Environment.NewLine;
                            ItemInformationTextBox.Text += "SPI: " + showI10[rowMess].SPI + Environment.NewLine;

                            break;
                        case 4:
                            ItemInformationTextBox.Text += "Time of Day: " + showI10[rowMess].convert2TimeOfDay(showI10[rowMess].TimeOfDay) + Environment.NewLine;

                            break;
                        case 5:
                            ItemInformationTextBox.Text += "Latitude: " + Math.Round(showI10[rowMess].latitude, 3) + " º" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Longitude: " + Math.Round(showI10[rowMess].longitude, 3) + " º" + Environment.NewLine;
                            break;
                        case 6:
                            ItemInformationTextBox.Text += "rho: " + showI10[rowMess].rho + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "theta: " + showI10[rowMess].theta + " º" + Environment.NewLine;

                            break;
                        case 7:
                            ItemInformationTextBox.Text += "x: " + showI10[rowMess].x + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "y: " + showI10[rowMess].y + " m" + Environment.NewLine;

                            break;
                        case 8:
                            ItemInformationTextBox.Text += "Ground speed: " + Math.Round(showI10[rowMess].groundSpeed, 3) + " kt" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Track angle: " + Math.Round(showI10[rowMess].trackAngle) + " º" + Environment.NewLine;
                            break;
                        case 9:
                            ItemInformationTextBox.Text += "Vx: " + showI10[rowMess].Vx + " m/s" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Vy: " + showI10[rowMess].Vy + " m/s" + Environment.NewLine;
                            break;
                        case 10:
                            ItemInformationTextBox.Text += "Track number: " + showI10[rowMess].trackNumber + Environment.NewLine;

                            break;
                        case 11:
                            ItemInformationTextBox.Text += "CNF: " + showI10[rowMess].CNF + Environment.NewLine;
                            ItemInformationTextBox.Text += "TRE: " + showI10[rowMess].TRE + Environment.NewLine;
                            ItemInformationTextBox.Text += "CST: " + showI10[rowMess].CST + Environment.NewLine;
                            ItemInformationTextBox.Text += "MAH: " + showI10[rowMess].MAH + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCC: " + showI10[rowMess].TCC + Environment.NewLine;
                            ItemInformationTextBox.Text += "STH: " + showI10[rowMess].STH + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOM: " + showI10[rowMess].TOM + Environment.NewLine;
                            ItemInformationTextBox.Text += "DOU: " + showI10[rowMess].DOU + Environment.NewLine;
                            ItemInformationTextBox.Text += "MSR: " + showI10[rowMess].MSR + Environment.NewLine;
                            ItemInformationTextBox.Text += "GHO: " + showI10[rowMess].GHO + Environment.NewLine;

                            break;
                        case 12:
                            ItemInformationTextBox.Text += "V 3A: " + showI10[rowMess].V_3A + Environment.NewLine;
                            ItemInformationTextBox.Text += "G 3A: " + showI10[rowMess].G_3A + Environment.NewLine;
                            ItemInformationTextBox.Text += "L: " + showI10[rowMess].L + Environment.NewLine;
                            ItemInformationTextBox.Text += "Mode 3A: " + showI10[rowMess].mode3A + Environment.NewLine;

                            break;
                        case 13:
                            ItemInformationTextBox.Text += "Target Address: " + showI10[rowMess].targetAddress + Environment.NewLine;

                            break;
                        case 14:
                            ItemInformationTextBox.Text += "STI: " + showI10[rowMess].STI + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Identification: " + showI10[rowMess].targetIdentification + Environment.NewLine;

                            break;
                        case 15:
                            ItemInformationTextBox.Text += "REP: " + showI10[rowMess].REP_ModeSMB + Environment.NewLine;
                            for (int j = 0; j < showI10[rowMess].REP_ModeSMB; j++)
                            {
                                ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "MB Data: " + showI10[rowMess].GetMBDataList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS1: " + showI10[rowMess].GetBDS1List()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS2: " + showI10[rowMess].GetBDS2List()[j] + Environment.NewLine;
                            }

                            break;
                        case 16:
                            ItemInformationTextBox.Text += "VFI: " + showI10[rowMess].VFI + Environment.NewLine;

                            break;
                        case 17:
                            ItemInformationTextBox.Text += "V FL: " + showI10[rowMess].V_FL + Environment.NewLine;
                            ItemInformationTextBox.Text += "G FL: " + showI10[rowMess].G_FL + Environment.NewLine;
                            ItemInformationTextBox.Text += "Flight level: " + showI10[rowMess].flightLevel + Environment.NewLine;

                            break;
                        case 18:
                            ItemInformationTextBox.Text += "Height: " + showI10[rowMess].height + " ft" + Environment.NewLine;

                            break;
                        case 19:
                            ItemInformationTextBox.Text += "Target Length: " + showI10[rowMess].targetLength + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Orientation: " + showI10[rowMess].targetOrientation + " º" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Width: " + showI10[rowMess].targetWidth + " m" + Environment.NewLine;
                            break;
                        case 20:
                            ItemInformationTextBox.Text += "NOGO: " + showI10[rowMess].NOGO + Environment.NewLine;
                            ItemInformationTextBox.Text += "OVL: " + showI10[rowMess].OVL + Environment.NewLine;
                            ItemInformationTextBox.Text += "TSV: " + showI10[rowMess].TSV + Environment.NewLine;
                            ItemInformationTextBox.Text += "DIV: " + showI10[rowMess].DIV + Environment.NewLine;
                            ItemInformationTextBox.Text += "TTF: " + showI10[rowMess].TTF + Environment.NewLine;

                            break;
                        case 21:
                            ItemInformationTextBox.Text += "TRB: " + showI10[rowMess].TRB + Environment.NewLine;
                            ItemInformationTextBox.Text += "MSG: " + showI10[rowMess].MSG + Environment.NewLine;

                            break;
                        case 22:
                            ItemInformationTextBox.Text += "Sigma X: " + showI10[rowMess].sigmax + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Sigma Y: " + showI10[rowMess].sigmay + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Sigma XY: " + showI10[rowMess].sigmaxy + " m^2" + Environment.NewLine;

                            break;
                        case 23:
                            ItemInformationTextBox.Text += "REP: " + showI10[rowMess].REP_presence + Environment.NewLine;
                            for (int j = 0; j < showI10[rowMess].REP_presence; j++)
                            {
                                ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "Rho : " + showI10[rowMess].GetRhoThetaPresenceList()[j][0] + " m" + Environment.NewLine;
                                ItemInformationTextBox.Text += "Theta : " + showI10[rowMess].GetRhoThetaPresenceList()[j][1] + " º" + Environment.NewLine;

                            }

                            break;
                        case 24:
                            ItemInformationTextBox.Text += "PAM: " + showI10[rowMess].PAM + Environment.NewLine;

                            break;
                        case 25:
                            ItemInformationTextBox.Text += "Ax: " + showI10[rowMess].Ax + " m/s^2" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Ay: " + showI10[rowMess].Ay + " m/s^2" + Environment.NewLine;
                            break;
                        case 26:

                            break;
                        case 27:
                            ItemInformationTextBox.Text += "Special Purpose: " + showI10[rowMess].specialPurpose + Environment.NewLine;
                            break;
                        case 28:
                            ItemInformationTextBox.Text += "Reserved Field: " + showI10[rowMess].reservedField + Environment.NewLine;

                            break;
                    }

                    dataItemLabel.Text = showI10[rowMess].GetItemList()[rowDItem][2];

                    break;
                case 1:
                    List<CAT21> showI21;
                    switch (filter)
                    {
                        case true:
                            showI21 = FilterL21;
                            FRN = Convert.ToInt32(FilterL21[rowMess].GetItemList()[rowDItem][0]);
                            break;
                        default:
                            showI21 = Main.main.myListCAT21;
                            FRN = Convert.ToInt32(Main.main.myListCAT21[rowMess].GetItemList()[rowDItem][0]);
                            break;
                    }

                    switch (FRN)
                    {
                        case 1:
                            ItemInformationTextBox.Text += "SAC: " + showI21[rowMess].SAC + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIC: " + showI21[rowMess].SIC + Environment.NewLine;

                            break;
                        case 2:
                            ItemInformationTextBox.Text += "ATP: " + showI21[rowMess].ATP + Environment.NewLine;
                            ItemInformationTextBox.Text += "ARC: " + showI21[rowMess].ARC + Environment.NewLine;
                            ItemInformationTextBox.Text += "RC: " + showI21[rowMess].RC + Environment.NewLine;
                            ItemInformationTextBox.Text += "RAB: " + showI21[rowMess].RAB + Environment.NewLine;
                            ItemInformationTextBox.Text += "DCR: " + showI21[rowMess].DCR + Environment.NewLine;
                            ItemInformationTextBox.Text += "GBS: " + showI21[rowMess].GBS + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIM: " + showI21[rowMess].SIM + Environment.NewLine;
                            ItemInformationTextBox.Text += "TST: " + showI21[rowMess].TST + Environment.NewLine;
                            ItemInformationTextBox.Text += "SAA: " + showI21[rowMess].SAA + Environment.NewLine;
                            ItemInformationTextBox.Text += "CL: " + showI21[rowMess].CL + Environment.NewLine;
                            ItemInformationTextBox.Text += "IPC: " + showI21[rowMess].IPC + Environment.NewLine;
                            ItemInformationTextBox.Text += "NOGO: " + showI21[rowMess].NOGO + Environment.NewLine;
                            ItemInformationTextBox.Text += "CPR: " + showI21[rowMess].CPR + Environment.NewLine;
                            ItemInformationTextBox.Text += "LDPJ: " + showI21[rowMess].LDPJ + Environment.NewLine;
                            ItemInformationTextBox.Text += "RCF: " + showI21[rowMess].RCF + Environment.NewLine;


                            break;
                        case 3:

                            ItemInformationTextBox.Text += "Track Number: " + showI21[rowMess].trackNumber + Environment.NewLine;

                            break;
                        case 4:

                            ItemInformationTextBox.Text += "Service Identification: " + showI21[rowMess].serviceIdentification + Environment.NewLine;

                            break;
                        case 5:
                            ItemInformationTextBox.Text += "Time of Applicability for position: " + showI21[rowMess].convert2TimeOfDay(showI21[rowMess].timeOfAppPos) + Environment.NewLine;
                            break;
                        case 6:
                            ItemInformationTextBox.Text += "Latitude: " + Math.Round(showI21[rowMess].latitude, 3) + " degrees" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Longitude: " + Math.Round(showI21[rowMess].longitude, 3) + " degrees" + Environment.NewLine;
                            break;
                        case 7:
                            ItemInformationTextBox.Text += "High Resolution Latitude: " + Math.Round(showI21[rowMess].HRlatitude, 5) + " degrees" + Environment.NewLine;
                            ItemInformationTextBox.Text += "High Resolution Longitude: " + Math.Round(showI21[rowMess].HRlongitude, 5) + " degrees" + Environment.NewLine;
                            break;
                        case 8:
                            ItemInformationTextBox.Text += "Time of Applicability for Velocity: " + showI21[rowMess].timeOfAppVel + Environment.NewLine;
                            break;
                        case 9:
                            ItemInformationTextBox.Text += "Type speed: " + showI21[rowMess].typeSpeed + Environment.NewLine;

                            ItemInformationTextBox.Text += showI21[rowMess].typeSpeed == "IAS" ? ("Air Speed: " + showI21[rowMess].airSpeed + " m/s" + Environment.NewLine) : ("Air Speed: " + showI21[rowMess].airSpeed + "Mach" + Environment.NewLine);
                            break;
                        case 10:
                            ItemInformationTextBox.Text += "RE: " + showI21[rowMess].RE + Environment.NewLine;
                            ItemInformationTextBox.Text += "True air speed: " + showI21[rowMess].trueAirSpeed + " m/s" + Environment.NewLine;
                            break;
                        case 11:
                            ItemInformationTextBox.Text += "Target address: " + showI21[rowMess].targetAddress + Environment.NewLine;
                            break;
                        case 12:
                            ItemInformationTextBox.Text += "Time of Message Reception Reception of position : " + showI21[rowMess].timeReceptPos + " s" + Environment.NewLine;
                            break;
                        case 13:
                            ItemInformationTextBox.Text += "Time of Message Reception Reception of position - High Precision: " + showI21[rowMess].timeReceptPosHP + " s" + Environment.NewLine;
                            break;
                        case 14:
                            ItemInformationTextBox.Text += "Time of Message Reception Reception of Velocity: " + showI21[rowMess].timeReceptVel + " s" + Environment.NewLine;
                            break;
                        case 15:
                            ItemInformationTextBox.Text += "Time of Message Reception Reception of Velocity - High Precision: " + showI21[rowMess].timeReceptVelHP + " s" + Environment.NewLine;
                            break;
                        case 16:
                            ItemInformationTextBox.Text += "Geometric Height: " + showI21[rowMess].geometricHeight + " ft" + Environment.NewLine;
                            break;
                        case 17:
                            ItemInformationTextBox.Text += "NUCr or NACv: " + showI21[rowMess].NUCr + Environment.NewLine;
                            ItemInformationTextBox.Text += "NUCp or NIC: " + showI21[rowMess].NUCp + Environment.NewLine;
                            ItemInformationTextBox.Text += "NICbaro: " + showI21[rowMess].NICbaro + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIL: " + showI21[rowMess].SIL1 + Environment.NewLine;
                            ItemInformationTextBox.Text += "NACp: " + showI21[rowMess].NACp + Environment.NewLine;
                            ItemInformationTextBox.Text += "NUCr or NACv: " + showI21[rowMess].NUCr + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIL: " + showI21[rowMess].SIL2 + Environment.NewLine;
                            ItemInformationTextBox.Text += "SDA: " + showI21[rowMess].SDA + Environment.NewLine;
                            ItemInformationTextBox.Text += "GVA: " + showI21[rowMess].GVA + Environment.NewLine;
                            ItemInformationTextBox.Text += "PIC: " + showI21[rowMess].PIC + Environment.NewLine;
                            break;
                        case 18:
                            ItemInformationTextBox.Text += "VNS: " + showI21[rowMess].VNS + Environment.NewLine;
                            ItemInformationTextBox.Text += "VN: " + showI21[rowMess].VN + Environment.NewLine;
                            ItemInformationTextBox.Text += "LTT: " + showI21[rowMess].PIC + Environment.NewLine;
                            break;
                        case 19:
                            ItemInformationTextBox.Text += "Mode 3/A: " + showI21[rowMess].mode3A + Environment.NewLine;
                            break;
                        case 20:
                            ItemInformationTextBox.Text += "Roll Angle: " + showI21[rowMess].rollAngle + " degrees" + Environment.NewLine;
                            break;
                        case 21:
                            ItemInformationTextBox.Text += "Flight Level: " + showI21[rowMess].flightLevel + " FL" + Environment.NewLine;

                            break;
                        case 22:
                            ItemInformationTextBox.Text += "Magnetic Heading: " + showI21[rowMess].magneticHeading + " degrees" + Environment.NewLine;

                            break;
                        case 23:
                            ItemInformationTextBox.Text += "ICF: " + showI21[rowMess].ICF + Environment.NewLine;
                            ItemInformationTextBox.Text += "LNAV: " + showI21[rowMess].LNAV + Environment.NewLine;
                            ItemInformationTextBox.Text += "PS: " + showI21[rowMess].PS + Environment.NewLine;

                            break;
                        case 24:

                            ItemInformationTextBox.Text += "RE: " + showI21[rowMess].RE_BVR + Environment.NewLine;
                            ItemInformationTextBox.Text += "BVR: " + showI21[rowMess].barometricVerticalRate + " feet/minute" + Environment.NewLine;

                            break;
                        case 25:

                            ItemInformationTextBox.Text += "RE: " + showI21[rowMess].RE_GVR + Environment.NewLine;
                            ItemInformationTextBox.Text += "GVR: " + showI21[rowMess].geometricVerticalRate + " feet/minute" + Environment.NewLine;

                            break;
                        case 26:
                            ItemInformationTextBox.Text += "Ground Speed: " + showI21[rowMess].groundSpeed + " NM/s" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Track Angle: " + showI21[rowMess].trackAngle + " degrees" + Environment.NewLine;

                            break;
                        case 27:
                            ItemInformationTextBox.Text += "Track Angle Rate: " + showI21[rowMess].trackAngleRate + " degrees/s" + Environment.NewLine;
                            break;
                        case 28:
                            ItemInformationTextBox.Text += "Time of report Transmission: " + showI21[rowMess].timeReportTrans + " s" + Environment.NewLine;
                            break;
                        case 29:
                            ItemInformationTextBox.Text += "Target Identification: " + showI21[rowMess].targetIdentification + Environment.NewLine;
                            break;
                        case 30:
                            ItemInformationTextBox.Text += "Emmiter Category: " + showI21[rowMess].ECAT + Environment.NewLine;
                            break;
                        case 31:
                            ItemInformationTextBox.Text += showI21[rowMess].WS + " " + "Wind Speed: " + showI21[rowMess].windSpeed + " knot" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].WD + " " + "Wind Direction: " + showI21[rowMess].windDirection + " degrees" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TMP + " " + "Temperature: " + showI21[rowMess].temperature + " ºC" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TRB + " " + "Turbulence: " + showI21[rowMess].turbulence + Environment.NewLine;
                            break;
                        case 32:
                            ItemInformationTextBox.Text += "SAS: " + showI21[rowMess].SAS + Environment.NewLine;
                            ItemInformationTextBox.Text += "Source: " + showI21[rowMess].source + Environment.NewLine;
                            ItemInformationTextBox.Text += "Altitude: " + showI21[rowMess].altitude + " ft" + Environment.NewLine;
                            break;
                        case 33:
                            ItemInformationTextBox.Text += "MV: " + showI21[rowMess].MV + Environment.NewLine;
                            ItemInformationTextBox.Text += "AH: " + showI21[rowMess].AH + Environment.NewLine;
                            ItemInformationTextBox.Text += "AM: " + showI21[rowMess].AM + Environment.NewLine;
                            ItemInformationTextBox.Text += "Altitude: " + showI21[rowMess].altitudeFSS + Environment.NewLine;
                            break;
                        case 34:
                            ItemInformationTextBox.Text += "TIS: " + showI21[rowMess].TIS + Environment.NewLine;
                            ItemInformationTextBox.Text += "TID: " + showI21[rowMess].TID + Environment.NewLine;
                            ItemInformationTextBox.Text += "NAV: " + showI21[rowMess].NAV + Environment.NewLine;
                            ItemInformationTextBox.Text += "TIS: " + showI21[rowMess].TIS + Environment.NewLine;
                            ItemInformationTextBox.Text += "NVB: " + showI21[rowMess].NVB + Environment.NewLine;
                            ItemInformationTextBox.Text += "REP: " + showI21[rowMess].RE + Environment.NewLine;
                            for (int j = 0; j < showI21[rowMess].REP; j++)
                            {
                                ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "TCA: " + showI21[rowMess].GetTCAList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TCA: " + showI21[rowMess].GetTCAList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "NC: " + showI21[rowMess].GetNCList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TCP number: " + showI21[rowMess].GetTCPList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "Altitude : " + showI21[rowMess].GetTIAList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "Latitude: " + showI21[rowMess].GetLatList()[j] + " degree" + Environment.NewLine;
                                ItemInformationTextBox.Text += "Longitude: " + showI21[rowMess].GetLongList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "Point Type: " + showI21[rowMess].GetPTypeList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TD: " + showI21[rowMess].GetTDList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TRA: " + showI21[rowMess].GetTRAList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TOA: " + showI21[rowMess].GetTOAList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TOV: " + showI21[rowMess].GetTOVList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "TTR: " + showI21[rowMess].GetTTRList()[j] + Environment.NewLine;

                            }
                            break;
                        case 35:
                            ItemInformationTextBox.Text += "RP: " + showI21[rowMess].reportPeriod + " s" + Environment.NewLine;
                            break;
                        case 36:
                            ItemInformationTextBox.Text += "RA: " + showI21[rowMess].RA + Environment.NewLine;
                            ItemInformationTextBox.Text += "TC: " + showI21[rowMess].TC + Environment.NewLine;
                            ItemInformationTextBox.Text += "TS: " + showI21[rowMess].TS + Environment.NewLine;
                            ItemInformationTextBox.Text += "ARV: " + showI21[rowMess].ARV + Environment.NewLine;
                            ItemInformationTextBox.Text += "CDTI/A: " + showI21[rowMess].CDTIA + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCAS: " + showI21[rowMess].NotTCAS + Environment.NewLine;
                            ItemInformationTextBox.Text += "SA: " + showI21[rowMess].SA + Environment.NewLine;
                            break;
                        case 37:
                            ItemInformationTextBox.Text += "POA: " + showI21[rowMess].POA + Environment.NewLine;
                            ItemInformationTextBox.Text += "CTDI/S: " + showI21[rowMess].CTDIS + Environment.NewLine;
                            ItemInformationTextBox.Text += "B2 low: " + showI21[rowMess].B2low + Environment.NewLine;
                            ItemInformationTextBox.Text += "RAS: " + showI21[rowMess].RAS + Environment.NewLine;
                            ItemInformationTextBox.Text += "IDENT: " + showI21[rowMess].IDENT + Environment.NewLine;
                            ItemInformationTextBox.Text += "L+W: " + showI21[rowMess].LandW + Environment.NewLine;
                            break;
                        case 38:
                            ItemInformationTextBox.Text += "Message Amplitude: " + showI21[rowMess].messageAmplitude + " dBm" + Environment.NewLine;
                            break;
                        case 39:
                            ItemInformationTextBox.Text += "REP: " + showI21[rowMess].REP_ModeSMB + Environment.NewLine;
                            for (int j = 0; j < showI21[rowMess].REP_ModeSMB; j++)
                            {
                                ItemInformationTextBox.Text += "ID: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "MB Data: " + showI21[rowMess].GetMBData()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS1: " + showI21[rowMess].GetBDS1()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS2: " + showI21[rowMess].GetBDS2()[j] + Environment.NewLine;

                            }
                            break;
                        case 40:

                            break;
                        case 41:
                            ItemInformationTextBox.Text += "Receiver ID: " + showI21[rowMess].RID + Environment.NewLine;
                            break;
                        case 42:
                            ItemInformationTextBox.Text += showI21[rowMess].AOS_DA + " Aircraft Operational Status age: " + showI21[rowMess].AOS_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TRD_DA + " Target Report Descriptor age: " + showI21[rowMess].TRD_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].M3A + " Mode 3/A Code age: " + showI21[rowMess].M3A_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].QI + " Quality Indicators age: " + showI21[rowMess].QI_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TI1_DA + " Trajectory Intent age: " + showI21[rowMess].TI1_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].MAM_DA + " Message Amplitude age: " + showI21[rowMess].MAM_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].GH_DA + " Geometric Height age: " + showI21[rowMess].GH_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].FL_DA + " Flight Level age: " + showI21[rowMess].FL_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].ISA_DA + " Intermediate State Selected Altitude age: " + showI21[rowMess].ISA_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].FSA_DA + " Final State Selected Altitude age: " + showI21[rowMess].FSA_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].AS_DA + " Air Speed age: " + showI21[rowMess].AS_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TAS_DA + " True Air Speed age: " + showI21[rowMess].TAS_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].MH_DA + " Magnetic Heading age: " + showI21[rowMess].MH_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].BVR_DA + " Barometric Vertical Rate age: " + showI21[rowMess].BVR_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].GVR_DA + " Geometric Vertical Rate age: " + showI21[rowMess].GVR_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].GV_DA + " Ground Vector age: " + showI21[rowMess].GV_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TAR_DA + " Track Angle Rate age: " + showI21[rowMess].TAR_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TI2_DA + " Target Identification age: " + showI21[rowMess].TI2_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].TS_DA + " Target Status age: " + showI21[rowMess].TS_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].MET_DA + " Met Information age: " + showI21[rowMess].MET_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].ROA_DA + " Roll Angle age: " + showI21[rowMess].ROA_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].ARA_DA + " ACAS Resolution Advisory age: " + showI21[rowMess].ARA_data + " s" + Environment.NewLine;
                            ItemInformationTextBox.Text += showI21[rowMess].SCC_DA + "Surface Capabilities and Characteristics age: " + showI21[rowMess].SCC_data + " s" + Environment.NewLine;

                            break;
                        case 48:
                            ItemInformationTextBox.Text += "Reserver Expansion Field: " + Environment.NewLine;
                            break;
                        case 49:
                            ItemInformationTextBox.Text += "Special Purpose Field: " + Environment.NewLine;
                            break;
                    }



                    dataItemLabel.Text = showI21[rowMess].GetItemList()[rowDItem][2];
                    break;
            }
        }


    }
}

