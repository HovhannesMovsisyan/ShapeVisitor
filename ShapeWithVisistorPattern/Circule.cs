using System;

namespace ShapeWithVisistorPattern
{
    public class Circule : Figure//Часть 1
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    radius = value;
            }
        }
        //Circle area
        public double CircleArea { get => radius * radius * 3.14; }

        //Circle perimeter
        public double CirclePerimeter { get => radius * 2 * 3.14; }

        public Circule(double radius)
        {
            Radius = radius;
        }

        public override double Visit(IVisitor visitor)
        {
            return visitor.Accept(this);
        }

        //Print the area and perimeter of the Circle
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Circle's Area is {CircleArea} and Perimeter is {CirclePerimeter}!!!");
        }
    }
}
