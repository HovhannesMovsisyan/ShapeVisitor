using System;
using System.Collections.Generic;

namespace ShapeWithVisistorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                                              //--------------------//Часть 1//Часть 3
                Circule circule = new Circule(3);
                Rectangle rectangle = new Rectangle(3, 5);
                Square square = new Square(5);
                Triangle triangle = new Triangle(2, 3, 4, 5);
                Trapezium trapezium = new Trapezium(2, 3, 4, 5, 7);
                circule.PrintFigureAreaAndPerimeter();
                rectangle.PrintFigureAreaAndPerimeter();
                square.PrintFigureAreaAndPerimeter();
                triangle.PrintFigureAreaAndPerimeter();
                trapezium.PrintFigureAreaAndPerimeter();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

            List<Figure> figures = new List<Figure>();//------------//Часть 2
            figures.Add(new Circule(3));
            figures.Add(new Square(2));
            figures.Add(new Trapezium(4, 2, 6, 5,8));
            figures.Add(new Rectangle(3, 2));
            figures.Add(new Triangle(4, 2, 6, 5));

            //Show total areas and perimeters of List<Figure>
            TotalAreaAndPerimeter.PrintTotalSum(figures);
        }
    }
}
