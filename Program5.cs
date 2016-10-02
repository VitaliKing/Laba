using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 20, -1, 5, 8, 32, 2, -10, 2, 8 };
            int sum = 0;
            int max = 0; //индекс наибольшего числа
            for (int i = 0; i< n.Length; i++)
            {
                sum += n[i];
            }
            sum = sum / n.Length; //средзнач массива
            for (int i=0; i< n.Length; i++)
            {
                if (n[max]< n[i])
                {
                    max = i;
                }
            }
            for (int i=0; i< n.Length; i++)
            {
                if (i> max)
                {
                    n[i] = sum;
                }
                Console.Write(n[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
