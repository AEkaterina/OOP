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
            Student b = new Student("Volodina", "Angelina", "Pavlovna", "FIT", 1, 3, 2001, "Minsk", 29156529);
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
        }
    }
}
