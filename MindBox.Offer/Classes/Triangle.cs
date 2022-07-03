using static System.Math;

namespace MindBox.Offer.Classes;

public class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double s1, double s2, double s3)
    {
        Side1 = s1;
        Side2 = s2;
        Side3 = s3;
    }

    public bool CheckRightTriangle()
    {
        // If triangle is right it's sides complete Pythagorean theorem
        return Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2) ||
               Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2) ||
               Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2);
    }

    public bool ValidationInputValue()
    {
        if (IsNotPositive())
        {
            throw new Exception("All sides must be positive");
        }

        if (IsNotCorrectSideLength())
        {
            throw new Exception("For any triangle two sides must be more then one side");
        }

        return true;
    }

    public bool IsNotCorrectSideLength()
    {
        return Side1 + Side2 <= Side3 ||
               Side1 + Side3 <= Side2 ||
               Side2 + Side3 <= Side1;
    }

    public bool IsNotPositive()
    {
        return Side1 <= 0 || Side2 <= 0 || Side3 <= 0;
    }

    public double Perimeter
    {
        get
        {
            return Side1 + Side2 + Side3;
        }
    }

    /// <summary>
    /// Use Heron's formula
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double GetAreaUseHeronsFormula()
    {
        var semiPerimeter = Perimeter / 2;

        return Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
    }

    public override double Area()
    {
        return GetAreaUseHeronsFormula();
    }
}
