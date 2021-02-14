
namespace ShapeWithVisistorPattern
{
    public class AreaVisitor : IVisitor//Часть 1//Часть 2//Часть 3
    {
        public double Accept(Circule circule) => circule.CircleArea;

        public double Accept(Rectangle rectangle) => rectangle.RectangleArea;

        public double Accept(Square square) => square.SquareArea;

        public double Accept(Triangle triangle) => triangle.TriangleArea;

        public double Accept(Trapezium trapezium) => trapezium.TrapeziumArea;
    }
}
