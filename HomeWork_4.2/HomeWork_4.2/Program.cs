using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество строк");
            int n = int.Parse(Console.ReadLine());

            //Создаем место для нашего массива в массивее
            int[][] paskal = new int[n][];

            //Запускаем счетчик, с количеством итераций равным числу массивов в массиве
            for (int i = 0; i < n; i++)
            {
                //Создаем массив, который нахожится в массиве)
                paskal[i] = new int[i + 1];

                //Счетчик, у которого количество итераций будет расти с итерацией внешнего
                for (int j = 0; j <= i; j++)
                {
                    paskal[i][j] = (int)(Factorial(i) / (Factorial(j) * Factorial(i - j)));
                }
            }
            Print(paskal,n);

        }
        /// <summary>
        /// Высчитываник факториала
        /// </summary>
        public static decimal Factorial(decimal n)
        {
            decimal factorial = 1;
            n++;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial / n;
        }
        public static void Print(int[][] paskal, int n)
        {
            int left = n;


            for (int i = 0; i < n; i++)
            {
                left--;

                //Система самма будет определять положение сверху
                int top = Console.CursorTop;

                //Задаем положение курсора
                Console.SetCursorPosition(left, top);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(paskal[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
   
}
