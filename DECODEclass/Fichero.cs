using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;


namespace DECODEclass
{
    public class Fichero
    {
        //Atributes
        string path; // url of binary file
        byte[] fileBytes; /*= new List<byte>();*/ // Array to save the file's information
        List<CAT10> lCAT10 = new List<CAT10>(); //List where we sabe CAT10's message
        List<CAT21> lCAT21 = new List<CAT21>(); //List where we sabe CAT21's message

        //Constructor
        public Fichero(string adress) //Create a Fichero class with a given url
        {
            this.path = adress;
           
        }

        //Methods

        //readFile() -> Read Information's file with the given url
        public void readFile()

        {
            this.fileBytes = File.ReadAllBytes(this.path);//.ToList<byte>();

        }

        // classifyMessage => Decide category of message
        public void classifyMessage()
        {
            int ini = 0;
            while (ini < fileBytes.Length) //While we are not read all the message...
            {
                //Calculate length of the message
                int length = fileBytes[ini + 2];
                byte[] CATmessage = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    CATmessage[i] = fileBytes[ini + i];
                }
                int CAT = CATmessage[0];
                //Note: Machine read from right to Left the byte  ->  .Reverse()
                //Note: ToArray() -> to use .Skip().Take();







                switch (CAT)
                {
                    case 10:

                        /*byte[] CATmessage10 = fileBytes.Skip(0).Take(length).ToArray(); *///We take n (=length) bytes-> message's length
                        //bin2Hex(CATmessage);
                        CAT10 Ten = new CAT10(CATmessage, length); //Create message's CAT 10
                        lCAT10.Add(Ten); //Add CAT10 message in our list of CAT10




                        break;

                    case 21:

                        /*byte[] CATmessage21 = fileBytes.Skip(0).Take(length).ToArray();*/ //We take n (=length) bytes-> message's length
                        CAT21 twentyone = new CAT21(CATmessage, length);
                        lCAT21.Add(twentyone);
                        break;


                }

                ini = ini + length;

            }


        }


        //// DisplayMessage() -> to verify if we read sucessfully all the information of the file
        //public void DisplayMessage(byte[] word)
        //{
        //    BitArray messageBit = new BitArray(word);
        //    for (int i = 0; i < word.Count(); i++)
        //    {
        //        Console.WriteLine(word[i]);
        //    }
        //}


        ////bin2Hex() -> to verify with the Asterixdecoder.exe if we read sucessfully all the information of the file
        //public void bin2Hex(byte[] word)
        //{

        //    for (int i = 0; i < word.Count(); i++)
        //    {
        //        string[] Hex = new string[word.Count()];
        //        Hex[i] = BitConverter.ToString(new byte[] { word[i] });
        //        Console.WriteLine("{0} -> {1}", word[i], Hex[i]);
        //    }
        //}



        //GETTER -> to obtain atribute from other class
        public List<CAT10> GetListCAT10()
        {
            return lCAT10;
        }

        public List<CAT21> GetListCAT21()
        {
            return lCAT21;
        }

    }
}
