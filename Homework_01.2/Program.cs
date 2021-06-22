﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(40);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            
            // Увольняем всех сотрудников, указав минимально возможную зарпалту
            repository.DeleteWorkerBySalary(10000);

            // Печать в консоль сотрудников, которые не попали под увольнение(таких нет)
            repository.Print("База данных после преобразования");
                      
            //Чтобы не было пусто и грутсно, можно нанять новых 20 сотрудников)
             Repository repository1 = new Repository(30);
           
            //Печать в консоль наших новых сотрудников
            repository1.Print("База данных после преобразования");
           
            Console.ReadKey();
            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе должно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
