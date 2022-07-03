using static System.Math;

namespace MindBox.Offer.Classes;

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value <= 0)
                throw new Exception("Radius must be a positive number");
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return PI * Radius * Radius;
    }
}
