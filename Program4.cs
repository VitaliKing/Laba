using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[10] { 12, 2, -5, 8, -6, 72, 5, 7, 8, -12 };
            int max = 0;
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                if (m[i] > m[max])
                {
                    max = i;
                }
            }
                for (int a= 0; a<max; a++)
                {
                    s += m[a];
                }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
