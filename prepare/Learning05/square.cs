public class Square: Shape
{
    private double _sides;

    public Square(double side, string color): base(color)
    {
        _sides = side;
    }

    public override double GetArea()
    {
        double area = _sides * _sides;
        return area;
    }
}