using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02
{
    /// <summary>
    /// Класс, описывающий модель работника
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возраст работника
        /// </summary>
        public int Age { get; set; }
        
        /// <summary>
        /// Рост работника
        /// </summary>
        public int Height { get; set; }
      
        /// <summary>
        /// Балл по Русскому языку работника
        /// </summary>
        public int ScoreRusLang { get; set; }
      
        /// <summary>
        /// Балл по Истории работника
        /// </summary>
        public int ScoreHis { get; set; }
       
        /// <summary>
        /// Балл по Математике работника
        /// </summary>
        public int ScoreMath { get; set; }

        /// <summary>
        /// Средний балл работника
        /// </summary>
        public double AverageScore { get; set; }

        /// <summary>
        /// Конструктор, позволяющий присвоить значение соответствующим полям работника
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="ScoreRusLang">Балл по Русскому языку</param>
        /// <param name="ScoreHis">Балл по Истории</param>
        /// <param name="ScoreMath">Балл по Математике</param>
        public Worker(string Name, int Age, int Height, int ScoreRusLang, int ScoreHis, int ScoreMath)
        {
            this.Name = Name;                                                      // Сохранить переданное значение имени
            this.Age = Age;                                                        // Сохранить переданное значение возраста   
            this.Height = Height;                                                  // Сохранить переданное значение роста
            this.ScoreRusLang = ScoreRusLang;                                      // Сохранить переданное значение балла по Русскому язку
            this.ScoreHis = ScoreHis;                                              // Сохранить переданное значение былла по Истории
            this.ScoreMath = ScoreMath;                                            // Сохранить переданное значение былла по Математике
            this.AverageScore = (double)(ScoreRusLang + ScoreHis + ScoreMath) / 3; // Рассчитать и сохранить средний балл. 
            Console.Clear();                                                       // Очистить экран, чтобы следущий не увидел данные другого
        }
        /// <summary>
        /// Организация вывода информации о работнике
        /// </summary>
        /// <returns>Строковое представление информации</returns>
        public override string ToString()
        {
            //Инициализируем переменной, содержащая строку вывода. Методом интерполяции           
            string text = $"Имя:{this.Name}_Возраст:{this.Age}_Рост:{this.Height}_Русский язык:{this.ScoreRusLang}_" +
                $"История:{this.ScoreHis}_Математика:{this.ScoreMath}_Средний балл:{this.AverageScore.ToString("###.##")}";

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
            
            return null;
        }
    }
}