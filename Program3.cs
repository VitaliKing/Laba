using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[8] { 12, 2, 5, 8, -6, 7, 5, 7 };
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (m[i] > 0)
                {
                    a += (m[i] * m[i]);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
