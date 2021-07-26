using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество чисел в последовательности(не менее трех)...");
            int count = Check(Console.ReadLine());
            for (;;)
            {
                if (count < 3)
                {
                    Console.WriteLine("НЕ МЕНЕЕ ТРЕХ !!!");
                    count = Check(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            int[] nums = Creat(count);
            Print(ArifmProgress(nums), GeometrProgress(nums));
        }
        /// <summary>
        /// Метод для создания массива чисел
        /// </summary>
        /// <param name="n">Количество членов массива</param>
        /// <returns></returns>
        public static int[] Creat(int n)
        {
            Console.WriteLine("Введите числа...");
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Check(Console.ReadLine());
            }
            return nums;
        }
        /// <summary>
        /// Метод для проверки корректности данных
        /// </summary>
        /// <param name="n">Данные с консоли</param>
        /// <returns></returns>
        public static int Check(string n)
        {
            int result;
            for (; ; )
            {
                if (int.TryParse(n, out result) && result >= 0) break;
                else
                {
                    Console.WriteLine("Не корректные данные. Повторите ввод.");
                    n = Console.ReadLine();
                }
            }
            return result;
        }
        /// <summary>
        /// Метод для проверки на арифметическую прогрессию
        /// </summary>
        /// <param name="nums">Последовательность чисел</param>
        /// <returns></returns>
        public static bool ArifmProgress(int[] nums)
        {
            int d = nums[1] - nums[0];
            bool isArifm = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (isArifm)
                {
                    if (nums[i + 1] - nums[i] != d)
                    {
                        isArifm = false;
                    }
                }
            }
            return isArifm;
        }
        /// <summary>
        /// Метод проверки на геометрическую прогрессию
        /// </summary>
        /// <param name="nums">Последовательность чисел</param>
        /// <returns></returns>
        public static bool GeometrProgress(int[] nums)
        {
            bool isGeometr = true;
            if (nums[0] != 0)
            {
                int q = nums[1] / nums[0];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (isGeometr)
                    {
                        if (q * nums[i] != nums[i+1])
                        {
                            isGeometr = false;
                        }
                    }
                }
            }
            else
            {
                isGeometr = false;
            }
            return isGeometr;
        }
        /// <summary>
        /// Метод вывода ответа
        /// </summary>
        /// <param name="isArifm"></param>
        /// <param name="isGeometr"></param>
        public static void Print(bool isArifm,bool isGeometr)
        {
            if (isArifm && isGeometr)
            {
                Console.WriteLine("Числовая последовательность одновременно арифметическая и геометричиская прогрессия !!!");
            }
            else if (isArifm && isGeometr==false)
            {
                Console.WriteLine("Последовательность является арифметической прогрессией !!!");
            }
            else if (isArifm == false && isGeometr)
            {
                Console.WriteLine("Последовательность является геометрической прогрессией !!!");
            }
            else
            {
                Console.WriteLine("Последовательность не прогрессия !!!");
            }
        }
    }
}
