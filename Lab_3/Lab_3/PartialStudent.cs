using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class Student       //partial class
    {
        public override bool Equals(object obj)     //сравнение
        {
            if (obj == null)
                return false;
            Student stud = obj as Student;
            if (stud == null)
                return false;
            return this.Surname == stud.Surname && this.Name == stud.Name && this.Fathername == stud.Fathername
                && this.Date == stud.Date && this.Adress == stud.Adress && this.Telephone == stud.Telephone
                && this.Faculty == stud.Faculty && this.Course == stud.Course && this.Group == stud.Group;
        }

        public override int GetHashCode()           //расчет уникального номера
        {
            return (Telephone + Group) / 2;
        }

        public override string ToString()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Fathername} ";
        }
    }
}
