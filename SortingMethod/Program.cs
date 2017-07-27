using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethod
{
    class Program
    {
        public static void sort(int[]nilai)
        {
            for (int b = nilai.Length - 1; b > 0; b--)
            {
                for (int c = 0; c < b; c++)
                {
                    if (nilai[c] < nilai[c + 1])
                    {
                        int temp = nilai[c];
                        nilai[c] = nilai[c + 1];
                        nilai[c + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n Data setelah diurutkan :");
            for (int d = 0; d < nilai.Length; d++)
            {
                Console.Write(nilai[d] + " ");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input berapa jumlah angka :");
            int a = int.Parse(Console.ReadLine());
            int[] sorting = new int[a];

            Console.WriteLine("Masukan {0} angka :", a);
            for (int x = 0; x < a; x++)
            {
                sorting[x] = int.Parse(Console.ReadLine());
            }
            sort(sorting);
            Console.ReadKey();
            
        }
    }
}
