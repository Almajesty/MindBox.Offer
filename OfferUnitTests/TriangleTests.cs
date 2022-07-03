using MindBox.Offer.Classes;
using Xunit;

namespace MindBox.OfferUnitTests
{
    public class TriangleTests
    {
        /// <summary>
        /// Если стороная отрицательной длины вернуть true
        /// </summary>
        [Fact]
        public void Triangle_HaveNegativeSide_IsNotPositive()
        {
            // arrange
            var triangle = new Triangle(-1, 2, 2);
            // act
            var result = triangle.IsNotPositive();
            // assert
            Assert.True(result);
        }

        /// <summary>
        /// Если две стороны меньше третьей вернуть true
        /// </summary>
        [Fact]
        public void Triangle_IsNotCorrectSideLength()
        {
            // arrange
            var triangle = new Triangle(35, 3, 10);
            // act
            var result = triangle.IsNotCorrectSideLength();
            // assert
            Assert.True(result);
        }

        [Fact]
        public void Triangle_CheckZeroSize_ValidationInputValue()
        {
            // arrange
            var triangle = new Triangle(0, 3, 10);
            // act & assert
            var result = Assert.Throws<Exception>(() => triangle.ValidationInputValue());
        }

        [Fact]
        public void Triangle_3_2_2_CheckPythTriangle_ReturnFalse()
        {
            // arrange
            var triangle = new Triangle(3, 2, 2);
            var expected = false;
            // act
            var result = triangle.CheckPythTriangle();
            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Triangle_3_4_5_CheckPythTriangle_ReturnTrue()
        {
            // arrange
            var triangle = new Triangle(3, 4, 5);
            var expected = true;
            // act
            var result = triangle.CheckPythTriangle();
            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Triangle_CheckPythTriangle_6_8_10_GetArea()
        {
            // arrange
            var triangle = new Triangle(6, 8, 10);
            var expected = 24;
            // act
            var result = triangle.GetAreaUseHeronsFormula();
            // assert
            Assert.Equal(expected, result);
        }
    }
}
