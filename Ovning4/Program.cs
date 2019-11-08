using System;

namespace Ovning4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Skriv in ditt namn: ");
            string namn = Console.ReadLine();

            Console.WriteLine("Välkommen {0}!", namn);

            Console.WriteLine();
            Console.Write("Skriv in din ålder: ");
            string strAlder = Console.ReadLine();
            float numAlder = Convert.ToSingle(strAlder);

            int dagarPAr = 365;
            float res1 = numAlder*dagarPAr;
            int res2 = Convert.ToInt32(res1);

            Console.WriteLine("Du har levt i cirka {0} dagar.", res2);

        }
    }
}
