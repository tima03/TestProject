using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;
using Xunit;

namespace UnitTests.Tests
{
    public class TestFigureSquare
    {
        [Fact]
        public void TestSquareFuncs()
        {
            // Arrange
            Square sqr1 = new Square(2,4);

            // Act
            double resultHeight = sqr1.GetHeight();
            double resultWidth = sqr1.GetWidth();
            double resultArea = sqr1.GetArea();


            // Assert
            Assert.Equal(resultWidth, 2);
            Assert.Equal(resultHeight, 4);
            Assert.Equal(Math.Round(resultArea), 8);

        }

        [Fact]
        public void TestSquareThrowBelowZero()
        {
            // Arrange
            Square sqr1 = new Square();

            // Act
            sqr1.SetHeight(-1);
            sqr1.SetWidth(-1);
            sqr1.SetArea(-1);
          

            // Assert
            Assert.Equal(0, sqr1.GetHeight());
            Assert.Equal(0, sqr1.GetWidth());
            Assert.Equal(0, sqr1.GetArea());
        }

        [Fact]
        public void TestSquareSetGet()
        {
            // Arrange
            Square sqr1 = new Square();

            // Act
            sqr1.SetArea(10);
            sqr1.SetHeight(20);
            sqr1.SetWidth(2);
            sqr1.SetX(150);
            sqr1.SetY(5);
            sqr1.SetName("Square");
            
            // Assert
            Assert.Equal(10, sqr1.GetArea());
            Assert.Equal(20, sqr1.GetHeight());
            Assert.Equal(2, sqr1.GetWidth());
            Assert.Equal(150, sqr1.GetX());
            Assert.Equal(5, sqr1.GetY());
            Assert.Equal("Square", sqr1.GetName());
            
        }

    }
}
