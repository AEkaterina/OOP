using System;
using System.Text;

//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.IO;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///*1a Определите переменные всех возможных примитивных типов С# и проинициализируйте их. 
            //Осуществите ввод и вывод их значений используя консоль.*/

            //bool bl = true;
            //byte bt = 250;
            //sbyte sb = 101;
            //char ch = 'g';
            //decimal dc = 2.1m;           
            //float fl = 46.3F;
            //Console.WriteLine("bool = {0}, byte = {1}, sbyte = {2}, char = {3}", bl, bt, sb, ch);
            //Console.WriteLine("decimal = {0}, float = {1}", dc, fl);
            //short sh = 354;
            //ushort ush = 60358;
            //uint ui = 3598;
            //long l = 58793;
            //ulong ul = 468931687621;
            //Console.WriteLine("short = {0}, ushort = {1} uint = {2}, long = {3}, ulong = {4}", sh, ush, ui, l, ul);
            //Console.Write("Input double: ");            
            //double dl = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input int: ");
            //int ii = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"double = {dl}, int = {ii} ");            

            ////1b Выполните 5 операций явного и 5 неявного приведения.

            ////неявное
            //int i = 135487;
            //long il = i;
            //short s = 533;
            //int si = s;
            //float f = 8.93F;
            //double fd = f;
            //int ifl = 697;
            //float fli = ifl;
            //long ll = 798451;
            //double ld = ll;

            ////явное
            //double dd = 896.16447;
            //int id = (int)dd;
            //float ff = 8.9F;
            //short sf = (short)ff;
            //double ddl = 648.568798;
            //long dll = (long)ddl;
            //float ffl = 89.34F;
            //int iifl = (int)ffl;
            //float fbyte = 78.45F;
            //byte bfl = (byte)(fbyte);

            ////1c Выполните упаковку и распаковку значимых типов. 
            //Object o = ii;      //упаковка
            //int x = (int)o;     //распаковка

            ////1d Продемонстрируйте работу с неявно типизированной переменной
            //var str = "Hello";
            //Console.WriteLine(str);

            ////1e Продемонстрируйте пример работы с Nullable переменной
            //Nullable<int> x1 = 65498;
            //Console.WriteLine(x1);



            ////2a Объявите строковые литералы. Сравните их.
            //string str1 = "cat";
            //string str2 = "kitten";
            //int comp = String.Compare(str1, str2);
            //if (comp == 0)
            //    Console.WriteLine("Строки {0} и {1} одинаковы", str1, str2);
            //else
            //    Console.WriteLine("строки {0} и {1} различны", str1, str2);

            ///*2b Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, 
            //  разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки. */
            //string s1 = "Astapkina ";
            //string s2 = "Ekaterina";
            //string s3 = "Hello and goodbye";
            //string s4;
            //Console.WriteLine(s1 + s2);    //сцепление 
            //s4 = s3;                        //копирование
            //Console.WriteLine($"Строка \"{s3}\" скопирована в строку s4");
            //Console.WriteLine("Выделение из строки слова " + s4.Substring(10));        //выделение подстроки
            //string[] words = s3.Split(' ');                 //разделение на слова
            //Console.WriteLine($"Разделим строку \"{s3}\" на слова:");
            //foreach (string s in words)
            //    Console.WriteLine(s);
            //string news1 = "Hello  and goodbye";                 //вставка подстроки
            //string news2 = news1.Insert(6, s2);
            //Console.WriteLine(news2);
            //Console.WriteLine($"Удаление подстроки в строке \"{news2}\": " + news2.Remove(15));         //удаление подстроки

            ///*2c Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty.Продемонстрируйте
            //что еще можно выполнить с такими строками*/
            //string emptstr = "";
            //string nullstr = null;
            //if (String.IsNullOrEmpty(emptstr))
            //    Console.WriteLine("Строка emptstr пустая или null");
            //else
            //    Console.WriteLine("Cтрока не null");

            //if (String.IsNullOrEmpty(nullstr))
            //    Console.WriteLine("Строка nullstr пустая или null");
            //else
            //    Console.WriteLine("Cтрока не null");

            ///*2dСоздайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало
            // и конец строки*/            
            //StringBuilder sb = new StringBuilder(" строка моя");
            //sb.Remove(8, 3);            ///удалите опр. позиции
            //sb.Insert(0, "Это");      ///добавить символы в начало
            //sb.Append("новая");       ///и конец строки
            //Console.WriteLine(sb);


            //3a Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица).
            int[,] arr = new int[3, 3] { { 5, 8, 3 }, { 7, 9, 16 }, { 49, 37, 2 } };
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");             
                }
                Console.WriteLine();
            }

            /*3b Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
             Поменяйте произвольный элемент (пользователь определяет позицию и значение)*/
            string[] arrstr = { "one", "two", "three", "four" };
            for(int i=0; i<4;i++)
                Console.Write(arrstr[i] + " ");

            Console.WriteLine("\nДлина массива = " + arrstr.Length);

            Console.Write("Ведите позицию элемента массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите новое значение: ");
            string newelem = Console.ReadLine();
            arrstr[a] = newelem;
            for (int i = 0; i < 4; i++)
                Console.Write(arrstr[i] + " ");
            Console.WriteLine();

            /*3c Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2,
             3 и 4 столбцов соответственно.Значения массива введите с консоли.*/
            int[][] ar = new int[3][];
            ar[0] = new int[2];
            ar[1] = new int[3];
            ar[2] = new int[4];
            Console.WriteLine("Введите значения массива:");
            for (int i = 0; i < 2; i++)                                     //ввод
                ar[0][i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; ++i)
                ar[1][i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; ++i)
                ar[2][i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)                                     //ввод
                Console.Write(ar[0][i] + "  ");
            Console.WriteLine();
            for (int i = 0; i < 3; ++i)
                Console.Write(ar[1][i] + "  ");
            Console.WriteLine();
            for (int i = 0; i < 4; ++i)
                Console.Write(ar[2][i] + "  ");
            Console.WriteLine();

            //3d Создайте неявно типизированные переменные для хранения массива и строки.
            var massiv = new int [] { 1, 89, 105 };
            var strstr = "Катя";
            Console.WriteLine("\n" + strstr);



        }
    }
}
