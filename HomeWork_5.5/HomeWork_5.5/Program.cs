using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._5
{
    class Program
    {
        public static int count=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение для функции..."); 
            int m = Check(Console.ReadLine());
            
            Console.WriteLine("Введите второе значение для функции..."); 
            int n = Check(Console.ReadLine());

            Console.WriteLine($"Значение функции Аккермана при таких аргументах: {Akkerman(m,n)}");
            Console.WriteLine($"Значение рекурсии: {count}");
        }
        public static int Check(string n)
        {
            int result;
            for (; ; )
            {
                if (int.TryParse(n, out result) && result > 0) break;
                else
                {
                    Console.WriteLine("Не корректные данные. Повторите ввод.");
                    n = Console.ReadLine();
                }
            }
            return result;
        }
        public static int Akkerman(int m,int n)
        {
            count++;
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
