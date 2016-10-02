using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[8] { -15, 28, 3, 0, -6, 10, -5, -20 };
            int min = 0;
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (m[i]<min)
                {
                    min = m[i];
                    a = i;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
