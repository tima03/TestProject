using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;
using Xunit;

namespace UnitTests.Tests
{
    public class TestFigureCircle
    {
        [Fact]
        public void TestCircleFuncs()
        {
            // Arrange
            Circle cr1 = new Circle(2);

            // Act
            double resultRadius = cr1.GetRadius();
            double resultDiameter = cr1.GetDiameter();
            double resultAreaByRadius = cr1.GetAreaByRadius();
           

            // Assert
            Assert.Equal(resultRadius, 2);
            Assert.Equal(resultDiameter, 4);
            Assert.Equal(Math.Round(resultAreaByRadius), 13);
            
        }

        [Fact]
        public void TestCircleThrowBelowZero()
        {
            // Arrange
            Circle cr1 = new Circle();

            // Act
            cr1.SetArea(-1);
            cr1.SetDiameter(-1);
            cr1.SetRadius(-1);
      
   
            // Assert
            Assert.Equal(0, cr1.GetRadius());
            Assert.Equal(0, cr1.GetDiameter());
            Assert.Equal(0, cr1.GetRadius());   
        }

        [Fact]
        public void TestCircleSetGet()
        {
            // Arrange
            Circle cr1 = new Circle();

            // Act
            cr1.SetArea(10);
            cr1.SetDiameter(20);
            cr1.SetX(150);
            cr1.SetY(5);
            cr1.SetName("Circle");
            cr1.SetRadius(2);

            // Assert
            Assert.Equal(10, cr1.GetArea());
            Assert.Equal(20, cr1.GetDiameter());
            Assert.Equal(150, cr1.GetX());
            Assert.Equal(5, cr1.GetY());   
            Assert.Equal("Circle", cr1.GetName());
            Assert.Equal(2, cr1.GetRadius());
        }
    }
}
