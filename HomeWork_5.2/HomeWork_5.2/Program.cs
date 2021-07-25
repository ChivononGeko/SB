using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для удобства я хотел разбирать одно и то же предложение
            Console.WriteLine("Введите предложение...");
            string a = Console.ReadLine();

            Console.WriteLine("Слова с минимальным кол-ом букв");
            Print(MinWord(a));

            Console.WriteLine("Слова с максимальным кол-ом букв");
            Print(MaxWord(a));
        }
        /// <summary>
        /// Метод для определения слов с минимальной длиной
        /// </summary>
        /// <param name="str">предложение полученное из консоли</param>
        /// <returns></returns>
        static string[] MinWord(string str)
        {
            char[] chars = { ' ', ',', '.', '-', '_' };
            string[] array = str.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            string help;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        help = array[i];
                        array[i] = array[j];
                        array[j] = help;
                    }
                }
            }
            string[] minstr = new string[array.Length];
            minstr[0] = array[0];
            for (int i = 1; i < minstr.Length; i++)
            {              
                if (minstr[0].Length!=array[i].Length)
                {
                    break;
                }
                else
                {
                    minstr[i] = array[i];
                }
            }
            return minstr;
        }
        /// <summary>
        /// Метод для определения слов с максимальной длиной
        /// </summary>
        /// <param name="str">предложение полученное из консоли</param>
        /// <returns></returns>
        static string[] MaxWord(string str)
        {
            char[] chars = { ' ', ',', '.', '-', '_' };
            string[] array = str.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            string help;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length < array[j].Length)
                    {
                        help = array[i];
                        array[i] = array[j];
                        array[j] = help;
                    }
                }
            }
            string[] minstr = new string[array.Length];
            minstr[0] = array[0];
            for (int i = 1; i < minstr.Length; i++)
            {
                if (minstr[0].Length != array[i].Length)
                {
                    break;
                }
                else
                {
                    minstr[i] = array[i];
                }
            }
            return minstr;
        }
        /// <summary>
        /// Метод для печати
        /// </summary>
        /// <param name="array"></param>
        public static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
