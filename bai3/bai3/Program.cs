using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                sum += ar[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            long n = Convert.ToInt32(Console.ReadLine());
            long[] arr = new long[n];

            for (long i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            long result = aVeryBigSum(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
