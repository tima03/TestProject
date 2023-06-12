using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Triangle:Figure
    {
        private double A_Side, B_Side, C_Side;
        private double A_Height,B_Height, C_Height;
        private double AB_Angle, BC_Angle, CA_Angle;
        private double Perimeter, PerimHalf;

        public Triangle()
        {
            this.A_Side = 0;
            this.B_Side = 0;
            this.C_Side = 0;
            this.A_Height = 0;
            this.B_Height = 0;
            this.C_Height = 0;
            this.AB_Angle = 0;
            this.BC_Angle = 0;
            this.CA_Angle = 0;
            Perimeter = A_Side + B_Side + C_Side;
            PerimHalf = Perimeter / 2;
            this.SetArea(this.GetAreaByThreeSides());
        }

        public Triangle(double a_side, double a_height)
        {
            this.A_Side = a_side;
            this.B_Side = 0;
            this.C_Side = 0;
            this.A_Height = a_height;
            this.AB_Angle = 0;
            this.BC_Angle = 0;
            this.CA_Angle = 0;
            Perimeter = A_Side + B_Side + C_Side;
            PerimHalf = Perimeter / 2;
            this.SetArea(this.GetAreaByHeightAndSide());
        }

        public Triangle(double a_side, double b_side,double c_side)
        {
            this.A_Side = a_side;
            this.B_Side = b_side;
            this.C_Side = c_side;
            this.AB_Angle = this.GetAB_AngleByThreeSides();
            this.BC_Angle = this.GetBC_AngleByThreeSides();
            this.CA_Angle = this.GetCA_AngleByThreeSides();
            Perimeter = A_Side + B_Side + C_Side;
            PerimHalf = Perimeter / 2;
            this.SetArea(this.GetAreaByThreeSides());
            this.A_Height = this.GetA_HeightByThreeSides();
            this.B_Height = this.GetB_HeightByThreeSides();
            this.C_Height = this.GetC_HeightByThreeSides();
        }

        public void SetA_Side(double a_side) => this.A_Side = a_side;
        public void SetB_Side(double b_side) => this.B_Side = b_side;
        public void SetC_Side(double c_side) => this.C_Side = c_side;
        public void SetA_Height(double a_height) => this.A_Height = a_height;
        public void SetB_Height(double b_height) => this.B_Height = b_height;
        public void SetC_Height(double c_height) => this.C_Height = c_height;
        public void SetAB_Angle(double ab_angle) => this.AB_Angle = ab_angle;
        public void SetBC_Angle(double bc_angle) => this.BC_Angle = bc_angle;
        public void SetCA_Angle(double ca_angle) => this.CA_Angle = ca_angle;
        public void SetPerimeter(double perimeter) => this.Perimeter = perimeter;
        public void SetPerimHalf(double perimhalf) => this.PerimHalf = perimhalf;

        public double GetA_Side() { return this.A_Side; }
        public double GetB_Side() { return this.B_Side; }
        public double GetC_Side() { return this.C_Side; }
        public double GetA_Height() { return this.A_Height; }
        public double GetB_Height() { return this.B_Height; }
        public double GetC_Height() { return this.C_Height; }
        public double GetAB_Angle() { return this.AB_Angle; }
        public double GetBC_Angle() { return this.BC_Angle; }
        public double GetCA_Angle() { return this.CA_Angle; }
        public double GetPerimeter() { return this.A_Side + this.A_Side + this.C_Side; }
        public double GetPerimHalf() { return this.Perimeter / 2; }


        public double GetAreaByThreeSides()
        {
            return Math.Sqrt(PerimHalf * (PerimHalf - A_Side) * (PerimHalf - B_Side) * (PerimHalf - C_Side));
        }

        public double GetAreaByHeightAndSide()
        {
            return 1 / 2 * (A_Side * A_Height);
        }

        public double GetAreaByTwoSidesAndAngle() {
            return 1 / 2 * (A_Side * B_Side * Math.Sin(AB_Angle));
        }

        public double GetAB_AngleByThreeSides() {
            return Math.Acos((Math.Pow(A_Side, 2) + Math.Pow(C_Side, 2) - Math.Pow(B_Side, 2)) / (2 * A_Side * C_Side));
        }

        public double GetBC_AngleByThreeSides()
        {
            return Math.Acos((Math.Pow(A_Side, 2) + Math.Pow(B_Side, 2) - Math.Pow(C_Side, 2)) / (2 * A_Side * B_Side));
        }

        public double GetCA_AngleByThreeSides()
        {
            return Math.Acos((Math.Pow(B_Side, 2) + Math.Pow(C_Side, 2) - Math.Pow(A_Side, 2)) / (2 * C_Side * B_Side));
        }

        public double GetA_HeightByThreeSides()
        {
            return 2*this.GetAreaByThreeSides() / A_Side;
        }

        public double GetB_HeightByThreeSides()
        {
            return 2 * this.GetAreaByThreeSides() / B_Side;
        }

        public double GetC_HeightByThreeSides()
        {
            return 2 * this.GetAreaByThreeSides() / C_Side;
        }

        public void PrintA_Side() => Console.WriteLine($"Сторона А треугольника - {A_Side}");
        public void PrintB_Side() => Console.WriteLine($"Сторона B треугольника - {B_Side}");
        public void PrintC_Side() => Console.WriteLine($"Сторона C треугольника - {C_Side}");
        public void PrintA_Height() => Console.WriteLine($"Высота A треугольника - {A_Height}");
        public void PrintB_Height() => Console.WriteLine($"Высота B треугольника - {B_Height}");
        public void PrintC_Height() => Console.WriteLine($"Высота C треугольника - {C_Height}");
        public void PrintAB_Angle() => Console.WriteLine($"Угол между AB и BC  - {AB_Angle}");
        public void PrintBC_Angle() => Console.WriteLine($"Угол между BC и CA - {BC_Angle}");
        public void PrintCA_Angle() => Console.WriteLine($"Угол между CA и AB  -  {CA_Angle}");
        public void PrintPerimeter() => Console.WriteLine($"Периметр треугольника - {Perimeter}");
        public void PrintPerimHalf() => Console.WriteLine($"Полупериметр треугольника - {PerimHalf}");
    }
}
