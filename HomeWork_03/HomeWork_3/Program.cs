using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Создаем экземпляр класса Random, чтобы можно было в дальнейшем к нему обратиться
           Random random = new Random();

           // Обьявляем все нужные переменные
          string name=null;
           string name1=null;
           string name2=null;
           string name3=null;
           string name4=null;
           string name5 = null;
           int i = 0;
           int gameNumber = 0;
           int userTry = 0;

            // Вывод правил в консоль
            Console.WriteLine("Приветствую вас. Я хочу сыграть с вами в игру. Я загадаю число от 12 до 120.\nВаша задача" +
                             " по очереди вводить число от 1 до 4, пока загаданное мной число не станет 0.\nНа чей ход оно станет таковым " +
                             " - выиграет.\nЕсли вы введете число не входящее в заданный промежуток, вас накажут.\nМаксимум участников 5\n" +
                             "Удачи!!!\nДля запуска нажмите любую клавишу.");
            
           Console.ReadKey();

           Console.WriteLine("Какое количество игроков будет играть?");
           
            // Бесконечный цикл с поправочкой. Из него можно выйти только при соблюдении определнных правил
           for (; ; )
           {
              // Присваиваем количество игроков, введенных с клавиатуры
              i = int.Parse(Console.ReadLine());
              
              // В зависимости от количества, просим представиться игроко
              if (i > 1 && i < 6)
              {

                 Console.WriteLine("Игрок №1, представьтесь");
                 name1 = Console.ReadLine();

                 Console.WriteLine("Игрок №2, представьтесь");
                 name2 = Console.ReadLine();
                 if (i > 2)
                 {
                    Console.WriteLine("Игрок №3, представьтесь");
                    name3 = Console.ReadLine();
                    if (i > 3)
                    {
                       Console.WriteLine("Игрок №4, представьтесь");
                       name4 = Console.ReadLine();
                       if (i > 4 && i < 6)
                       {
                         Console.WriteLine("Игрок №5, представьтесь");
                         name5 = Console.ReadLine();
                         break;
                       }
                       else
                       {
                         break;
                       }
                    }
                    else
                    {
                      break;
                    }
                 }
                 else
                 {
                   break;
                 }
              }
              if (i==1)
              {
                Console.WriteLine("Твоим проивником будет компьютер");
                Console.WriteLine("Игрок, представьтесь");
                name1 = Console.ReadLine();
                break;
              }
              else
              {
                Console.WriteLine("Игроков слишком много");
              }
           }

           // Присваиваем нашей переменной псевдослучайное значение в заданном диапазоне
           gameNumber = random.Next(12, 121);
           
           //Еще один бесконечный цикл, с такой же поправкой
           for (; ; )
           {
              //Запускаем цикл for, где крайним значением является количество игроков
              for (int j = 0; j < i; j++)
              {
                 if (j == 0) name = name1;
                 if (j == 1) name = name2;
                 if (j == 2) name = name3;
                 if (j == 3) name = name4;
                 if (j == 4) name = name5;
                 

                 // Вывод текущего числа
                 Console.WriteLine($"Мое число: {gameNumber}");
                 
                 //Предупреждение
                 if (gameNumber < 4)
                 {
                   Console.WriteLine($"Предупреждение !!! Если вы введете число больше чем {gameNumber}, то ваш ход не засчитается " +
                                     $"и перейдет следующему");
                 }
                                                 
                 Console.WriteLine($"{name}, введите число");
                 
                 // Парсинг введенного пользователем числа
                 userTry = int.Parse(Console.ReadLine());
                
                 // Проверка, меньше ли число введенное пользователем,чем загаданное
                 if (gameNumber >= userTry)
                 {

                    // Проверка принадлежности числа к промежутку
                    if (userTry > 0 && userTry <= 4)
                    {
                      gameNumber -= userTry;

                       if (gameNumber == 0)
                       {
                         Console.WriteLine($"{name} победил !!!");

                         Console.WriteLine("Может реванш? Введите 'Да' или 'Нет'");

                         if (Console.ReadLine() == "Да")
                         {
                           gameNumber = random.Next(12, 121);
                           break;
                         }
                         else
                         {
                           break;
                         }
                       }
                    }
                    else
                    {
                       Console.WriteLine($"{name} пропускает ход !!!");
                    }

                 }
                 else
                 {
                    Console.WriteLine($"{name} пропускает ход !!!");
                 }
                 

              }

              // Условие, при котором, в игру вступает компьютер
              if (i == 1)
              {
                 Console.WriteLine($"Мое число: {gameNumber}");
                
                 // Предпоследний ход, который собственно и обдуман. Что скорее всего и позволит выйграть
                 if (gameNumber <= 8)
                 {

                    // Единственный момент, когда пользователь может победить
                    if (gameNumber != 5)
                    {
                       if (gameNumber < 5) userTry = gameNumber;
                       else userTry = gameNumber - 5;
                    }
                    else
                    {
                       userTry = 1;
                    }
                            
                 }
                 
                 // Что в основном будет делат компьютер
                 else
                 {
                     userTry = 4;
                 }

                 // Вывод числа компьютера
                 Console.WriteLine($"Компьютер: {userTry}");
                
                 gameNumber -= userTry;

                 // Отдельная проверка, на победу компьютера
                 if (gameNumber == 0)
                 {
                    Console.WriteLine("Компьютер победил");
                    
                    Console.WriteLine("Может реванш? Введите 'Да' или 'Нет'");

                    // Возможность реванша
                    if (Console.ReadLine() == "Да")
                    {
                       gameNumber = random.Next(12, 121);

                    }
                    else
                    {
                       break;
                    }
                 }

              }

           }
            
        }
    }
}
