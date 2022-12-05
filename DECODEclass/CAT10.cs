using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;


namespace DECODEclass
{
    public class CAT10
    {
        //Atributes
        
        int length; //message's length

        List<string[]> itemList = new List<string[]>();

        public List<string[]> GetItemList()
        {
            return itemList;
        }

        public int GetLength()
        {
            return length;
        }

        //List<byte> FSPEC; //FSPEC
        List<byte> DataFields; //DataFields
                               //------------------DATA SOURCE IDENTIFIER [I010/010]----------------------------------------------------------


        public string SAC { get; set; } //System Area code fixed to zero
        public int SIC { get; set; } //System identification Code

        //--------------------MESSAGE TYPE [I010/000]------------------------------------------------------------------
        public string MessageType { get; set; }



        //------------------TARGET REPORT DESCRIPTOR [I010/020]--------------------------------------------------------
        public string TYP { get; set; }
        public string DCR { get; set; }
        public string CHN { get; set; }
        public string GBS { get; set; }
        public string CRT { get; set; }
        public string SIM { get; set; }
        public string TST { get; set; }
        public string RAB { get; set; }
        public string LOP { get; set; }
        public string TOT { get; set; }
        public string SPI { get; set; }


        //-----------------------------TIME OF DAY [I010/140]--------------------------------------------------------------------------------------------------

       
        public double TimeOfDay { get; set; } // hh:mm:ss

        //------------------------------------------POSITION IN WGS-84 CO-ORDINATES[I010/041]-------------------------------------------------------------------

        public double latitude { get; set; }
        public double longitude { get; set; }

        //--------------------------------------------------------POLAR COORDINATES[I010/040]-------------------------------------------------------------------
        public double rho { get; set; }
        public double theta { get; set; }

        //--------------------------------------------------------CARTESIAN COORDINATES[I010/042]---------------------------------------------------------------
        public int x { get; set; }
        public int y { get; set; }

        //--------------------------------------------------TRACK VELOCITY IN POLAR COORDINATES[I010/200]--------------------------------------------------------
        public double groundSpeed { get; set; }
        public double trackAngle { get; set; }

        //--------------------------------------------TRACK VELOCITY IN CARTESIAN COORDINATES[I010/202]---------------------------------------------------------
        public double Vx { get; set; }
        public double Vy { get; set; }

        //------------------------------------------------------TRACK NUMBER[I010/161]--------------------------------------------------------------------------
        public int trackNumber { get; set; }

        //----------------------------------------------------------TRACK STATUS [I010/170]---------------------------------------------------------------------
        public string CNF { get; set; }
        public string TRE { get; set; }
        public string CST { get; set; }
        public string MAH { get; set; }
        public string TCC { get; set; }
        public string STH { get; set; }
        public string TOM { get; set; }
        public string DOU { get; set; }
        public string MSR { get; set; }
        public string GHO { get; set; }

        //-------------------------------------------------------MODE 3/A CODE IN OCTAL REPRESENTATION[I010/060]--------------------------------------------------
        public string V_3A { get; set; }
        public string G_3A { get; set; }
        public string L { get; set; }
        public string mode3A { get; set; }

        //--------------------------------------------------------------TARGET ADDRESS[I010/220]---------------------------------------------------------------
        public string targetAddress { get; set; }

        //-----------------------------------------------------------TARGET IDENTIFICATION[I010/245]-----------------------------------------------------------------
        public string STI { get; set; }
        public string targetIdentification { get; set; }

        //------------------------------------------------------------MODE S MB DATA[I010/250]--------------------------------------------------------------------

        public int REP_ModeSMB { get; set; }
        List<string> MBData = new List<string>();
        public List<string> GetMBDataList()
        {
            return MBData;
        }
        List<string> BDS1 = new List<string>();
        public List<string> GetBDS1List()
        {
            return BDS1;
        }
        List<string> BDS2 = new List<string>();
        public List<string> GetBDS2List()
        {
            return BDS2;
        }

        //------------------------------------------------------VEHICLE FLEET IDENTIFICATION[I010/300]------------------------------------------------------------

        public string VFI { get; set; }

        //---------------------------------------------------FLIGHT LEVEL IN BINARY REPRESENTATION[I010/090]------------------------------------------------------
        public string V_FL { get; set; }
        public string G_FL { get; set; }
        public string flightLevel { get; set; }

        //----------------------------------------------------------MEASURED HIGHT[I010/091]-----------------------------------------------------------------------

        public double height { get; set; } = -1;

        //------------------------------------------------------TARGET SIZE AND ORIENTATION [I010/270]-------------------------------------------------------------

        public int targetLength { get; set; }
        public double targetOrientation { get; set; }
        public int targetWidth { get; set; }

        //------------------------------------------------------------SYSTEM STATUS[I010/550]----------------------------------------------------------------------
        public string NOGO { get; set; }
        public string OVL { get; set; }
        public string TSV { get; set; }
        public string DIV { get; set; }
        public string TTF { get; set; }
        //------------------------------------------------------------PRE PROGRAMMED MESSAGE[I010/310]-------------------------------------------------------------

        public string TRB { get; set; }
        public string MSG { get; set; }

        //----------------------------------------------------------STANDARD DEVIATION OF POSITION[I010/500]-------------------------------------------------------
        public double sigmax { get; set; }
        public double sigmay { get; set; }
        public double sigmaxy { get; set; }

        //-------------------------------------------------------------------PRESENCE[I010/280]---------------------------------------------------------------

        public int REP_presence { get; set; }
        List<double[]> rho_theta_presenceList = new List<double[]>(); // [drho dtheta]
        public List<double[]> GetRhoThetaPresenceList()
        {
            return rho_theta_presenceList;
        }

        //------------------------------------------------------------AMPLITUDE OF PRIMARY PLOT[I010/131]-------------------------------------------------------------

        public int PAM { get; set; }

        //--------------------------------------------------------------CALCULATED ACCELARATION[I010/210]------------------------------------------------------

        public double Ax { get; set; }
        public double Ay { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------SPECIAL PURPOSE FIELD----------------------------------------------------------------

        public string specialPurpose { get; set; }
        //---------------------------------------------------------------RESERVED FIELD---------------------------------------------------------------------------

        public string reservedField;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------

        //BUILDER
        public CAT10(byte[] message, int length)
        {
            //this.message = message;
            this.length = length;
            List<byte> FSPEC = readFSPEC(message.Skip(3).ToArray()); //The three first byte is CAT (byte 1) and second and third bytes are length
            this.DataFields = new List<byte>(message.Skip(3 + FSPEC.Count).ToArray()); //Only contain DataFields without CAT,LENGTH and FSPEC
            createDataItem(FSPEC); //We calculte each data item of CAT 10
        }

      
        //-----------------------------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //readFSPEC() -> we obtain FSPEC from the message
        public List<byte> readFSPEC(byte[] message)
        {
            List<byte> FSPEC = new List<byte>();


            for (int i = 0; i < message.Length; i++)
            {
                BitArray octect = new BitArray(new byte[] { message[i] });



                FSPEC.Add(message[i]);




                if (octect[0] == false) //If FX=="0" the FSPEC has finished
                {
                    break; //We finished iterarions because the FSPEC is finished
                }

            }

            return FSPEC;

        }

        //createDataItem() -> Create each data item through our FSPEC
        public void createDataItem(List<byte> FSPEC)
        {

            for (int i = 0; i < FSPEC.Count; i++)
            {
                BitArray Ebits = new BitArray(new byte[] { FSPEC[i] });
                switch (i)
                {
                    case 0:
                        if (Ebits[7] == true) { DataItem1(); }
                        if (Ebits[6] == true) { DataItem2(); }
                        if (Ebits[5] == true) { DataItem3(); }
                        if (Ebits[4] == true) { DataItem4(); }
                        if (Ebits[3] == true) { DataItem5(); }
                        if (Ebits[2] == true) { DataItem6(); }
                        if (Ebits[1] == true) { DataItem7(); }

                        break;
                    case 1:
                        if (Ebits[7] == true) { DataItem8(); }
                        if (Ebits[6] == true) { DataItem9(); }
                        if (Ebits[5] == true) { DataItem10(); }
                        if (Ebits[4] == true) { DataItem11(); }
                        if (Ebits[3] == true) { DataItem12(); }
                        if (Ebits[2] == true) { DataItem13(); }
                        if (Ebits[1] == true) { DataItem14(); }
                        break;
                    case 2:
                        if (Ebits[7] == true) { DataItem15(); }
                        if (Ebits[6] == true) { DataItem16(); }
                        if (Ebits[5] == true) { DataItem17(); }
                        if (Ebits[4] == true) { DataItem18(); }
                        if (Ebits[3] == true) { DataItem19(); }
                        if (Ebits[2] == true) { DataItem20(); }
                        if (Ebits[1] == true) { DataItem21(); }
                        break;
                    case 3:
                        if (Ebits[7] == true) { DataItem22(); }
                        if (Ebits[6] == true) { DataItem23(); }
                        if (Ebits[5] == true) { DataItem24(); }
                        if (Ebits[4] == true) { DataItem25(); }
                        //if (Ebits[3] == true) { DataItem26(); }
                        if (Ebits[2] == true) { DataItem27(); }
                        if (Ebits[1] == true) { DataItem28(); }
                        break;

                }

                if (Ebits[0] == false) { break; }

        }
    }

        public string convert2TimeOfDay(double s)
        {
            string data1 = Convert.ToString(s / 3600);
            data1.Split('.');
            string hour = data1[0].ToString();
            string data2 = Convert.ToString((Convert.ToDouble(data1) - Convert.ToDouble(data1[0].ToString())) * 60);
            data2.Split('.');
            string min = data2[0].ToString();
            string seconds = Convert.ToString(Math.Round(((Convert.ToDouble(data2) - Convert.ToDouble(data2[0].ToString())) * 60), 3));


            return hour + " : " + min + " : " + seconds;


        }
        public void printbits(byte B)
        {
            BitArray b = new BitArray(new byte[] { B });
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(Convert.ToInt32(b[i]));
            }
        }

        //ComplementA2() -> Calculate our number "bit" in complement A2
        public List<byte> complementA2(List<byte> list)
        {
            bool take = true;

            for (int j = list.Count - 1; j >= 0; j--) //byte less significant
            {
                BitArray cad = new BitArray(new byte[] { list[j] });

                for (int k = 0; k < cad.Length; k++)
                {
                    cad[k] = cad[k] == false ? true : false; //Complement A1


                    // Add 1 -> Complement A2
                    switch (cad[k])
                    {
                        case true:
                            cad[k] = take == true ? false : true;
                            break;
                        case false:
                            cad[k] = take == true ? true : false;
                            take = false;
                            break;
                    }
                }


                list[j] = ConvertToByte(cad);

            }

            return list; //Return our number "bit" in complement A"


        }

        public double computeData(List<byte> list, double Range, int exp, bool sign)
        {
            if (sign == true)
            {


                //Check sign

                BitArray checksign = new BitArray(new byte[] { list[0] });

                if (checksign[7] == true) //If we have negative number....
                {
                    list = complementA2(list); //Negative number -> Calculate complement A2
                }
                else
                {
                    sign = false; //positive number
                }
            }
            double value = 0;


            for (int j = list.Count - 1; j >= 0; j--)
            {
                BitArray cad = new BitArray(new byte[] { list[j] });

                for (int k = 0; k < cad.Length; k++)
                {
                    value = value + Convert.ToInt32(cad[k]) * Math.Pow(2, exp);
                    exp++;
                }

            }
            value = Range * value;

            if (sign == true && value != 0)
            {
                return -value;
            }
            else
            {
                return value;
            }
        }

        public byte ConvertToByte(BitArray bits)
        {
            if (bits.Count != 8)
            {
                throw new ArgumentException("bits");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }

        void DataItem1()
        {


            itemList.Add(new string[] { "1", "[I010/010]", " Data Source Identifier" });
            this.SAC = "00";

            DataFields.RemoveAt(0); //We eliminate de data field after we decode to save computer memory
            this.SIC = DataFields[0]; //BitConverter.ToString(new byte[] { DataFields[0] }); // !!! Warning I dont know if ihave to use Reverse()



            DataFields.RemoveAt(0);

        }
        void DataItem2()
        {


            itemList.Add(new string[] { "2", "[I010/000]", "Message Type" });

            int Type = Convert.ToInt32(DataFields[0]);

            switch (Type)
            {
                case 1:
                    this.MessageType = "Target Report";
                    break;
                case 2:
                    this.MessageType = "Start of Update Cycle";
                    break;
                case 3:
                    this.MessageType = "Periodic Status Message";
                    break;
                case 4:
                    this.MessageType = "Event-Triggered Status Message";
                    break;
                default:
                    this.MessageType = "";
                    break;

            }

            DataFields.RemoveAt(0);
        }
        void DataItem3()
        {


            itemList.Add(new string[] { "3", "[I010/020]", "Target Report Descriptor" });

            //----------------Define Target Report Descriptor Extension---------------------------------------


            int cont1 = 1;
            for (int j = 0; j < DataFields.Count; j++)
            {

                BitArray trd = new BitArray(new byte[] { DataFields[0] });
                if (cont1 == 1)
                {
                    string TYPlabel = Convert.ToString(Convert.ToInt32(trd[7])) + Convert.ToInt32(trd[6]) + Convert.ToInt32(trd[5]);
                    switch (TYPlabel)
                    {
                        case "000":
                            this.TYP = "SSR multilateration";
                            break;
                        case "001":
                            this.TYP = "Mode S multilateration";
                            break;
                        case "010":
                            this.TYP = "ADS-B";
                            break;
                        case "011":
                            this.TYP = "PSR";
                            break;
                        case "100":
                            this.TYP = "Magnetic Loop System";
                            break;
                        case "101":
                            this.TYP = "HF multilateration";
                            break;
                        case "110":
                            this.TYP = "Not Defined";
                            break;
                        case "111":
                            this.TYP = "Other types";
                            break;

                    }



                    this.DCR = trd[4] == false ? "Non differential correction (ADS-B)" : "Differential correction(ADS-B)";



                    this.CHN = trd[3] == false ? "Chain 1" : "Chain 2";



                    this.GBS = trd[2] == false ? "Transponder Ground bit not set" : "Transponder ground bit set";



                    this.CRT = trd[1] == false ? "No Corrupted reply in multilateration" : "Corrupted replies in multilateration";



                }

                if (cont1 == 2)
                {
                    this.SIM = trd[7] == false ? "Actual Target Report" : "Simulated Target Report";



                    this.TST = trd[6] == false ? "Default" : "Target test";



                    this.RAB = trd[5] == false ? "Report from target transponder" : "Report from field monitor (fixed transponder)";



                    string LOPlabel = Convert.ToString(Convert.ToInt32(trd[4])) + Convert.ToInt32(trd[3]);

                    switch (LOPlabel)
                    {
                        case "00":
                            this.LOP = "Undeterminated";
                            break;
                        case "01":
                            this.LOP = "Loop start";
                            break;
                        case "10":
                            this.LOP = "Loop finish";
                            break;
                    }



                    string TOTlabel = Convert.ToString(Convert.ToInt32(trd[2])) + Convert.ToInt32(trd[1]);

                    switch (TOTlabel)
                    {
                        case "00":
                            this.TOT = "Undeterminated";
                            break;
                        case "01":
                            TOT = "Aircraft";
                            break;
                        case "10":
                            this.TOT = "Ground Vehicle";
                            break;
                        case "11":
                            this.TOT = "Helicopter";
                            break;
                    }



                }

                if (cont1 == 3)
                {
                    this.SPI = trd[7] == false ? "Absence of SPI" : "Special Position Identification";



                }

                DataFields.RemoveAt(0);

                if (trd[0] == false)
                {
                    break;
                }
                else
                {

                    cont1++;
                }
            }


        }
        void DataItem4()
        {
            itemList.Add(new string[] { "4", "[I010/140]", "Time of Day" });



            List<byte> timeList = new List<byte>();
            timeList.Add(DataFields[0]);
            timeList.Add(DataFields[1]);
            timeList.Add(DataFields[2]);

            this.TimeOfDay = computeData(timeList, 1, -7, false);

           




            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem5()
        {
            itemList.Add(new string[] { "5", "[I010/041]", "Position in WGS-84 Co-ordinates" });


            List<byte> latitudeBytes = new List<byte>();
            List<byte> longitudBytes = new List<byte>();

            // Add latitude bytes
            latitudeBytes.Add(DataFields[0]);
            latitudeBytes.Add(DataFields[1]);
            latitudeBytes.Add(DataFields[2]);
            latitudeBytes.Add(DataFields[3]);


            //Add longitude bytes
            longitudBytes.Add(DataFields[4]);
            longitudBytes.Add(DataFields[5]);
            longitudBytes.Add(DataFields[6]);
            longitudBytes.Add(DataFields[7]);


            //Compute Latitude

            this.latitude = computeData(latitudeBytes, 180, -31, true); //sign true because maybe be negative

            //Compute Longitude

            this.longitude = computeData(longitudBytes, 180, -31, true);



            for (int j = 0; j < 8; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem6()
        {
            itemList.Add(new string[] { "6", "[I010/040]", "Measured Position in Polar Co-ordinates" });

            //Compute rho 
            List<byte> rhoList = new List<byte>();
            rhoList.Add(DataFields[0]);

            rhoList.Add(DataFields[1]);


            this.rho = Math.Round(computeData(rhoList, 1, 0, false), 4);


            //Compute theta 
            List<byte> thetaList = new List<byte>();
            thetaList.Add(DataFields[2]);

            thetaList.Add(DataFields[3]);


            this.theta = Math.Round(computeData(thetaList, 360, -16, false), 4);



            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem7()
        {
            itemList.Add(new string[] { "7", "[I010/042]", "Position en cartesian co-ordinates" });



            List<byte> xList = new List<byte>();
            xList.Add(DataFields[0]);
            xList.Add(DataFields[1]);
            this.x = Convert.ToInt32(computeData(xList, 1, 0, true));



            List<byte> yList = new List<byte>();
            yList.Add(DataFields[2]);
            yList.Add(DataFields[3]);
            this.y = Convert.ToInt32(computeData(yList, 1, 0, true));



            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem8()
        {
            itemList.Add(new string[] { "8", "[I010/200]", "Calculated Track Velocity in Polar Co-ordintates" });


            List<byte> GSList = new List<byte>();
            GSList.Add(DataFields[0]);
            GSList.Add(DataFields[1]);
            this.groundSpeed = Math.Round(3600 * computeData(GSList, 1, -14, false), 4); // *3600 to convert in Knots!!!

            List<byte> TAList = new List<byte>();
            TAList.Add(DataFields[2]);
            TAList.Add(DataFields[3]);
            this.trackAngle = Math.Round(computeData(TAList, 360, -16, false), 4);




            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
            
        }
        void DataItem9()
        {
            itemList.Add(new string[] { "9", "[I010/202]", "Calculated Track Velocity in Cartesian Co-ordintates" });



            List<byte> VxList = new List<byte>();
            VxList.Add(DataFields[0]);
            VxList.Add(DataFields[1]);
            this.Vx = Math.Round(computeData(VxList, 1, -2, true), 4);

            List<byte> VyList = new List<byte>();
            VyList.Add(DataFields[2]);
            VyList.Add(DataFields[3]);
            this.Vy = Math.Round(computeData(VyList, 1, -2, true), 4);



            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem10()
        {
            itemList.Add(new string[] { "10", "[I010/161]", "Track number" });


            List<byte> TNList = new List<byte>();
            TNList.Add(DataFields[0]);
            TNList.Add(DataFields[1]);

            this.trackNumber = Convert.ToInt32(computeData(TNList, 1, 0, false));




            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem11()
        {
            itemList.Add(new string[] { "11", "[I010/170]", "Track Status" });

            int cont = 0;
            foreach (byte B in DataFields)
            {

                BitArray b = new BitArray(new byte[] { B });
                cont++;

                if (cont == 1)
                {
                    this.CNF = b[7] == false ? "Confirmed Track" : "Track initialisation phase";

                  

                    this.TRE = b[6] == false ? "Default" : "Last Report for a Track";

                

                    int bit6 = Convert.ToInt32(b[5]);
                    int bit5 = Convert.ToInt32(b[4]);
                    string CSTlabel = Convert.ToString(bit6) + bit5;
                    switch (CSTlabel)
                    {
                        case "00":
                            this.CST = "No extrapolation";
                            break;
                        case "01":
                            this.CST = "Predictable extrapolation due to sensor refresh period";
                            break;
                        case "10":
                            this.CST = "Predictable extrapolation in masked area";
                            break;
                        case "11":
                            this.CST = "Extrapolation due to unpreditable abcence of detection";
                            break;
                    }

                    

                    this.MAH = b[3] == false ? "Default" : "Horizontal manoeuvre";

                    

                    this.TCC = b[2] == false ? "Tracking performed in 'Sensor Plane', i.e. neither slant range correction nor projection was applied." : "Slant range correction and a suitable projection technique are used to track in a 2D.reference plane, tangential to the earth model at the Sensor Site co-ordinates.";

                   

                    this.STH = b[1] == false ? "Measured position" : "Smoothed position";

                   

                }

                if (cont == 2)
                {
                    int bit8 = Convert.ToInt32(b[7]);
                    int bit7 = Convert.ToInt32(b[6]);
                    string TOMlabel = Convert.ToString(bit8) + bit7;
                    switch (TOMlabel)
                    {
                        case "00":
                            this.TOM = "Unknown type of movement";
                            break;
                        case "01":
                            this.TOM = "Taking off";
                            break;
                        case "10":
                            this.TOM = "Landing";
                            break;
                        case "11":
                            this.TOM = "Other types of movement";
                            break;
                    }

              

                    int bit6 = Convert.ToInt32(b[5]);
                    int bit5 = Convert.ToInt32(b[4]);
                    int bit4 = Convert.ToInt32(b[3]);
                    string DOUlabel = Convert.ToString(bit6) + bit5 + bit4;
                    switch (DOUlabel)
                    {
                        case "000":
                            this.DOU = "No doubt";
                            break;
                        case "001":
                            this.DOU = "Doubtful correlation (undeteminated reason)";
                            break;
                        case "010":
                            this.DOU = "Doubtful correlation in clutter";
                            break;
                        case "011":
                            this.DOU = "Loss of accuracy";
                            break;
                        case "100":
                            this.DOU = "Loss of accuracy in clutter";
                            break;
                        case "101":
                            this.DOU = "Unstable track";
                            break;
                        case "110":
                            this.DOU = "Previously coasted";
                            break;
                    }

                   

                    int bit3 = Convert.ToInt32(b[2]);
                    int bit2 = Convert.ToInt32(b[1]);
                    string MRSlabel = Convert.ToString(bit3) + bit2;
                    switch (MRSlabel)
                    {
                        case "00":
                            this.MSR = "Merge or split indication undeterminated";
                            break;
                        case "01":
                            this.MSR = "Track merged by association to plot";
                            break;
                        case "10":
                            this.MSR = "Track merged by non-association to plot";
                            break;
                        case "11":
                            this.MSR = "Split track";
                            break;
                    }

                    

                }

                if (cont == 3)
                {
                    this.GHO = b[7] == false ? "Default" : "Ghost track";

                    

                }

                if (b[0] == false)
                {
                    break;
                }
            }
            for (int j = 0; j < cont; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem12()
        {
            itemList.Add(new string[] { "12", "[I010/060]", "Mode 3/A Code in octal representation" });


            BitArray bits1 = new BitArray(new byte[] { DataFields[0] });

            this.V_3A = bits1[7] == false ? "Code validated" : "Code not validated";

            

            this.G_3A = bits1[6] == false ? "Default" : "Garbled code";

            

            this.L = bits1[5] == false ? "Mode 3/A code derived from the reply of the transponder" : "Mode 3 / A code not extracted during the last scan";

            

            BitArray bits2 = new BitArray(new byte[] { DataFields[1] });

            //Compute Digits
            string DA = Convert.ToString(Convert.ToInt32(bits1[3]) * 4 + Convert.ToInt32(bits1[2]) * 2 + Convert.ToInt32(bits1[1]));
            int DB = Convert.ToInt32(bits1[0]) * 4 + Convert.ToInt32(bits2[7]) * 2 + Convert.ToInt32(bits2[6]);
            int DC = Convert.ToInt32(bits2[5]) * 4 + Convert.ToInt32(bits2[4]) * 2 + Convert.ToInt32(bits2[3]);
            int DD = Convert.ToInt32(bits2[2]) * 4 + Convert.ToInt32(bits2[1]) * 2 + Convert.ToInt32(bits2[0]);

            this.mode3A = DA + DB + DC + DD;

            

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem13()
        {
            itemList.Add(new string[] { "13", "[I010/220]", "Target adress" });

            string D3 = BitConverter.ToString(new byte[] { DataFields[0] });
            string D2 = BitConverter.ToString(new byte[] { DataFields[1] }); ;
            string D1 = BitConverter.ToString(new byte[] { DataFields[2] }); ;

            this.targetAddress = D3 + D2 + D1;

            


            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem14()
        {
            itemList.Add(new string[] { "14", "[I010/245]", "Target Identfication" });

            List<BitArray> listbytes = new List<BitArray>();

            for (int j = 0; j < 7; j++)
            {


                listbytes.Add(new BitArray(new byte[] { DataFields[j] }));


            }

            //Compute STI

            int sti2 = Convert.ToInt32(listbytes[0][7]);

            int sti1 = Convert.ToInt32(listbytes[0][6]);
            string stiLabel = Convert.ToString(sti2) + sti1;


            switch (stiLabel)
            {
                case "00":
                    this.STI = "Callsign or registration downlinked from transponder";
                    break;
                case "01":
                    this.STI = "Callsign not downlinked from transponder";
                    break;
                case "10":
                    this.STI = "Registration not downlinked from transponder";
                    break;
            }

            
           


            //Compute target identification



            List<string> myChars = new List<string>();

            string char1 = Convert.ToString(Convert.ToInt32(listbytes[1][7])) + Convert.ToInt32(listbytes[1][6]) + " " + Convert.ToInt32(listbytes[1][5]) + Convert.ToInt32(listbytes[1][4]) + Convert.ToInt32(listbytes[1][3]) + Convert.ToInt32(listbytes[1][2]);
            string char2 = Convert.ToString(Convert.ToInt32(listbytes[1][1])) + Convert.ToInt32(listbytes[1][0]) + " " + Convert.ToInt32(listbytes[2][7]) + Convert.ToInt32(listbytes[2][6]) + Convert.ToInt32(listbytes[2][5]) + Convert.ToInt32(listbytes[2][4]);
            string char3 = Convert.ToString(Convert.ToInt32(listbytes[2][3])) + Convert.ToInt32(listbytes[2][2]) + " " + Convert.ToInt32(listbytes[2][1]) + Convert.ToInt32(listbytes[2][0]) + Convert.ToInt32(listbytes[3][7]) + Convert.ToInt32(listbytes[3][6]);
            string char4 = Convert.ToString(Convert.ToInt32(listbytes[3][5])) + Convert.ToInt32(listbytes[3][4]) + " " + Convert.ToInt32(listbytes[3][3]) + Convert.ToInt32(listbytes[3][2]) + Convert.ToInt32(listbytes[3][1]) + Convert.ToInt32(listbytes[3][0]);
            string char5 = Convert.ToString(Convert.ToInt32(listbytes[4][7])) + Convert.ToInt32(listbytes[4][6]) + " " + Convert.ToInt32(listbytes[4][5]) + Convert.ToInt32(listbytes[4][4]) + Convert.ToInt32(listbytes[4][3]) + Convert.ToInt32(listbytes[4][2]);
            string char6 = Convert.ToString(Convert.ToInt32(listbytes[4][1])) + Convert.ToInt32(listbytes[4][0]) + " " + Convert.ToInt32(listbytes[5][7]) + Convert.ToInt32(listbytes[5][6]) + Convert.ToInt32(listbytes[5][5]) + Convert.ToInt32(listbytes[5][4]);
            string char7 = Convert.ToString(Convert.ToInt32(listbytes[5][3])) + Convert.ToInt32(listbytes[5][2]) + " " + Convert.ToInt32(listbytes[5][1]) + Convert.ToInt32(listbytes[5][0]) + Convert.ToInt32(listbytes[6][7]) + Convert.ToInt32(listbytes[6][6]);
            string char8 = Convert.ToString(Convert.ToInt32(listbytes[6][5])) + Convert.ToInt32(listbytes[6][4]) + " " + Convert.ToInt32(listbytes[6][3]) + Convert.ToInt32(listbytes[6][2]) + Convert.ToInt32(listbytes[6][1]) + Convert.ToInt32(listbytes[6][0]);

            myChars.Add(char1);
            myChars.Add(char2);
            myChars.Add(char3);
            myChars.Add(char4);
            myChars.Add(char5);
            myChars.Add(char6);
            myChars.Add(char7);
            myChars.Add(char8);

            for (int j = 0; j < 8; j++)
            {
                string[] sections = myChars[j].Split(' ');


                switch (sections[1])
                {
                    case "0000":
                        switch (sections[0])
                        {
                            case "00":

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "P";
                                break;

                            case "10":
                                this.targetIdentification = this.targetIdentification + " ";
                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "0";

                                break;
                        }
                        break;
                    case "0001":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "A";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "Q";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "1";

                                break;
                        }
                        break;
                    case "0010":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "B";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "R";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "2";

                                break;
                        }
                        break;
                    case "0011":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "C";

                                break;

                            case "01":

                                this.targetIdentification = this.targetIdentification + "S";

                                break;

                            case "10":



                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "3";

                                break;
                        }
                        break;
                    case "0100":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "D";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "T";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "4";

                                break;
                        }
                        break;
                    case "0101":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "E";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "U";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "5";

                                break;
                        }
                        break;
                    case "0110":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "F";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "V";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "6";

                                break;
                        }
                        break;
                    case "0111":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "G";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "W";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "7";

                                break;
                        }
                        break;
                    case "1000":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "H";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "X";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "8";

                                break;
                        }
                        break;
                    case "1001":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "I";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "Y";
                                break;

                            case "10":

                                break;

                            case "11":

                                this.targetIdentification = this.targetIdentification + "9";

                                break;
                        }
                        break;
                    case "1010":
                        switch (sections[0])
                        {
                            case "00":

                                this.targetIdentification = this.targetIdentification + "J";

                                break;

                            case "01":
                                this.targetIdentification = this.targetIdentification + "Z";
                                break;

                        }
                        break;
                    case "1011":

                        this.targetIdentification = this.targetIdentification + "K";

                        break;
                    case "1100":

                        this.targetIdentification = this.targetIdentification + "L";

                        break;
                    case "1101":

                        this.targetIdentification = this.targetIdentification + "M";

                        break;
                    case "1110":

                        this.targetIdentification = this.targetIdentification + "N";

                        break;
                    case "1111":

                        this.targetIdentification = this.targetIdentification + "O";

                        break;
                }
            }

            
            for (int j = 0; j < 7; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem15()
        {
            itemList.Add(new string[] { "15", "[I010/250]", "Mode SMB Data" });

            this.REP_ModeSMB = DataFields[0];

           

            DataFields.RemoveAt(0);

            for (int j = 0; j < REP_ModeSMB * 8; j++)
            {
               
                MBData.Add(BitConverter.ToString(new byte[] { DataFields[0], DataFields[1], DataFields[2], DataFields[3], DataFields[4], DataFields[5], DataFields[6] }));
                
                int BDS1byte = DataFields[7] >> 4;

                BDS1.Add(BitConverter.ToString(new byte[] { (byte)BDS1byte }));
                


                BitArray BDS2Array = new BitArray(new byte[] { DataFields[7] });
                BDS2Array[7] = false;
                BDS2Array[6] = false;
                BDS2Array[5] = false;
                BDS2Array[4] = false;

                byte BDS2byte = ConvertToByte(BDS2Array);
                BDS2.Add(BitConverter.ToString(new byte[] { BDS2byte }));
               


                for (int k = 0; k < 7; k++)
                {
                    DataFields.RemoveAt(0);
                }
            }
        }
        void DataItem16()
        {
            itemList.Add(new string[] { "16", "[I010/300]", "Vehicle Fleet Identification" });

            int VFIdentificarion = DataFields[0];

            switch (VFIdentificarion)
            {
                case 0:
                    this.VFI = "Unknown";
                    break;
                case 1:
                    this.VFI = "ATC equipment maintenance";
                    break;
                case 2:
                    this.VFI = "Airport maintenance";
                    break;
                case 3:
                    this.VFI = "Fire";
                    break;
                case 4:
                    this.VFI = "Bird scarer";
                    break;
                case 5:
                    this.VFI = "Snow plough";
                    break;
                case 6:
                    this.VFI = "Runway sweeper";
                    break;
                case 7:
                    this.VFI = "Emergency";
                    break;
                case 8:
                    this.VFI = "Police";
                    break;
                case 9:
                    this.VFI = "Bus";
                    break;
                case 10:
                    this.VFI = "Tug (push/tow)";
                    break;
                case 11:
                    this.VFI = "Grass cutter";
                    break;
                case 12:
                    this.VFI = "Fuel";
                    break;
                case 13:
                    this.VFI = "Baggage";
                    break;
                case 14:
                    this.VFI = "Catering";
                    break;
                case 15:
                    this.VFI = "Aircraft maintenance";
                    break;
                case 16:
                    this.VFI = "Flyco (follow me)";
                    break;
            }




            DataFields.RemoveAt(0);
        }
        void DataItem17()
        {
            itemList.Add(new string[] { "17", "[I010/090]", "Flight level in Binary representation" });

            BitArray BYTE1 = new BitArray(new byte[] { DataFields[0] });

            this.V_FL = BYTE1[7] == false ? "Code validated" : "Code not validated";

            this.G_FL = BYTE1[6] == false ? "Default" : "Garbled code";


            BYTE1[7] = false;
            BYTE1[6] = false;

            List<byte> FLlist = new List<byte>();
            FLlist.Add(ConvertToByte(BYTE1));
            FLlist.Add(DataFields[1]);

            this.flightLevel = Convert.ToString(computeData(FLlist, 1, -2, true));



            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem18()
        {
            itemList.Add(new string[] { "18", "[I010/091]", "Measured Hight" });

            List<byte> heightList = new List<byte>();

            heightList.Add(DataFields[0]);
            heightList.Add(DataFields[1]);

            this.height = computeData(heightList, 204800, -15, true);

      

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem19()
        {
            itemList.Add(new string[] { "19", "[I010/270]", "Target size and orientation" });

            List<byte> SyO = new List<byte>();

            foreach (byte syo in DataFields)
            {
                SyO.Add(syo);

                BitArray SyObyte = new BitArray(new byte[] { syo });

                if (SyObyte[0] == false)
                {
                    break;
                }
            }

            for (int j = 0; j < SyO.Count; j++)
            {
                var BYTE = SyO[j] >> 1; // moves to the right 1 position the bits of the byte

                switch (j)
                {
                    case 0: //First byte

                        this.targetLength = BYTE;




                        break;

                    case 1: //Second byte
                        List<byte> Sbyte = new List<byte>();
                        Sbyte.Add((byte)BYTE);
                        this.targetOrientation = computeData(Sbyte, 360, -7, false);
 

                        break;

                    case 2: //Third byte

                        this.targetWidth = BYTE;
                   

                        break;
                }
            }


            for (int j = 0; j < SyO.Count; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem20()
        {
            itemList.Add(new string[] { "20", "[I010/550]", "System status" });

            BitArray ss = new BitArray(new byte[] { DataFields[0] });

            string NOGOLabel = Convert.ToString(Convert.ToInt32(ss[7])) + Convert.ToInt32(ss[6]);


            switch (NOGOLabel)
            {
                case "00":
                    this.NOGO = "Operational";
                    break;
                case "01":
                    this.NOGO = "Degraded";
                    break;
                case "10":
                    this.NOGO = "NOGO";
                    break;
            }

         


            this.OVL = ss[5] == false ? "No overload" : "Overload";

           

            this.TSV = ss[4] == false ? "Valid" : "Invalid";

            

            this.DIV = ss[3] == false ? "Normal operation" : "Diversity degraded";

          

            this.TTF = ss[2] == false ? "Test Target Operative" : "Test Target Failure";

            

            DataFields.RemoveAt(0);

        }
        void DataItem21()
        {
            itemList.Add(new string[] { "21", "[I010/310]", "Pre programmed message" });

            BitArray ppm = new BitArray(new byte[] { DataFields[0] });

            this.TRB = ppm[7] == false ? "Default" : "In Trouble";

           

            int MSGlabel = 0;

            for (int j = 0; j < 3; j++)
            {
                MSGlabel = MSGlabel + Convert.ToInt32(Math.Pow(2, j)) * Convert.ToInt32(ppm[j]);
            }

            switch (MSGlabel)
            {
                case 1:
                    this.MSG = "Towing aircraft";
                    break;
                case 2:
                    this.MSG = "Follow me operation";
                    break;
                case 3:
                    this.MSG = "Runway check";
                    break;
                case 4:
                    this.MSG = "Emergency operation (fire, medical...)";
                    break;
                case 5:
                    this.MSG = "Work in progress (maintenance,birds scarer, sweepers...)";
                    break;
            }

           

            DataFields.RemoveAt(0);

        }
        void DataItem22()
        {
            itemList.Add(new string[] { "22", "[I010/500]", "Standard deviation of position" });

            List<byte> sigmaxList = new List<byte>();
            sigmaxList.Add(DataFields[0]);

            this.sigmax = computeData(sigmaxList, 1, -2, false);

           

            List<byte> sigmayList = new List<byte>();
            sigmayList.Add(DataFields[1]);



            this.sigmay = computeData(sigmayList, 1, -2, false);

            



            List<byte> sigmaxyList = new List<byte>();
            sigmaxyList.Add(DataFields[2]);
            sigmaxyList.Add(DataFields[3]);

            this.sigmaxy = computeData(sigmaxyList, 1, -2, true);

            

            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem23()
        {
            itemList.Add(new string[] { "23", "[I010/280]", "Presence" });

            this.REP_presence = DataFields[0];

            

            DataFields.RemoveAt(0);


            int index = 0;

            for (int j = 0; j < this.REP_presence; j++)
            {
                index = j * 2;

                List<byte> presenceRhoList = new List<byte>();
                presenceRhoList.Add(DataFields[index]);

                List<byte> presenceThetaList = new List<byte>();
                presenceThetaList.Add(DataFields[index + 1]);

                double drho = computeData(presenceRhoList, 1, -7, true);
                double dtheta = computeData(presenceRhoList, 19.05, -7, true);
                this.rho_theta_presenceList.Add(new double[] { drho, dtheta });



            }
            for (int j = 0; j < 2 * REP_presence; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem24()
        {

            itemList.Add(new string[] { "24", "[I010/131]", "Amplitude of primary plot" });

            this.PAM = DataFields[0];



            DataFields.RemoveAt(0);

        }
        void DataItem25()
        {
            itemList.Add(new string[] { "25", "[I010/210]", "Calculated Acceleration" });

            List<byte> AxList = new List<byte>();
            AxList.Add(DataFields[0]);

            this.Ax = computeData(AxList, 1, -2, true);



            List<byte> AyList = new List<byte>();
            AyList.Add(DataFields[1]);

            this.Ay = computeData(AyList, 1, -2, true);


            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
            
        }
        void DataItem27()
        {

            itemList.Add(new string[] { "27", "-", "Special purpose Field" });

            this.specialPurpose = "Special Purpose Field";

        }
        void DataItem28()
        {
            itemList.Add(new string[] { "28", "-", "Reserved expansion Field" });

            this.reservedField = "Reserved Field";

        }

    }
}