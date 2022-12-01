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
        List<CAT10> l10 = new List<CAT10>();
        List<CAT21> l21 = new List<CAT21>();
        int rowMess;
        int flag;
        int filter;
        public DataForm()
        {
            InitializeComponent();

        }
        public DataForm(List<CAT10> l)
        {
            InitializeComponent();
            l10 = l;
            flag = 0;
        }

        public DataForm(List<CAT21> l)
        {
            InitializeComponent();
            l21 = l;
            flag = 1;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 0:
                    
                messagedataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                messagedataGrid.ReadOnly = true;
                messagedataGrid.RowHeadersVisible = false;
                messagedataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                messagedataGrid.RowCount = l10.Count; //Tendremos tantas filas como mensajes haya en nuestra lista
                messagedataGrid.ColumnCount = 5; //ID, CAT, TIME,Length
                messagedataGrid.Columns[0].HeaderText = "ID";
                messagedataGrid.Columns[1].HeaderText = "CAT";
                messagedataGrid.Columns[2].HeaderText = "Time of Day";
                messagedataGrid.Columns[3].HeaderText = "Length";
                messagedataGrid.Columns[4].HeaderText = "Data Items";

                for (int i = 0; i < l10.Count; i++)
                {
                    messagedataGrid.Rows[i].Cells[0].Value = i;
                    messagedataGrid.Rows[i].Cells[1].Value = 10;
                    messagedataGrid.Rows[i].Cells[2].Value = l10[i].convert2TimeOfDay(l10[i].TimeOfDay);
                    messagedataGrid.Rows[i].Cells[3].Value = l10[i].GetLength();
                    messagedataGrid.Rows[i].Cells[4].Value = l10[i].GetItemList().Count;


                }

                    break;


                case 1:
                messagedataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                messagedataGrid.ReadOnly = true;
                messagedataGrid.RowHeadersVisible = false;
                messagedataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                messagedataGrid.RowCount = l21.Count; //Tendremos tantas filas como mensajes haya en nuestra lista
                messagedataGrid.ColumnCount = 5; //ID, CAT, TIME,Length
                messagedataGrid.Columns[0].HeaderText = "ID";
                messagedataGrid.Columns[1].HeaderText = "CAT";
                messagedataGrid.Columns[2].HeaderText = "Time of Day";
                messagedataGrid.Columns[3].HeaderText = "Length";
                messagedataGrid.Columns[4].HeaderText = "Data Items";

                for (int i = 0; i < l21.Count; i++)
                {
                    messagedataGrid.Rows[i].Cells[0].Value = i;
                    messagedataGrid.Rows[i].Cells[1].Value = 21;
                    messagedataGrid.Rows[i].Cells[2].Value = " ";
                    messagedataGrid.Rows[i].Cells[3].Value = l21[i].GetLength();
                    messagedataGrid.Rows[i].Cells[4].Value = l21[i].GetItemList().Count;


                }
                    break;

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void messagedataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (flag)
            {
                case 0:
                    rowMess = messagedataGrid.CurrentCell.RowIndex;
                    dataItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataItemsGridView.ReadOnly = true;
                    dataItemsGridView.RowHeadersVisible = false;
                    dataItemsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataItemsGridView.RowCount = l10[rowMess].GetItemList().Count;
                    dataItemsGridView.ColumnCount = 3;
                    dataItemsGridView.Columns[0].HeaderText = "FRN";
                    dataItemsGridView.Columns[1].HeaderText = "Data Field";
                    dataItemsGridView.Columns[2].HeaderText = "Description";

                    for (int i = 0; i < l10[rowMess].GetItemList().Count; i++)
                    {
                        dataItemsGridView.Rows[i].Cells[0].Value = l10[rowMess].GetItemList()[i][0];
                        dataItemsGridView.Rows[i].Cells[1].Value = l10[rowMess].GetItemList()[i][1];
                        dataItemsGridView.Rows[i].Cells[2].Value = l10[rowMess].GetItemList()[i][2];
                    }
                    break;

                case 1:

                    rowMess = messagedataGrid.CurrentCell.RowIndex;
                    dataItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataItemsGridView.ReadOnly = true;
                    dataItemsGridView.RowHeadersVisible = false;
                    dataItemsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataItemsGridView.RowCount = l21[rowMess].GetItemList().Count;
                    dataItemsGridView.ColumnCount = 3;
                    dataItemsGridView.Columns[0].HeaderText = "FRN";
                    dataItemsGridView.Columns[1].HeaderText = "Data Field";
                    dataItemsGridView.Columns[2].HeaderText = "Description";

                    for (int i = 0; i < l21[rowMess].GetItemList().Count; i++)
                    {
                        dataItemsGridView.Rows[i].Cells[0].Value = l21[rowMess].GetItemList()[i][0];
                        dataItemsGridView.Rows[i].Cells[1].Value = l21[rowMess].GetItemList()[i][1];
                        dataItemsGridView.Rows[i].Cells[2].Value = l21[rowMess].GetItemList()[i][2];
                    }
                    break;

            }
        }

        private void dataItemsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemInformationTextBox.Text = "";
            dataItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowDItem = dataItemsGridView.CurrentCell.RowIndex;

            int FRN;

            List<string> itemList = new List<string>();

            

            switch(flag)
            {
                case 0:
                    FRN = Convert.ToInt32(l10[rowMess].GetItemList()[rowDItem][0]);

                    switch (FRN)
                    {
                        case 1:
                            ItemInformationTextBox.Text += "SAC: " + l10[rowMess].SAC+ Environment.NewLine;
                            ItemInformationTextBox.Text += "SIC: " + l10[rowMess].SIC + Environment.NewLine;

                            break;
                        case 2:
                            ItemInformationTextBox.Text += "Message Type: " + l10[rowMess].MessageType + Environment.NewLine;

                            break;
                        case 3:
                            ItemInformationTextBox.Text += "TYP: " + l10[rowMess].TYP + Environment.NewLine;
                            ItemInformationTextBox.Text += "DCR: " + l10[rowMess].DCR + Environment.NewLine;
                            ItemInformationTextBox.Text += "CHN: " + l10[rowMess].CHN + Environment.NewLine;
                            ItemInformationTextBox.Text += "GBS: " + l10[rowMess].GBS + Environment.NewLine;
                            ItemInformationTextBox.Text += "CRT: " + l10[rowMess].CRT + Environment.NewLine;
                            ItemInformationTextBox.Text += "SIM: " + l10[rowMess].SIM + Environment.NewLine;
                            ItemInformationTextBox.Text += "TST: " + l10[rowMess].TST + Environment.NewLine;
                            ItemInformationTextBox.Text += "RAB: " + l10[rowMess].RAB + Environment.NewLine;
                            ItemInformationTextBox.Text += "LOP: " + l10[rowMess].LOP + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOT: " + l10[rowMess].TOT + Environment.NewLine;
                            ItemInformationTextBox.Text += "SPI: " + l10[rowMess].SPI + Environment.NewLine;

                            break;
                        case 4:
                            ItemInformationTextBox.Text += "Time of Day: " + l10[rowMess].convert2TimeOfDay(l10[rowMess].TimeOfDay) + Environment.NewLine;

                            break;
                        case 5:
                            ItemInformationTextBox.Text += "Latitude: " + Math.Round(l10[rowMess].latitude,3) + " º" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Longitude: " + Math.Round(l10[rowMess].longitude,3) + " º" + Environment.NewLine;
                            break;
                        case 6:
                            ItemInformationTextBox.Text += "rho: " + l10[rowMess].rho + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "theta: " + l10[rowMess].theta + " º"+ Environment.NewLine;

                            break;
                        case 7:
                            ItemInformationTextBox.Text += "x: " + l10[rowMess].x + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "y: " + l10[rowMess].y + " m" + Environment.NewLine;

                            break;
                        case 8:
                            ItemInformationTextBox.Text += "Ground speed: " + Math.Round(l10[rowMess].groundSpeed,3) + " kt" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Track angle: " + Math.Round(l10[rowMess].trackAngle)+ " º" + Environment.NewLine;
                            break;
                        case 9:
                            ItemInformationTextBox.Text += "Vx: " + l10[rowMess].Vx + " m/s" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Vy: " + l10[rowMess].Vy + " m/s" + Environment.NewLine;
                            break;
                        case 10:
                            ItemInformationTextBox.Text += "Track number: " + l10[rowMess].trackNumber + Environment.NewLine;

                            break;
                        case 11:
                            ItemInformationTextBox.Text += "CNF: " + l10[rowMess].CNF + Environment.NewLine;
                            ItemInformationTextBox.Text += "TRE: " + l10[rowMess].TRE + Environment.NewLine;
                            ItemInformationTextBox.Text += "CST: " + l10[rowMess].CST + Environment.NewLine;
                            ItemInformationTextBox.Text += "MAH: " + l10[rowMess].MAH + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCC: " + l10[rowMess].TCC + Environment.NewLine;
                            ItemInformationTextBox.Text += "STH: " + l10[rowMess].STH + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOM: " + l10[rowMess].TOM + Environment.NewLine;
                            ItemInformationTextBox.Text += "DOU: " + l10[rowMess].DOU + Environment.NewLine;
                            ItemInformationTextBox.Text += "MSR: " + l10[rowMess].MSR + Environment.NewLine;
                            ItemInformationTextBox.Text += "GHO: " + l10[rowMess].GHO + Environment.NewLine;

                            break;
                        case 12:
                            ItemInformationTextBox.Text += "V 3A: " + l10[rowMess].V_3A + Environment.NewLine;
                            ItemInformationTextBox.Text += "G 3A: " + l10[rowMess].G_3A + Environment.NewLine;
                            ItemInformationTextBox.Text += "L: " + l10[rowMess].L + Environment.NewLine;
                            ItemInformationTextBox.Text += "Mode 3A: " + l10[rowMess].mode3A + Environment.NewLine;

                            break;
                        case 13:
                            ItemInformationTextBox.Text += "Target Address: " + l10[rowMess].targetAddress + Environment.NewLine;

                            break;
                        case 14:
                            ItemInformationTextBox.Text += "STI: " + l10[rowMess].STI + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Identification: " + l10[rowMess].targetIdentification + Environment.NewLine;

                            break;
                        case 15:
                            ItemInformationTextBox.Text += "REP: " + l10[rowMess].REP_ModeSMB + Environment.NewLine;
                            for (int j = 0; j < l10[rowMess].REP_ModeSMB; j++)
                            {
                                ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "MB Data: " + l10[rowMess].GetMBDataList()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS1: " + l10[rowMess].GetBDS1List()[j] + Environment.NewLine;
                                ItemInformationTextBox.Text += "BDS2: " + l10[rowMess].GetBDS2List()[j] + Environment.NewLine;
                            }

                            break;
                        case 16:
                            ItemInformationTextBox.Text += "VFI: " + l10[rowMess].VFI + Environment.NewLine;

                            break;
                        case 17:
                            ItemInformationTextBox.Text += "V FL: " + l10[rowMess].V_FL + Environment.NewLine;
                            ItemInformationTextBox.Text += "G FL: " + l10[rowMess].G_FL + Environment.NewLine;
                            ItemInformationTextBox.Text += "Flight level: " + l10[rowMess].flightLevel + Environment.NewLine;

                            break;
                        case 18:
                            ItemInformationTextBox.Text += "Height: " + l10[rowMess].height + " ft" + Environment.NewLine;

                            break;
                        case 19:
                            ItemInformationTextBox.Text += "Target Length: " + l10[rowMess].targetLength + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Orientation: " + l10[rowMess].targetOrientation + " º" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Target Width: " + l10[rowMess].targetWidth + " m" + Environment.NewLine;
                            break;
                        case 20:
                            ItemInformationTextBox.Text += "NOGO: " + l10[rowMess].NOGO + Environment.NewLine;
                            ItemInformationTextBox.Text += "OVL: " + l10[rowMess].OVL + Environment.NewLine;
                            ItemInformationTextBox.Text += "TSV: " + l10[rowMess].TSV + Environment.NewLine;
                            ItemInformationTextBox.Text += "DIV: " + l10[rowMess].DIV + Environment.NewLine;
                            ItemInformationTextBox.Text += "TTF: " + l10[rowMess].TTF + Environment.NewLine;

                            break;
                        case 21:
                            ItemInformationTextBox.Text += "TRB: " + l10[rowMess].TRB + Environment.NewLine;
                            ItemInformationTextBox.Text += "MSG: " + l10[rowMess].MSG + Environment.NewLine;

                            break;
                        case 22:
                            ItemInformationTextBox.Text += "Sigma X: " + l10[rowMess].sigmax + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Sigma Y: " + l10[rowMess].sigmay + " m" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Sigma XY: " + l10[rowMess].sigmaxy + " m^2" + Environment.NewLine;

                            break;
                        case 23:
                            ItemInformationTextBox.Text += "REP: " + l10[rowMess].REP_presence + Environment.NewLine;
                            for (int j = 0; j < l10[rowMess].REP_presence; j++)
                            {
                                ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                                ItemInformationTextBox.Text += "Rho : " + l10[rowMess].GetRhoThetaPresenceList()[j][0] + " m" + Environment.NewLine;
                                ItemInformationTextBox.Text += "Theta : " + l10[rowMess].GetRhoThetaPresenceList()[j][1] +" º" + Environment.NewLine;

                            }

                            break;
                        case 24:
                            ItemInformationTextBox.Text += "PAM: " + l10[rowMess].PAM + Environment.NewLine;

                            break;
                        case 25:
                            ItemInformationTextBox.Text += "Ax: " + l10[rowMess].Ax + " m/s^2" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Ay: " + l10[rowMess].Ay + " m/s^2" + Environment.NewLine;
                            break;
                        case 26:

                            break;
                        case 27:
                            ItemInformationTextBox.Text += "Special Purpose: " + l10[rowMess].specialPurpose + Environment.NewLine;
                            break;
                        case 28:
                            ItemInformationTextBox.Text += "Reserved Field: " + l10[rowMess].reservedField + Environment.NewLine;

                            break;
                    }

                    dataItemLabel.Text = l10[rowMess].GetItemList()[rowDItem][2];
            
            break;
            case 1:
                FRN = Convert.ToInt32(l21[rowMess].GetItemList()[rowDItem][0]);
                switch (FRN)
                {
                    case 1:
                        ItemInformationTextBox.Text += "SAC: " + l21[rowMess].SAC + Environment.NewLine;
                        ItemInformationTextBox.Text += "SIC: " + l21[rowMess].SIC + Environment.NewLine;

                        break;
                    case 2:
                        ItemInformationTextBox.Text += "ATP: " + l21[rowMess].ATP + Environment.NewLine;
                        ItemInformationTextBox.Text += "ARC: " + l21[rowMess].ARC + Environment.NewLine;
                        ItemInformationTextBox.Text += "RC: " + l21[rowMess].RC + Environment.NewLine;
                        ItemInformationTextBox.Text += "RAB: " + l21[rowMess].RAB + Environment.NewLine;
                        ItemInformationTextBox.Text += "DCR: " + l21[rowMess].DCR + Environment.NewLine;
                        ItemInformationTextBox.Text += "GBS: " + l21[rowMess].GBS + Environment.NewLine;
                        ItemInformationTextBox.Text += "SIM: " + l21[rowMess].SIM + Environment.NewLine;
                        ItemInformationTextBox.Text += "TST: " + l21[rowMess].TST + Environment.NewLine;
                        ItemInformationTextBox.Text += "SAA: " + l21[rowMess].SAA + Environment.NewLine;
                        ItemInformationTextBox.Text += "CL: " + l21[rowMess].CL + Environment.NewLine;
                        ItemInformationTextBox.Text += "IPC: " + l21[rowMess].IPC + Environment.NewLine;
                        ItemInformationTextBox.Text += "NOGO: " + l21[rowMess].NOGO + Environment.NewLine;
                        ItemInformationTextBox.Text += "CPR: " + l21[rowMess].CPR + Environment.NewLine;
                        ItemInformationTextBox.Text += "LDPJ: " + l21[rowMess].LDPJ + Environment.NewLine;
                        ItemInformationTextBox.Text += "RCF: " + l21[rowMess].RCF + Environment.NewLine;


                        break;
                    case 3:

                        ItemInformationTextBox.Text += "Track Number: " + l21[rowMess].trackNumber + Environment.NewLine;

                        break;
                    case 4:

                        ItemInformationTextBox.Text += "Service Identification: " + l21[rowMess].serviceIdentification + Environment.NewLine;

                        break;
                    case 5:
                        ItemInformationTextBox.Text += "Time of Applicability for position: " + l21[rowMess].convert2TimeOfDay(l21[rowMess].timeOfAppPos) + Environment.NewLine;
                        break;
                    case 6:
                        ItemInformationTextBox.Text += "Latitude: " + Math.Round(l21[rowMess].latitude,3) + " degrees" + Environment.NewLine;
                        ItemInformationTextBox.Text += "Longitude: " + Math.Round(l21[rowMess].longitude,3) + " degrees" + Environment.NewLine;
                        break;
                    case 7:
                        ItemInformationTextBox.Text += "High Resolution Latitude: " + Math.Round(l21[rowMess].HRlatitude,5) + " degrees" + Environment.NewLine;
                        ItemInformationTextBox.Text += "High Resolution Longitude: " + Math.Round(l21[rowMess].HRlongitude,5) + " degrees" + Environment.NewLine;
                        break;
                    case 8:
                        ItemInformationTextBox.Text += "Time of Applicability for Velocity: " + l21[rowMess].timeOfAppVel + Environment.NewLine;
                        break;
                    case 9:
                        ItemInformationTextBox.Text += "Type speed: " + l21[rowMess].typeSpeed + Environment.NewLine;

                        ItemInformationTextBox.Text += l21[rowMess].typeSpeed == "IAS" ? ("Air Speed: " + l21[rowMess].airSpeed + " m/s" + Environment.NewLine) : ("Air Speed: " + l21[rowMess].airSpeed + "Mach" + Environment.NewLine);
                        break;
                    case 10:
                        ItemInformationTextBox.Text += "RE: " + l21[rowMess].RE + Environment.NewLine;
                        ItemInformationTextBox.Text += "True air speed: " + l21[rowMess].trueAirSpeed + " m/s" + Environment.NewLine;
                        break;
                    case 11:
                        ItemInformationTextBox.Text += "Target address: " + l21[rowMess].targetAddress + Environment.NewLine;
                        break;
                    case 12:
                        ItemInformationTextBox.Text += "Time of Message Reception Reception of position : " + l21[rowMess].timeReceptPos + " s" + Environment.NewLine;
                        break;
                    case 13:
                        ItemInformationTextBox.Text += "Time of Message Reception Reception of position - High Precision: " + l21[rowMess].timeReceptPosHP + " s" + Environment.NewLine;
                        break;
                    case 14:
                        ItemInformationTextBox.Text += "Time of Message Reception Reception of Velocity: " + l21[rowMess].timeReceptVel + " s" + Environment.NewLine;
                        break;
                    case 15:
                        ItemInformationTextBox.Text += "Time of Message Reception Reception of Velocity - High Precision: " + l21[rowMess].timeReceptVelHP + " s" + Environment.NewLine;
                        break;
                    case 16:
                        ItemInformationTextBox.Text += "Geometric Height: " + l21[rowMess].geometricHeight + " ft" + Environment.NewLine;
                        break;
                    case 17:
                        ItemInformationTextBox.Text += "NUCr or NACv: " + l21[rowMess].NUCr + Environment.NewLine;
                        ItemInformationTextBox.Text += "NUCp or NIC: " + l21[rowMess].NUCp + Environment.NewLine;
                        ItemInformationTextBox.Text += "NICbaro: " + l21[rowMess].NICbaro + Environment.NewLine;
                        ItemInformationTextBox.Text += "SIL: " + l21[rowMess].SIL1 + Environment.NewLine;
                        ItemInformationTextBox.Text += "NACp: " + l21[rowMess].NACp + Environment.NewLine;
                        ItemInformationTextBox.Text += "NUCr or NACv: " + l21[rowMess].NUCr + Environment.NewLine;
                        ItemInformationTextBox.Text += "SIL: " + l21[rowMess].SIL2 + Environment.NewLine;
                        ItemInformationTextBox.Text += "SDA: " + l21[rowMess].SDA + Environment.NewLine;
                        ItemInformationTextBox.Text += "GVA: " + l21[rowMess].GVA + Environment.NewLine;
                        ItemInformationTextBox.Text += "PIC: " + l21[rowMess].PIC + Environment.NewLine;
                        break;
                    case 18:
                        ItemInformationTextBox.Text += "VNS: " + l21[rowMess].VNS + Environment.NewLine;
                        ItemInformationTextBox.Text += "VN: " + l21[rowMess].VN + Environment.NewLine;
                        ItemInformationTextBox.Text += "LTT: " + l21[rowMess].PIC + Environment.NewLine;
                        break;
                    case 19:
                        ItemInformationTextBox.Text += "Mode 3/A: " + l21[rowMess].mode3A + Environment.NewLine;
                        break;
                    case 20:
                        ItemInformationTextBox.Text += "Roll Angle: " + l21[rowMess].rollAngle + " degrees" + Environment.NewLine;
                        break;
                    case 21:
                        ItemInformationTextBox.Text += "Flight Level: " + l21[rowMess].flightLevel + " FL" + Environment.NewLine;

                        break;
                    case 22:
                        ItemInformationTextBox.Text += "Magnetic Heading: " + l21[rowMess].magneticHeading + " degrees" + Environment.NewLine;

                        break;
                    case 23:
                        ItemInformationTextBox.Text += "ICF: " + l21[rowMess].ICF + Environment.NewLine;
                        ItemInformationTextBox.Text += "LNAV: " + l21[rowMess].LNAV + Environment.NewLine;
                        ItemInformationTextBox.Text += "PS: " + l21[rowMess].PS + Environment.NewLine;

                        break;
                    case 24:

                        ItemInformationTextBox.Text += "RE: " + l21[rowMess].RE_BVR + Environment.NewLine;
                        ItemInformationTextBox.Text += "BVR: " + l21[rowMess].barometricVerticalRate + " feet/minute" + Environment.NewLine;

                        break;
                    case 25:

                        ItemInformationTextBox.Text += "RE: " + l21[rowMess].RE_GVR + Environment.NewLine;
                        ItemInformationTextBox.Text += "GVR: " + l21[rowMess].geometricVerticalRate + " feet/minute" + Environment.NewLine;

                        break;
                    case 26:
                        ItemInformationTextBox.Text += "Ground Speed: " + l21[rowMess].groundSpeed + " NM/s" + Environment.NewLine;
                        ItemInformationTextBox.Text += "Track Angle: " + l21[rowMess].trackAngle + " degrees" + Environment.NewLine;

                        break;
                    case 27:
                        ItemInformationTextBox.Text += "Track Angle Rate: " + l21[rowMess].trackAngleRate + " degrees/s" + Environment.NewLine;
                        break;
                    case 28:
                        ItemInformationTextBox.Text += "Time of report Transmission: " + l21[rowMess].timeReportTrans + " s" + Environment.NewLine;
                        break;
                    case 29:
                        ItemInformationTextBox.Text += "Target Identification: " + l21[rowMess].targetIdentification + Environment.NewLine;
                        break;
                    case 30:
                        ItemInformationTextBox.Text += "Emmiter Category: " + l21[rowMess].ECAT + Environment.NewLine;
                        break;
                    case 31:
                        ItemInformationTextBox.Text += l21[rowMess].WS + " " + "Wind Speed: " + l21[rowMess].windSpeed + " knot" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].WD + " " + "Wind Direction: " + l21[rowMess].windDirection + " degrees" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TMP + " " + "Temperature: " + l21[rowMess].temperature + " ºC" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TRB + " " + "Turbulence: " + l21[rowMess].turbulence + Environment.NewLine;
                        break;
                    case 32:
                        ItemInformationTextBox.Text += "SAS: " + l21[rowMess].SAS + Environment.NewLine;
                        ItemInformationTextBox.Text += "Source: " + l21[rowMess].source + Environment.NewLine;
                        ItemInformationTextBox.Text += "Altitude: " + l21[rowMess].altitude + " ft" + Environment.NewLine;
                        break;
                    case 33:
                        ItemInformationTextBox.Text += "MV: " + l21[rowMess].MV + Environment.NewLine;
                        ItemInformationTextBox.Text += "AH: " + l21[rowMess].AH + Environment.NewLine;
                        ItemInformationTextBox.Text += "AM: " + l21[rowMess].AM + Environment.NewLine;
                        ItemInformationTextBox.Text += "Altitude: " + l21[rowMess].altitudeFSS + Environment.NewLine;
                        break;
                    case 34:
                        ItemInformationTextBox.Text += "TIS: " + l21[rowMess].TIS + Environment.NewLine;
                        ItemInformationTextBox.Text += "TID: " + l21[rowMess].TID + Environment.NewLine;
                        ItemInformationTextBox.Text += "NAV: " + l21[rowMess].NAV + Environment.NewLine;
                        ItemInformationTextBox.Text += "TIS: " + l21[rowMess].TIS + Environment.NewLine;
                        ItemInformationTextBox.Text += "NVB: " + l21[rowMess].NVB + Environment.NewLine;
                        ItemInformationTextBox.Text += "REP: " + l21[rowMess].RE + Environment.NewLine;
                        for (int j = 0; j < l21[rowMess].REP; j++)
                        {
                            ItemInformationTextBox.Text += "Id: " + (j + 1) + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCA: " + l21[rowMess].GetTCAList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCA: " + l21[rowMess].GetTCAList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "NC: " + l21[rowMess].GetNCList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TCP number: " + l21[rowMess].GetTCPList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "Altitude : " + l21[rowMess].GetTIAList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "Latitude: " + l21[rowMess].GetLatList()[j] + " degree" + Environment.NewLine;
                            ItemInformationTextBox.Text += "Longitude: " + l21[rowMess].GetLongList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "Point Type: " + l21[rowMess].GetPTypeList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TD: " + l21[rowMess].GetTDList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TRA: " + l21[rowMess].GetTRAList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOA: " + l21[rowMess].GetTOAList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TOV: " + l21[rowMess].GetTOVList()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "TTR: " + l21[rowMess].GetTTRList()[j] + Environment.NewLine;

                        }
                        break;
                    case 35:
                        ItemInformationTextBox.Text += "RP: " + l21[rowMess].reportPeriod + " s" + Environment.NewLine;
                        break;
                    case 36:
                        ItemInformationTextBox.Text += "RA: " + l21[rowMess].RA + Environment.NewLine;
                        ItemInformationTextBox.Text += "TC: " + l21[rowMess].TC + Environment.NewLine;
                        ItemInformationTextBox.Text += "TS: " + l21[rowMess].TS + Environment.NewLine;
                        ItemInformationTextBox.Text += "ARV: " + l21[rowMess].ARV + Environment.NewLine;
                        ItemInformationTextBox.Text += "CDTI/A: " + l21[rowMess].CDTIA + Environment.NewLine;
                        ItemInformationTextBox.Text += "TCAS: " + l21[rowMess].NotTCAS + Environment.NewLine;
                        ItemInformationTextBox.Text += "SA: " + l21[rowMess].SA + Environment.NewLine;
                        break;
                    case 37:
                        ItemInformationTextBox.Text += "POA: " + l21[rowMess].POA + Environment.NewLine;
                        ItemInformationTextBox.Text += "CTDI/S: " + l21[rowMess].CTDIS + Environment.NewLine;
                        ItemInformationTextBox.Text += "B2 low: " + l21[rowMess].B2low + Environment.NewLine;
                        ItemInformationTextBox.Text += "RAS: " + l21[rowMess].RAS + Environment.NewLine;
                        ItemInformationTextBox.Text += "IDENT: " + l21[rowMess].IDENT + Environment.NewLine;
                        ItemInformationTextBox.Text += "L+W: " + l21[rowMess].LandW + Environment.NewLine;
                        break;
                    case 38:
                        ItemInformationTextBox.Text += "Message Amplitude: " + l21[rowMess].messageAmplitude + " dBm" + Environment.NewLine;
                        break;
                    case 39:
                        ItemInformationTextBox.Text += "REP: " + l21[rowMess].REP_ModeSMB + Environment.NewLine;
                        for (int j = 0; j < l21[rowMess].REP_ModeSMB; j++)
                        {
                            ItemInformationTextBox.Text += "ID: " + (j + 1) + Environment.NewLine;
                            ItemInformationTextBox.Text += "MB Data: " + l21[rowMess].GetMBData()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "BDS1: " + l21[rowMess].GetBDS1()[j] + Environment.NewLine;
                            ItemInformationTextBox.Text += "BDS2: " + l21[rowMess].GetBDS2()[j] + Environment.NewLine;

                        }
                        break;
                    case 40:

                        break;
                    case 41:
                        ItemInformationTextBox.Text += "Receiver ID: " + l21[rowMess].RID + Environment.NewLine;
                        break;
                    case 42:
                        ItemInformationTextBox.Text += l21[rowMess].AOS_DA + " Aircraft Operational Status age: " + l21[rowMess].AOS_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TRD_DA + " Target Report Descriptor age: " + l21[rowMess].TRD_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].M3A + " Mode 3/A Code age: " + l21[rowMess].M3A_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].QI + " Quality Indicators age: " + l21[rowMess].QI_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TI1_DA + " Trajectory Intent age: " + l21[rowMess].TI1_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].MAM_DA + " Message Amplitude age: " + l21[rowMess].MAM_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].GH_DA + " Geometric Height age: " + l21[rowMess].GH_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].FL_DA + " Flight Level age: " + l21[rowMess].FL_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].ISA_DA + " Intermediate State Selected Altitude age: " + l21[rowMess].ISA_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].FSA_DA + " Final State Selected Altitude age: " + l21[rowMess].FSA_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].AS_DA + " Air Speed age: " + l21[rowMess].AS_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TAS_DA + " True Air Speed age: " + l21[rowMess].TAS_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].MH_DA + " Magnetic Heading age: " + l21[rowMess].MH_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].BVR_DA + " Barometric Vertical Rate age: " + l21[rowMess].BVR_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].GVR_DA + " Geometric Vertical Rate age: " + l21[rowMess].GVR_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].GV_DA + " Ground Vector age: " + l21[rowMess].GV_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TAR_DA + " Track Angle Rate age: " + l21[rowMess].TAR_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TI2_DA + " Target Identification age: " + l21[rowMess].TI2_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].TS_DA + " Target Status age: " + l21[rowMess].TS_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].MET_DA + " Met Information age: " + l21[rowMess].MET_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].ROA_DA + " Roll Angle age: " + l21[rowMess].ROA_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].ARA_DA + " ACAS Resolution Advisory age: " + l21[rowMess].ARA_data + " s" + Environment.NewLine;
                        ItemInformationTextBox.Text += l21[rowMess].SCC_DA + "Surface Capabilities and Characteristics age: " + l21[rowMess].SCC_data + " s" + Environment.NewLine;

                        break;
                    case 48:
                        ItemInformationTextBox.Text += "Reserver Expansion Field: " + Environment.NewLine;
                        break;
                    case 49:
                        ItemInformationTextBox.Text += "Special Purpose Field: " + Environment.NewLine;
                        break;
                }



                dataItemLabel.Text = l21[rowMess].GetItemList()[rowDItem][2];
            break;
            }
        

             

            //for (int j = 0; j<itemList.Count; j++)
            //{
                
            //    ItemInformationTextBox.Text += itemList[j]+Environment.NewLine;
            //}


        }




        public void SearchAttributes(string searchText)
        {
            switch (flag)
            {
                case 0:
                    messagedataGrid.DataSource = l10.Where(x => x.targetIdentification.Contains (searchText));
                break;

            }
            

        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }



        private void csvbutton_Click(object sender, EventArgs e)
        {
            DataGridView dg = new DataGridView();
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (flag)
                {
                    case 0:



                            dg.ColumnCount = 21;
                            dg.RowCount = l10.Count;
                            dg.Columns[0].HeaderText = "ID";
                            dg.Columns[1].HeaderText = "CAT";
                            dg.Columns[2].HeaderText = "[Data Source Identifier] SAC";
                            dg.Columns[3].HeaderText = "[Data Source Identifier] SIC";
                            dg.Columns[4].HeaderText = "[Message Type] ";
                            dg.Columns[5].HeaderText = "[Target Report Descriptor] TYP";
                            dg.Columns[6].HeaderText = "[Target Report Descriptor] DCR";
                            dg.Columns[7].HeaderText = "[Target Report Descriptor] CHN";
                            dg.Columns[8].HeaderText = "[Target Report Descriptor] GBS";
                            dg.Columns[9].HeaderText = "[Target Report Descriptor] CRT";
                            dg.Columns[10].HeaderText = "[Target Report Descriptor] SIM";
                            dg.Columns[11].HeaderText = "[Target Report Descriptor] TST";
                            dg.Columns[12].HeaderText = "[Target Report Descriptor] RAB";
                            dg.Columns[13].HeaderText = "[Target Report Descriptor] LOP";
                            dg.Columns[14].HeaderText = "[Target Report Descriptor] TOT";
                            dg.Columns[15].HeaderText = "[Target Report Descriptor] SPI";
                            dg.Columns[16].HeaderText = "[Time of day]";
                            dg.Columns[17].HeaderText = "[WGS-84 Coordinates] Latitude (º)";
                            dg.Columns[18].HeaderText = "[WGS-84 Coordinates] Longitude (º)";
                            dg.Columns[19].HeaderText = "[Measured Position in Polar Coordinates] RHO (m)";
                            dg.Columns[20].HeaderText = "[Measured Position in Polar Coordinates] THETA (º)";





                            for (int i = 0; i < l10.Count; i++)
                            {
                                dg.ColumnCount = 21;
                                dg.Rows[i].Cells[0].Value = i;
                                dg.Rows[i].Cells[1].Value = 10;
                                dg.Rows[i].Cells[2].Value = l10[i].SAC;
                                dg.Rows[i].Cells[3].Value = l10[i].SIC;
                                dg.Rows[i].Cells[4].Value = l10[i].MessageType;
                                dg.Rows[i].Cells[5].Value = l10[i].TYP;
                                dg.Rows[i].Cells[6].Value = l10[i].DCR;
                                dg.Rows[i].Cells[7].Value = l10[i].CHN;
                                dg.Rows[i].Cells[8].Value = l10[i].GBS;
                                dg.Rows[i].Cells[9].Value = l10[i].CRT;
                                dg.Rows[i].Cells[10].Value = l10[i].SIM;
                                dg.Rows[i].Cells[11].Value = l10[i].TST;
                                dg.Rows[i].Cells[12].Value = l10[i].RAB;
                                dg.Rows[i].Cells[13].Value = l10[i].LOP;
                                dg.Rows[i].Cells[14].Value = l10[i].TOT;
                                dg.Rows[i].Cells[15].Value = l10[i].SPI;
                                dg.Rows[i].Cells[16].Value = TimeSpan.FromSeconds(l10[i].TimeOfDay).ToString(@"hh\:mm\:ss");
                                dg.Rows[i].Cells[17].Value = l10[i].latitude;
                                dg.Rows[i].Cells[18].Value = l10[i].longitude;
                                dg.Rows[i].Cells[19].Value = l10[i].rho;
                                dg.Rows[i].Cells[20].Value = l10[i].theta;


                            }
                            


                            break;
                    case 1:


                        dg.ColumnCount = 118;
                        dg.RowCount = l21.Count;
                        dg.Columns[0].HeaderText = "ID";
                        dg.Columns[1].HeaderText = "CAT";
                        dg.Columns[2].HeaderText = "[Data Source Identifier] SAC";
                        dg.Columns[3].HeaderText = "[Data Source Identifier] SIC";
                        dg.Columns[4].HeaderText = "[Target Report Descriptor] ATP";
                        dg.Columns[5].HeaderText = "[Target Report Descriptor] ARC";
                        dg.Columns[6].HeaderText = "[Target Report Descriptor] RC";
                        dg.Columns[7].HeaderText = "[Target Report Descriptor] RAB";
                        dg.Columns[8].HeaderText = "[Target Report Descriptor] DCR";
                        dg.Columns[9].HeaderText = "[Target Report Descriptor] GBS";
                        dg.Columns[10].HeaderText = "[Target Report Descriptor] SIM";
                        dg.Columns[11].HeaderText = "[Target Report Descriptor] TST";
                        dg.Columns[12].HeaderText = "[Target Report Descriptor] SAA";
                        dg.Columns[13].HeaderText = "[Target Report Descriptor] CL";
                        dg.Columns[14].HeaderText = "[Target Report Descriptor] IPC";
                        dg.Columns[15].HeaderText = "[Target Report Descriptor] NOGO";
                        dg.Columns[16].HeaderText = "[Target Report Descriptor] CPR";
                        dg.Columns[17].HeaderText = "[Target Report Descriptor] LDPJ";
                        dg.Columns[18].HeaderText = "[Target Report Descriptor] RCF";
                        dg.Columns[19].HeaderText = "[Track Number]";
                        dg.Columns[20].HeaderText = "[Service Identification]";
                        dg.Columns[21].HeaderText = "[Time of Applicability for Position]";
                        dg.Columns[22].HeaderText = "[Position in WGS-84 Coordinates] Latitude (º)";
                        dg.Columns[23].HeaderText = "[Position in WGS-84 Coordinates] Longitude (º)";
                        dg.Columns[24].HeaderText = "[High-Resolution Position in WGS-84 Coordinates] Latitude (º)";
                        dg.Columns[25].HeaderText = "[High-Resolution Position in WGS-84 Coordinates] Longitude (º)";
                        dg.Columns[26].HeaderText = "[Time of Applicability for Velocity] (s)";
                        dg.Columns[27].HeaderText = "[Air Speed] IM";
                        dg.Columns[28].HeaderText = "[Air Speed] IAS/MACH (NM/s or Mach)";
                        dg.Columns[29].HeaderText = "[True Airspeed] RE";
                        dg.Columns[30].HeaderText = "[True Airspeed] (knot)";
                        dg.Columns[31].HeaderText = "[Target Address]";
                        dg.Columns[32].HeaderText = "[Time of Message Reception for Position]";
                        dg.Columns[33].HeaderText = "[Time of Message Reception of Position–High Precision]";
                        dg.Columns[34].HeaderText = "[Time of Message Reception for Velocity]";
                        dg.Columns[35].HeaderText = "[Time of Message Reception of Velocity–High Precision]";
                        dg.Columns[36].HeaderText = "[Geometric Height] (ft)";
                        dg.Columns[37].HeaderText = "[Quality Indicators] NUCr or NACv";
                        dg.Columns[38].HeaderText = "[Quality Indicators] NUCp or NIC";
                        dg.Columns[39].HeaderText = "[Quality Indicators] NIC BARO";
                        dg.Columns[40].HeaderText = "[Quality Indicators] SIL (I)";
                        dg.Columns[41].HeaderText = "[Quality Indicators] NACp";
                        dg.Columns[42].HeaderText = "[Quality Indicators] SIL (II)";
                        dg.Columns[43].HeaderText = "[Quality Indicators] SDA";
                        dg.Columns[44].HeaderText = "[Quality Indicators] GVA";
                        dg.Columns[45].HeaderText = "[Quality Indicators] PIC";
                        dg.Columns[46].HeaderText = "[MOPS Version] VNS";
                        dg.Columns[47].HeaderText = "[MOPS Version] VN";
                        dg.Columns[48].HeaderText = "[MOPS Version] LTT";
                        dg.Columns[49].HeaderText = "[Mode 3/A Code in Octal Representation] ";
                        dg.Columns[50].HeaderText = "[Roll Angle] (degree)";
                        dg.Columns[51].HeaderText = "[Flight Level] (FL)";
                        dg.Columns[52].HeaderText = "[Magnetic Heading] (º)";
                        dg.Columns[53].HeaderText = "[Target Status] ICF";
                        dg.Columns[54].HeaderText = "[Target Status] LNAV";
                        dg.Columns[55].HeaderText = "[Target Status] PS";
                        dg.Columns[56].HeaderText = "[Target Status] SS";
                        dg.Columns[57].HeaderText = "[Barometric Vertical Rate] RE";
                        dg.Columns[58].HeaderText = "[Barometric Vertical Rate] BVR (ft/min)";
                        dg.Columns[59].HeaderText = "[Geometric Vertical Rate]";
                        dg.Columns[60].HeaderText = "[Geometric Vertical Rate] GVR (ft/min)";
                        dg.Columns[61].HeaderText = "[Airborne Ground Vector] RE";
                        dg.Columns[62].HeaderText = "[Airborne Ground Vector] Ground Speed (NM/s)";
                        dg.Columns[63].HeaderText = "[Airborne Ground Vector] Track Angle (degree)";
                        dg.Columns[64].HeaderText = "[Track Angle Rate]  (º/s)";
                        dg.Columns[65].HeaderText = "[Time of ASTERIX Report Transmission]";
                        dg.Columns[66].HeaderText = "[Target Identification]";
                        dg.Columns[67].HeaderText = "[Emitter Category]";
                        dg.Columns[68].HeaderText = "[Met Information] Wind Speed (knot)";
                        dg.Columns[69].HeaderText = "[Met Information] Wind Direction (degree)";
                        dg.Columns[70].HeaderText = "[Met Information] Temperature (ºC)";
                        dg.Columns[71].HeaderText = "[Met Information] Turbulence ";
                        dg.Columns[72].HeaderText = "[Selected Altitude] SAS ";
                        dg.Columns[73].HeaderText = "[Selected Altitude] Source ";
                        dg.Columns[74].HeaderText = "[Selected Altitude] Altitude (ft) ";
                        dg.Columns[75].HeaderText = "[Final State Selected Altitude] MV ";
                        dg.Columns[76].HeaderText = "[Final State Selected Altitude] AH ";
                        dg.Columns[77].HeaderText = "[Final State Selected Altitude] AM ";
                        dg.Columns[78].HeaderText = "[Final State Selected Altitude] Altitude (ft) ";
                        dg.Columns[79].HeaderText = "[Service Management] Report Period (s)";
                        dg.Columns[80].HeaderText = "[Aircraft Operational Status] RA";
                        dg.Columns[81].HeaderText = "[Aircraft Operational Status] TC";
                        dg.Columns[82].HeaderText = "[Aircraft Operational Status] TS";
                        dg.Columns[83].HeaderText = "[Aircraft Operational Status] ARV";
                        dg.Columns[84].HeaderText = "[Aircraft Operational Status] CTDT/A";
                        dg.Columns[85].HeaderText = "[Aircraft Operational Status] NOT CAS";
                        dg.Columns[86].HeaderText = "[Aircraft Operational Status] SA";
                        dg.Columns[87].HeaderText = "[Receiver ID]";
                        dg.Columns[88].HeaderText = "[Message Amplitude] (dBm)";
                        dg.Columns[89].HeaderText = "[Surface Capabilities and Characteristics] POA";
                        dg.Columns[90].HeaderText = "[Surface Capabilities and Characteristics] CTDTI/S";
                        dg.Columns[91].HeaderText = "[Surface Capabilities and Characteristics] B2 LOW";
                        dg.Columns[92].HeaderText = "[Surface Capabilities and Characteristics] RAS";
                        dg.Columns[93].HeaderText = "[Surface Capabilities and Characteristics] IDENT";
                        dg.Columns[94].HeaderText = "[Surface Capabilities and Characteristics] L+W";
                        dg.Columns[95].HeaderText = "[Data Ages] AOS(s)";
                        dg.Columns[96].HeaderText = "[Data Ages] TRD(s)";
                        dg.Columns[97].HeaderText = "[Data Ages] M3A(s)";
                        dg.Columns[98].HeaderText = "[Data Ages] QI(s)";
                        dg.Columns[99].HeaderText = "[Data Ages] TI(s)";
                        dg.Columns[100].HeaderText = "[Data Ages] MAM(s)";
                        dg.Columns[101].HeaderText = "[Data Ages] GH(s)";
                        dg.Columns[102].HeaderText = "[Data Ages] FL(s)";
                        dg.Columns[103].HeaderText = "[Data Ages] ISA(s)";
                        dg.Columns[104].HeaderText = "[Data Ages] FSA(s)";
                        dg.Columns[105].HeaderText = "[Data Ages] AS(s)";
                        dg.Columns[106].HeaderText = "[Data Ages] TAS(s)";
                        dg.Columns[107].HeaderText = "[Data Ages] MH(s)";
                        dg.Columns[108].HeaderText = "[Data Ages] BVR(s)";
                        dg.Columns[109].HeaderText = "[Data Ages] GVR(s)";
                        dg.Columns[110].HeaderText = "[Data Ages] GV(s)";
                        dg.Columns[111].HeaderText = "[Data Ages] TAR(s)";
                        dg.Columns[112].HeaderText = "[Data Ages] TI(s)";
                        dg.Columns[113].HeaderText = "[Data Ages] TS(s)";
                        dg.Columns[114].HeaderText = "[Data Ages] MET(s)";
                        dg.Columns[115].HeaderText = "[Data Ages] ROA(s)";
                        dg.Columns[116].HeaderText = "[Data Ages] ARA(s)";
                        dg.Columns[117].HeaderText = "[Data Ages] SCC(s)";




                        for (int i = 0; i < l21.Count; i++)
                        {
                            dg.Rows[i].Cells[0].Value = i;
                            dg.Rows[i].Cells[1].Value = 21;
                            dg.Rows[i].Cells[2].Value = l21[i].SAC;
                            dg.Rows[i].Cells[3].Value = l21[i].SIC;
                            dg.Rows[i].Cells[4].Value = l21[i].ATP;
                            dg.Rows[i].Cells[5].Value = l21[i].ARC;
                            dg.Rows[i].Cells[6].Value = l21[i].RC;
                            dg.Rows[i].Cells[7].Value = l21[i].RAB;
                            dg.Rows[i].Cells[8].Value = l21[i].DCR;
                            dg.Rows[i].Cells[9].Value = l21[i].GBS;
                            dg.Rows[i].Cells[10].Value = l21[i].SIM;
                            dg.Rows[i].Cells[11].Value = l21[i].TST;
                            dg.Rows[i].Cells[12].Value = l21[i].SAA;
                            dg.Rows[i].Cells[13].Value = l21[i].CL;
                            dg.Rows[i].Cells[14].Value = l21[i].IPC;
                            dg.Rows[i].Cells[15].Value = l21[i].NOGO;
                            dg.Rows[i].Cells[16].Value = l21[i].CPR;
                            dg.Rows[i].Cells[17].Value = l21[i].LDPJ;
                            dg.Rows[i].Cells[18].Value = l21[i].RCF;
                            dg.Rows[i].Cells[19].Value = l21[i].trackNumber;
                            dg.Rows[i].Cells[20].Value = l21[i].serviceIdentification;
                            dg.Rows[i].Cells[21].Value = TimeSpan.FromSeconds(l21[i].timeOfAppPos).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[22].Value =l21[i].latitude;
                            dg.Rows[i].Cells[23].Value = l21[i].longitude;
                            dg.Rows[i].Cells[24].Value = l21[i].HRlatitude;
                            dg.Rows[i].Cells[25].Value = l21[i].HRlongitude;
                            dg.Rows[i].Cells[26].Value = l21[i].timeOfAppVel;
                            dg.Rows[i].Cells[27].Value = l21[i].typeSpeed;
                            dg.Rows[i].Cells[28].Value = l21[i].airSpeed;
                            dg.Rows[i].Cells[29].Value = l21[i].RE;
                            dg.Rows[i].Cells[30].Value = l21[i].trueAirSpeed;
                            dg.Rows[i].Cells[31].Value = l21[i].targetAddress;
                            dg.Rows[i].Cells[32].Value = TimeSpan.FromSeconds(l21[i].timeReceptPos).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[33].Value = TimeSpan.FromSeconds(l21[i].timeReceptPosHP).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[34].Value = TimeSpan.FromSeconds(l21[i].timeReceptVel).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[35].Value = TimeSpan.FromSeconds(l21[i].timeReceptVelHP).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[36].Value = l21[i].geometricHeight;
                            dg.Rows[i].Cells[37].Value = l21[i].NUCr;
                            dg.Rows[i].Cells[38].Value = l21[i].NUCp;
                            dg.Rows[i].Cells[39].Value = l21[i].NICbaro;
                            dg.Rows[i].Cells[40].Value = l21[i].SIL1;
                            dg.Rows[i].Cells[41].Value = l21[i].NACp;
                            dg.Rows[i].Cells[42].Value = l21[i].SIL2;
                            dg.Rows[i].Cells[43].Value = l21[i].SDA;
                            dg.Rows[i].Cells[44].Value = l21[i].GVA;
                            dg.Rows[i].Cells[45].Value = l21[i].PIC;
                            dg.Rows[i].Cells[46].Value = l21[i].VNS;
                            dg.Rows[i].Cells[47].Value = l21[i].VN;
                            dg.Rows[i].Cells[48].Value = l21[i].LTT;
                            dg.Rows[i].Cells[49].Value = l21[i].mode3A;
                            dg.Rows[i].Cells[50].Value = l21[i].rollAngle;
                            dg.Rows[i].Cells[51].Value = l21[i].flightLevel;
                            dg.Rows[i].Cells[52].Value = l21[i].magneticHeading;
                            dg.Rows[i].Cells[53].Value = l21[i].ICF;
                            dg.Rows[i].Cells[54].Value = l21[i].LNAV;
                            dg.Rows[i].Cells[55].Value = l21[i].PS;
                            dg.Rows[i].Cells[56].Value = l21[i].SS;
                            dg.Rows[i].Cells[57].Value = l21[i].RE_BVR;
                            dg.Rows[i].Cells[58].Value = l21[i].barometricVerticalRate;
                            dg.Rows[i].Cells[59].Value = l21[i].RE_GVR;
                            dg.Rows[i].Cells[60].Value = l21[i].geometricVerticalRate;
                            dg.Rows[i].Cells[61].Value = l21[i].RE_GS;
                            dg.Rows[i].Cells[62].Value = l21[i].groundSpeed;
                            dg.Rows[i].Cells[63].Value = l21[i].trackAngle;
                            dg.Rows[i].Cells[64].Value = l21[i].trackAngleRate;
                            dg.Rows[i].Cells[65].Value = TimeSpan.FromSeconds(l21[i].timeReportTrans).ToString(@"hh\:mm\:ss");
                            dg.Rows[i].Cells[66].Value = l21[i].targetIdentification;
                            dg.Rows[i].Cells[67].Value = l21[i].ECAT;
                            dg.Rows[i].Cells[68].Value = l21[i].windSpeed;
                            dg.Rows[i].Cells[69].Value = l21[i].windDirection;
                            dg.Rows[i].Cells[70].Value = l21[i].temperature;
                            dg.Rows[i].Cells[71].Value = l21[i].turbulence;
                            dg.Rows[i].Cells[72].Value = l21[i].SAS;
                            dg.Rows[i].Cells[73].Value = l21[i].source;
                            dg.Rows[i].Cells[74].Value = l21[i].altitude;
                            dg.Rows[i].Cells[75].Value = l21[i].MV;
                            dg.Rows[i].Cells[76].Value = l21[i].AH;
                            dg.Rows[i].Cells[77].Value = l21[i].AM;
                            dg.Rows[i].Cells[78].Value = l21[i].altitudeFSS;
                            dg.Rows[i].Cells[79].Value = l21[i].reportPeriod;
                            dg.Rows[i].Cells[80].Value = l21[i].RA;
                            dg.Rows[i].Cells[81].Value = l21[i].TC;
                            dg.Rows[i].Cells[82].Value = l21[i].TS;
                            dg.Rows[i].Cells[83].Value = l21[i].ARV;
                            dg.Rows[i].Cells[84].Value = l21[i].CDTIA;
                            dg.Rows[i].Cells[85].Value = l21[i].NotTCAS;
                            dg.Rows[i].Cells[86].Value = l21[i].SA;
                            dg.Rows[i].Cells[87].Value = l21[i].RID;
                            dg.Rows[i].Cells[88].Value = l21[i].messageAmplitude;
                            dg.Rows[i].Cells[89].Value = l21[i].POA;
                            dg.Rows[i].Cells[90].Value = l21[i].CTDIS;
                            dg.Rows[i].Cells[91].Value = l21[i].B2low;
                            dg.Rows[i].Cells[92].Value = l21[i].RAS;
                            dg.Rows[i].Cells[93].Value = l21[i].IDENT;
                            dg.Rows[i].Cells[94].Value = l21[i].LandW;
                            dg.Rows[i].Cells[95].Value = l21[i].LandW;
                            dg.Rows[i].Cells[96].Value = l21[i].AOS_data;
                            dg.Rows[i].Cells[97].Value = l21[i].TRD_data;
                            dg.Rows[i].Cells[98].Value = l21[i].QI_data;
                            dg.Rows[i].Cells[99].Value = l21[i].TI1_data;
                            dg.Rows[i].Cells[100].Value = l21[i].MAM_data;
                            dg.Rows[i].Cells[101].Value = l21[i].GH_data;
                            dg.Rows[i].Cells[102].Value = l21[i].FL_data;
                            dg.Rows[i].Cells[103].Value = l21[i].ISA_data;
                            dg.Rows[i].Cells[104].Value = l21[i].FSA_data;
                            dg.Rows[i].Cells[105].Value = l21[i].AS_data;
                            dg.Rows[i].Cells[106].Value = l21[i].TAS_data;
                            dg.Rows[i].Cells[107].Value = l21[i].MH_data;
                            dg.Rows[i].Cells[108].Value = l21[i].BVR_data;
                            dg.Rows[i].Cells[109].Value = l21[i].GVR_data;
                            dg.Rows[i].Cells[110].Value = l21[i].GV_data;
                            dg.Rows[i].Cells[111].Value = l21[i].TAR_data;
                            dg.Rows[i].Cells[112].Value = l21[i].TI2_data;
                            dg.Rows[i].Cells[113].Value = l21[i].TS_data;
                            dg.Rows[i].Cells[114].Value = l21[i].MET_data;
                            dg.Rows[i].Cells[115].Value = l21[i].ROA_data;
                            dg.Rows[i].Cells[116].Value = l21[i].ARA_data;
                            dg.Rows[i].Cells[117].Value = l21[i].SCC_data;




                        }

                        break;
                }




                List<string> rows = new List<string>();
                List<string> header = new List<string>();
                foreach (DataGridViewColumn col in dg.Columns)
                {
                    header.Add(col.HeaderText);
                }
                string SEP = ";";
                rows.Add(string.Join(SEP, header));
                foreach (DataGridViewRow r in dg.Rows)
                {
                    try
                    {
                        List<string> cells = new List<string>();
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            cells.Add(Convert.ToString(c.Value) == string.Empty || Convert.ToString(c.Value) == "0" ? "N/A" : Convert.ToString(c.Value));
                        }
                        rows.Add(string.Join(SEP, cells));
                    }
                    catch (Exception ex) { }

                }
                File.WriteAllLines(sfd.FileName, rows);
            }
        }


    }
}

