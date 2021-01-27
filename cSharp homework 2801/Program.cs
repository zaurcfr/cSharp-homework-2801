using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_homework_2801
{

    //Task 1
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Show()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
        }

    }

    //Task 2
    class Counter
    {
        public Counter(int min, int max)
        {
            Min = min;
            Max = max;
            CurrentData = min;
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public int CurrentData { get; set; }

        public void increment()
        {
            if (CurrentData < Max)
            {
                CurrentData += 1;
            }
            else
            {
                CurrentData = Min;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Current Data: {CurrentData}");
        }
    }

    //Task 3
    class Fraction
    {
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public int FindGCD()
        {
            int x = Numerator;
            int y = Denominator;
            int m;

            if (x > y)
            {
                m = y;
            }
            else
            {
                m = x;
            }

            for (int i = m; i >= 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }

        public Fraction Sum(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * (b.Denominator / FindGCD()) + b.Numerator * (a.Denominator / FindGCD());
            int denominator = a.Denominator * (b.Denominator / FindGCD());
            return new Fraction(numerator, denominator);
        }
        public Fraction Subt(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * (b.Denominator / FindGCD()) - b.Numerator * (a.Denominator / FindGCD());
            int denominator = a.Denominator * (b.Denominator / FindGCD());
            return new Fraction(numerator, denominator);
        }
        public void Show()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }

    }

    //Task 4
    class Car
    {
        public Car(string model, string vendor, double volume, DateTime produceYear)
        {
            ID = CarID++;
            Model = model;
            Vendor = vendor;
            Volume = volume;
            ProduceYear = produceYear;
        }

        public int ID { get; set; }
        public double Volume { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public DateTime ProduceYear { get; set; }
        public static int CarID { get; set; } = default;

        public void Show()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Vendor: {Vendor}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Produce Year: {ProduceYear.Year}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine();
        }
        public double GetAge()
        {
            DateTime dateTime = DateTime.Now;
            var age = dateTime.Year - ProduceYear.Year;
            return (int)age;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            //Point p = new Point(10, 15);
            //p.Show();

            //Task 2
            //Counter c = new Counter(5, 10);
            //c.Show();
            //c.increment();
            //c.Show();

            //Task 3
            //Fraction f1 = new Fraction(1, 5);
            //Fraction f2 = new Fraction(1, 4);
            //f1.Show();

            //Task 4
            //var ProduceDate1 = new DateTime(2018, 10, 10);
            //Car car1 = new Car("Camaro", "Chevrolet", 4.3, ProduceDate1);
            //car1.Show();

            //var ProduceDate2 = new DateTime(2015, 01, 01);
            //Car car2 = new Car("M5", "BMW", 3.6, ProduceDate2);
            //car2.Show();
        }
    }
}
