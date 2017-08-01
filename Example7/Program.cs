using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numnber to reverse");
            int n = int.Parse(Console.ReadLine());
            int d, r = 0;
            while (n > 0)
            {
                d = n % 10; 
                r = r * 10 + d; 
                n = n / 10;

            }
            Console.WriteLine("Reverse of a given number is {0}", r);
            Console.ReadKey();
        }
    }
}
