using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void plusminus(int[] arr)
        {
            int duong = 0;
            int am = 0;
            int zero = 0;
            float length = arr.Length;

           for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    am++;
                }else if (arr[i] == 0)
                {
                    zero++;
                }
                else
                {
                    duong++;
                }
            }
            Console.WriteLine("ti le duong la:" + duong / length);
            Console.WriteLine("ti le am la:" + am / length);
            Console.WriteLine("ti le 0 la:" + zero / length);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("moi ban nhap so phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            plusminus(arr);
            Console.ReadLine();

        }
    }
}
