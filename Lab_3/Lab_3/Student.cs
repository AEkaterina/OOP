using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class Student
    {
        //поля
        const int maxStudents = 50;         //поле константа
        public readonly int id;         //поле только для чтения
        static int numberOfStudent = 0;     //статическое поле с количеством объектов
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
                if (value < 290000000 && value > +450000000)
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
        public Student(string surname = "", string name = "", string fathername = "", string faculty = "", int course = 0, int group = 0, int date = 0, string adress = "", int telephone = 0)
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

        public Student(Student a) : this(a.Surname, a.Name, a.Fathername, a.Faculty, a.Course, a.Group, a.Date, a.Adress, a.Telephone)          //конструктор с параметрами
        {
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
        //метод для вывода информации
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Фамилия: " + Surname + "\nИмя: " + Name + "\nОтчество: " + Fathername);
            Console.WriteLine("Год рождения: " + Date + "\nАдрес: " + Adress + "\nТелефон: " + Telephone);
            Console.WriteLine("Факультет: " + Faculty + "\nКурс: " + Course + "\nГруппа: " + Group);
            Console.WriteLine("Униальный номер (ID)" + id);
        }
        //----------------------------------------

        public static void TypeOfClass()
        {
            Type tp = Type.GetType("Lab_3.Student");
            Console.WriteLine(tp.AssemblyQualifiedName);
        }
        public int Age(int date)
        {
            int age = 2020 - date;
            return age;
        }
    }
}
