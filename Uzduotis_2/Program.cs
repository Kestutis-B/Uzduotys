using System;

namespace Uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Iveskite du skaicius su kableliu");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            
            

           
            Console.WriteLine($"Pasirinkite veiksma: (+, -, *, /,)");
            string veiksmas = Console.ReadLine();

            
            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2}");
                    break;
                default:
                    Console.WriteLine("Veiksmas nepavyko");
                    break;
            }

            
            

           

            /*
            UŽDUOTIS 2
1.Sukurti naują metodą.
2.Paprašyti vartotojo įvesti du skaičius su kableliu.
3.Paprašyti vartotojo pasirinkti kokį veiksmą jis nori atlikti su su
skaičiaus: sudėti, atimti(iš pirmojo atimti antrąjį), padauginti,
padalinti(pirmąjį iš antro), abiejų skaičių sumą pakelti kvadratu,
abiejų skaičių sumą pakelti kubu.
4.Pasirinkimams panaudoti switch sakinį
            */
            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
