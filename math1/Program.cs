﻿using System;
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

            int j = 7;
            int t = 9;

            if (j == t)
            {
                j = 0;
                t = 0;
                Console.WriteLine($"{j}, {t}");
            }
            else
            {
                j = j + t;
                t = j + t;
                Console.WriteLine($"{j}, {t}");
            }

            string str = Console.ReadLine();
            int str1 = Int32.Parse( str );
            switch (str1)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.WriteLine("Введите l");
            string str2 = Console.ReadLine();
            int l = Int32.Parse( str2 );
            Console.WriteLine("Введите v");
            string str3 = Console.ReadLine();
            int v = Int32.Parse(str2);

            for (int  d = 0; d <= l; d++)
            {
                Console.WriteLine(v);
            }
            int N = Int32.Parse(Console.ReadLine());
            bool result = false;
            int K = 1;
            while (N >= Math.Pow(3, K))
            {
                if (N == Math.Pow(3, K))
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                    K++;
                }
            }
            Console.WriteLine(result);

            int i, _, sum = 0; 

            Console.Write("Input the 10 numbers : \n");  
            for (i = 1; i <= 10; i++)  
            {
                Console.Write("Number-{0} :", i);  

                _ = Convert.ToInt32(Console.ReadLine());  
                sum += _;  
            }

            Console.Write("The sum of 10 numbers is : {0}", sum);
            Console.ReadKey();
        }
    }
}
