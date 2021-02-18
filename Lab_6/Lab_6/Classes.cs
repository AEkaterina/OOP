﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_5
{
    class Printer
    {
        public void iAmPrinting(Playground someobj)     //полиморфный
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }
    abstract class Playground
    {
        protected int Exp = 0;
        public override string ToString() => "Playground";
        public Playground() { }

        public int GetExp() => Exp;
        public abstract void DoExercise();
        public virtual void Relax(int hour)
        {
            Console.WriteLine($"Отдых {hour} минут");
        }
    }

    partial class Tennis : Playground, ITennisBall
    {
        public override string ToString() => "Теннис";

        //методы интерфейса
        public void Take_Invent() => Console.WriteLine("Вы взяли теннисный инвентарь");
        public void Back_Invent() => Console.WriteLine("Вы вернули теннисный инвентарь");
        public void Throw() => Console.WriteLine("Вы бросаете теннисный мяч");      //ball : inventary
        public void Play() => Console.WriteLine("Вы играете с теннисным мячом");    //tennisball : ball (new)

        //одноименные методы 
        public override void DoExercise() => Console.WriteLine("У вас теннисная тренировка (abstract)", Exp += 10);

        void ITennisBall.DoExercise() => Console.WriteLine("У вас теннисная тренировка (interface)", Exp += 10);

        //переопределение методов object (в 1 классе)
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            Tennis other = (Tennis)obj;
            return (Exp == other.Exp);
        }

        public override int GetHashCode()
        {
            return DateTime.Now.Millisecond;
        }
    }

    sealed class Basketball : Playground, IBasketBall
    {
        public override string ToString() => "Баскетбол";
        public void Take_Invent() => Console.WriteLine("Вы взяли баскетбольный инвентарь");
        public void Back_Invent() => Console.WriteLine("Вы вернули баскетбольный инвентарь");

        public void Throw() => Console.WriteLine("Вы бросаете баскетбольный мяч");

        public void Play() => Console.WriteLine("Вы играете с баскетбольным мячом");

        public override void DoExercise() => Console.WriteLine("У вас баскетбольная тренировка", Exp += 15);     ///а.к.
    }

    class Beams : Playground
    {
        private int Pullup;
        public override string ToString() => "Брусья";
        public Beams(int num)
        {
            Pullup = num;           //кол-во подтягиваний
        }
        public override void DoExercise()
        {
            Console.WriteLine("Вы тренируетесь на брусьях");
            Exp += Pullup / 10;
        }
    }

    sealed class Bench : Playground
    {
        public override string ToString() => "Скамейка";
        public override void DoExercise() => Console.WriteLine("Вы не можете тренироваться на скамейке");
    }

    class Mats : Playground
    {
        public override string ToString() => "Маты";
        public override void DoExercise() => Console.WriteLine("Вы тренируетесь на матах", Exp += 1);
    }
}
