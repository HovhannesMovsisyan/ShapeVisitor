
namespace ShapeWithVisistorPattern
{
    public class PerimeterVisitor : IVisitor//Часть 1//Часть 2//Часть 3
    {
        public double Accept(Circule circule) => circule.CirclePerimeter;

        public double Accept(Rectangle rectangle) => rectangle.RectanglePerimeter;

        public double Accept(Square square) => square.SquarePerimeter;

        public double Accept(Triangle triangle) => triangle.TrianglePerimeter;

        public double Accept(Trapezium trapezium) => trapezium.TrapeziumPerimeter;
    }
}
