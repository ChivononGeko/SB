using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02
{
    /// <summary>
    /// Класс, осуществляющий проверку на корректность введенных данных
    /// </summary>
    class Check
    {
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
        int weight;

        /// <summary>
        /// Вспомогательная переменная для балла работника
        /// </summary>
        int score;

        /// <summary>
        /// Метод для проверки корректности имени
        /// </summary>
        /// <param name="name">Имя</param>
        public string Name(string name)
        {
            // Проверка на возмонсть конвертации string в int (мало ли, вдруг есть особоодаренные). В случае true метод запустится снова 
            // В случае false строка присвоится к вспомогательной переменной имени
            if (int.TryParse(name, out int result))
            {
                Console.WriteLine("Сомневаюсь, что данная последовательность цифр является вашим именем. Пожалуйста, введите корректное имя.");
                Name(Console.ReadLine());
            }
            else
            {
                this.name = name;
            }

            // Возврат корректной переменной
            return this.name;
        }

        /// <summary>
        /// Метод для проверки корректности возраста
        /// </summary>
        /// <param name="age">Возраст</param>
        public int Age(string age)
        {
            // Проверка на возможность ковертации string в int. В случае результата true проверка пойдет на следующий этап.
            // В случае false Метод запустится снова
            if (int.TryParse(age, out int result))
            {
                // Проверка числа о принадлежности к диапозону возможного возраста(Быть может компания примет и 100-летних. Надо уточнить). 
                // В случае true Метод запустится снова.
                // В случае false переменная присвоится к вспомогательной переменной возраста.
                if (result > 100 || result < 0)
                {
                    Console.WriteLine("Вы ввели не корректный возраст. Пожалуйста, повторите ввод");
                    Age(Console.ReadLine());
                }
                else
                {
                    this.age = result;
                }

            }
            else
            {
                Console.WriteLine("Вы ввели не корректный возраст. Пожалуйста, повторите ввод");
                Age(Console.ReadLine());
            }

            // Возврат корректной переменной
            return this.age;

        }

        /// <summary>
        /// Метод для проверки корректности роста
        /// </summary>
        /// <param name="weight">Рост</param>
        public int Weight(string weight)
        {
            // Проверка на возможность ковертации string в int. В случае результата true проверка пойдет на следующий этап.
            // В случае false Метод запустится снова
            if (int.TryParse(weight, out int result))
            {
                // Проверка числа на положительность. Так как максимально возможный рост мне не известен. В случае true Метод запустится снова.
                // В случае false переменная присвоится к вспомогательной переменной роста.
                if (result < 0)
                {
                    Console.WriteLine("Вы ввели не корректный рост. Пожалуйста, повторите ввод");
                    Weight(Console.ReadLine());
                }
                else
                {
                    this.weight = result;
                }

            }
            else
            {
                Console.WriteLine("Вы ввели не корректный рост. Пожалуйста, повторите ввод");
                Weight(Console.ReadLine());
            }

            // Возврат корректной переменной
            return this.weight;

        }

        /// <summary>
        /// Метод для проверки корректности балла
        /// </summary>
        /// <param name="score">Балл</param>
        public int Score(string score)
        {
            // Проверка на возможность ковертации string в int. В случае результата true проверка пойдет на следующий этап.
            // В случае false Метод запустится снова
            if (int.TryParse(score, out int result))
            {
                // Проверка числа о принадлежности к диапозону возможных баллов. В случае true Метод запустится снова.
                // В случае false переменная присвоится к вспомогательной переменной балла.
                if (result > 300 || result < 0)
                {
                    Console.WriteLine("Вы ввели не корректный балл. Пожалуйста, повторите ввод");
                    Score(Console.ReadLine());
                }
                else
                {
                    this.score = result;
                }

            }
            else
            {
                Console.WriteLine("Вы ввели не корректный балл. Пожалуйста, повторите ввод");
                Score(Console.ReadLine());
            }

            // Возврат корректной переменной
            return this.score;
        }
    }
}
