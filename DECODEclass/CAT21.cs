using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;


namespace DECODEclass
{
    public class CAT21
    {
        //Atributes
        
        int length; //message's length
        //List<byte> FSPEC; //FSPEC
        List<byte> DataFields; //DataFields
        List<string[]> DataItemsList= new List<string[]>();

        public List<string[]> GetItemList()
        {
            return DataItemsList;
        }





        public int GetLength()
        {
            return length;
        }


        //-----------------------------------DATA SOURCE IDENTIFIER [I010/010]----------------------------------------------------------

        //List<string> // DI1 = new List<string>();

       // public List<string> Get// DI1() { return // DI1; }

        public string SAC { get; set; } //System Area code fixed to zero
        public int SIC { get; set; } //System identification Code
        
        //----------------------------------TARGET REPORT DESCRIPTOR [I021/040]------------------------------------------------------------------

        //List<string> // DI2 = new List<string>();

       // public List<string> Get// DI2() { return // DI2; }


        public string ATP { get; set;}
        public string ARC { get; set; }
        public string RC { get; set; }
        public string RAB { get; set; }
        public string DCR{ get; set;}
        public string GBS { get; set; }
        public string SIM { get; set; }
        public string TST { get; set; }
        public string SAA { get; set; }
        public string CL{ get; set; }
        public string IPC { get; set; }
        public string NOGO { get; set; }
        public string CPR { get; set; }
        public string LDPJ { get; set; }
        public string RCF { get; set; }


        //-----------------------------------------TRACK NUMBER [I021/161]--------------------------------------------------------

        //List<string> // DI3 = new List<string>();

        // public List<string> Get// DI3() { return // DI3; }

        public int trackNumber { get; set; }

        //--------------------------------------SERVICE IDENTIFICATION[I021/015]--------------------------------------------------------------------------------------------------

        //List<string> // DI4 = new List<string>();

        // public List<string> Get// DI4() { return // DI4; }

        public string serviceIdentification { get; set; } //Seconds

        //------------------------------------------TIME OF APPLICABILITY FOR POSITION[I021/071]-------------------------------------------------------------------

        //List<string> // DI5 = new List<string>();

        // public List<string> Get// DI5() { return // DI5; }

        public double timeOfAppPos { get; set; }

        //--------------------------------------------------------POSITION IN WGS-84 COOR// DINATES [I021/130]-------------------------------------------------------------------

        //List<string> // DI6 = new List<string>();

        // public List<string> Get// DI6() { return // DI6; }

        public double latitude { get; set; }
        public double longitude { get; set; }

        //--------------------------------------------------------POSITION IN WGS-84 COOR// DINATES [I021/131]---------------------------------------------------------------

        //List<string> // DI7 = new List<string>();

        // public List<string> Get// DI7() { return // DI7; }

        public double HRlatitude { get; set; }
        public double HRlongitude { get; set; }

        //--------------------------------------------------TIME FOR APPLICABILITY FOR VELOCITY[I021/072]--------------------------------------------------------

        //List<string> // DI8 = new List<string>();

        // public List<string> Get// DI8() { return // DI8; }

        public string timeOfAppVel { get; set; }

        //--------------------------------------------Air Speed [I010/150]---------------------------------------------------------

        //List<string> // DI9 = new List<string>();

        // public List<string> Get// DI9() { return // DI9; }

        public double airSpeed{get; set;} 
        public string typeSpeed { get; set; }

        //------------------------------------------------------TRUE AIR SPEED [I021/151]--------------------------------------------------------------------------

        //List<string> // DI10 = new List<string>();

        // public List<string> Get// DI10() { return // DI10; }

        public double trueAirSpeed { get; set; }
        public string RE { get; set; }

        //----------------------------------------------------------TARGET ADDRESS[I021/080]---------------------------------------------------------------------

        //List<string> // DI11 = new List<string>();

        // public List<string> Get// DI11() { return // DI11; }

        public string targetAddress { get; set; }

        //-------------------------------------------------------TIME OF MESSAGE RECEPTION OF POSITION[I021/073]--------------------------------------------------

        //List<string> // DI12 = new List<string>();

        // public List<string> Get// DI12() { return // DI12; }

        public double timeReceptPos { get; set; }

        //--------------------------------------------------TIME OF MESSAGE RECEPTION OF POSITION HIGH PRECISION[I021/074]---------------------------------------------------------------

        //List<string> // DI13 = new List<string>();

        // public List<string> Get// DI13() { return // DI13; }

        public double timeReceptPosHP { get; set; }
        public string FSI_pos { get; set; }

        //------------------------------------------------TIME OF MESSAGE RECEPTION OF VELOCITY [I021/075]--------------------------------------------------------------------

        //List<string> // DI14 = new List<string>();

        // public List<string> Get// DI14() { return // DI14; }

        public double timeReceptVel { get; set; }


        //----------------------------------TIME OF MESSAGE RECEPTION OF VELOCITY  HIGH PRECISION PRECISION [I021/075]-----------------------------------------------------------

        //List<string> // DI15 = new List<string>();

        // public List<string> Get// DI15() { return // DI15; }

        public double timeReceptVelHP { get; set; }
        public string FSI_Vel { get; set; }

        //---------------------------------------------------------GEOMETRIC HEIGHT[I021/300] ------------------------------------------------------

        //List<string> // DI16 = new List<string>();

        // public List<string> Get// DI16() { return // DI16; }

        public string geometricHeight { get; set; }

        //----------------------------------------------------------QUALITY IN// DICATORS[I021/090]-----------------------------------------------------------------------

        //List<string> // DI17 = new List<string>();

        // public List<string> Get// DI17() { return // DI17; }

        public string NUCr { get; set; }
        public string NUCp { get; set; }
        public string NICbaro { get; set; }
        public string SIL1 { get; set; }
        public string NACp { get; set; }
        public string SIL2 { get; set; }
        public string SDA { get; set; }
        public string GVA { get; set; }
        public string PIC { get; set; }

        //------------------------------------------------------MOPS VERSION [I021/210]-------------------------------------------------------------

        //List<string> // DI18 = new List<string>();

        // public List<string> Get// DI18() { return // DI18; }

        public string VNS { get; set; }
        public string VN { get; set; }
        public string LTT { get; set; }

        //------------------------------------------------------------MODE 3/A CODE[I021/070]----------------------------------------------------------------------

        //List<string> // DI19 = new List<string>();

        // public List<string> Get// DI19() { return // DI19; }

        public string mode3A { get; set; }

        //------------------------------------------------------------ROLL ANGLE [I021/230]-------------------------------------------------------------

        //List<string> // DI20 = new List<string>();

        // public List<string> Get// DI20() { return // DI20; }

        public double rollAngle { get; set; }

        //----------------------------------------------------------FLIGHT LEVEL[I021/145]-------------------------------------------------------

        //List<string> // DI21 = new List<string>();

        // public List<string> Get// DI21() { return // DI21; }

        public string flightLevel { get; set; }

        //--------------------------------------------------------MAGNETIC HEA// DING [I021/152]---------------------------------------------------------------

        //List<string> // DI22 = new List<string>();

        // public List<string> Get// DI22() { return // DI22; }

        public double magneticHeading { get; set; }

        //------------------------------------------------------------TARGET STATUS [I021/200]-------------------------------------------------------------

        //List<string> // DI23 = new List<string>();

        // public List<string> Get// DI23() { return // DI23; }

        public string ICF { get; set; }
        public string LNAV { get; set; }
        public string PS { get; set; }
        public string SS { get; set; }

        //--------------------------------------------------------------BAROMETRIC VERTICAL RATE [I021/155]------------------------------------------------------

        //List<string> // DI24 = new List<string>();

        // public List<string> Get// DI24() { return // DI24; }

        public string RE_BVR;
        public double barometricVerticalRate { get; set; }

        //------------------------------------------------------------GEOMETRIC VERTICAL RATE [I021/157]------------------------------------------------------

        //List<string> // DI25 = new List<string>();

        // public List<string> Get// DI25() { return // DI25; }

        public string RE_GVR { get; set; }
        public double geometricVerticalRate { get; set; }

        //------------------------------------------------------------AIRBORNE GROUND VECTOR [I021/160]------------------------------------------------------

        //List<string> // DI26 = new List<string>();

        // public List<string> Get// DI26() { return // DI26; }

        public string RE_GS { get; set; }
        public double groundSpeed { get; set; }

        public double trackAngle { get; set; }

        //----------------------------------------------------------TRACK ANGLE RATE[I021 / 165]--------------------------------------------------------------

        //List<string> // DI27 = new List<string>();

        // public List<string> Get// DI27() { return // DI27; }

        public double trackAngleRate { get; set; }

        //-------------------------------------------------------------TIME OF REPORT TRANSMISSION[I021/077]------------------------------------------------------
        //List<string> // DI28 = new List<string>();

        // public List<string> Get// DI28() { return // DI28; }

        public double timeReportTrans { get; set; }

        //------------------------------------------------------------------TARGET IDENTIFICATION[I021/170]----------------------------------------------------

        //List<string> // DI29 = new List<string>();

        // public List<string> Get// DI29() { return // DI29; }

        public string targetIdentification { get; set; }
        //------------------------------------------------------------------EMITTER CATEGORY[I021/020]---------------------------------------------------------------

        //List<string> // DI30 = new List<string>();

        // public List<string> Get// DI30() { return // DI30; }

        public string ECAT { get; set; }


        //-------------------------------------------------------------------MET INFORMATION[I021/220]----------------------------------------------------------------

        //List<string> // DI31 = new List<string>();

        // public List<string> Get// DI31() { return // DI31; }

        public int windSpeed { get; set; }
        public int windDirection { get; set; }
        public double temperature { get; set; }
        public int turbulence { get; set; }
        public string WS { get; set; }
        public string WD { get; set; }
        public string TMP { get; set; }
        public string TRB { get; set; }

        //------------------------------------------------------------------SELECTED ALTITUDE[I021/146]---------------------------------------------------------------------
        //List<string> // DI32 = new List<string>();

        // public List<string> Get// DI32() { return // DI32; }

        public string SAS { get; set; }
        public string source { get; set; }
        public int altitude { get; set; }

        //------------------------------------------------------------FINAL STATE SELECTED ALTITUDE[I021/148]---------------------------------------------------------------
        //List<string> // DI33 = new List<string>();

        // public List<string> Get// DI33() { return // DI33; }

        public string MV { get; set; }
        public string AH { get; set; }
        public string AM { get; set; }
        public int altitudeFSS { get; set; }

        //-----------------------------------------------------------------TRAJECTORY INTENT [I021/110 ]---------------------------------------------------------

        //List<string> // DI34 = new List<string>();

        // public List<string> Get// DI34() { return // DI34; }

        public string TIS { get; set; }
        public string TID { get; set; }
        public string NAV { get; set; }
        public string NVB { get; set; }
        public int REP { get; set; }
        List<string> TCAList = new List<string>();
        public List<string> GetTCAList()
        {
            return TCAList;
        }
        List<string> NCList = new List<string>();
        public List<string> GetNCList()
        {
            return NCList;
        }
        List<int> TCPList = new List<int>();
        public List<int> GetTCPList()
        {
            return TCPList;
        }
        List<int> TIAList = new List<int>();
        public List<int> GetTIAList()
        {
            return TIAList;
        }
        List<double> LatList = new List<double>();
        public List<double> GetLatList()
        {
            return LatList;
        }
        List<double> LongList = new List<double>();
        public List<double> GetLongList()
        {
            return LongList;
        }
        List<string> PTypeList = new List<string>();
        public List<string> GetPTypeList()
        {
            return PTypeList;
        }
        List<string> TDList = new List<string>();
        public List<string> GetTDList()
        {
            return TDList;
        }
        List<string> TRAList = new List<string>();
        public List<string> GetTRAList()
        {
            return TRAList;
        }
        List<string> TOAList = new List<string>();
        public List<string> GetTOAList()
        {
            return TOAList;
        }
        List<int> TOVList = new List<int>();
        public List<int> GetTOVList()
        {
            return TOVList;
        }
        List<double> TTRList = new List<double>();
        public List<double> GetTTRList()
        {
            return TTRList;
        }

        //-----------------------------------------------------------SERVICE MANAGEMENT [I021/016 ]------------------------------------------------------------------

        //List<string> // DI35 = new List<string>();

        // public List<string> Get// DI35() { return // DI35; }

        public double reportPeriod { get; set; }

        //----------------------------------------------------------AIRCRAFT OPRATIONAL STATUS [I021/008]-------------------------------------------------------------

        //List<string> // DI36 = new List<string>();

       // public List<string> Get// DI36() { return // DI36; }

        public string RA { get; set; }
        public string TC { get; set; }
        public string TS { get; set; }
        public string ARV { get; set; }
        public string CDTIA { get; set; }
        public string NotTCAS { get; set; }
        public string SA { get; set; }

        //--------------------------------------------------------SURFACE CAPABILITIES AND CHARACTERISTICS [I021/271] ------------------------------------------------------

        //List<string> // DI37 = new List<string>();

        // public List<string> Get// DI37() { return // DI37; }

        public string POA { get; set; }
        public string CTDIS { get; set; }
        public string B2low { get; set; }
        public string RAS { get; set; }
        public string IDENT { get; set; }
        public string LandW { get; set; }
        //-------------------------------------------------------------------MESSAGE AMPLITUDE[I021/132]---------------------------------------------------------------------

        //List<string> // DI38 = new List<string>();

        // public List<string> Get// DI38() { return // DI38; }

        public int messageAmplitude { get; set; }

        //-------------------------------------------------------------------MODE S MB DATA [I021/250]-----------------------------------------------------------------------

        //List<string> // DI39 = new List<string>();

        // public List<string> Get// DI39() { return // DI39; }

        public int REP_ModeSMB { get; set; }
        List<string> MBData = new List<string>();
        public List<string> GetMBData()
        {
            return MBData;
        }
        List<string> BDS1 = new List<string>();
        public List<string> GetBDS1()
        {
            return BDS1;
        }
        List<string> BDS2 = new List<string>();
        public List<string> GetBDS2()
        {
            return BDS2;
        }

        //------------------------------------------------------------------ACAS RESOLUTION ADVISORY REPORT[I021/260]---------------------------------------------------------
        //List<string> // DI40 = new List<string>();

        // public List<string> Get// DI40() { return // DI40; }
        //----------------------------------------------------------------------------RECEIVER ID[I021/400]---------------------------------------------------------------
        //List<string> // DI41 = new List<string>();

        // public List<string> Get// DI41() { return // DI41; }
        public int RID { get; set; }


        //------------------------------------------------------------------------------DATE AGES[I021/295]----------------------------------------------------------------

        //List<string> // DI42 = new List<string>();

        // public List<string> Get// DI42() { return // DI42; }

        public string AOS_DA { get; set; }
        public string TRD_DA { get; set; }
        public string M3A { get; set; }
        public string QI { get; set; }
        public string TI1_DA { get; set; }
        public string MAM_DA { get; set; }
        public string GH_DA { get; set; }
        public string FL_DA { get; set; }
        public string ISA_DA { get; set; }
        public string FSA_DA { get; set; }
        public string AS_DA { get; set; }
        public string TAS_DA { get; set; }
        public string MH_DA { get; set; }
        public string BVR_DA { get; set; }
        public string GVR_DA { get; set; }
        public string GV_DA { get; set; }
        public string TAR_DA { get; set; }
        public string TI2_DA { get; set; }
        public string TS_DA { get; set; }
        public string MET_DA { get; set; }
        public string ROA_DA { get; set; }
        public string ARA_DA { get; set; }
        public string SCC_DA { get; set; }
        public double AOS_data { get; set; }
        public double TRD_data { get; set; }
        public double M3A_data { get; set; }
        public double QI_data { get; set; }
        public double TI1_data { get; set; }
        public double MAM_data { get; set; }
        public double GH_data { get; set; }
        public double FL_data { get; set; }
        public double ISA_data { get; set; }
        public double FSA_data { get; set; }
        public double AS_data { get; set; }
        public double TAS_data { get; set; }
        public double MH_data { get; set; }
        public double BVR_data { get; set; }
        public double GVR_data { get; set; }
        public double GV_data { get; set; }
        public double TAR_data { get; set; }
        public double TI2_data { get; set; }
        public double TS_data { get; set; }
        public double MET_data { get; set; }
        public double ROA_data { get; set; }
        public double ARA_data { get; set; }
        public double SCC_data { get; set; }




        //----------------------------------------------------------------------RESERVED FIELD----------------------------------------------------------------------------
        //List<string> // DI48 = new List<string>();

        // public List<string> Get// DI48() { return // DI48; }

        public string reservedField { get; set; }


        //--------------------------------------------------------------------SPECIAL PURPOSE FIELD------------------------------------------------------------------------
        public string specialPField { get; set; }

        //List<string> // DI49 = new List<string>();

        // public List<string> Get// DI49() { return // DI49; }




        //BUILDER
        public CAT21(byte[] message, int length)
        {
            //this.message = message;
            this.length = length;
            List<byte> FSPEC = readFSPEC(message.Skip(3).ToArray()); //The three first byte is CAT (byte 1) and second and third bytes are length
            DataFields = new List<byte>(message.Skip(3 + FSPEC.Count).ToArray()); //Only contain DataFields without CAT,LENGTH and FSPEC
            createDataItem(FSPEC); //We calculte each data item of CAT 10
        }

        //METHODS
        //-----------------------------------------------------------------------------------------------------------------------------------------------------



        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //readFSPEC() -> we obtain FSPEC from the message
        public List<byte> readFSPEC(byte[] message)
        {
            List<byte> FSPEC = new List<byte>();
           

            for (int i = 0; i < message.Length; i++)
            {
                BitArray octect = new BitArray(new byte[] { message[i] });

                //----------------------------TEST-----------------------------------------------------------------------

                //---------------------------------------------------------------------------------------------------

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

            for(int i = 0; i < FSPEC.Count; i++)
            {
                BitArray Ebits = new BitArray(new byte[] { FSPEC[i] });
                switch (i)
                {
                    case 0:
                        if (Ebits[7]==true) { DataItem1(); }
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
                        if (Ebits[3] == true) { DataItem26(); }
                        if (Ebits[2] == true) { DataItem27(); }
                        if (Ebits[1] == true) { DataItem28(); }
                        break;
                    case 4:
                        if (Ebits[7] == true) { DataItem29(); }
                        if (Ebits[6] == true) { DataItem30(); }
                        if (Ebits[5] == true) { DataItem31(); }
                        if (Ebits[4] == true) { DataItem32(); }
                        if (Ebits[3] == true) { DataItem33(); }
                        if (Ebits[2] == true) { DataItem34(); }
                        if (Ebits[1] == true) { DataItem35(); }
                        break;
                    case 5:
                        if (Ebits[7] == true) { DataItem36(); }
                        if (Ebits[6] == true) { DataItem37(); }
                        if (Ebits[5] == true) { DataItem38(); }
                        if (Ebits[4] == true) { DataItem39(); }
                        if (Ebits[3] == true) { DataItem40(); }
                        if (Ebits[2] == true) { DataItem41(); }
                        if (Ebits[1] == true) { DataItem42(); }
                        break;
                    case 6:
                       
                        if (Ebits[2] == true) { DataItem48(); }
                        if (Ebits[1] == true) { DataItem49(); }
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
        //public void printbits(byte B)
        //{
        //    BitArray b = new BitArray(new byte[] { B });
        //    for (int i = b.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(Convert.ToInt32(b[i]));
        //    }
        //}

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

        void DataItem1() // Data Source Identifier [I021/010] -> Length 2 bytes
        {
            DataItemsList.Add(new string[] { "1", "[I021/010]", "Data Source Identifier" });
            this.SAC = BitConverter.ToString(new byte[] { DataFields[0] });

            DataFields.RemoveAt(0); //We eliminate de data field after we decode to save computer memory
            this.SIC = DataFields[0]; //BitConverter.ToString(new byte[] { DataFields[0] });


            //// DI1.Add("SAC: " + SAC);
            //// DI1.Add("SIC: " + SIC);


            DataFields.RemoveAt(0);

        }

        void DataItem2()
        {
            DataItemsList.Add(new string[] { "2", "[I021/040]", "Target Report Descriptor" });
            int cont1 = 1;
            for (int j = 0; j < DataFields.Count; j++)
            {

                BitArray trd = new BitArray(new byte[] { DataFields[0] });
                if (cont1 == 1)
                {

                    int ATPlabel = 4 * Convert.ToInt32(trd[7]) + 2 * Convert.ToInt32(trd[6]) + Convert.ToInt32(trd[5]);
                    switch (ATPlabel)
                    {
                        case 0:
                            this.ATP = "24-Bit ICAO address";
                            break;
                        case 1:
                            this.ATP = "Duplicate address";
                            break;
                        case 2:
                            this.ATP = "Surface vehicle address";
                            break;
                        case 3:
                            this.ATP = "Anonymous address";
                            break;
                        default:
                            this.ATP = "Reserved for future use";
                            break;

                    }




                    int ARClabel = 2 * Convert.ToInt32(trd[4]) + Convert.ToInt32(trd[3]);
                    switch (ATPlabel)
                    {
                        case 0:
                            this.ARC = "25 ft";
                            break;
                        case 1:
                            this.ARC = "100 ft";
                            break;
                        case 2:
                            this.ARC = "Unknown";
                            break;
                        case 3:
                            this.ARC = "Invalid";
                            break;

                    }



                    this.RC = trd[2] == false ? "Default" : "Range Check passed,CPR Validation pending";



                    this.RAB = trd[1] == false ? "Report from target transponder" : "Report from field monitor (fixed transponder)";

                    // DI2.Add("ATP: " + ATP);
                    // DI2.Add("ARC: " + ARC + " ft");
                    // DI2.Add("RC: " + RC);
                    // DI2.Add("RAB: " + RAB);

                }

                if (cont1 == 2)
                {


                    this.DCR = trd[7] == false ? "No differential correction (ADS-B)" : " Differential correction (ADS-B)";



                    this.GBS = trd[6] == false ? "Ground Bit not set" : "Ground Bit set";



                    this.SIM = trd[5] == false ? "Actual target report" : "Simulated target report";



                    this.TST = trd[4] == false ? "Default" : "Test Target";



                    this.SAA = trd[3] == false ? "Equipment capable to provide Selected Altitude" : "Equipment not capable to provide Selected Altitude";



                    int CLlabel = 2 * Convert.ToInt32(trd[2]) + Convert.ToInt32(trd[1]);

                    switch (CLlabel)
                    {
                        case 0:
                            this.CL = "Report valid";
                            break;
                        case 1:
                            this.CL = "Report suspect";
                            break;
                        case 2:
                            this.CL = "No information";
                            break;
                        case 3:
                            this.CL = "Reserved for future use";
                            break;
                    }

                    // DI2.Add("DCR: " + DCR);
                    // DI2.Add("GBS: " + GBS);
                    // DI2.Add("SIM: " + SIM);
                    // DI2.Add("TST: " + TST);
                    // DI2.Add("SAA: " + SAA);
                    // DI2.Add("CL: " + CL);

                }

                if (cont1 == 3)
                {

                    this.IPC = trd[5] == false ? "default" : "Independent Position Check failed";



                    this.NOGO = trd[4] == false ? "NOGO-bit not set" : "NOGO-bit set";



                    this.CPR = trd[3] == false ? "CPR Validation correct" : "CPR Validation failed";



                    this.LDPJ = trd[2] == false ? "LDPJ not detected" : "LDPJ detected";



                    this.RCF = trd[1] == false ? "default" : "Range Check failed";

                    // DI2.Add("IPC: " + IPC);
                    // DI2.Add("NOGO: " + NOGO);
                    // DI2.Add("CPR: " + CPR);
                    // DI2.Add("LDPJ: " + LDPJ);
                    // DI2.Add("RCF: " + RCF);




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
        void DataItem3()
        {
            DataItemsList.Add(new string[] { "3", "[I021/161]", "Track Number" });

            BitArray TR1bytes = new BitArray(new byte[] { DataFields[0] });
            BitArray TR2bytes = new BitArray(new byte[] { DataFields[1] });

            for (int j = 0; j < 12; j++)
            {
                if (j < 8)
                {
                    this.trackNumber = this.trackNumber + Convert.ToInt32(Math.Pow(2, j)) * Convert.ToInt32(TR2bytes[j]);
                }
                else
                {
                    this.trackNumber = this.trackNumber + Convert.ToInt32(Math.Pow(2, j)) * Convert.ToInt32(TR1bytes[j - 8]);
                }


            }



            // DI3.Add("Track Number: " + trackNumber);

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem4()
        {
            DataItemsList.Add(new string[] { "4", "[I021/015]", "Service Identification" });

            this.serviceIdentification = BitConverter.ToString(new byte[] { DataFields[0] });


            // DI4.Add("Service Identification: " + serviceIdentification);

            DataFields.RemoveAt(0);
        }
        void DataItem5()
        {
            DataItemsList.Add(new string[] { "5", "[I021/071]", "Time of Applicability for position" });

            double timePos;

            List<byte> timeList = new List<byte>();
            timeList.Add(DataFields[0]);
            timeList.Add(DataFields[1]);
            timeList.Add(DataFields[2]);

            this.timeOfAppPos = computeData(timeList, 1, -7, false);

 



            // DI5.Add("Time of App. for Position: " + timeOfAppPos + " s");

            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem6()
        {
            DataItemsList.Add(new string[] { "6", "[I010/130]", "Position in WGS-84 Coor// DInates" });

            List<byte> latitudeBytes = new List<byte>();
            List<byte> longitudBytes = new List<byte>();

            // Add latitude bytes
            latitudeBytes.Add(DataFields[0]);
            latitudeBytes.Add(DataFields[1]);
            latitudeBytes.Add(DataFields[2]);

            //Add longitude bytes
            longitudBytes.Add(DataFields[3]);
            longitudBytes.Add(DataFields[4]);
            longitudBytes.Add(DataFields[5]);

            //Compute Latitude

            this.latitude = Math.Round(computeData(latitudeBytes, 180, -23, true), 6); //sign true because maybe be negative

            //Compute Longitude

            this.longitude = Math.Round(computeData(longitudBytes, 180, -23, true), 6);



            // DI6.Add("Latitude: " + latitude + " degrees");
            // DI6.Add("Longitude: " + longitude + " degrees");


            for (int j = 0; j < 6; j++)
            {
                DataFields.RemoveAt(0);
            }
            
        }
        void DataItem7()
        {
            DataItemsList.Add(new string[] { "7", "[I021/131]", "Position in WGS-84 Coor// DInates High Res." });

            List<byte> latitudeHRBytes = new List<byte>();
            List<byte> longitudHRBytes = new List<byte>();

            // Add latitude bytes
            latitudeHRBytes.Add(DataFields[0]);
            latitudeHRBytes.Add(DataFields[1]);
            latitudeHRBytes.Add(DataFields[2]);
            latitudeHRBytes.Add(DataFields[3]);

            //Add longitude bytes
            longitudHRBytes.Add(DataFields[4]);
            longitudHRBytes.Add(DataFields[5]);
            longitudHRBytes.Add(DataFields[6]);
            longitudHRBytes.Add(DataFields[7]);

            //Compute Latitude

            this.HRlatitude = Math.Round(computeData(latitudeHRBytes, 180, -30, true), 8); //sign true because maybe be negative

            //Compute Longitude

            this.HRlongitude = Math.Round(computeData(longitudHRBytes, 180, -30, true), 8);



            // DI7.Add("HR Latitude: " + HRlatitude + " degrees");
            // DI7.Add("HR Longitude: " + HRlongitude + " degrees");


            for (int j = 0; j < 8; j++)
            {
                DataFields.RemoveAt(0);
            }

        }

        void DataItem8()
        {
            DataItemsList.Add(new string[] { "8", "[I021/072]", "Time of applicability for velocity" });

            double timeVel;

            List<byte> timeVList = new List<byte>();
            timeVList.Add(DataFields[0]);
            timeVList.Add(DataFields[1]);
            timeVList.Add(DataFields[2]);

            timeVel = computeData(timeVList, 1, -7, false);

            this.timeOfAppVel = convert2TimeOfDay(timeVel);



            // DI8.Add("Time of App. for Velocity: " + timeOfAppVel + " s");


            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem9()
        {
            DataItemsList.Add(new string[] { "9", "[I021/150]", "Air Speed" });

            BitArray AS1 = new BitArray(new byte[] { DataFields[0] });


            AS1[7] = false;
            byte AS1Byte = ConvertToByte(AS1);

            List<byte> ASList = new List<byte>();
            ASList.Add(AS1Byte);
            ASList.Add(DataFields[1]);


            switch (AS1[7])
            {
                case false:

                    this.typeSpeed = "IAS";
                    this.airSpeed = computeData(ASList, 1, -14, false);

                    // DI9.Add("Air Speed Type: " + typeSpeed);
                    // DI9.Add("Air Speed: " + airSpeed + " NM/s");

                    break;
                case true:
                    this.typeSpeed = "Mach";
                    this.airSpeed = computeData(ASList, Math.Pow(10, -3), 0, false);

                    // DI9.Add("Air Speed Type: " + typeSpeed);
                    // DI9.Add("Air Speed: " + airSpeed);

                    break;

            }



            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem10()
        {
            DataItemsList.Add(new string[] { "10", "[I021/151]", "True Air Speed" });

            BitArray TAS1 = new BitArray(new byte[] { DataFields[0] });


            TAS1[7] = false;
            byte TAS1Byte = ConvertToByte(TAS1);

            List<byte> TASList = new List<byte>();
            TASList.Add(TAS1Byte);
            TASList.Add(DataFields[1]);



            switch (TAS1[7])
            {
                case false:

                    this.RE = "Value in defined range";
                    this.trueAirSpeed = computeData(TASList, 1, 0, false);


                    break;
                case true:
                    this.RE = "Value exceeds defined range";
                    this.trueAirSpeed = computeData(TASList, 1, 0, false);
                    break;

            }


            // DI10.Add("RE: " + RE);
            // DI10.Add("True Air Speed: " + trueAirSpeed + " knots");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem11()
        {
            DataItemsList.Add(new string[] { "11", "[I021/080]", "Target Address" });

            string D3 = BitConverter.ToString(new byte[] { DataFields[0] });
            string D2 = BitConverter.ToString(new byte[] { DataFields[1] }); ;
            string D1 = BitConverter.ToString(new byte[] { DataFields[2] }); ;

            this.targetAddress = D3 + D2 + D1;


            // DI11.Add("Target Address: " + targetAddress);

            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem12()
        {
            DataItemsList.Add(new string[] { "12", "[I021/073]", "Time of message reception of position" });

            List<byte> timeRPList = new List<byte>();
            timeRPList.Add(DataFields[0]);
            timeRPList.Add(DataFields[1]);
            timeRPList.Add(DataFields[2]);

            this.timeReceptPos = Math.Round(computeData(timeRPList, 1, -7, false), 1);



            // DI12.Add("Time of Message Reception of Position: "+timeReceptPos+ " s");

            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem13()
        {
            DataItemsList.Add(new string[] { "13", "[I021/074]", "Time of message reception of position High Prec." });

            BitArray timeHP = new BitArray(new byte[] { DataFields[0] });

            string FSILabel = Convert.ToString(Convert.ToInt32(timeHP[7])) + Convert.ToInt32(timeHP[6]);

            switch (FSILabel)
            {
                case "11":
                    this.FSI_pos = "Reserved";
                    break;
                case "10":
                    this.FSI_pos = "TOMRp whole seconds =(I021/073) Whole seconds – 1";
                    break;
                case "01":
                    this.FSI_pos = "TOMRp whole seconds = (I021/073) Whole seconds + 1";
                    break;
                case "00":
                    this.FSI_pos = "TOMRp whole seconds = (I021/073) Whole seconds";
                    break;
            }

            List<byte> timeRPHPList = new List<byte>();
            timeRPHPList.Add(ConvertToByte(timeHP));
            timeRPHPList.Add(DataFields[1]);
            timeRPHPList.Add(DataFields[2]);
            timeRPHPList.Add(DataFields[3]);

            this.timeReceptPosHP = computeData(timeRPHPList, 1, -30, false);



            // DI13.Add("FSI: "+FSI_pos);
            // DI13.Add("Time of Message Reception for Position HP: " + timeReceptPosHP + " s");

            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem14()
        {


            List<byte> timeRVList = new List<byte>();
            timeRVList.Add(DataFields[0]);
            timeRVList.Add(DataFields[1]);
            timeRVList.Add(DataFields[2]);

            this.timeReceptVel = Math.Round(computeData(timeRVList, 1, -7, false), 1);



            // DI14.Add("Time of Message Reception for Velocity: " + timeReceptVel + " s");

            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem15()
        {
            DataItemsList.Add(new string[] { "15", "[I021/076]", "Time of message reception of velocity High Prec." });

            BitArray timeVHP = new BitArray(new byte[] { DataFields[0] });

            string FSIVLabel = Convert.ToString(Convert.ToInt32(timeVHP[7])) + Convert.ToInt32(timeVHP[6]);

            switch (FSIVLabel)
            {
                case "11":
                    this.FSI_Vel = "Reserved";
                    break;
                case "10":
                    this.FSI_Vel = "TOMRp whole seconds =(I021/073) Whole seconds – 1";
                    break;
                case "01":
                    this.FSI_Vel = "TOMRp whole seconds = (I021/073) Whole seconds + 1";
                    break;
                case "00":
                    this.FSI_Vel = "TOMRp whole seconds = (I021/073) Whole seconds";
                    break;
            }

            List<byte> timeRVHPList = new List<byte>();
            timeRVHPList.Add(ConvertToByte(timeVHP));
            timeRVHPList.Add(DataFields[1]);
            timeRVHPList.Add(DataFields[2]);
            timeRVHPList.Add(DataFields[4]);

            this.timeReceptVelHP = computeData(timeRVHPList, 1, -30, false);



            // DI15.Add("FSI: "+FSI_Vel);
            // DI15.Add("Time of Message Reception for Velocity HP: " + timeReceptVelHP + " s");

            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem16()
        {
            DataItemsList.Add(new string[] { "16", "[I021/140]", "Geometric Height" });

            int GH1 = DataFields[0];
            int GH2 = DataFields[1];


            if (GH1 == 127 && GH2 == 255)
            {
                this.geometricHeight = "Aircraft transmits a greater than in// DIcation.";
            }
            else
            {
                List<byte> GHeightList = new List<byte>();

                GHeightList.Add(DataFields[0]);
                GHeightList.Add(DataFields[1]);

                this.geometricHeight = Convert.ToString(computeData(GHeightList, 6.25, 0, true));
            }



            // DI16.Add("Geometric Height: " + geometricHeight + " ft");



            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem17()
        {
            DataItemsList.Add(new string[] { "17", "[I021/090]", "Quality Indicators" });


            for (int j = 0; j < DataFields.Count; j++)
            {
                BitArray cadBits = new BitArray(new byte[] { DataFields[0] });
                DataFields.RemoveAt(0);



                if (j == 0)
                {


                    string NUClabel = Convert.ToString(Convert.ToInt32(cadBits[7])) + Convert.ToInt32(cadBits[6]) + Convert.ToInt32(cadBits[5]);

                    switch (NUClabel)
                    {
                        default:
                            this.NUCr = "“Navigation Uncertainty Category for velocity” NUCr or the “Navigation Accuracy Category for Velocity” NACv";
                            break;
                    }



                    // DI17.Add("NUCr: " + NUCr);

                    string NUCplabel = Convert.ToString(Convert.ToInt32(cadBits[4])) + Convert.ToInt32(cadBits[3]) + Convert.ToInt32(cadBits[2]) + Convert.ToInt32(cadBits[1]);

                    switch (NUClabel)
                    {
                        default:
                            this.NUCp = "“Navigation Uncertainty Category for velocity” NUCr or the “Navigation Accuracy Category for Velocity” NACv";
                            break;
                    }



                    // DI17.Add("NUCp: "+NUCp);


                }

                if (j == 1)
                {



                    this.NICbaro = " “Navigation Integrity Category for Barometric Altitude”";


                    // DI17.Add("NICbaro: "+NICbaro);

                    string SIL1label = Convert.ToString(Convert.ToInt32(cadBits[6])) + Convert.ToInt32(cadBits[5]);

                    switch (SIL1label)
                    {
                        default:
                            this.SIL1 = "“Surveillance(version 1) or Source(version 2) Integrity Level”";
                            break;
                    }


                    // DI17.Add("SIL1: " + SIL1);

                    string NACplabel = Convert.ToString(Convert.ToInt32(cadBits[4])) + Convert.ToInt32(cadBits[3]) + Convert.ToInt32(cadBits[2]) + Convert.ToInt32(cadBits[1]);

                    switch (NACplabel)
                    {
                        default:
                            this.NACp = "“Navigation Accuracy Category for Position”";
                            break;
                    }


                    // DI17.Add("NACp: " + NACp);
                }

                if (j == 2)
                {


                    this.SIL2 = cadBits[5] == false ? "measured per flight hour" : "measured per sample";



                    string SDAlabel = Convert.ToString(Convert.ToInt32(cadBits[4])) + Convert.ToInt32(cadBits[3]);

                    switch (SDAlabel)
                    {
                        default:
                            this.SDA = "Horizontal Position System Design Assurance Level (as defined in version 2)";
                            break;
                    }


                    // DI17.Add("SDA: " + SDA);

                    string GVAlabel = Convert.ToString(Convert.ToInt32(cadBits[2])) + Convert.ToInt32(cadBits[1]);

                    switch (GVAlabel)
                    {
                        default:
                            this.GVA = "Geometric Altitude Accuracy";
                            break;
                    }


                    // DI17.Add("GVA: " + GVA);
                }

                if (j == 3)
                {

                    string PIClabel = Convert.ToString(Convert.ToInt32(cadBits[7])) + Convert.ToInt32(cadBits[6]) + Convert.ToInt32(cadBits[5]) + Convert.ToInt32(cadBits[4]);

                    switch (PIClabel)
                    {
                        case "0000":
                            this.PIC = "No integrity(or > 20.0 NM)";
                            break;
                        case "0001":
                            this.PIC = "< 20.0 NM";
                            break;
                        case "0010":
                            this.PIC = "< 10.0 NM";
                            break;
                        case "0011":
                            this.PIC = "< 8.0 NM";
                            break;
                        case "0100":
                            this.PIC = "< 4.0 NM";
                            break;
                        case "0101":
                            this.PIC = "< 2.0 NM";
                            break;
                        case "0110":
                            this.PIC = "< 1.0 NM";
                            break;
                        case "0111":
                            this.PIC = "< 0.6 NM";
                            break;
                        case "1000":
                            this.PIC = "< 0.5 NM";
                            break;
                        case "1001":
                            this.PIC = "< 0.3 NM";
                            break;
                        case "1010":
                            this.PIC = "< 0.2 NM";
                            break;
                        case "1011":
                            this.PIC = "< 0.1 NM";
                            break;
                        case "1100":
                            this.PIC = "< 0.04 NM";
                            break;
                        case "1101":
                            this.PIC = "< 0.013 NM";
                            break;
                        case "1110":
                            this.PIC = "< 0.004 NM";
                            break;
                        case "1111":
                            this.PIC = "not defined";
                            break;
                    }


                    // DI17.Add("PIC: " + PIC);

                }



                if (cadBits[0] == false)
                {
                    break;
                }
            }



        }
        void DataItem18()
        {
            DataItemsList.Add(new string[] { "18", "[I021/210]", "MOPS Version" });



            BitArray MOPS = new BitArray(new byte[] { DataFields[0] });

            this.VNS = MOPS[6] == false ? "The MOPS Version is supported by the GS" : "The MOPS Version is not supported by the GS";




            string VNLabel = Convert.ToString(Convert.ToInt32(MOPS[5])) + Convert.ToInt32(MOPS[4]) + Convert.ToInt32(MOPS[3]);


            switch (VNLabel)
            {
                case "000":
                    this.VN = "ED102/DO-260 [Ref. 8]";
                    break;

                case "001":
                    this.VN = "DO-260A [Ref. 9]";
                    break;

                case "010":
                    this.VN = "ED102A/DO-260B [Ref. 11]";
                    break;
                default:
                    this.VN = "Not assigned";
                    break;
            }



            string LTTLabel = Convert.ToString(Convert.ToInt32(MOPS[2])) + Convert.ToInt32(MOPS[1]) + Convert.ToInt32(MOPS[0]);

            switch (LTTLabel)
            {
                case "000":
                    this.LTT = "Other";
                    break;

                case "001":
                    this.LTT = "UAT";
                    break;

                case "010":
                    this.LTT = "1090 ES";
                    break;
                case "011":
                    this.LTT = "VDL 4";
                    break;
                default:
                    this.LTT = "Not assigned";
                    break;
            }



            // DI18.Add("VNS: " + VNS);
            // DI18.Add("VN: " + VN);
            // DI18.Add("LTT: " + LTT);

            DataFields.RemoveAt(0);
        }
        void DataItem19()
        {
            DataItemsList.Add(new string[] { "19", "[I021/070]", "Mode 3/A Code" });

            BitArray bits1 = new BitArray(new byte[] { DataFields[0] });
            BitArray bits2 = new BitArray(new byte[] { DataFields[1] });

            //Compute // DIgits
            string DA = Convert.ToString(Convert.ToInt32(bits1[3]) * 4 + Convert.ToInt32(bits1[2]) * 2 + Convert.ToInt32(bits1[1]));
            int DB = Convert.ToInt32(bits1[0]) * 4 + Convert.ToInt32(bits2[7]) * 2 + Convert.ToInt32(bits2[6]);
            int DC = Convert.ToInt32(bits2[5]) * 4 + Convert.ToInt32(bits2[4]) * 2 + Convert.ToInt32(bits2[3]);
            int DD = Convert.ToInt32(bits2[2]) * 4 + Convert.ToInt32(bits2[1]) * 2 + Convert.ToInt32(bits2[0]);


            this.mode3A = DA + DB + DC + DD;


            // DI19.Add("Mode 3/A: "+mode3A);

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem20()
        {
            DataItemsList.Add(new string[] { "20", "[I021/230]", "Roll Angle" });

            List<byte> RAList = new List<byte>();

            RAList.Add(DataFields[0]);
            RAList.Add(DataFields[1]);

            this.rollAngle = computeData(RAList, Math.Pow(10, -3), 0, true);



            // DI20.Add("Roll Angle: " + rollAngle + " degrees");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem21()
        {
            DataItemsList.Add(new string[] { "21", "[I021/145]", "Flight Level" });

            List<byte> FLList = new List<byte>();
            FLList.Add(DataFields[0]);
            FLList.Add(DataFields[1]);

            this.flightLevel = Convert.ToString(computeData(FLList, 1, -2, true));



            // DI21.Add("Flight Level: " + flightLevel+" FL");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }


        }
        void DataItem22()
        {
            DataItemsList.Add(new string[] { "22", "[I021/152]", "Magnetic Headingng" });

            List<byte> MHList = new List<byte>();
            MHList.Add(DataFields[0]);
            MHList.Add(DataFields[1]);

            this.magneticHeading = computeData(MHList, 360, -16, false);



            // DI22.Add("Magnetic Hea// DIng: " + magneticHea// DIng + " degrees");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem23()
        {
            DataItemsList.Add(new string[] { "23", "[I021/200]", "Target Status" });



            BitArray TT = new BitArray(new byte[] { DataFields[0] });

            this.ICF = TT[7] == false ? "No intent change active" : "Intent change flag raised";



            this.LNAV = TT[6] == false ? "LNAV Mode engaged" : "LNAV Mode not engaged";



            string PSLabel = Convert.ToString(Convert.ToInt32(TT[4])) + Convert.ToInt32(TT[3]) + Convert.ToInt32(TT[2]);

            switch (PSLabel)
            {
                case "000":
                    this.PS = "No emergency / not reported";
                    break;

                case "001":
                    this.PS = "General emergency";
                    break;

                case "010":
                    this.PS = "Lifeguard / me// DIcal emergency";
                    break;

                case "011":
                    this.PS = "Minimum fuel";
                    break;

                case "100":
                    this.PS = "No communications";
                    break;

                case "101":
                    this.PS = "Unlawful interference";
                    break;

                case "110":
                    this.PS = "“Downed” Aircraft";
                    break;
            }


            string SSLabel = Convert.ToString(Convert.ToInt32(TT[1])) + Convert.ToInt32(TT[0]);

            switch (SSLabel)
            {
                case "00":
                    this.SS = "No con// DItion reported";
                    break;

                case "01":
                    this.SS = "Permanent Alert (Emergency con// DItion)";
                    break;

                case "10":
                    this.SS = "Temporary Alert (change in Mode 3/A Code other than emergency)";
                    break;

                case "11":
                    this.SS = "SPI set";
                    break;

            }


            // DI23.Add("ICF: " + ICF);
            // DI23.Add("LNAV: " + LNAV);
            // DI23.Add("PS: " + PS);
            // DI23.Add("SS: "+SS);



            DataFields.RemoveAt(0);

        }
        void DataItem24()
        {
            DataItemsList.Add(new string[] { "24", "[I021/155]", "Barometric Vertical Rate" });

            BitArray BVR = new BitArray(new byte[] { DataFields[0] });

            string RE_BVR = BVR[7] == false ? "Value in defined range" : "Value exceeds defined range";


            if (BVR[6] == true) //We move the sign sideways
            {
                BVR[7] = true;

            }
            else
            {
                BVR[7] = false;
            }


            List<byte> BVRList = new List<byte>();
            BVRList.Add(ConvertToByte(BVR));
            BVRList.Add(DataFields[1]);



            this.barometricVerticalRate = computeData(BVRList, 6.25, 0, true);


            // DI24.Add("Barometric Vertical Rate: " + barometricVerticalRate+" ft/min");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem25()
        {
            DataItemsList.Add(new string[] { "25", "[I021/157]", "Geometric Vertical Rate" });

            BitArray GVR = new BitArray(new byte[] { DataFields[0] });

            this.RE_GVR = GVR[7] == false ? "Value in defined range" : "Value exceeds defined range";

            if (GVR[6] == true) //We move the sign sideways
            {
                GVR[7] = true;

            }
            else
            {
                GVR[7] = false;
            }

            List<byte> GVRList = new List<byte>();
            GVRList.Add(ConvertToByte(GVR));
            GVRList.Add(DataFields[1]);

            this.geometricVerticalRate = computeData(GVRList, 6.25, 0, true);


            // DI25.Add("Geometric Vertical Rate: " + geometricVerticalRate + " ft/min");


            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem26()
        {
            DataItemsList.Add(new string[] { "26", "[I021/160]", "Airborne Ground Vector" });

            BitArray AGV1 = new BitArray(new byte[] { DataFields[0] });

            string RE_GS = AGV1[7] == false ? "Value in defined range" : "Value exceeds defined range";
            if (AGV1[6] == true)
            {
                AGV1[7] = true;

            }
            else
            {
                AGV1[7] = false;

            }




            List<byte> GSList = new List<byte>();
            GSList.Add(ConvertToByte(AGV1));
            GSList.Add(DataFields[1]);

            this.groundSpeed = computeData(GSList, 1, -14, false);


            List<byte> TAList = new List<byte>();
            TAList.Add(DataFields[2]);
            TAList.Add(DataFields[3]);

            this.trackAngle = Math.Round(computeData(TAList, 360, -16, false),3);


            // DI26.Add("RE: " + RE_GS);
            // DI26.Add("Ground Speed: " + groundSpeed + " kt");
            // DI26.Add("Track Angle: "+trackAngle+" degrees");


            for (int j = 0; j < 4; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem27()
        {
            DataItemsList.Add(new string[] { "27", "[I021/165]", "Track Angle Rate" });

            BitArray TAR1 = new BitArray(new byte[] { DataFields[0] });

            if (TAR1[1] == true)
            {
                TAR1[7] = true;

            }

            List<byte> TARList = new List<byte>();
            TARList.Add(ConvertToByte(TAR1));
            TARList.Add(DataFields[1]);

            this.trackAngleRate = computeData(TARList, 1, -5, true);



            // DI27.Add("Track Angle Rate: " + trackAngleRate + "  degrees/s");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem28()
        {
            DataItemsList.Add(new string[] { "28", "[I021/077]", "Time of Report Transmission" });

            List<byte> timeRTList = new List<byte>();
            timeRTList.Add(DataFields[0]);
            timeRTList.Add(DataFields[1]);
            timeRTList.Add(DataFields[2]);

            this.timeReportTrans = Math.Round(computeData(timeRTList, 1, -7, false), 1);



            // DI28.Add("Time of Report Transmission: " + timeReportTrans + " s");

            for (int j = 0; j < 3; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem29()
        {

            DataItemsList.Add(new string[] { "29", "[I021/170]", "Target Identification" });

            List<BitArray> listbytes = new List<BitArray>();

            for (int j = 0; j < 6; j++)
            {
                listbytes.Add(new BitArray(new byte[] { DataFields[j] }));

            }
            List<string> myChars = new List<string>();

            string char1 = Convert.ToString(Convert.ToInt32(listbytes[0][7])) + Convert.ToInt32(listbytes[0][6]) + " " + Convert.ToInt32(listbytes[0][5]) + Convert.ToInt32(listbytes[0][4]) + Convert.ToInt32(listbytes[0][3]) + Convert.ToInt32(listbytes[0][2]);
            string char2 = Convert.ToString(Convert.ToInt32(listbytes[0][1])) + Convert.ToInt32(listbytes[0][0]) + " " + Convert.ToInt32(listbytes[1][7]) + Convert.ToInt32(listbytes[1][6]) + Convert.ToInt32(listbytes[1][5]) + Convert.ToInt32(listbytes[1][4]);
            string char3 = Convert.ToString(Convert.ToInt32(listbytes[1][3])) + Convert.ToInt32(listbytes[1][2]) + " " + Convert.ToInt32(listbytes[1][1]) + Convert.ToInt32(listbytes[1][0]) + Convert.ToInt32(listbytes[2][7]) + Convert.ToInt32(listbytes[2][6]);
            string char4 = Convert.ToString(Convert.ToInt32(listbytes[2][5])) + Convert.ToInt32(listbytes[2][4]) + " " + Convert.ToInt32(listbytes[2][3]) + Convert.ToInt32(listbytes[2][2]) + Convert.ToInt32(listbytes[2][1]) + Convert.ToInt32(listbytes[2][0]);
            string char5 = Convert.ToString(Convert.ToInt32(listbytes[3][7])) + Convert.ToInt32(listbytes[3][6]) + " " + Convert.ToInt32(listbytes[3][5]) + Convert.ToInt32(listbytes[3][4]) + Convert.ToInt32(listbytes[3][3]) + Convert.ToInt32(listbytes[3][2]);
            string char6 = Convert.ToString(Convert.ToInt32(listbytes[3][1])) + Convert.ToInt32(listbytes[3][0]) + " " + Convert.ToInt32(listbytes[4][7]) + Convert.ToInt32(listbytes[4][6]) + Convert.ToInt32(listbytes[4][5]) + Convert.ToInt32(listbytes[4][4]);
            string char7 = Convert.ToString(Convert.ToInt32(listbytes[4][3])) + Convert.ToInt32(listbytes[4][2]) + " " + Convert.ToInt32(listbytes[4][1]) + Convert.ToInt32(listbytes[4][0]) + Convert.ToInt32(listbytes[5][7]) + Convert.ToInt32(listbytes[5][6]);
            string char8 = Convert.ToString(Convert.ToInt32(listbytes[5][5])) + Convert.ToInt32(listbytes[5][4]) + " " + Convert.ToInt32(listbytes[5][3]) + Convert.ToInt32(listbytes[5][2]) + Convert.ToInt32(listbytes[5][1]) + Convert.ToInt32(listbytes[5][0]);

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

                // DI29.Add("Target Identification: " + targetIdentification);
            }

            for (int j = 0; j < 6; j++)
            {
                DataFields.RemoveAt(0);
            }


        }
        void DataItem30()
        {
            DataItemsList.Add(new string[] { "30", "[I021/020]", "Emitter Category" });

            int ECATlabel = DataFields[0];

            switch (ECATlabel)
            {
                case 0:

                    this.ECAT = "No ADS-B Emitter Category Information";
                    break;

                case 1:

                    this.ECAT = "light aircraft <= 15500 lbs";
                    break;

                case 2:

                    this.ECAT = "15500 lbs < small aircraft <75000 lbs";
                    break;

                case 3:

                    this.ECAT = "75000 lbs < me// DIum a/c < 300000 lbs";
                    break;

                case 4:

                    this.ECAT = "High Vortex Large";
                    break;

                case 5:

                    this.ECAT = "300000 lbs <= heavy aircraft";
                    break;

                case 6:

                    this.ECAT = "highly manoeuvrable (5g acceleration capability) and high speed (>400 knots cruise)";
                    break;

                case 10:

                    this.ECAT = "rotocraft";
                    break;

                case 11:

                    this.ECAT = "glider / sailplane";
                    break;

                case 12:

                    this.ECAT = "lighter-than-air";
                    break;

                case 13:

                    this.ECAT = "unmanned aerial vehicle";
                    break;

                case 14:

                    this.ECAT = "space / transatmospheric vehicle";
                    break;

                case 15:

                    this.ECAT = "ultralight / handglider / paraglider";
                    break;

                case 16:

                    this.ECAT = "parachutist / sky// DIver";
                    break;

                case 20:

                    this.ECAT = "surface emergency vehicle";
                    break;

                case 21:

                    this.ECAT = "surface service vehicle";
                    break;
                case 22:

                    this.ECAT = "fixed ground or tethered obstruction";
                    break;

                case 23:

                    this.ECAT = "cluster obstacle";
                    break;

                case 24:

                    this.ECAT = "line obstacle";
                    break;

                default:

                    this.ECAT = "reserved";

                    break;

            }

            // DI30.Add("ECAT: " + ECAT);

            DataFields.RemoveAt(0);
        }
        void DataItem31()
        {
            DataItemsList.Add(new string[] { "31", "[I021/220]", "Met Information" });

            BitArray MET = new BitArray(new byte[] { DataFields[0] });
            DataFields.RemoveAt(0);




            this.WS = MET[7] == false ? "Absence of subfield #1" : "Presence of subfield #1";

            this.WD = MET[6] == false ? "Absence of subfield #2" : "Presence of subfield #2";

            this.TMP = MET[5] == false ? "Absence of subfield #3" : "Presence of subfield #3";

            this.TRB = MET[4] == false ? "Absence of subfield #4" : "Presence of subfield #4";

            // DI31.Add(WS);

            if (MET[7] == true)
            {
                List<byte> WSList = new List<byte>();
                WSList.Add(DataFields[0]);
                WSList.Add(DataFields[1]);

                this.windSpeed = Convert.ToInt32(computeData(WSList, 1, 0, false));


                // DI31.Add("Wind Speed: " + windSpeed + " kt");

                for (int j = 0; j < 2; j++)
                {
                    DataFields.RemoveAt(0);
                }
            }


            // DI31.Add(WD);

            if (MET[6] == true)
            {
                List<byte> WDList = new List<byte>();
                WDList.Add(DataFields[0]);
                WDList.Add(DataFields[1]);

                this.windDirection = Convert.ToInt32(computeData(WDList, 1, 0, false));


                // DI31.Add("Wind // DIrection: " + wind// DIrection + " degrees");

                for (int j = 0; j < 2; j++)
                {
                    DataFields.RemoveAt(0);
                }
            }


            // DI31.Add(TMP);
            if (MET[5] == true)
            {
                List<byte> TList = new List<byte>();
                TList.Add(DataFields[0]);
                TList.Add(DataFields[1]);

                this.temperature = computeData(TList, 1, -2, true);


                // DI31.Add("Temperature: " + temperature + "ºC");

                for (int j = 0; j < 2; j++)
                {
                    DataFields.RemoveAt(0);
                }
            }


            // DI31.Add(TRB);
            if (MET[4] == true)
            {
                List<byte> TRBList = new List<byte>();
                TRBList.Add(DataFields[0]);


                this.turbulence = Convert.ToInt32(computeData(TRBList, 1, 0, true));


                // DI31.Add("Turbulence: " + turbulence);
                DataFields.RemoveAt(0);
            }



        }
        void DataItem32()
        {
            DataItemsList.Add(new string[] { "32", "[I021/146]", "Selected Altitude" });

            BitArray SAcad = new BitArray(new byte[] { DataFields[0] });

            this.SAS = SAcad[7] == false ? "No source information provided" : "Source Information provided";



            // DI32.Add("SAS: " + SAS);

            string sourceLabel = Convert.ToString(Convert.ToInt32(SAcad[6])) + Convert.ToInt32(SAcad[5]);

            switch (sourceLabel)
            {
                case "00":
                    this.source = "Unknown";
                    break;
                case "01":
                    this.source = "Aircraft Altitude (Hol// DIng Altitude)";
                    break;
                case "10":
                    this.source = "MCP/FCU Selected Altitude";
                    break;
                case "11":
                    this.source = "FMS Selected altitude";
                    break;

            }


            // DI32.Add("Source: " + source);

            if (SAcad[4] == true)
            {
                SAcad[7] = true;
                SAcad[6] = true;
                SAcad[5] = true;
            }
            else
            {
                SAcad[7] = false;
                SAcad[6] = false;
                SAcad[5] = false;
            }



            List<byte> SAList = new List<byte>();

            SAList.Add(ConvertToByte(SAcad));
            SAList.Add(DataFields[1]);

            this.altitude = Convert.ToInt32(computeData(SAList, 25, 0, true));



            // DI32.Add("Altitude: " + altitude+" ft");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }

        }
        void DataItem33()
        {
            DataItemsList.Add(new string[] { "33", "[I021/148]", "Final State Selected Altitude" });

            BitArray FSSA = new BitArray(new byte[] { DataFields[0] });



            this.MV = FSSA[7] == false ? "No active or unknown" : "Active";

            this.AH = FSSA[6] == false ? "No active or unknown" : "Active";

            this.AM = FSSA[5] == false ? "No active or unknown" : "Active";

            if (FSSA[4] == true)
            {
                FSSA[7] = true;
                FSSA[4] = false;
            }

            FSSA[6] = false;
            FSSA[5] = false;

            List<byte> FSSAList = new List<byte>();
            FSSAList.Add(ConvertToByte(FSSA));
            FSSAList.Add(DataFields[1]);

            this.altitudeFSS = Convert.ToInt32(computeData(FSSAList, 25, 0, true));

            // DI33.Add("MV: " + MV);


            // DI33.Add("AH: " + AH);

            // DI33.Add("AM: " + AM);


            // DI33.Add("Altitude FSSA: " + altitudeFSS + " ft");

            for (int j = 0; j < 2; j++)
            {
                DataFields.RemoveAt(0);
            }
        }
        void DataItem34()
        {
            DataItemsList.Add(new string[] { "34", "[I021/110]", "Trajectory Intent" });

            BitArray TI = new BitArray(new byte[] { DataFields[0] });

            this.TIS = TI[7] == false ? "Absence of subfield #1" : "Presence of subfield #1";
            this.TID = TI[6] == false ? "Absence of subfield #2" : "Presence of subfield #2";
            // DI34.Add("TIS: "+TIS);
            // DI34.Add("TID: " + TID);

            DataFields.RemoveAt(0);

            if (TI[7] == true)
            {
                BitArray sub1 = new BitArray(new byte[] { DataFields[0] });

                this.NAV = sub1[7] == false ? "Trajectory Intent Data is availabel for this aircraft" : "Trajectory Intent Data is not available for this aircraft";
                this.NVB = sub1[6] == false ? "Trajectory Intent Data is valid" : "Trajectory Intent Data is valid";
                // DI34.Add("NAV: " + NAV);
                // DI34.Add("NVB: " + NVB);
                DataFields.RemoveAt(0);
            }

            if (TI[6] == true)
            {
                this.REP = DataFields[0];
                // DI34.Add("REP: " + REP);
                DataFields.RemoveAt(0);

                for (int n = 0; n < this.REP; n++)
                {
                    // DI34.Add("Object: "+(n+1));
                    BitArray oct2 = new BitArray(new byte[] { DataFields[0] });

                    DataFields.RemoveAt(0);

                    string tca = oct2[7] == false ? "TCP number avialble" : "TCP number not available";

                    this.TCAList.Add(tca);

                    string nc = oct2[6] == false ? "TCP compliance" : "TCP non compliance";

                    this.NCList.Add(nc);

                    oct2[7] = false;
                    oct2[6] = false;

                    this.TCPList.Add(Convert.ToInt32(ConvertToByte(oct2)));

                    List<byte> ATI = new List<byte>();
                    ATI.Add(DataFields[0]);
                    ATI.Add(DataFields[1]);

                    this.TIAList.Add(Convert.ToInt32(computeData(ATI, 10, 0, true)));

                    for (int k = 0; k < 2; k++)
                    {
                        DataFields.RemoveAt(0);
                    }

                    List<byte> TILAList = new List<byte>();
                    TILAList.Add(DataFields[0]);
                    TILAList.Add(DataFields[1]);
                    TILAList.Add(DataFields[2]);

                    this.LatList.Add(computeData(TILAList, 180, -23, true));

                    for (int k = 0; k < 3; k++)
                    {
                        DataFields.RemoveAt(0);
                    }

                    List<byte> TILOList = new List<byte>();
                    TILOList.Add(DataFields[0]);
                    TILOList.Add(DataFields[1]);
                    TILOList.Add(DataFields[2]);

                    this.LongList.Add(computeData(TILOList, 180, -23, true));

                    for (int k = 0; k < 3; k++)
                    {
                        DataFields.RemoveAt(0);
                    }

                    BitArray oct11 = new BitArray(new byte[] { DataFields[0] });

                    DataFields.RemoveAt(0);

                    string PTLabel = Convert.ToString(Convert.ToInt32(oct11[7])) + Convert.ToInt32(oct11[6]) + Convert.ToInt32(oct11[5]) + Convert.ToInt32(oct11[4]);

                    switch (PTLabel)
                    {
                        case "0000":

                            this.PTypeList.Add("Unknown");

                            break;
                        case "0001":

                            this.PTypeList.Add("Fly by waypoint (LT)");

                            break;
                        case "0010":

                            this.PTypeList.Add("Fly over waypoint LT");

                            break;
                        case "0011":

                            this.PTypeList.Add("Hold pattern (LT)");

                            break;

                        case "0100":

                            this.PTypeList.Add("Procedure Hold (LT)");

                            break;

                        case "0101":

                            this.PTypeList.Add("Procedure Turn(LT)");

                            break;

                        case "0110":

                            this.PTypeList.Add("RF Leg(LT)");

                            break;
                        case "0111":

                            this.PTypeList.Add("Top of Climb (VT)");

                            break;

                        case "1000":

                            this.PTypeList.Add("Top of descent (VT)");

                            break;

                        case "1001":

                            this.PTypeList.Add("Start of Level (VT)");

                            break;

                        case "1010":

                            this.PTypeList.Add("cross-over altitude (VT)");

                            break;

                        case "1011":

                            this.PTypeList.Add("Transition Altitude (VT)");

                            break;

                    }

                    string TDLabel = Convert.ToString(Convert.ToInt32(oct11[3])) + Convert.ToInt32(oct11[2]);

                    switch (TDLabel)
                    {
                        case "00":
                            this.TDList.Add("N/A");
                            break;
                        case "01":
                            this.TDList.Add("Turn Right");
                            break;
                        case "10":
                            this.TDList.Add("Turn Left");
                            break;
                        case "11":
                            this.TDList.Add("No Turn");
                            break;
                    }


                    this.TRAList.Add(oct11[1] == false ? "TTR not available" : "TTR available");
                    this.TOAList.Add(oct11[0] == false ? "TOV available" : "TOV not available");

                    List<byte> TOVBYTES = new List<byte>();
                    TOVBYTES.Add(DataFields[0]);
                    TOVBYTES.Add(DataFields[1]);
                    TOVBYTES.Add(DataFields[2]);

                    for (int k = 0; k < 3; k++)
                    {
                        DataFields.RemoveAt(0);
                    }

                    this.TOVList.Add(Convert.ToInt32(computeData(TOVBYTES, 1, 0, false)));

                    List<byte> TTRBYTES = new List<byte>();
                    TTRBYTES.Add(DataFields[0]);
                    TTRBYTES.Add(DataFields[1]);

                    for (int k = 0; k < 2; k++)
                    {
                        DataFields.RemoveAt(0);
                    }

                    this.TTRList.Add(computeData(TTRBYTES, Math.Pow(10, -2), 0, false));

                }
            }

        }
        void DataItem35()
        {
            DataItemsList.Add(new string[] { "35", "[I021/016]", "Service Management" });

            List<byte> SMList = new List<byte>();
            SMList.Add(DataFields[0]);
            DataFields.RemoveAt(0);

            this.reportPeriod = computeData(SMList, 1, -1, false);

            // DI35.Add("Report Period: " + reportPeriod + " s");
        }
        void DataItem36()
        {
            DataItemsList.Add(new string[] { "36", "[I021/008]", "Aircraft Operational Status" });

            BitArray AOS = new BitArray(new byte[] { DataFields[0] });
            DataFields.RemoveAt(0);

            this.RA = AOS[7] == false ? "TCAS II or ACAS RA not active" : "TCAS RA active";

            string TCLabel = Convert.ToString(Convert.ToInt32(AOS[6])) + Convert.ToInt32(AOS[5]);

            switch (TCLabel)
            {
                case "00":
                    this.TC = "no capability for Trajectory Change Reports";
                    break;

                case "01":
                    this.TC = "support for TC +0 repors only";
                    break;

                case "10":
                    this.TC = "support for multiple TC report";
                    break;
                case "11":
                    this.TC = "reserved";
                    break;
            }

            this.TS = AOS[4] == false ? "no capability to support Target State Report" : "capable of supporting target State Reports";
            this.ARV = AOS[3] == false ? "no capability to generate ARV- Report" : "capable of generate ARV-reports";
            this.CDTIA = AOS[2] == false ? "CT// DI not operational" : "CT// DI operational";
            this.NotTCAS = AOS[1] == false ? "TCAS Operational" : "TCAS not operational";
            this.SA = AOS[0] == false ? "Antenna // DIversity" : "Single antenna only";



            // DI36.Add("RA: " + RA);
            // DI36.Add("TC: " + TC);
            // DI36.Add("TS: " + TS);
            // DI36.Add("ARV: " + ARV);
            // DI36.Add("CDTIA: "+CDTIA);
            // DI36.Add("NotTCAS: " + NotTCAS);
            // DI36.Add("SA: " + SA);
        }
        void DataItem37()
        {
            DataItemsList.Add(new string[] { "37", "[I021/271]", "Surface Capabilities and Characteristics" });


            for (int j = 0; j < 2; j++)
            {
                BitArray SCCBYTE = new BitArray(new byte[] { DataFields[0] });

                if (j == 0)
                {
                    this.POA = SCCBYTE[5] == false ? "Position transmitted is not ADS-B position reference point" : "Position transmitted is the ADS-B position reference point";
                    this.CTDIS = SCCBYTE[4] == false ? "CDTI not operational" : "CDTI operational";
                    this.B2low = SCCBYTE[3] == false ? "≥ 70 Watts" : "< 70 Watts";
                    this.RAS = SCCBYTE[2] == false ? "Aircraft not receiving ATC-services" : "Aircraft receiving ATC services";
                    this.IDENT = SCCBYTE[1] == false ? "IDENT switch not active" : "IDENT switch active";

                    // DI37.Add("POA:" + POA);
                    // DI37.Add("CT// DI/S: " + CT// DIS);
                    // DI37.Add("B2 low: "+B2low);
                    // DI37.Add("RAS: " + RAS);
                    // DI37.Add("IDENT: " + IDENT);

                    DataFields.RemoveAt(0);
                    if (SCCBYTE[0] == false)
                    {
                        break;
                    }
                }

                if (j == 1)
                {
                    int LWLabel = Convert.ToInt32(SCCBYTE[3]) * 8 + Convert.ToInt32(SCCBYTE[2]) * 4 + Convert.ToInt32(SCCBYTE[1]) * 2 + Convert.ToInt32(SCCBYTE[0]);

                    switch (LWLabel)
                    {
                        case 0:
                            this.LandW = "L < 15 m & W < 11.5 m";
                            break;
                        case 1:
                            this.LandW = "L < 15 m & W < 23 m";
                            break;
                        case 2:
                            this.LandW = "L < 25 m & W < 28.5 m";
                            break;
                        case 3:
                            this.LandW = "L < 25 m & W < 34 m";
                            break;
                        case 4:
                            this.LandW = "L < 35 m & W < 33 m";
                            break;
                        case 5:
                            this.LandW = "L < 35 m & W < 38 m";
                            break;
                        case 6:
                            this.LandW = "L < 45 m & W < 39.5";
                            break;
                        case 7:
                            this.LandW = "L < 45 m & W < 45 m";
                            break;
                        case 8:
                            this.LandW = "L < 55 m & W < 45 m";
                            break;
                        case 9:
                            this.LandW = "L < 55 m & W < 52 m";
                            break;
                        case 10:
                            this.LandW = "L < 65 m & W < 59.5 m";
                            break;
                        case 11:
                            this.LandW = "L < 65 m & W < 67 m";
                            break;
                        case 12:
                            this.LandW = "L < 75 m & W < 72.5 m";
                            break;
                        case 13:
                            this.LandW = "L < 75 m & W < 80 m";
                            break;
                        case 14:
                            this.LandW = "L < 85 m & W < 80 m";
                            break;
                        case 15:
                            this.LandW = "L > 85 m or W < 80 m";
                            break;



                    }
                    // DI37.Add("L + W: " + LandW);

                }
            }

        }
        void DataItem38()
        {
            DataItemsList.Add(new string[] { "38", "[I021/132]", "Message Amplitude" });

            List<byte> MA = new List<byte>();
            MA.Add(DataFields[0]);
            this.messageAmplitude = Convert.ToInt32(computeData(MA, 1, 0, true));

            // DI38.Add("Message Amplitude: " + messageAmplitude);
            DataFields.RemoveAt(0);
        }
        void DataItem39()
        {
            DataItemsList.Add(new string[] { "39", "[I021/250]", "Mode S MB Data" });



            REP_ModeSMB = DataFields[0];

            // DI39.Add("Repetition Factor: " + REP_ModeSMB);

            DataFields.RemoveAt(0);

            for (int j = 0; j < REP_ModeSMB * 8; j++)
            {
                // DI39.Add("ITEM: " + j + 1);

                this.MBData.Add(BitConverter.ToString(new byte[] { DataFields[0], DataFields[1], DataFields[2], DataFields[3], DataFields[4], DataFields[5], DataFields[6] }));
                int BDS1byte = DataFields[7] >> 4;

                this.BDS1.Add(BitConverter.ToString(new byte[] { (byte)BDS1byte }));

                // DI39.Add("MB Data: " + BitConverter.ToString(new byte[] { DataFields[0], DataFields[1], DataFields[2], DataFields[3], DataFields[4], DataFields[5], DataFields[6] }));
                // DI39.Add("BDS1: " + BitConverter.ToString(new byte[] { (byte)BDS1byte }));



                BitArray BDS2Array = new BitArray(new byte[] { DataFields[7] });
                BDS2Array[7] = false;
                BDS2Array[6] = false;
                BDS2Array[5] = false;
                BDS2Array[4] = false;

                byte BDS2byte = ConvertToByte(BDS2Array);
                this.BDS2.Add(BitConverter.ToString(new byte[] { BDS2byte }));

                // DI39.Add("BDS2: " + BitConverter.ToString(new byte[] { BDS2byte }));

                for (int k = 0; k < 7; k++)
                {
                    DataFields.RemoveAt(0);
                }
            }
        }
        void DataItem40()
        {

            DataItemsList.Add(new string[] { "40", "[I021/260]", "ACAS Resolution Advisory Report" });

            //NO NECESSARY DECODE

        }
        void DataItem41()
        {
            DataItemsList.Add(new string[] { "41", "[I021/400]", "Receiver ID" });

            this.RID = DataFields[0];
            // DI41.Add("Receiver ID: " + RID);
            DataFields.RemoveAt(0);
        }
        void DataItem42()
        {
            DataItemsList.Add(new string[] { "42", "[I021/295]", "Data Ages" });

            int cont2 = 0;



            for (int j = 0; j < DataFields.Count; j++)
            {
                cont2++;



                BitArray DAGES = new BitArray(new byte[] { DataFields[cont2 - 1] });


                if (cont2 == 1)
                {
                    this.AOS_DA = DAGES[7] == false ? "Absence of Subfield #1" : "Presence of Subfield #1";
                    this.TRD_DA = DAGES[6] == false ? "Absence of Subfield #2" : "Presence of Subfield #2";
                    this.M3A = DAGES[5] == false ? "Absence of Subfield #3" : "Presence of Subfield #3";
                    this.QI = DAGES[4] == false ? "Absence of Subfield #4" : "Presence of Subfield #4";
                    this.TI1_DA = DAGES[3] == false ? "Absence of Subfield #5" : "Presence of Subfield #5";
                    this.MAM_DA = DAGES[2] == false ? "Absence of Subfield #6" : "Presence of Subfield #6";
                    this.GH_DA = DAGES[1] == false ? "Absence of Subfield #7" : "Presence of Subfield #7";

                    // DI42.Add("AOS: " + AOS_DA);
                    // DI42.Add("TRD: "+TRD_DA);
                    // DI42.Add("M3A: " + M3A);
                    // DI42.Add("QI: " + QI);
                    // DI42.Add("TI: " + TI1_DA);
                    // DI42.Add("MAM: " + MAM_DA);
                    // DI42.Add("GH: " + GH_DA);


                }

                if (cont2 == 2)
                {
                    this.FL_DA = DAGES[7] == false ? "Absence of Subfield #8" : "Presence of Subfield #8";
                    this.ISA_DA = DAGES[6] == false ? "Absence of Subfield #9" : "Presence of Subfield #9";
                    this.FSA_DA = DAGES[5] == false ? "Absence of Subfield #10" : "Presence of Subfield #10";
                    this.AS_DA = DAGES[4] == false ? "Absence of Subfield #11" : "Presence of Subfield #11";
                    this.TAS_DA = DAGES[3] == false ? "Absence of Subfield #12" : "Presence of Subfield #12";
                    this.MH_DA = DAGES[2] == false ? "Absence of Subfield #13" : "Presence of Subfield #13";
                    this.BVR_DA = DAGES[1] == false ? "Absence of Subfield #14" : "Presence of Subfield #14";

                    // DI42.Add("FL: " + FL_DA);
                    // DI42.Add("ISA: " + ISA_DA);
                    // DI42.Add("FSA: "+FSA_DA);
                    // DI42.Add("AS: " + AS_DA);
                    // DI42.Add("TAS: " + TAS_DA);
                    // DI42.Add("MH: " + MH_DA);
                    // DI42.Add("BVR: " + BVR_DA);

                }

                if (cont2 == 3)
                {
                    this.GVR_DA = DAGES[7] == false ? "Absence of Subfield #15" : "Presence of Subfield #15";
                    this.GV_DA = DAGES[6] == false ? "Absence of Subfield #16" : "Presence of Subfield #16";
                    this.TAR_DA = DAGES[5] == false ? "Absence of Subfield #17" : "Presence of Subfield #17";
                    this.TI2_DA = DAGES[4] == false ? "Absence of Subfield #18" : "Presence of Subfield #18";
                    this.TS_DA = DAGES[3] == false ? "Absence of Subfield #19" : "Presence of Subfield #19";
                    this.MET_DA = DAGES[2] == false ? "Absence of Subfield #20" : "Presence of Subfield #20";
                    this.ROA_DA = DAGES[1] == false ? "Absence of Subfield #21" : "Presence of Subfield #21";

                    // DI42.Add("GVR: " + GVR_DA);
                    // DI42.Add("GV: " + GV_DA);
                    // DI42.Add("TAR: " + TAR_DA);
                    // DI42.Add("TI: " + TI2_DA);
                    // DI42.Add("TS: " + TS_DA);
                    // DI42.Add("MET: " + MET_DA);
                    // DI42.Add("ROA: " + ROA_DA);

                }

                if (cont2 == 4)
                {
                    this.ARA_DA = DAGES[7] == false ? "Absence of Subfield #22" : "Presence of Subfield #22";
                    this.SCC_DA = DAGES[6] == false ? "Absence of Subfield #23" : "Presence of Subfield #23";

                    // DI42.Add("ARA: " + ARA_DA);
                    // DI42.Add("SCC: " + SCC_DA);


                }


                if (DAGES[0] == false)
                {
                    break;
                }

            }

            for (int k = 0; k < cont2; k++)
            {
                DataFields.RemoveAt(0);
            }

            if (AOS_DA == "Presence of Subfield #1")
            {
                // DI42.Add(AOS_DA);
                List<byte> AOSDList = new List<byte>();
                AOSDList.Add(DataFields[0]);
                this.AOS_data = computeData(AOSDList, 0.1, 0, false);
                // DI42.Add("Aircraft Operational Status Age: " + AOS_data+" s");
                DataFields.RemoveAt(0);

            }

            if (TRD_DA == "Presence of Subfield #2")
            {
                // DI42.Add(TRD_DA);
                List<byte> TRDDList = new List<byte>();
                TRDDList.Add(DataFields[0]);
                this.TRD_data = computeData(TRDDList, 0.1, 0, false);
                // DI42.Add("Target Report Descriptor Age: " + TRD_DA + " s");
                DataFields.RemoveAt(0);

            }

            if (M3A == "Presence of Subfield #3")
            {
                // DI42.Add(M3A);
                List<byte> AOSDList = new List<byte>();
                AOSDList.Add(DataFields[0]);
                this.M3A_data = computeData(AOSDList, 0.1, 0, false);
                // DI42.Add("Mode 3/A Age: "+M3A_data+" s");
                DataFields.RemoveAt(0);

            }

            if (QI == "Presence of Subfield #4")
            {
                // DI42.Add(QI);
                List<byte> QIDList = new List<byte>();
                QIDList.Add(DataFields[0]);
                this.QI_data = computeData(QIDList, 0.1, 0, false);
                // DI42.Add("Quality In// DIcators Age: "+QI_data+" s");
                DataFields.RemoveAt(0);

            }

            if (TI1_DA == "Presence of Subfield #5")
            {
                List<byte> TIDList = new List<byte>();
                TIDList.Add(DataFields[0]);
                this.TI1_data = computeData(TIDList, 0.1, 0, false);
                // DI42.Add(TI1_DA);
                // DI42.Add("Trajectory Intent Age: " + TI1_data + "s");
                DataFields.RemoveAt(0);

            }

            if (MAM_DA == "Presence of Subfield #6")
            {
                List<byte> MAMDList = new List<byte>();
                MAMDList.Add(DataFields[0]);
                this.MAM_data = computeData(MAMDList, 0.1, 0, false);
                // DI42.Add(MAM_DA);
                // DI42.Add("Message Amplitude Age: " + MAM_data + " s");
                DataFields.RemoveAt(0);

            }

            if (GH_DA == "Presence of Subfield #7")
            {
                List<byte> GHDList = new List<byte>();
                GHDList.Add(DataFields[0]);
                this.GH_data = computeData(GHDList, 0.1, 0, false);
                // DI42.Add(GH_DA);
                // DI42.Add("Geometric Height Age: "+GH_data + " s");
                DataFields.RemoveAt(0);

            }

            if (FL_DA == "Presence of Subfield #8")
            {
                List<byte> FLDList = new List<byte>();
                FLDList.Add(DataFields[0]);
                this.FL_data = computeData(FLDList, 0.1, 0, false);
                // DI42.Add(FL_DA);
                // DI42.Add("Flight Level Age: " + FL_data + " s");
                DataFields.RemoveAt(0);

            }

            if (ISA_DA == "Presence of Subfield #9")
            {
                List<byte> ISADList = new List<byte>();
                ISADList.Add(DataFields[0]);
                this.ISA_data = computeData(ISADList, 0.1, 0, false);
                // DI42.Add(ISA_DA);
                // DI42.Add("Int. State Selected Altitude Age: " + ISA_data + " s");
                DataFields.RemoveAt(0);

            }

            if (FSA_DA == "Presence of Subfield #10")
            {
                List<byte> FSADList = new List<byte>();
                FSADList.Add(DataFields[0]);
                this.FSA_data = computeData(FSADList, 0.1, 0, false);

                // DI42.Add(FSA_DA);
                // DI42.Add("Final State Selected Altitude Age: " + FSA_data + " s");
                DataFields.RemoveAt(0);

            }

            if (AS_DA == "Presence of Subfield #11")
            {
                List<byte> ASDList = new List<byte>();
                ASDList.Add(DataFields[0]);
                this.AS_data = computeData(ASDList, 0.1, 0, false);

                // DI42.Add(AS_DA);
                // DI42.Add("Air Speed Age: "+AS_data+" s");
                DataFields.RemoveAt(0);

            }

            if (TAS_DA == "Presence of Subfield #12")
            {
                List<byte> TASDList = new List<byte>();
                TASDList.Add(DataFields[0]);
                this.TAS_data = computeData(TASDList, 0.1, 0, false);
                // DI42.Add(TAS_DA);
                // DI42.Add("True Air Speed Age: " + TAS_data + " s");
                DataFields.RemoveAt(0);

            }

            if (MH_DA == "Presence of Subfield #13")
            {
                List<byte> MHDList = new List<byte>();
                MHDList.Add(DataFields[0]);
                this.MH_data = computeData(MHDList, 0.1, 0, false);
                // DI42.Add(MH_DA);
                // DI42.Add("Magnetic Hea// DIng Age: " + MH_data + " s");
                DataFields.RemoveAt(0);

            }

            if (BVR_DA == "Presence of Subfield #14")
            {
                List<byte> BVRDList = new List<byte>();
                BVRDList.Add(DataFields[0]);
                this.BVR_data = computeData(BVRDList, 0.1, 0, false);
                // DI42.Add(BVR_DA);
                // DI42.Add("Barometric Vertical Rate Age: "+BVR_data + " s");
                DataFields.RemoveAt(0);

            }

            if (GVR_DA == "Presence of Subfield #15")
            {
                List<byte> GVRDList = new List<byte>();
                GVRDList.Add(DataFields[0]);
                this.GVR_data = computeData(GVRDList, 0.1, 0, false);
                // DI42.Add(GVR_DA);
                // DI42.Add("Geometric Vertical Rante Age: " + GVR_data);
                DataFields.RemoveAt(0);

            }

            if (GV_DA == "Presence of Subfield #16")
            {
                List<byte> GVDList = new List<byte>();
                GVDList.Add(DataFields[0]);
                this.GV_data = computeData(GVDList, 0.1, 0, false);
                // DI42.Add(GV_DA);
                // DI42.Add("Ground Vector Age: " + GV_data + " s");
                DataFields.RemoveAt(0);

            }

            if (TAR_DA == "Presence of Subfield #17")
            {
                List<byte> TARDList = new List<byte>();
                TARDList.Add(DataFields[0]);
                this.TAR_data = computeData(TARDList, 0.1, 0, false);
                // DI42.Add(TAR_DA);
                // DI42.Add("Track Angle Rate Age: " + TAR_data + " s");
                DataFields.RemoveAt(0);

            }

            if (TI2_DA == "Presence of Subfield #18")
            {
                List<byte> TI2DList = new List<byte>();
                TI2DList.Add(DataFields[0]);
                this.TI2_data = Math.Round(computeData(TI2DList, 0.1, 0, false), 1);
                // DI42.Add(TI2_DA);
                // DI42.Add("Target Identification Age: "+TI2_data + " s");
                DataFields.RemoveAt(0);

            }

            if (TS_DA == "Presence of Subfield #19")
            {
                List<byte> TSDList = new List<byte>();
                TSDList.Add(DataFields[0]);
                this.TS_data = computeData(TSDList, 0.1, 0, false);
                // DI42.Add(TS_DA);
                // DI42.Add("Target Status Age: "+TS_data+ " s");
                DataFields.RemoveAt(0);

            }

            if (MET_DA == "Presence of Subfield #20")
            {
                List<byte> METDList = new List<byte>();
                METDList.Add(DataFields[0]);
                this.MET_data = computeData(METDList, 0.1, 0, false);
                // DI42.Add(MET_DA);
                // DI42.Add("Met Information Age: " + MET_data + " s");
                DataFields.RemoveAt(0);

            }

            if (ROA_DA == "Presence of Subfield #21")
            {
                List<byte> ROADList = new List<byte>();
                ROADList.Add(DataFields[0]);
                this.ROA_data = computeData(ROADList, 0.1, 0, false);
                // DI42.Add(ROA_DA);
                // DI42.Add("Roll Angle Age: " + ROA_data + " s");
                DataFields.RemoveAt(0);

            }

            if (ARA_DA == "Presence of Subfield #22")
            {
                List<byte> ARADList = new List<byte>();
                ARADList.Add(DataFields[0]);
                this.ARA_data = computeData(ARADList, 0.1, 0, false);
                // DI42.Add(ARA_DA);
                // DI42.Add("ACAS resolution Advisory Age: "+ARA_data + " s");
                DataFields.RemoveAt(0);

            }

            if (SCC_DA == "Presence of Subfield #23")
            {
                List<byte> SCCDList = new List<byte>();
                SCCDList.Add(DataFields[0]);
                this.SCC_data = computeData(SCCDList, 0.1, 0, false);
                // DI42.Add(SCC_DA);
                // DI42.Add("Surface Capabilities and Characteristics Age: "+SCC_data + " s");
                DataFields.RemoveAt(0);

            }
        }
        void DataItem48()
        {
            DataFields.RemoveAt(0);
            this.reservedField = "Reserver Field";

            // DI48.Add("Reserved Field: " + reservedField);

        }
        void DataItem49()
        {
            DataFields.RemoveAt(0);
            this.specialPField = "Special Purpose Field";

            // DI49.Add("Special Purpose Field: " + specialPField);

        }


    }


}

