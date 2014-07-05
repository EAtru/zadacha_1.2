using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double d;
            double x1, x2;
            
            Console.Write("Введите коэффициент а:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c:");
            c = Convert.ToDouble(Console.ReadLine());
            
            d = Math.Pow(b, 2) - 4 * a * c;

            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Первый корень уравнения = {0}", x1);
                Console.WriteLine("Второй корень уравнения = {0}", x2);
                
            }
            else
            Console.WriteLine("Действительных корней нет");

            Console.ReadKey();

        }
    }
}
