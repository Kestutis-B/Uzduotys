using System;

namespace Uzduotis_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Iveskite dvejetainiu skaiciu eile: ");
            string ivestasSkaicius = Console.ReadLine();

            // ivesta dvejetainiu eile konvertuoja i desimtaini skaciu
            Console.WriteLine("{0}", Convert.ToInt32(ivestasSkaicius, 2));
            Console.ReadLine();




            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
