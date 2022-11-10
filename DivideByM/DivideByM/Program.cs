using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivideByM(99, 3);
            Console.ReadLine();
        }
        static int DivideByM(int n, int m)
        {
            int i;
            for (i = 0; i <= n; i++)
            {
                if (i % m == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return i;
        }
    }
}
