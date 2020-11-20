using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    static class StatisticOperations
    {
        public static int Max(params int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 1];
        }

        public static int Min(params int[] arr)
        {
            Array.Sort(arr);
            return arr[0];
        }

        public static int Length(params int[] arr) //количество
        {
            return arr.Length;
        }

        public static int Dif(params int[] arr)    //разница
        {
            return Max(arr) - Min(arr);
        }

        public static int Sum(this Massiv arr) //сумма
        {
            int res = 0;
            for (int i = 0; i < arr.Index; i++)
            {
                res += arr[i];
            }
            return res;
        }

        public static String DeleteVowel(this String str)   //удаление гласных
        {
            string res = "";
            res = Regex.Replace(str, "аеиоуэюыaeiou", "");
            return res;
        }

        public static Massiv FiveElem(this Massiv arr)  //удаление 5 элементов
        {
            Massiv res = new Massiv(arr.Index - 5);
            for (int i = 0; i < arr.Index; i++)
            {
                res[i] = arr[i + 5];
            }
            return res;
        }
    }
}
