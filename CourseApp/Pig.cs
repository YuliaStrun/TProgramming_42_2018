﻿using System;

namespace CourseApp
{
    public class Pig : Animal, ICut, IComparable
    {
        private int age;

        public Pig()
            : base()
        {
            Age = 20;
            Salo = Ves;
        }

        public Pig(string pol)
        {
            Pol = pol;
            if (Pol == "F")
            {
                Age = 15;
                Salo = 45.0f;
            }
            else
            {
                Age = 20;
                Salo = 70.0f;
            }
        }

        public Pig(float salo)
        {
            Salo = salo;
            if (Salo <= 70.0f && Salo > 45.0f)
            {
                Pol = "M";
                Age = 20;
            }

            if (Salo <= 45.0f && Salo >= 30.0f)
            {
                Pol = "F";
                Age = 15;
            }

            if (Salo < 30.0f || Salo > 70.0f)
            {
                Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон[30.0f;70.0f]");
                throw new Exception();
            }
        }

        public Pig(int age)
        {
            Age = age;
            if (Age > 15 && Age <= 20)
            {
                Pol = "M";
                Salo = 65.0f;
            }

            if (Age <= 15 && Age > 1)
            {
                Pol = "F";
                Salo = 45.0f;
            }
        }

        public float Salo { get; set; }

        public override int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 1 || value > 20)
                {
                    Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон[1;20]");
                    throw new Exception();
                }
                else
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"it's a Pig of the age of {Age} and weighing {Salo}";
        }

        public string Cut()
        {
            return "a pig slaughtered";
        }

        public int CompareTo(object o)
        {
            Pig p = o as Pig;
            if (p != null)
            {
                return this.Age.CompareTo(p.Age);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }

        public override void Info()
        {
            Console.WriteLine($"Пол: {Pol}  Возраст: {Age}  Масса сало: {Salo}");
            Console.WriteLine(Graz());
            Console.WriteLine(Voice());
            Console.WriteLine(Ris());
            Console.WriteLine(Cut());
        }

        public string Graz()
        {
            return $"pig age {Age} went to lie in the mud ";
        }

        public override string Ris()
        {
            return @"     _
         <`--'\>______
         /. .  `'     \
        (`')  ,        @
         `-._,        /
            )-)_/--( >  
           ''''  ''''";
        }

        public override string Voice()
        {
            return $"свинья пола {Pol} издала звук хрю хрю";
        }
    }
}
