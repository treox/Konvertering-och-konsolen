using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Detta program konverterar ett decimaltal till närmaste heltal.");
            Console.Write("Skriv in ett decimaltal (decimaltecken skrivs med decimalkomma ,): ");
            string siffra = Console.ReadLine();

            float numVal = Convert.ToSingle(siffra);
            int res = Convert.ToInt32(numVal);

            Console.WriteLine("Konverterade {0} till {1} ", numVal, res);

        }
    }
}
