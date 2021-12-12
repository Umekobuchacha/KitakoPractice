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
            Exec1_12();
            Console.ReadKey();
        }

        private static void Exec1_12()
        {
            int x = 10;

            x++;
            Console.WriteLine(x);
            x--;
            x--;
            Console.WriteLine(x);
        }

        private static void Exec1_11()
        {
            int x = 13;

            Console.WriteLine("商={0}, 余り={1}", x / 5, x % 5);

        }

        private static void Exec1_10()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("x^2={0}", x * x);
            Console.WriteLine("x^3={0}", x * x * x);
            Console.WriteLine("x^4={0}", x * x * x * x);
        }

        private static void Exec1_9()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("2x={0}", 2 * x);
            Console.WriteLine("3x={0}", 3 * x);
            Console.WriteLine("4x={0}", 4 * x);

        }

        private static void Exec1_8()
        {
            int x = 19;
            int y = 23;
            int z = x * y;
            Console.WriteLine("z={0}", z);

        }

        private static void Exec1_7()
        {
            int x = 3;
            int y = 7;
            int tmp = y;
            y = x;
            x = tmp;
            Console.WriteLine("x={0},y={1}", x, y);

        }

        private static void Exec1_6()
        {
            int x = 7;
            x *= 3;
            Console.WriteLine("x={0}", x);
            x /= 2;
            Console.WriteLine("x={0}", x);

        }

        private static void Exec1_5()
        {
            Console.WriteLine(13 * 17);
        }

        private static void Exec1_4()
        {
            int x;
            x = 13 + 17;
            Console.WriteLine("x={0}", x);

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
