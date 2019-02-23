using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ue_StatischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            double flaeche = Mathematik.BerechneFlaeche(10, 20);
            Console.WriteLine(flaeche);
            Console.ReadKey();
      
        }
    }

    static class Mathematik
    {
        //Methoden
        public static double BerechneFlaeche(double _laenge, double _breite)
        {
            return _laenge * _breite;
        }
    }
}
