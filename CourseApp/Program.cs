﻿using System;
namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            double[] z = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };
            Console.WriteLine("Задание А");
            for (double x = 0.08; x <= 1.08; x = x + 0.2)
            {
                Console.WriteLine(Formula(x));
            }

            Console.WriteLine();
            Console.WriteLine("Задание Б");
            int i = -1;
            foreach (int x in z)
            {
                i += 1;
                Console.WriteLine(Formula(x));
            }

            double Formula(double x)
            {
                double a = 2.0;
                double b = 1.1;
                double y = Math.Log(Math.Abs(Math.Pow(b, a) - Math.Pow(x, 2))) / Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2)), 0.2);
                return y;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
