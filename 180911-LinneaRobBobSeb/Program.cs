﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_LinneaRobBobSeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en karaktär att använda");
            string karaktär = Console.ReadLine();
            Console.WriteLine("Hans favoritfärg var: ");
            string favoritecolor = Console.ReadLine();
            Console.WriteLine("Hans skor fick namnet?");
            string shoesName = Console.ReadLine();
            Console.Write("Vad är din favorithobby?");
            string hobby = Console.ReadLine();

            Console.Write("\nDet var en gång ");
            SebastiansClass.SebastiansSaga(karaktär);
            RobertsClass.RobertsSaga(favoritecolor);
            LinneaClass.Linnea(shoesName);
        }

        public void Story()
        {

        }
        
    }
}
