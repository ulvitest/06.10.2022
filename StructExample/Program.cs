using System;
using StructExample.Extention;

namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct

            //Shape shape = new Shape();
            //shape.x = 10;
            //shape.Y = 20;
            //shape.Area();


            //Shape s;
            //s.x = 10;
            //s.Area();
            #endregion

            Manat manat = new Manat(340);

            //Dollar dollar =manat;
            //Console.WriteLine(dollar.Usd);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);

            Person person1 = new Person
            {
                Name="Sabir",
                Age=25
            };

            Person person2 = new Person
            {
                Name = "Yuksel",
                Age = 26
            };
            // Console.WriteLine(person2==person1);
            string n = "Hellworld! world ,world";
            Console.WriteLine(n.WordFinder("world"));

        }
    }
    #region struct
    //interface ITest
    //{
    //    void Lorem();
    //}
    //struct Shape:ITest
    //{
    //    public int x;
    //    public int Y { get; set; }
    //    public Shape(int num,int num1)
    //    {
    //        x = num;
    //        Y = num1;
    //    }

    //    public int  Area()
    //    {
    //        return x + Y;
    //    }

    //    public void Lorem()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion

    class Manat
    {
        public double Azn { get; set; }
        public Manat()
        {

        }
        public Manat(double azn)
        {
            Azn = azn;
        }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7);
        //}
        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar()
        {

        }
        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
}
