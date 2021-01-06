using System;

namespace Sem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Pen
        {
            public string color;
            public int cost;

            public Pen()
            {
                color = "Неизвестно";
                cost = 20;
            }

            public Pen(string n)
            {
                color = n;
                cost = 20;
            }
        }
        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle()
            {
                a = 6;
                b = 4;
            }

            public Rectangle(int side)
            {
                a = side;
                b = side;
            }

            public Rectangle(int first, int second)
            {
                a = first;
                b = second;
            }

            public int Square()
            {
                return a * b;
            }
        }

        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue)
                {
                    Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
                }
                else
                {
                    Console.WriteLine("Автобус пуст!");
                }
            }
        }

        class Car
        {
            public double Fuel;

            public int Mileage;

            public Car()
            {
                Fuel = 50;
                Mileage = 0;
            }

            public void Move()
            {
                // Move a kilometer
                Mileage++;
                Fuel -= 0.5;
            }

            public void FillTheCar()
            {
                Fuel = 50;
            }
        }
        /* class TrafficLight
          {
              private void ChangeColor(string color)
              {

              }

              public string GetColor()
              {

              }
          } */
    }
    class User
    {
        private string login;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть длиной от 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат адреса электронной почты");
                }
                else
                {
                    email = value;
                }
            }
        }
    }

    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0 && b + c > value)
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0 && a + c > value)
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value > 0 && a + b > value)
                {
                    c = value;
                }
            }
        }

    }

}
