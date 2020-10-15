using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        //поля
        const int maxStudents = 50;         //поле константа
        public readonly int id;         //поле только для чтения
        static int numberOfStudent = 0;
        public int Date;            //только год
        public string Adress;
        public string Faculty;
        public int Course;
        public int Group;

        //----------------------------------
        //свойства
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }

        private int telephone;          //формат 29ххххххх 291534450
        public int Telephone            //свойство с ограничением доступа по set
        {
            get
            {
                return telephone;
            }
            set
            {
                if(value<290000000 && value >+450000000)
                {
                    Console.WriteLine("Неправильно введен телефон");
                }
                else
                {
                    telephone = value;
                }
            }
        }
        //---------------------------------------------
        //конструктор с параметрами по умолчанию
        public Student(string surname="", string name="", string fathername="", string faculty="", int course=0, int group=0, int date=0, string adress="", int telephone=0)
        {
            numberOfStudent++;
            Surname = surname;
            Name = name;
            Fathername = fathername;
            Faculty = faculty;
            Course = course;
            Group = group;
            Date = date;
            Adress = adress;
            Telephone = telephone;
            id = this.GetHashCode();
        }
        
        public Student(Student a)           //конструктор с параметрами
        {
            numberOfStudent++;
            Name = a.Name;
            Surname = a.Surname;
            Fathername = a.Fathername;
            Faculty = a.Faculty;
            Course = a.Course;
            Group = a.Group;
            Date = a.Date;
            Adress = a.Adress;
            Telephone = a.Telephone;
            id = this.GetHashCode();
        }

        static Student()            //конструктор без параметров, статический
        {
            Console.WriteLine("Новая запись");
        }

        private Student()           //конструктор закрытый
        {
            numberOfStudent++;
            Console.WriteLine("Будущая запись");
        }
        //----------------------------------

        public int Age(int date)
        {
            int age = 2020 - date;
            return age;
        }

        public override int GetHashCode()           //расчет уникального номера
        {
            return (Telephone+Group) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
