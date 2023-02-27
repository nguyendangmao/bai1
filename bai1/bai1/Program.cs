using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static int simpleArraySum(int[] arr)
        {
            int tong = 0;
            foreach (var item in arr)
            {
                tong += item;
            }
            return tong;
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = simpleArraySum(arr);        
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
