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
            Console.WriteLine("Введите размер матрицы");
            int n = int.Parse(Console.ReadLine());

            //Заполнаем матрицу, через соответствующий метод
            int[,] matrix = CreatMatrix(n);
            
            //Выводим ее
            Console.WriteLine("Наша матрица");
            Print(matrix);
            
            //Запращивает числа для умножения
            Console.WriteLine("Введите число для умножения");
            int k = int.Parse(Console.ReadLine());
           
            //Вызывем операцию
            Print(Multi(matrix, k));
            
            //Чтобы можно было наслаждаться результатом и не нагромаждать информацией консоль, для более легкого воспрития
            Console.ReadKey();
            Console.Clear();
            
            //Создаем вторую матрицу
            int[,] matrix1 = CreatMatrix(n);
            
            //Выводим нашу матрицу
            Console.WriteLine("Первая матрица");
            Print(matrix);
            
            //Выводим вторую матрицу
            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод вычитания
            Console.WriteLine($"Матрица после вычитания из другой матрицы:");
            Print(Sub(matrix, matrix1));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Первая матрица");
            Print(matrix);

            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод сложения
            Console.WriteLine($"Матрица после сложения с другой матрицой:");
            Print(Add(matrix, matrix1));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Первая матрица");
            Print(matrix);

            Console.WriteLine("Вторая матрица");
            Print(matrix1);

            //Вызываем метод умножения матрицы на матрицу
            Console.WriteLine($"Матрица после умножения на другую матрицу:");
            Print(MultiMat(matrix, matrix1));
        }
        /// <summary>
        /// Операция заполнения матрицы
        /// </summary>
        public static int[,] CreatMatrix(int n)
        {
            // Создаем экземпляр псевдорандома
            Random random = new Random();

            //Создаем место хранения для матрицы
            int[,] matrix = new int[n,n];

            //Заполняем нашу матрицу
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Операция умножения числа на матрицу
        /// </summary>
        public static int[,] Multi(int[,] matrix, int k)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= k;
                }
            }
            return matrix;
        }
        /// <summary>
        /// Операция сложения двух матриц
        /// </summary>
        public static int[,] Add(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += matrix1[i, j];
                }
            }
            return matrix;
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static int[,] Sub(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] -= matrix1[i, j];
                }
            }
            return matrix;
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static int[,] MultiMat(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= matrix1[j, i];
                    matrix[i, j] += matrix[i, j];
                }
            }
            return matrix;
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
