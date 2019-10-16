using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5__
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la temperatura: ");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura >= 18)
            {
                Console.WriteLine($"la temperatura della serra è stabile");
            }
            if (temperatura > 5)
            {
                Console.WriteLine($"la temperatura della serra è in situazione di pericolo");
            }
            else if (temperatura < 18)
            {
                Console.WriteLine($"la temperatura della serra è in situazione di pericolo");
            }
            if (temperatura <= 5)
            {
                Console.WriteLine($"la temperatura della serra sta facendo danni irreparabili");
            }
            Console.ReadLine();
        }
    }
}
