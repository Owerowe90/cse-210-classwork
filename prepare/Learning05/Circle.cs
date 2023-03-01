public class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(_pi * _radius, 2);
    }
}
