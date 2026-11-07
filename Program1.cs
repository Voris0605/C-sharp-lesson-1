using System;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld{
    class Program1{
        static void Main(){
            double sum = 1;

            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            System.Console.WriteLine("Summ: " + sum);
        }
    }
}