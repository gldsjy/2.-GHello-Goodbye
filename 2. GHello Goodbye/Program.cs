using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GHello_Goodbye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine(i);
                }
            } 
            Console.ReadKey();
        }
    }
}
