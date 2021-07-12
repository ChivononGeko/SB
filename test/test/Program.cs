using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public const int pos = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество строк");
            int n = int.Parse(Console.ReadLine());

            //Создаем место для нашего массива в массивее
            double[][] paskal = new double[n][];

            //Запускаем счетчик, с количеством итераций равным числу массивов в массиве
            for (int i = 0; i < n; i++)
            {
                //Создаем массив, который нахожится в массиве)
                paskal[i] = new double[i + 1];

                //Присваем первому элементу массива единицу, так как значение всегда будет таковым
                paskal[i][0] = 1;
                
                //Счетчик, у которого количество итераций будет расти с итерацией внешнего
                for (int j = 1; j < i; j++)
                {      
                    paskal[i][j] = paskal[i-1][j-1] + paskal[i-1][j];
                }
                //Так же, как и с первой ячейкой массива
                paskal[i][i] = 1;
            }
            Print(paskal, n);
                       
        }
        public static void Print(double[][] paskal, int n)
        {
            int left = n*pos;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //Задаем положение курсора
                    Console.SetCursorPosition(left, i+1);
                    Console.Write($"{paskal[i][j],pos}");
                    left += pos * 2;
                }
                left = pos * n - pos * (i+1);
                Console.WriteLine();
            }
        }
    }
}
