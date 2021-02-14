using System;

namespace ShapeWithVisistorPattern
{
    public class Triangle: Figure//Часть 3
    {
        private double firstSide;
        private double secondSide;
        private double baseSide;
        private double height;

        public double FirstSide
        {
            get => firstSide;

            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    firstSide = value;
            }
        }
        public double SecondSide
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
        public double BaseSide
        {
            get => baseSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    baseSide = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    height = value;
            }
        }

        //Triangle area
        public double TriangleArea { get => (baseSide * height) / 2; }
        //Triangle perimeter
        public double TrianglePerimeter { get => firstSide + secondSide + baseSide; }

        public Triangle(double firstside, double secondside, double baseside, double height)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            BaseSide = baseside;
            Height = height;
        }

        public override double Visit(IVisitor visitor)
        {
            return visitor.Accept(this);
        }

        //Print the area and perimeter of the Triangle
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Triangle's Area is {TriangleArea} and Perimeter is {TrianglePerimeter}!!!");
        }
    }
}
