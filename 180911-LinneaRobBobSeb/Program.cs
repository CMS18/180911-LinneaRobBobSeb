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
            Console.Write("\n\tDet var en gång en {0}", karaktär);
            Console.Write("Hans favoritfärg var: ");
            string favoritecolor = Console.ReadLine();
            Console.WriteLine();
            SebastiansClass.SebastiansSaga();
            RobertsClass.RobertsSaga(favoritecolor);
            Console.WriteLine("\n\tDet var en gång..");
            Console.Write("Vilken färg har du på dina skor?");
            string colourShoes = "";

            LinneaClass.Linnea();
        }
        
    }

}
