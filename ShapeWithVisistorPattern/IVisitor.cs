
namespace ShapeWithVisistorPattern
{
    public interface IVisitor//Часть 1//Часть 2//Часть 3
    {
        double Accept(Circule circule);
        double Accept(Rectangle rectangle);
        double Accept(Square square);
        double Accept(Triangle triangle);
        double Accept(Trapezium trapezium);
    }
}
