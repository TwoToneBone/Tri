using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if (a / b == c)
            {
                Console.WriteLine($"{a}/{b}={c}");
            }
            else if (a * b == c)
            {
                Console.WriteLine($"{a}*{b}={c}");
            }
            else if (a - b == c)
            {
                Console.WriteLine($"{a}-{b}={c}");
            }
            else if (a + b == c)
            {
                Console.WriteLine($"{a}+{b}={c}");
            }
            else if (a == b / c)
            {
                Console.WriteLine($"{a}={b}/{c}");
            }
            else if (a == b * c)
            {
                Console.WriteLine($"{a}={b}*{c}");
            }
            else if (a == b - c)
            {
                Console.WriteLine($"{a}={b}-{c}");
            }
            else if (a == b + c)
            {
                Console.WriteLine($"{a}={b}+{c}");
            }

        }
    }
}
