using TestProject;
using Xunit;

namespace UnitTests.Tests
{
    public class TestFigureTriangle
    {
        [Fact]
        public void TestTriangleFuncs()
        {
            // Arrange
            Triangle tr1 = new Triangle(3, 4, 5);

            // Act
            double resultAngleAB = tr1.GetAB_AngleByThreeSides();
            double resultAngleBC = tr1.GetBC_AngleByThreeSides();
            double resultAngleCA = tr1.GetCA_AngleByThreeSides();
            double resultAreaByHeightAndSide = tr1.GetAreaByHeightAndSide();
            double resultAreaByThreeSides = tr1.GetAreaByThreeSides();
            double resultAreaByTwoSidesAndAngle = tr1.GetAreaByTwoSidesAndAngle();
            double resultGetA_Height = tr1.GetA_HeightByThreeSides();
            double resultGetB_Height = tr1.GetB_HeightByThreeSides();
            double resultGetC_Height = tr1.GetC_HeightByThreeSides();

            // Assert
            Assert.Equal(Math.Round(resultAngleAB), 53);
            Assert.Equal(resultAngleBC, 90);
            Assert.Equal(Math.Round(resultAngleCA), 37);
            Assert.Equal(resultAreaByHeightAndSide, 6);
            Assert.Equal(resultAreaByThreeSides, 6);
            Assert.Equal(resultAreaByTwoSidesAndAngle, 6);
        }

        [Fact]
        public void TestTriangleThrowBelowZero()
        {
            // Arrange
            Triangle tr1 = new Triangle();

            // Act
            tr1.SetAB_Angle(-1);
            tr1.SetBC_Angle(-1);
            tr1.SetCA_Angle(-1);
            tr1.SetA_Height(-1);
            tr1.SetA_Side(-1);
            tr1.SetB_Height(-1);
            tr1.SetB_Side(-1);
            tr1.SetC_Height(-1);
            tr1.SetC_Side(-1);
            tr1.SetArea(-1);
            tr1.SetPerimeter(-1);
            tr1.SetPerimHalf(-1);
            tr1.SetArea(-1);
            // Assert
            Assert.Equal(0, tr1.GetAB_Angle());
            Assert.Equal(0, tr1.GetBC_Angle());
            Assert.Equal(0, tr1.GetCA_Angle());
            Assert.Equal(0, tr1.GetA_Height());
            Assert.Equal(0, tr1.GetA_Side());
            Assert.Equal(0, tr1.GetB_Height());
            Assert.Equal(0, tr1.GetB_Side());
            Assert.Equal(0, tr1.GetC_Height());
            Assert.Equal(0, tr1.GetC_Side());
            Assert.Equal(0, tr1.GetArea());    
            Assert.Equal(0, tr1.GetPerimeter());
            Assert.Equal(0, tr1.GetPerimHalf());
            Assert.Equal(0, tr1.GetArea());
        }

        [Fact]
        public void TestRightTriangleChecking()
        {
            // Arrange
            Triangle tr1 = new Triangle(3,4,5);

            // Act
            bool result = tr1.CheckRightTriangle();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestTriangleSetGet()
        {
            // Arrange
            Triangle tr1 = new Triangle();
            
            // Act
            bool result = tr1.CheckRightTriangle();
            tr1.SetAB_Angle(10);
            tr1.SetBC_Angle(20);
            tr1.SetCA_Angle(150);
            tr1.SetA_Height(5);
            tr1.SetA_Side(6);
            tr1.SetB_Height(7);
            tr1.SetB_Side(8);
            tr1.SetC_Height(9);
            tr1.SetC_Side(10);
            tr1.SetArea(11);
            tr1.SetName("TriAngle");
            tr1.SetPerimeter(12);
            tr1.SetPerimHalf(13);
            tr1.SetX(100);
            tr1.SetY(110);

            // Assert
            Assert.Equal(10, tr1.GetAB_Angle());
            Assert.Equal(20, tr1.GetBC_Angle());
            Assert.Equal(150, tr1.GetCA_Angle());
            Assert.Equal(5, tr1.GetA_Height());
            Assert.Equal(6, tr1.GetA_Side());
            Assert.Equal(7, tr1.GetB_Height());
            Assert.Equal(8, tr1.GetB_Side());
            Assert.Equal(9, tr1.GetC_Height());
            Assert.Equal(10, tr1.GetC_Side());
            Assert.Equal(11, tr1.GetArea());
            Assert.Equal("TriAngle", tr1.GetName());
            Assert.Equal(12, tr1.GetPerimeter());
            Assert.Equal(13, tr1.GetPerimHalf());
            Assert.Equal(100, tr1.GetX());
            Assert.Equal(110, tr1.GetY());
        }

    }
}