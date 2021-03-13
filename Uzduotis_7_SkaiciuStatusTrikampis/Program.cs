using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_7_SkaiciuStatusTrikampis
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
        
            int skaicius;
            int eilute, stulpelis;
            Console.WriteLine($"Iveskite skaiciu nuo 1 iki 9: ");
            string input = Console.ReadLine();
            
            //patikrinam, ar ivestas skaicius, t.y. int tipo kintamasis
            while (int.TryParse(input, out int n) == false)
            {
                Console.WriteLine("Ivedete neteisinga simboli. Si karta iveskite skaiciu");
                input = Console.ReadLine();
            }

            
            skaicius = Int32.Parse(input);

            for (eilute = 1; eilute <= 5; eilute++)
            {
                for (stulpelis = 1; stulpelis <= eilute; stulpelis++)
                {

                    Console.Write(skaicius + " ");

                }
                Console.WriteLine();

            }





            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
        
        
        
    }
}
