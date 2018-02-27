using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_1_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i.ToString().Replace("3", "A").Replace("5","B").Replace("9","C").Replace("0","D"));
            }
            Console.ReadLine();
        }
    }
}
