using System;

namespace esercizio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la temperatura: ");
            double temperatura = double.parse(Console.readLine());
            if (temperatura>18)
            {
                Console.ReadLine($"la temperatura della serra è stabile");
            }
            if(temperatura>5)
            {
                Console.ReadLine($"la temperatura della serra è in situazione di pericolo");
            }
            else if (temperatura < 18)
            {
                Console.ReadLine($"la temperatura della serra è in situazione di pericolo");
            }
            if(temperatura<5)
            {
                Console.ReadLine($"la temperatura della serra sta facendo danni irreparabili");
            }
            Console.ReadLine();
        }
    }
}
