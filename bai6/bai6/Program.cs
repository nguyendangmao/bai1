using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void staircase(int n)
        {
            for(int y=n-1;y>=0;y--)
            {
                for(int x = 0; x < n; x++)
                {
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadLine();
        }
    }
}
