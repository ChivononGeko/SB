using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._3
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Узнаем у пользователя рамер матрицы
            Console.WriteLine("Введите количество строк матрицы");
            int n;

            //Проверка на число и его положительность
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
                else Console.WriteLine("Не корректные данные. Повторите ввод.");
            }
            Console.WriteLine("Введите количество столбцов матрицы");
            int m;
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out m) && m > 0) break;
                else Console.WriteLine("Не корректные данные. Повторите ввод.");
            }

            //Заполнаем матрицу, через соответствующий метод
            int[,] matrix = CreatMatrix(n, m);

            //Выводим ее
            Console.WriteLine("Наша матрица");
            Print(matrix);

            //Запращивает числа для умножения
            Console.WriteLine("Введите число для умножения");
            int k;
            for (;;)
            {
                if (int.TryParse(Console.ReadLine(), out k) && k>0) break;
                else Console.WriteLine("Не корректные данные. Повторите ввод.");
            }
            //Вызывем операцию
            Print(Multi(matrix, k, n, m));

            //Чтобы можно было наслаждаться результатом и не нагромаждать информацией консоль, для более легкого воспрития
            Console.ReadKey();
            Console.Clear();

            //Создаем вторую матрицу
            int[,] matrix1 = CreatMatrix(n, m);

            //Выводим нашу матрицу
            Console.WriteLine("Первая матрица");
            Print(matrix);

            //Выводим вторую матрицу
            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод вычитания
            Console.WriteLine($"Матрица после вычитания из другой матрицы:");
            Print(Sub(matrix, matrix1, n, m));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Первая матрица");
            Print(matrix);

            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод сложения
            Console.WriteLine($"Матрица после сложения с другой матрицой:");
            Print(Add(matrix, matrix1, n, m));

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Первая матрица");
            Print(matrix);

            Console.WriteLine("Введите количество строк матрицы");
            int n1;
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out n1) && n1 > 0) break;
                else Console.WriteLine("Не корректные данные. Повторите ввод.");
            }
            for (; ; )
            {
                if (m != n1)
                {
                    Console.WriteLine("Количество строк второй матрицы не равно количеству столбцов первой. Повторите ввод.");
                    for (; ; )
                    {
                        if (int.TryParse(Console.ReadLine(), out n1) && n1 > 0) break;
                        else Console.WriteLine("Не корректные данные. Повторите ввод.");
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Введите количество столбцов матрицы");
            int m1;
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out m1) && m1 > 0) break;
                else Console.WriteLine("Не корректные данные. Повторите ввод.");
            }
            matrix1 = CreatMatrix(n1, m1);
            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод умножения матрицы на матрицу
            Console.WriteLine($"Матрица после умножения на другую матрицу:");
            Print(MultiMat(matrix, matrix1,n,m1));
        }
        /// <summary>
        /// Операция заполнения матрицы
        /// </summary>
        public static int[,] CreatMatrix(int n,int m)
        {
            // Создаем экземпляр псевдорандома
            Random random = new Random();

            //Создаем место хранения для матрицы
            int[,] matrix = new int[n,m];

            //Заполняем нашу матрицу
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1,100);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Операция умножения числа на матрицу
        /// </summary>
        public static int[,] Multi(int[,] matrix, int k, int n, int m)
        {
            int[,] result = CreatMatrix(n,m);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j]= matrix[i, j] * k;
                }
            }
            return result;
        }
        /// <summary>
        /// Операция сложения двух матриц
        /// </summary>
        public static int[,] Add(int[,] matrix, int[,] matrix1, int n, int m)
        {
            int[,] result = CreatMatrix(n, m);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j]= matrix[i,j] + matrix1[i, j];
                }
            }
            return result;
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static int[,] Sub(int[,] matrix, int[,] matrix1, int n, int m)
        {
            int[,] result = CreatMatrix(n, m);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j]= matrix[i, j] - matrix1[i, j];
                }
            }
            return result;
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static int[,] MultiMat(int[,] matrix, int[,] matrix1, int n, int m1)
        {
            int[,] result = new int[n, m1];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        result[i, j] += matrix[i, k] * matrix1[k, j];
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Операция вывода матрицы в консоль
        /// </summary>
        public static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }
                Console.WriteLine();
            }
        }
    }
}
