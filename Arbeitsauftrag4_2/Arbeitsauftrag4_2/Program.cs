using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // mit Hilfe von Kilian

            try
            {
                int zahl1 = 10;
                int zahl2 = 0;

                int ergebnis = zahl1 / zahl2;

                Console.WriteLine("Ergebnis: {0}", ergebnis);
            }
            catch (DivideByZeroException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
