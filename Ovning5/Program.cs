using System;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Är det fint väder? ");
            var svar = Console.ReadLine();

            string substr = svar.Substring(0, 1);

            if (substr == "J" || substr == "j")
            {
                Console.WriteLine("Vad bra! Du skulle kunna gå på picknick!");
            }
            else if (substr == "N" || substr == "n")
            {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            }
            else 
            {
                Console.WriteLine("Jag förstår inte riktigt!");
            }

        }
    }
}
