using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n個包裝紙可以換一糖果");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("想吃x個糖果");
            int x = int.Parse(Console.ReadLine());
            int package = 0, y = 0;

            while(x != 0)
            {
                if(package == 0)
                {
                    package++;
                    y++;
                    x--;
                }
                else
                {
                    if(package % n == 0)
                    {
                        package = 1;
                        x--;
                    }
                    else
                    {
                        y++;
                        package++;
                        x--;
                    }
                }
            }

            Console.WriteLine("總共需買" + y + "個糖果");
            Console.ReadLine();
        }
    }
}
