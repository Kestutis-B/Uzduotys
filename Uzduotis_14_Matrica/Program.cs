using System;

namespace Uzduotis_14_Matrica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // sukuriu kintamaji, matrica is keturiu eiluciu ir keturiu stulpeliu
            int[,] a = new int[4, 4]
            {
                {9, 22, 3, 19},
                {6, 16, 11, 8},
                {7, 5, 18, 10},
                {8, 6, 2, 11}
            };
            // x ir y asys
            int x = a.GetUpperBound(0);
            int y = a.GetUpperBound(1);
            
            Console.WriteLine($"\n Dabar rasime didziausia matricos skaiciu");
            int max = a[0, 0];
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    if (max<a[i, j])
                    {
                        max = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Didziausias matricos skaicius yra:");
            Console.WriteLine(max);
            
            Console.WriteLine($"\n Dabar rasime vidutinio dydzio matricos skaiciu");
            //kadangi vidurkis greiciausiai bus ne sveikasis skaicius, pasirenku float kintamaji
            float average = 0.0F;
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    sum += a[i, j];
                }

                average = (float)sum / a.Length;
            }
            Console.WriteLine($"Vidutinis matricos skaicius yra:");
            Console.WriteLine(average);

            






            Console.WriteLine("---Press any key to continue---");
            Console.ReadLine();
        }
        
    }
}
