using System;

namespace Uzduotis_8_SkaiciuTrikampis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int skaicius;
            Console.WriteLine($"Iveskite skaiciu nuo 1 iki 9: ");
            string input = Console.ReadLine();
            //patikrinam, ar ivestas skaicius, t.y. int tipo kintamasis
            while (int.TryParse(input, out int n) == false)
            {
                Console.WriteLine("Ivedete neteisinga simboli. Si karta iveskite skaiciu");
                input = Console.ReadLine();
            }

            skaicius = Int32.Parse(input);




            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
