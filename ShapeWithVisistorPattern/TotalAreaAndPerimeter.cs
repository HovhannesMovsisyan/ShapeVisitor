using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeWithVisistorPattern
{
    static class TotalAreaAndPerimeter//Часть 2
    {
        public static double TotalArea(List<Figure> figures)
        {
            double totalArea =0;
            AreaVisitor area = new AreaVisitor();
            foreach (var element in figures)
            {
                totalArea += element.Visit(area);
            }
            return totalArea;
        }
        public static double TotalPerimeter(List<Figure> figures)
        {
            double totalPerimeter = 0;
            PerimeterVisitor area = new PerimeterVisitor();
            foreach (var element in figures)
            {
                totalPerimeter += element.Visit(area);
            }
            return totalPerimeter;
        }
        public static void PrintTotalSum(List<Figure> figures)
        {
            Console.WriteLine($" The total area of given figures is {TotalArea(figures)}, and total perimeter is {TotalPerimeter(figures)}");
        }
    }
}
