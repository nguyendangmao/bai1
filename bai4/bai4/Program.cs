using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static int Dia(int[,] arr, int n)
        {
            int d1 = 0, d2 = 0;
            for (int i = 0; i < n; i++)
            {
                d1 += arr[i, i];
                d2 += arr[i, n - i - 1];
            }
            return Math.Abs(d1 - d2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("ma tran vua nhap la:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("chenh lech 2 duong cheo la:"+Dia(arr, n));
            Console.ReadLine();
        }
    }
}
