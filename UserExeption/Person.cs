using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExeption
{
    internal class Person_12Plus
    {
        private int age;
        public string Name { get; set; } = "User" + DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.fff");
        public int Age
        {
            get { return age; } // get => age;
            set
            {
                if (value < 0) // throw new Exception("Некорректный возраст");
                {
                    throw new Exception("Некорректный возраст");
                }
                else
                {
                    if (value < 12)
                    {
                        throw new Exception("Возрастное ограничение 12+");
                    }
                    else age = value;
                }
            }
        }
    }
    internal class RetiredPeople
    {
        private int age;
        private bool sex;
        public string Name { get; set; } = "User" + DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.fff");
        public int Age
        {
            get { return age; } 
            set
            {
                if (value < 0 && sex == true) 
                {
                    throw new Exception("Некорректный возраст");
                }
                else
                {
                    if (value < 65 && sex == true)
                    {
                        throw new Exception("Пенсионный возраст мужчины 65 лет.");
                    }
                    else age = value;
                }
                if (value < 0 && sex == false)
                {
                    throw new Exception("Некорректный возраст");
                }
                else
                {
                    if (value < 60 && sex == false)
                    {
                        throw new Exception("Пенсионный возраст женщины 60 лет.");
                    }
                    else age = value;
                }
            }
               
        }
        public bool Sex
        {
            get { return sex; }
            set
            {
                if (value == true) 
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
            }
        }
    }
}
