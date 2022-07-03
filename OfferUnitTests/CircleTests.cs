using MindBox.Offer.Classes;
using Xunit;

namespace MindBox.OfferUnitTests;

public class CircleTests
{
    /// <summary>
    /// Проверка правильности вычисления площади
    /// </summary>
    /// <param name="radius"></param>
    [Theory]
    [InlineData(0.333)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(Math.PI)]
    public void Circle_PositiveRadius_GetArea(double radius)
    {
        // arrange
        var cicrcle = new Circle(radius);
        var expected = Math.PI * Math.Pow(radius, 2);
        // act
        var result = cicrcle.Area();
        // assert
        Assert.Equal(expected, result);
    }

    /// <summary>
    /// Радиус обязан быть > 0
    /// </summary>
    /// <param name="radius"></param>
    [Theory]
    [InlineData(-Math.PI)]
    [InlineData(-3)]
    [InlineData(-2)]
    [InlineData(-1)]
    [InlineData(0)]
    public void Circle_NegativeRadius_ThrowException(double radius)
    {
        // arrange
        var expected = new Exception("Radius must be a positive number");
        // act
        var result = Assert.Throws<Exception>(() => new Circle(radius));
        // assert
        Assert.Equal(expected.Message, result.Message);

    }
}
