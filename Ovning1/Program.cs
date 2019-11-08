using System;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Skriv in en siffra (decimaltecken skrivs med decimalkomma ,): ");
            string siffra1 = Console.ReadLine();
            Console.Write("Skriv in en annan siffra (decimaltecken skrivs med decimalkomma ,): ");
            string siffra2 = Console.ReadLine();

            float numVal1 = Convert.ToSingle(siffra1);
            float numVal2 = Convert.ToSingle(siffra2);
            
            float res = numVal1 + numVal2;
            Console.Write("Resultat: ");
            Console.WriteLine(res);
            
        }
    }
}
