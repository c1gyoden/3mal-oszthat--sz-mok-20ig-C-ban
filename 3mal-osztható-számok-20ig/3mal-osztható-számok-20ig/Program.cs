using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mal_osztható_számok_20ig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = -100; i < 21; i++)
            {
                if (i % 3 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
