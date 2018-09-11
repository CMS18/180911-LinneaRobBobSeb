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
            Console.WriteLine("Hans favoritfärg var: ");
            string favoritecolor = Console.ReadLine();
            Console.WriteLine("Vilket språk talade han?");
            string shoesName = Console.ReadLine();
            Console.WriteLine("Vad var hans favorithobby?");
            string hobby = Console.ReadLine();
            Console.WriteLine("\nDet var en gång..");

            Console.Write("\nDet var en gång ");
            SebastiansClass.SebastiansSaga(karaktär);
            RobertsClass.RobertsSaga1(favoritecolor);
            LinneaClass.Linnea(shoesName);
            RobertsClass.RobertsSaga2(hobby);
        }

        public void Story()
        {

        }
        
    }
}
