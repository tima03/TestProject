using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Circle : Figure
    {
        private double Radius, Diameter;

        public Circle()
        {
            this.Radius = 0;
            this.Diameter = this.Radius * 2;
            this.SetArea(this.GetAreaByRadius());
        }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Diameter = this.Radius * 2;
            this.SetArea(this.GetAreaByRadius());
        }


        public void SetRadius(double radius) { if (radius > 0) { this.Radius = radius; } else { this.Radius = 0; } }
        public void SetDiameter(double diameter) { if (diameter > 0) { this.Diameter = diameter; } else { this.Diameter = 0; } }

        public double GetRadius() { return this.Radius; }
        public double GetDiameter() { return this.Diameter; }

        public double GetAreaByRadius() { return Math.PI * Math.Pow(Radius, 2); }

        public void PrintRadius() => Console.WriteLine($"Радус круга - {Radius}");
        public void PrintDiameter() => Console.WriteLine($"Диаметр круга - {Diameter}");
        
    }
}
