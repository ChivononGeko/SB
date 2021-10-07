using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.txt";
            Repository rep = new Repository(path);

            Console.WriteLine("Здравствуйте ! Для демонстрации существующих  записей нажмите 'Enter', для добавления новой записи " +
                "нажмите 'Spacebar', для удаления записи нажмите 'Delete', для редактирования записи нажмите 'Backspace', для сортировки по определенному полю нажмите 'Q'," +
                " для вывода данных по диапозону дат введите 'W'...");
            rep.Load();
            do
            { 
            switch (Console.ReadKey().Key)
            {              
                case ConsoleKey.Enter:                  
                       rep.PrintToConsole();
                   break;
                case ConsoleKey.Spacebar:
                       rep.Add(rep.FIlling());
                       rep.UnLoad();
                       rep.PrintToConsole();
                   break;
                case ConsoleKey.Delete:
                        Console.WriteLine("Введите имя по которому вы хотите удалить запись...");
                        string label = Console.ReadLine();
                        rep.Remove(label);                       
                        rep.UnLoad();
                        rep.PrintToConsole();
                        break;
                case ConsoleKey.Backspace:
                        Console.WriteLine("Введите имя по которому вы хотите редактировать запись...");
                        label = Console.ReadLine();
                        rep.Edit(label);
                        rep.UnLoad();
                        rep.PrintToConsole();
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Введите номер,по какому полю нужно упорядочить:\n1)По имени\n2)По фамилии\n3)По возрасту");
                        string n = Console.ReadLine();
                        rep.Sort(n);
                        rep.PrintToConsole();
                   break;
                    case ConsoleKey.W:
                        Console.WriteLine("Введите начальную и конечную даты...");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        rep.PrintSort(a, b);
                        rep.PrintToConsole();
                        break;
                    default:
                    break;
            }
            } while (Console.ReadKey().Key != ConsoleKey.Tab);
        }
    }
}
