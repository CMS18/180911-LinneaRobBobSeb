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
            Console.WriteLine("Skriv in en karaktär att använda ");
            string karaktär = Console.ReadLine();

            Console.Write("\nVad heter du? ");
            string namn = Console.ReadLine();
            
            Console.Write("\nDin favoritfärg är ");
            string favoritecolor = Console.ReadLine();
            Console.WriteLine();
            SebastiansClass.SebastiansSaga();
            RobertsClass.RobertsSaga(favoritecolor);
        }
        
    }

}
