using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_7_SkaiciuStatusTrikampis
{
    class Program
    {
        const string SK = "5";
        const string Tarpas = " ";
        const int Counter = 5;
        
        
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
        
            DisplayA();
                       



            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
        
        static void DisplayA()
        {
            for (int i = 0; i < Counter ; i++)
            {
                for (int c = 0; c <= i; c++)
                {
                    Console.Write(SK);
                }
                Console.WriteLine();
            }
            
        }
        
    }
}
