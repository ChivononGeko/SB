using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько цифр?");
            int n = int.Parse(Console.ReadLine());
            int k = (int)(Math.Log(n, 2) + 1);

            int cnst = Console.CursorTop+1;
            int top = cnst;
            Console.WriteLine($"Количество групп: {k} ");
            Console.WriteLine(1);
            for (int i = 2; i <= n; i++)
            {
                int left = Console.CursorLeft;
                Console.SetCursorPosition(left, top);
            
                top++;
                if (i % (i - 1) == 0)
                {
                    top++;
                    Console.SetCursorPosition(left, top);
                    Console.Write($" {i}");
                }
                else
                {
                    Console.Write($" {i}");
                }
                if (top == cnst+k)
                {
                    top = cnst;
                }
                
            }
        }
    }
}
