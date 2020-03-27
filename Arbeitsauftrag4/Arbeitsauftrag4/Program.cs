using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag4
{
    class Program
    {
        static void Main(string[] args)
        {
            // mit Hilfe von Kilian

            string[] namen = new string[3];

            int counter = 0;


            try
            {
                foreach (string name in namen)
                {
                    counter++;
                    Console.Write("{0} Name hinzufügen: ", counter);
                    namen[0] = Console.ReadLine();
                }

                Console.Write("letzter Name: ");
                namen[4] = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }
            finally
            {
                Console.WriteLine("Das Programm wurde beendet.");
            }
        }
    }
}
