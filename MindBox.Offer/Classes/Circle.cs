using static System.Math;

namespace MindBox.Offer.Classes;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (isNotPositiveRadius(value))
                throw new Exception("Radius must be a positive number");
            _radius = value;
        }
    }

    private bool isNotPositiveRadius(double radius) => 
        radius <= 0;

    public override double Area() => 
        PI * Radius * Radius;

}
