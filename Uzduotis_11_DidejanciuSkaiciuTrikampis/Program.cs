using System;

namespace Uzduotis_11_DidejanciuSkaiciuTrikampis
{
    class Program
    {
        static void Main(string[] args)
        {
            int eilute, stulpelis;

            Console.WriteLine($"Iveskite skaiciu nuo 1 iki 9: ");
            string input = Console.ReadLine();
            //patikrinam, ar ivestas skaicius, t.y. int tipo kintamasis
            while (int.TryParse(input, out int n) == false)
            {
                Console.WriteLine("Ivedete neteisinga simboli. Si karta iveskite skaiciu");
                input = Console.ReadLine();
            }


            for (eilute = 1; eilute <= 4; eilute++)
            {
                for (stulpelis = 1; stulpelis <= eilute; stulpelis++)
                {

                    Console.Write(eilute + " ");

                }
                Console.WriteLine();

            }
            /*kazkodel cia gaunasi
             * 3
             * 22
             * 111
             * */
            for (eilute = 3; eilute >= 1; eilute--)
            {
                for (stulpelis = 3; stulpelis >= eilute; stulpelis--)
                {
                    Console.Write(eilute + " ");
                }
                Console.WriteLine();

            }




            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
    }
}
