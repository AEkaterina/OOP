using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main()
        {
            Student a = new Student("Astapkina", "Ekaterina", "Vasilyevna", "FIT", 2, 4, 2000, "Minsk", 291534450);
            a.Age(a.Date);
            a.PrintInfo();
            Student.TypeOfClass();
            Student b = new Student("Volodina", "Angelina", "Pavlovna", "FIT", 2, 4, 2001, "Minsk", 29156529);
            b.Age(b.Date);
            b.PrintInfo();
            Student c = new Student(a);
            Console.WriteLine("Compare student");
            if (a.Equals(b))
                Console.WriteLine("Зпись 1 равна записи 2");
            else
                Console.WriteLine("Запись 1 и 2 не равны");
            if (a.Equals(c))
                Console.WriteLine("Зпись 1 равна записи 3");
            else
                Console.WriteLine("Запись 1 и 3 не равны");
            Console.WriteLine("------------------------------");
            //---------------------------
            Student[] arr = new Student[5];
            arr[0] = new Student(a);
            arr[1] = new Student(b);
            arr[2] = new Student("Aleksandrov", "Nikita", "Sergeevich", "FIT", 4, 1,1998,"Minsk", 296233647);
            arr[3] = new Student("Kachanova", "Anastasia", "Vasilyevna", "IEF", 3, 5, 2001, "Mogilev", 291278059);
            arr[4] = new Student("Kazakov", "Vladimir", "Nikolaevich", "IEF", 3, 5, 1999, "Mogilev", 296263546);

            string fac = "";
            Console.WriteLine("Введите факультет:");
            fac = Console.ReadLine();
            foreach(Student student in arr)
            {
                if(student.Faculty == fac)
                    student.PrintInfo();
            }

            int gr, cour;
            Console.WriteLine("Введите группу: ");
            gr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите курс: ");
            cour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите факультет: ");
            fac = Console.ReadLine();


            foreach (Student student1 in arr)
            {
                if(student1.Faculty == fac && student1.Group == gr && student1.Course == cour)
                    student1.PrintInfo();
            }
            //-------------------------
            Console.WriteLine("---------------------");
            var Anonim = new {Name = "Kate", Age = 22};
            Console.WriteLine(Anonim.Name + " " + Anonim.Age);

            Console.ReadLine();
        }
    }
}
