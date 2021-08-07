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
            Console.WriteLine("Введите путь к файлу, с которого нужно считать данные...");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                int numbers = Check(File.ReadAllText(file));
                if (numbers != 0)
                { 
                    Console.WriteLine("Если Вы хотете увидеть только количество возможных групп, нажмите ENTER");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        int groups = (int)(Math.Log(numbers, 2) + 1);
                        Console.WriteLine($"Количество групп: {groups}");
                    }
                    else
                    {
                        if (Writer(numbers))
                        {
                            Console.WriteLine(DateTime.Now);
                            Console.WriteLine("Данные успешно записаны !");

                            Console.WriteLine("Если Вы хотите архивировать файл, нажмите ПРОБЕЛ. В проивном случае любую другую...");
                            if (Console.ReadKey().Key != ConsoleKey.Enter)
                            {
                                GZip(file);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Файл содержит не корректные данные. Пожалуйста исправтье файл или используйте другой файл.");
                }
            }
            else
            {
                Console.WriteLine("Данный файл не существует. Необходимо его созать.");
            }
           
        }
        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="numbers">Количество чисел</param>
        public static bool Writer(int numbers)
        {
            bool check = true;
            int groups = (int)(Math.Log(numbers, 2) + 1);
            Console.WriteLine($"Количество групп: {groups}");
            Console.WriteLine("Укажите файл в который нужно записать данные...");
            string file = Console.ReadLine();
            int k = 0;
            if (File.Exists(file))
            {
                using (StreamWriter sw = new StreamWriter(file))
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
            else
            {
                Console.WriteLine("Данный файл не существует. Необходимо его созать");
                check = false;
            }
            return check;
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
        public static int Check(string n)
        {
            if (int.TryParse(n, out int result) == false && result <= 0) result = 0;
            
            return result;
        }
    }
}