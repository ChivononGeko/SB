using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(AntiCopi(Console.ReadLine()));
        }
        /// <summary>
        /// Метод, убирающий повторения букв
        /// </summary>
        /// <param name="str">Слово</param>
        /// <returns></returns>
        public static char[] AntiCopi(string str)
        {
            str= str.ToLower();
            char[] fword = str.ToCharArray();
            char[] tword = new char[fword.Length];
            tword[0] = fword[0];
            for (int i = 0; i < fword.Length-1; i++)
            {                
                    if (fword[i]!=fword[i+1])
                    {
                        tword[i] = fword[i+1];
                    }                
            }
            return tword;
        }
        /// <summary>
        /// Метод для вывода в консоль
        /// </summary>
        /// <param name="word">Слово</param>
        public static void Print(char[] word)
        {
            foreach (var item in word)
            {
                Console.Write(item);
            }
        }
    }
}
