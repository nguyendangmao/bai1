using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void minimaxsum(int[] arr)
          
        {
            Array.Sort(arr);
            long min = arr.Take(4).Sum();
            long max = arr.Skip(1).Sum();
            Console.WriteLine("sum_min:" + min);
            Console.WriteLine("sum_max:" + max);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("moi ban nhap so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            minimaxsum(arr);
            Console.ReadLine();
        }
    }
}
