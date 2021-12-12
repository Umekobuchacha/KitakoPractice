using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitakoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Exec1_3();
            Console.ReadKey();
        }

        private static void Exec1_3()
        {
            var x = 13;
            var y = 17;
            Console.WriteLine("x={0},y={1}", x, y);

        }

        private static void Exec1_2()
        {
            var x = 11;
            Console.WriteLine("x={0}", x);
        }

        private static void Exec1_1()
        {
            Console.WriteLine("Hello World");
        }
    }
}
