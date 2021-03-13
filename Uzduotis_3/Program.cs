using System;

namespace Uzduotis_3
{
    class Programm
    {
        static void Main(string[] args)
        {

            Console.Write("Iveskite skaiciu: ");
            // patikrinam ar ivestas simbolis yra skaicius
            int skaicius = int.Parse(Console.ReadLine());
            int liekana;
            string rezultatas = string.Empty;
            while(skaicius > 0)
            {
                liekana = skaicius % 2;
                skaicius /= 2;
                rezultatas = liekana.ToString() + rezultatas;
            }
            Console.WriteLine("Ivesto skaiciaus dvejetainis formatas {0}", rezultatas);
            Console.ReadLine();
            



            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
