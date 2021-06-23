using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 3 сотрудников
            Repository repository = new Repository(3);

            Console.ReadKey();
        }
       
    }
    
    
}
