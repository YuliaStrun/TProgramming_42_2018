using System;

namespace CourseApp
{
    public class Rifles : Gun, IShoot
    {
        public Rifles()
        {
            Name = "M16";
            Kalibr = 5.56;
            Mass = 2.4f;
            Emkostmag = 30;
        }

        public Rifles(string name, double kalibr, float mass )
            : base(name, kalibr, mass)
        {
            Emkostmag = 30;
        }

        public string Shoot(object o)
        {
            Rifles c = o as Rifles;
            return $" Я выстрелил из винтовки {c.Name} ";
}

        public override string ToString()
        {
            return $"Наименование: {Name}  калибр: {Kalibr} масса: {Mass} емкость магазина: {Emkostmag}\n Винтовка {Name} Выстрелила: \"Бах!\"";
        }

        public override void GetInfo()
        {
            Console.WriteLine(ToString());
            Console.WriteLine(Display());
        }

        public override string Display()
        {
            return @"

                           ______
        |\_______________ (_____\\______________
HH======#H###############H######################
        ' ~""""""""""""""`##(_))#H\""""Y########
                          ))    \#H\        Y###
                                 }#H)


";
        }
    }
}
