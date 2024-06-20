using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceDemo();
            AbstractClassesDemo();
            InterfaceDemo();
        }

        static void InheritanceDemo()
        {
            Console.WriteLine("Inheritance and Method Overriding Demo:");
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
            Console.WriteLine();
        }

        static void AbstractClassesDemo()
        {
            Console.WriteLine("Abstract Classes and Methods Demo:");
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area of circle: {circle.GetArea()}");
            Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}");
            Console.WriteLine();
        }

        static void InterfaceDemo()
        {
            Console.WriteLine("Interfaces Demo:");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
            Console.WriteLine();
        }
    }

    // Inheritance and Method Overriding
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Abstract Classes and Methods
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Interfaces
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
