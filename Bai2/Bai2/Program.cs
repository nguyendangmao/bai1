using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int A = 0;
            int B = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    A++;

                }
                else if (a[i] < b[i])
                {
                    B++;
                }
            }
            return new List<int> { A, B };
        }
        static void Main(string[] args)
        {
            var a = new List<int> { 10, 11, 12, 14, 45 };
            var b = new List<int> { 8, 15, 10, 12, 55 };
            var result = compareTriplets(a, b);      
            Console.WriteLine($"[ {result.ElementAt(0)} , {result.ElementAt(1)}]");
            Console.ReadKey();

        }
    }
}
