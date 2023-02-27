using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class Program
    {
        public static string timconversion(string s)
        {
            string AMorPM = s.Substring(8);
            string gio = s.Substring(0, 2);
            string phutgiauy = s.Substring(2, 6);
            if(AMorPM=="AM" && gio == "12")
            {
                gio = "00";

            }else if(AMorPM == "PM")
            {
                int sogioPM = int.Parse(gio);
                if(sogioPM != 12)
                {
                    gio = Convert.ToString(12 + sogioPM);
                }
            }
            return gio+phutgiauy;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string kq = timconversion(s);
            Console.WriteLine(kq);
            Console.ReadKey();
        }
    }
}
