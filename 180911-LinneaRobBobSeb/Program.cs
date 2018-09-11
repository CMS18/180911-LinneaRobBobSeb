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
            string karaktär = Console.ReadLine();
            Console.WriteLine("\n\tDet var en gång en {0}", karaktär);
            SebastiansClass.SebastiansSaga();
        }
    }
}
