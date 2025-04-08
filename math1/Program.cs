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
            int a = 4;
            int p = a * 4;
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
            Console.ReadKey();
        }
    }
}
