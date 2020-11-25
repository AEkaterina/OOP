﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    static class StatisticOperations
    {
        public static int Max(this Massiv arr)
        {
            int max = arr[0];
            for(int i=0; i<arr.Index;i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
            //Array.Sort(arr);
            //return arr[arr.Length - 1];
        }

        public static int Min(this Massiv arr)
        {
            int min = arr[0];
            for(int i=0;i<arr.Index;i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
            //Array.Sort(arr);
            //return arr[0];
        }

        public static int Length(this Massiv arr) //количество
        {
            int count = 0;
            for(int i=0;i<arr.Index;i++)
                count++;
            return count;
            //return arr.Length;
        }

        public static int Dif(this Massiv arr)    //разница
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
            res = Regex.Replace(str, "[аеиоуэюыaeiou]?", "");
            return res;
        }

        public static Massiv FiveElem(this Massiv arr)  //удаление 5 элементов
        {
            for (int i = 0; i < arr.Index; i++)
            {
                arr[i] = arr[i + 1];
                if (i == 4)
                    continue;
            }
            return arr;
        }
    }
}