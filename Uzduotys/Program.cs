using System;

namespace Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paprašau įvesti tris skirtingus skaičius
            Console.WriteLine($"Iveskite tris skaicius, atskirkite Enter mygtuku ");
            int skaicius1 = int.Parse(Console.ReadLine());
            int skaicius2 = int.Parse(Console.ReadLine());
            int skaicius3 = int.Parse(Console.ReadLine());

            //Paprašau pasirinkti kažkurį skaičių
            Console.WriteLine($"Pasirinkite viena is triju ivestu skaiciu");
            string input = Console.ReadLine(); // nuskaito pasirinktą vartotojo skaičių
            int ivestis = Int32.Parse(input); 
            
            Console.WriteLine($"Pasirinkite veiksma: (+, -, /, *)");
            string type_of_calculation = Console.ReadLine();

            Console.WriteLine($"Iveskite dar viena skaiciu");
            int skaicius4 = int.Parse(Console.ReadLine());
            

            if (type_of_calculation == "+")
            {                
                Console.WriteLine($"Atsakymas yra lygus {ivestis + skaicius4}");
            }

            else if (type_of_calculation == "-")
            {
                Console.WriteLine($"Atsakymas yra lygus {(ivestis - skaicius4)}");
            }
            else if (type_of_calculation == "/")
            {
                Console.WriteLine($"Atsakymas yra lygus {(ivestis / skaicius4)}");
            }
            else if (type_of_calculation == "*")
            {
                Console.WriteLine($"Atsakymas yra lygus {(ivestis * skaicius4)}");
            }
            else
            {
                Console.WriteLine($"Pasirinkite teisinga veiksma");
            }
            


            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
