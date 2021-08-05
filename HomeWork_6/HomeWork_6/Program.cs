using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace HomeWork_6.array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(File.ReadAllText(@"c:\data.txt"));
            Console.WriteLine("Если Вы хотете увидеть только количество возможных групп, нажмите ENTER");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int groups = (int)(Math.Log(numbers, 2) + 1);
                Console.WriteLine($"Количество групп: {groups}");
            }
            else
            {
               

                Writer(numbers);
                
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Данные успешно записаны !");

                Console.WriteLine("Если Вы хотите архивировать файл, нажмите ПРОБЕЛ. В проивном случае любую другую...");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    GZip(@"c:\data1.txt");
                }
            }
           
        }
        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="numbers">Количество чисел</param>
        public static void Writer(int numbers)
        {
            int groups = (int)(Math.Log(numbers, 2) + 1);
            Console.WriteLine($"Количество групп: {groups}");
            int k = 0;
            using (StreamWriter sw = new StreamWriter(@"c:\data1.txt"))
            {
                Console.WriteLine(DateTime.Now);
                for (int i = 1; i <= numbers; i++)
                {
                    if (k <= groups)
                    {
                        if (i % Math.Pow(2, k) == 0)
                        {
                            k++;
                            sw.WriteLine();
                            sw.Write(i + " ");
                        }
                        else
                        {
                            sw.Write(i + " ");
                        }
                    }
                    else
                    {
                        k = 0;
                    }
                }
            }
        }
        /// <summary>
        /// Архиватор
        /// </summary>
        /// <param name="name">Имя файла</param>
        public static void GZip(string name)
        {
            using (FileStream ss = new FileStream(name, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create("data1.zip"))
                {
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs);
                        Console.WriteLine($"Сжатие файла завершено. Было:{ss.Length} Стало:{ts.Length}");
                    }
                }
            }
        }
    }
}