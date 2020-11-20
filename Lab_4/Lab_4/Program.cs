using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv arr1 = new Massiv(5);
            for (int i = 0; i < arr1.Index; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }          
            Massiv arr2 = new Massiv(5);
            for (int i = 0; i < arr2.Index; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            arr1.Show();
            Console.WriteLine();
            arr2.Show();
            Console.WriteLine();

            Massiv arr3 = new Massiv(5);
            Console.WriteLine("--------- Перегрузка оператора - ---------");
            arr3 = arr1 - arr2;         //перегрузка -
            arr3.Show();
            Console.WriteLine();

            Massiv arr4 = new Massiv(20);
            Console.WriteLine("--------- Перегрузка оператора + ---------");
            arr4 = arr1 + arr2;         //перегрузка +
            arr4.Show();
            Console.WriteLine();

            int num, vhod;
            Console.WriteLine("--------- Перегрузка оператора > и != ---------");
            Console.WriteLine("Введите число");
            num = Convert.ToInt32(Console.ReadLine());
            vhod = arr1 > num;                  //перегрузка >
            if (vhod == 1)
                Console.WriteLine("число входит в arr1");
            else
                Console.WriteLine("число не входит в arr1");
            if (arr1 != arr2)                       //перегрузкаю !=
                Console.WriteLine(" Arr1 != Arr2");
            else
                Console.WriteLine("Arr1 == Arr2");

            Console.WriteLine("--------- Удаление гласных ---------");
            string str = "Персик";
            Console.WriteLine(str.DeleteVowel());

            Console.WriteLine("--------- Удаление первых 5 элементов ---------");
            Massiv arr5 = new Massiv(15);
            arr5 = arr4.FiveElem();
            arr5.Show();
            //Massiv arr5 = new Massiv(15);
            //Console.WriteLine("------------- Расширение Dif ----------------");
            //int r = Dif;
            //Console.WriteLine(r);

            //Console.WriteLine("------------- Количество элементов в массиве ----------------");
            //int c = arr5.Length();
            //Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
