using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    class Program
    {
        static void birtgdaycakecandles(int[] arr)
        {
            int max = arr[0];
            int c = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    c++;
                }else if (arr[i] == max)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("moi bann hap so phan tu mang")
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            birtgdaycakecandles(arr);
            Console.ReadLine();
        }
    }
}
