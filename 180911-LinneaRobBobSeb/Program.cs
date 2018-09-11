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
            Console.Write("Hans favoritfärg var: ");
            string favoritecolor = Console.ReadLine();
            Console.Write("Det var en gång en {0}", karaktär);
            SebastiansClass.SebastiansSaga();
            RobertsClass.RobertsSaga(favoritecolor);
            Console.Write("\nVad heter du?");
            string namn = Console.ReadLine();

            Console.Write("")

            Console.WriteLine("\n\tDet var en gång..");
            RobertN.Robert(story);
        }
    }
}
