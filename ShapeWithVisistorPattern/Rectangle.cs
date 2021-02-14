using System;

namespace ShapeWithVisistorPattern
{
    public class Rectangle : Figure//Часть 1
    {
        private double firstSide;
        private double secondSide;

        public double FirstSide 
        { 
            get=> firstSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    firstSide = value;
            }
        }
        public double SecondtSide
        {
            get => secondSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    secondSide = value;
            }
        }

        //Rectangle area
        public double RectangleArea { get => firstSide * secondSide; }
        //Rectangle perimeter
        public double RectanglePerimeter { get => (firstSide + secondSide) * 2; }

        public Rectangle(double first, double second)
        {
            FirstSide = first;
            SecondtSide = second;
        }

        public override double Visit(IVisitor visitor)
        {
            return visitor.Accept(this);
        }

        //Print the area and perimeter of the Rectangle
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Rectangle's Area is {RectangleArea} and Perimeter is {RectanglePerimeter}!!!");
        }
    }
}
