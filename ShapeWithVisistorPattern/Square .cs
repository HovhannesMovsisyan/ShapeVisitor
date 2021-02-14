using System;

namespace ShapeWithVisistorPattern
{
    public class Square : Figure//Часть 3
    {
        private double side;

        public double Side
        {
            get => side;

            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    side = value;
            }
        }

        //Square area 
        public double SquareArea { get => side * side; }

        //Square perimeter
        public double SquarePerimeter { get => side * 4; }

        public Square(double side)
        {
            Side = side;
        }
        public override double Visit(IVisitor visitor)
        {
            return visitor.Accept(this);
        }

        //Print the area and perimeter of the Square
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Square's Area is {SquareArea} and Perimeter is {SquarePerimeter}!!!");
        }
    }
}
