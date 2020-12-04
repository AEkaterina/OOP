﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Б Р У С Ь Я ------------");
            Playground brus = new Beams(10);
            brus.GetExp();
            brus.DoExercise();
            brus.DoExercise();
            brus.Relax(10);
            brus.GetExp();
            if (brus is Playground)
            {
                Console.WriteLine($"{brus} is Playground ");    //true
            }

            Console.WriteLine("\n\n--------- С К А М Е Й К А --------");
            Playground skam = new Bench();
            skam.DoExercise();
            skam.Relax(30);
            if (skam is Beams)
            {
                Console.WriteLine($"{skam} is Beams ");         //false
            }

            Console.WriteLine("\n\n--------- М А Т Ы -----------");
            Playground mat = new Mats();
            mat.DoExercise();
            mat.Relax(2);

            Console.WriteLine("\n\n---------- Б А С К Е Т Б О Л -----------");
            Basketball bask = new Basketball();
            IBasketBall bask_ball = bask;
            bask.Take_Invent();
            bask.DoExercise();
            bask.Play();
            bask.Throw();
            bask.Back_Invent();
            bask.GetExp();
            if (bask_ball as Beams != null)
            {
                Console.WriteLine($"{bask_ball} as Beams ");        //false
            }
            if (bask_ball as Playground != null)
            {
                Console.WriteLine($"{bask_ball} as Playground ");   //true
            }

            Console.WriteLine("\n\n---------- Т Е Н Н И С ----------");
            Tennis ten = new Tennis();
            ITennisBall ten_ball = ten;
            ten.DoExercise();           //а.к.
            ten_ball.DoExercise();      //интер.
            Console.ReadLine();
        }
    }
}
