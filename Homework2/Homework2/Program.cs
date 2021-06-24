using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");                                        //  Вывод на экран сообщения          
            string name1 = Console.ReadLine();                                            // Обьявление и сразу пприясвоение значения пременной

            Console.WriteLine("Введите ваш возраст");
            int age1 = int.Parse(Console.ReadLine());                                     // Так же, как и в первом случае, только плюс парсинг

            Console.WriteLine("Введите ваш рост");
            int height1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Русскому языку");
            int scoreRusLang1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Истории");
            int scoreHis1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Математике");
            int scoreMath1 = int.Parse(Console.ReadLine());

            double averagescore1 = (double)(scoreRusLang1 + scoreHis1 + scoreMath1) / 3;     // Обьявление и подсчет среднего балла

            Console.WriteLine("Имя: "+name1+" Возраст: "+age1+" Рост: "+height1+" Балл по Русскому языку: "+scoreRusLang1+  //Вывод данных в консоль
                " Балл по Истории: "+scoreHis1+" Балл по Математике: "+scoreMath1);                                         // методом прямого вывода

            Console.ReadKey();                
            Console.Clear();           // Очищаем консоль, чтобы следующий сотрудник не увидел чужие данные


            Console.WriteLine("Введите ваше имя");          // Аналогичные действия, как и с первым сотрудников
            string name2 = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            int age2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост");
            int height2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Русскому языку");
            int scoreRusLang2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Истории");
            int scoreHis2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Математике");
            int scoreMath2 = int.Parse(Console.ReadLine());

            double averagescore2 = (double)(scoreRusLang2 + scoreHis2 + scoreMath2) / 3;

            Console.WriteLine("Имя:{0}\nВозраст:{1}\nРост:{2}\nРусский язык:{3}\nИстория:{4}\nМатематика:{5}\nСредний балл:{6}" //Вывод данных в консоль
               , name2,age2,height2,scoreRusLang2,scoreHis2,scoreMath2,averagescore2);                                    //методом форматирования

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Введите ваше имя");       //Аналогичные действия, как и в первом и втором случиях
            string name3 = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            int age3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост");
            int height3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Русскому языку");
            int scoreRusLang3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Истории");
            int scoreHis3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш балл по Математике");
            int scoreMath3 = int.Parse(Console.ReadLine());

            double averagescore3 = (double)(scoreRusLang3 + scoreHis3 + scoreMath3) / 3;

            Console.WriteLine($"Имя:{name3}\nВозраст:{age3}\nРост:{height3}\nРусский язык:{scoreRusLang3}\n" +       //Вывод данных в консоль методом
                $"История:{scoreHis3}\nМатематика:{scoreMath3}\nСредний балл:{averagescore3.ToString("###.##")}"); //интерполяции строк

            Console.ReadKey();

            //Выводим данные по центру консоли
            Console.Clear();

            string text = $"Имя:{name3}_Возраст:{age3}_Рост:{height3}_Русский язык:{scoreRusLang3}_" +            
                $"История:{scoreHis3}_Математика:{scoreMath3}_Средний балл:{averagescore3.ToString("###.##")}";  

            //Разбиваем текст на массив строк, с разделяющим знаком "_"
            string[] lines = text.Split('_');

            //Определяем отступ сверху для первой строки
            int top = (Console.WindowHeight / 2) - (lines.Length / 2) - 1;

            //Отступ слева будет определяться для каждой строки отдельно
            int left = 0;

            //Находим центр консоли сразу, чтобы не грузить приложение лишними вычислениями
            int center = Console.WindowWidth / 2;

            for (int i = 0; i < lines.Length; i++)
            {
                //Определяем отступ для текущей строки
                left = center - (lines[i].Length / 2);

                //Меняем положение курсора
                Console.SetCursorPosition(left, top);
                //Выводим строку
                Console.WriteLine(lines[i]);

                //Для каждой новой строки программа будет автоматически считать отступ сверху
                top = Console.CursorTop;               
            }
            Console.ReadKey();
        }
    }
}
