using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExeption
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var RP = new RetiredPeople();
            Console.WriteLine($"Создан пользователь {RP.Name} введите его имя:");
            
            RP.Name = Console.ReadLine();
            
            try
            {
                Console.WriteLine($"Задано имя пользователя {RP.Name} введите пол (true - мужской, false - женский):");
                RP.Sex = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine($"Введите возраст {RP.Name}: ") ;
                RP.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e002)
            {
                Console.WriteLine("Пользовательские ошибки {0}", e002.Message);
            }

        }
    }
}
