using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tobbdimenziostombok
{
    class Program
    {
        static int[,] TombLetrehozEsFeltolt(int sor, int oszlop)
        {
            Random random = new Random();
            int[,] tomb = new int[sor, oszlop];
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = random.Next(1, 10);
                }
            }
            return tomb;
        }

        static void TombKiir(int[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write(tomb[i,j] + "\t");
                }
                Console.Write('\n');
            }
        }

        static void TombSorKiir(int[,] tomb, int sor)
        {
            for (int j = 0; j < tomb.GetLength(1); j++)
            {
                Console.WriteLine(tomb[sor, j]);
            }
        }

        static void TombOszlopKiir(int[,] tomb, int oszlop)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                Console.WriteLine(tomb[i, oszlop]);
            }
        }

        static void Main(string[] args)
        {
            //int[] tomb1D = new int[] { 1, 2, 3, 4, 5 };
            //int[,] tomb2D = new int[2, 3]
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 }
            //};

            //Console.WriteLine(tomb1D[3]);
            //Console.WriteLine(tomb2D[0, 1]);

            //Console.WriteLine($"Összes elem: {tomb1D.Length}");
            //Console.WriteLine($"Összes elem: {tomb2D.Length}");

            //Console.WriteLine($"Sorok száma: {tomb2D.GetLength(0)}");
            //Console.WriteLine($"Oszlopk száma: {tomb2D.GetLength(1)}");
            //Console.WriteLine("Összes elem: " + tomb2D.GetLength(0) * tomb2D.GetLength(1));

            //Console.WriteLine("Utolsó elem: " + tomb2D[tomb2D.GetLength(0) - 1, tomb2D.GetLength(1) - 1]);
            //Console.WriteLine("Első elem: " + tomb2D[0, 0]);

            int[,] tomb = TombLetrehozEsFeltolt(5, 5);
            TombKiir(tomb);


            Console.ReadKey();
        }
    }
}
