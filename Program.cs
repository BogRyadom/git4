using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static long Power(long x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                var p = Power(x, n / 2);
                return p * p;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }
    }
}
