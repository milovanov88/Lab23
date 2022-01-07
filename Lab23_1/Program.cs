using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №23");
            Console.WriteLine("Задайте число для нахождения факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            actorialAsync(n+1);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadLine();
        }
        static void factorial(int n)
        {
            int s = 1;
                for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }
        static async void actorialAsync(int n)
        {
            await Task.Run(() => factorial(n));
        }
    }
}
