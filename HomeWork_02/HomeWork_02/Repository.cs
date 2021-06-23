using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02
{
    /// <summary>
    /// Организация хранения и инициализации данных
    /// </summary>
    class Repository
    {
        /// <summary>
        /// База данных работников, в которой хранятся 
        /// Имя, возраст, рост и баллы по предметам ЕГЭ
        /// </summary>
        Check check = new Check();


        /// <summary>
        /// Вспомогательная переменная для имени работника
        /// </summary>
        string name;

        /// <summary>
        /// Вспомогательная переменная для возраста работника
        /// </summary>
        int age;

        /// <summary>
        /// Вспомогательная переменная для роста работника
        /// </summary>
        int height;


        /// <summary>
        /// Вспомогательная переменная для балла по Русскому языку работника
        /// </summary>
        int scoreRusLang;


        /// <summary>
        /// Вспомогательная переменная для балла по Истории работника
        /// </summary>
        int scoreHis;


        /// <summary>
        /// Вспомогательная переменная для балла по Математике работника
        /// </summary>
        int scoreMath;

        /// <summary>
        /// База данных работников, в которой хранятся 
        /// Имя, возраст, рост и баллы каждого сотрудника
        /// </summary>
        public List<Worker> Workers { get; set; }

        /// <summary>
        /// Конструктор, заполняющий базу данных Workers
        /// </summary>
        /// <param name="Count">Количество сотрудников, которых нужно создать</param>
        public Repository(int Count)
        {
            this.Workers = new List<Worker>(); // Выделение памяти для хранения базы данных Workers

            for (int i = 0; i < Count; i++)    // Заполнение базы данных Workers. Выполняется Count раз
            {
                Console.WriteLine("Введите ваше имя");                        // 
                this.name = check.Name(Console.ReadLine());

                Console.WriteLine("Введите ваш возраст"); 
                this.age = check.Age(Console.ReadLine());

                Console.WriteLine("Введите ваш рост"); 
                this.height = check.Weight(Console.ReadLine());

                Console.WriteLine("Введите ваш балл по Русскому языку"); 
                this.scoreRusLang = check.Score(Console.ReadLine());

                Console.WriteLine("Введите ваш балл по Истории"); 
                this.scoreHis = check.Score(Console.ReadLine());

                Console.WriteLine("Введите ваш балл по Математике"); 
                this.scoreMath = check.Score(Console.ReadLine());

                // Добавляем нового работника в базы данных Workers
                this.Workers.Add(new Worker(this.name,this.age,this.height,this.scoreRusLang,this.scoreHis,this.scoreMath));
            }
            foreach(Worker worker in this.Workers) //
            {                                      //                              
                Console.WriteLine(worker);         // Печатаем всех сотрудников в консоль
                Console.ReadKey();                 // Создаем задержку до нажатия любой клавиши
                Console.Clear();                   // Очищаем экран. Потому что я не знаю, как вывести всех сотрдников по центру разом :(
            }
        }
    }
}
