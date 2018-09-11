using System;
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
            Console.WriteLine("Vilken färg är han?");
            string charColor = Console.ReadLine();
            Console.Write("Hans favoritfärg var: ");
            string favoritecolor = Console.ReadLine();
            Console.Write("\nVad heter du?");
            string namn = Console.ReadLine();

            Console.Write("\nDet var en gång en {0} {1}", charColor, karaktär);
            SebastiansClass.SebastiansSaga();
            RobertsClass.RobertsSaga(favoritecolor);


            //Console.WriteLine("\nDet var en gång..");
        }
    }
}
