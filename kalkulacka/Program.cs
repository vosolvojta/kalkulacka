using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = int.Parse(Console.ReadLine());
            int cislo1 = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            double vysledek = 0;

            if (operace == "+")
            {
                vysledek = cislo + cislo1;
            }
            else if (operace == "*")
            {
                vysledek = cislo * cislo1;
            }
            else if (operace == "/")
            {
                vysledek = cislo / cislo1;
            }
            else if (operace == "-")
            {
                vysledek = cislo - cislo1;
            }
            else if (operace == "%")
            {
                vysledek = cislo % cislo1;
            }
            else 
            {
                Console.WriteLine("Wrong answer");
            }

            Console.WriteLine("Vysledek: " + vysledek);
            Console.ReadKey();
        }
    }
}
