using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 4;
            int p = s * 4;
            Console.WriteLine(p);

            int n = 123;

            int summ = n % 10;
            n /= 10;
            summ += n % 10;
            n /= 10;
            summ += n;
            Console.WriteLine("Сумма равна: {0}", summ);
            int y = 123;
            int o = 1;
            while (y > 0)
            {
                o *= y % 10;
                y /= 10;
            }
            Console.WriteLine("Произведение цифр = " + o);
         

            int a = 5;
            int b = 3;
            if (a > 2 & b <= 3)
            {
                Console.WriteLine(true);
            }

            Console.ReadKey();
        }
    }
}
