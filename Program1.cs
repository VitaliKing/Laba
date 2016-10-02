using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int a = 0;
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (p<q)
            {
                for (int i = 0; i<10; i++)
                {
                    if (m[i]>p && m[i]<q)
                    {
                        a++;
                    }
                }
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
            Console.ReadKey();
        }
    }
}
