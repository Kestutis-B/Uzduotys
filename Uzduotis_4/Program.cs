using System;

namespace Uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Iveskite skaiciu");
            //naudotojo ivesta skaiciu konvertuojam i INT32
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Iveskite laipsni, kuriuo norite pakelti ivesta skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            // Math.Pow pirma kintamaji kelia laipsniu, kokia yra antro kintamojo reiksme
            Console.WriteLine(Math.Pow(skaicius, skaicius1));





            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
