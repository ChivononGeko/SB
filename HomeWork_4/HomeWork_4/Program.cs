using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр рандом
            Random random = new Random();

            //Пременная для хранения положителььных значений
            int positiveCount = 0;

            //Двумерный массив, где будут храниться финансовые данные
            int[,] finance = new int[12, 4];

            //Для понимания таблицы
            Console.WriteLine($"Месяц  Доход(тыс.руб.) Расход(тыс.руб.)  Прибль(тыс.руб.)");

            //Вложенный счетчик для заполнения массива
            for (int i = 0; i < finance.GetLength(0); i++)
            {
                for (int j = 0; j < finance.GetLength(1); j++)
                {
                    // Условие, при которых первый столбец заполнается порядковыми числами          
                    if (j == 0)
                    {
                        finance[i, j] = i + 1;
                        Console.Write($"{finance[i, j],5}");
                        //Пропуск итерации, так как дальше нам идти не надо
                        continue;
                    }
                    //Условие для четвртого столбца
                    if (j == 3)
                    {
                        // Подсчет разности доходов и расходов
                        finance[i, j] = finance[i, j - 2] - finance[i, j - 1];
                        Console.Write($"{finance[i, j],18}");

                        //Тут же поиск положительных значений
                        if (finance[i, j] > 0)
                        {
                            positiveCount++;
                        }
                        continue;
                    }
                    //Заполнение псевдослучайными числаи во 2 и 3 столбцы
                    finance[i, j] = random.Next(5);
                    Console.Write($"{finance[i, j],17}");
                }
                Console.WriteLine();
            }
            //Вывод количества положительных значений
            Console.WriteLine($"Количество месяцев с положительной прибылью: {positiveCount}");

            //Создаем отдельный массив, для данных прибыли
            int[] profit = new int[12];

            //Копируем из общего массива данных, в отдельный массив прибыли
            for (int i = 0; i < finance.GetLength(0); i++)
            {
                profit[i] = finance[i, 3];
            }
            //Сортируем массив прыбили
            Array.Sort(profit);

            //Переменная, отвечающая за количесвто итераций
            int n = 3;

            //Переменнная, в которой будет храниться количество месяцев с минимальной прибылью
            int count = 0;

            int[] profitMin = new int[12];
            int k = 0;

            //Выводим первые три значения, так каак они булут минимальными. Но в случае равенства, пропускаем вывод и увеличиваем количество итераций
            for (int i = 0; i < n; i++)
            {
                if (n<12)
                {
                    if (profit[i] != profit[i + 1])
                    {
                        profitMin[k] = profit[i];
                        count++;
                        k++;
                    }
                    else
                    {
                        count++;
                        n++;
                    }
                }
                else
                {
                    count=12;
                    Console.WriteLine($"Все месяцы являются минимальными и составялют: {profit[0]}");
                    break;
                }

            }
            if (count != 12)
            {
                Console.WriteLine("Три месяца с наименьшей прибылью: ");
                for (int i = 0; i < 3; i++)
                {                   
                        Console.WriteLine(profitMin[i]);                  
                }
            }
            Console.WriteLine("Количество месяцев с минимальной прибылью:" + count);
        }
    }
}