using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[n1,m1];
            int[,] matrix2 = new int[n2,m2];
            
            int k=1;
            for (int i = 0; i < matrix1.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLongLength(1); j++)
                {
                    matrix1[i, j] = k;
                    k++;
                    Console.Write($"{matrix1[i, j],3} ");
                }
                Console.WriteLine();
            }
            k = 1;
            for (int i = 0; i < matrix2.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLongLength(1); j++)
                {
                    matrix2[i, j] = k;
                    k++;
                    Console.Write($"{ matrix2[i, j],3}");
                }
                Console.WriteLine();
            }
            int[,] result = new int[n1, m2];
            for (int i = 0; i < result.GetLongLength(0); i++)
            {
                for (int j = 0; j <result.GetLongLength(1); j++)
                {
                    for (int l = 0; l < matrix1.GetLongLength(1); l++)
                    {                       
                        result[i, j] += matrix1[i, l] * matrix2[l, j];
                    }
                    Console.Write($"{result[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}
