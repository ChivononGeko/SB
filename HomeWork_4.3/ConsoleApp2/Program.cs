using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр псевдорандома
            Random random = new Random();
            
            //Создаем место хранения для матрицы
            int[,] matrix = new int[5,5];
            Console.WriteLine("Матрица до преобразования");
            
            //Заполняем нашу матрицу
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Введите число для умножения");
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Матрица после умнажения на число:"); 
            
            //Вызывем операцию
            Multi(matrix, k);
            
            //Создаем место дял второй матрицы
            int[,] matrix1 = new int[5, 5];
            
            Console.WriteLine("Вторая матрица");
            
            //Заполняем ее
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(100);
                    Console.Write($"{matrix1[i, j],4}");
                }
                Console.WriteLine();
            }
            
            //Вызываем метод вычитания
            Console.WriteLine($"Матрица после вычитания из другой матрицы:");          
            Sub(matrix, matrix1);
            
            //Вызываем метод сложения
            Console.WriteLine($"Матрица после сложения с другой матрицой:");
            Add(matrix, matrix1);

            //Вызываем метод умножения матрицы на матрицу
            Console.WriteLine($"Матрица после умножения на другую матрицу:");
            MultiMat(matrix, matrix1);
        }
        /// <summary>
        /// Операция умножения числа на матрицу
        /// </summary>
        public static void Multi(int[,] matrix,int k)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= k;
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Операция сложения двух матриц
        /// </summary>
        public static void Add(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += matrix1[i, j];
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static void Sub(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] -= matrix1[i,j];
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Операция вычитания двух матриц
        /// </summary>
        public static void MultiMat(int[,] matrix, int[,] matrix1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= matrix1[j, i];
                    matrix[i, j] += matrix[i, j];
                    Console.Write($"{matrix[i, j],6}");
                }
                Console.WriteLine();
            }
        }
    }
}
