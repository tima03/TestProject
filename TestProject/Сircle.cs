using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Сircle : Figure
    {
        private double Radius, Diameter;

        public Сircle()
        {
            this.Radius = 0;
            this.Diameter = this.Radius * 2;
            this.SetArea(this.GetAreaByRadius());
        }

        public Сircle(double radius)
        {
            this.Radius = radius;
            this.Diameter = this.Radius * 2;
            this.SetArea(this.GetAreaByRadius());
        }


        public void SetRadius(double radius) => this.Radius = radius;
        public void SetDiameter(double diameter) => this.Diameter = diameter;

        public double GetRadius() { return this.Radius; }
        public double GetDiameter() { return this.Diameter; }

        public double GetAreaByRadius() { return Math.PI * Math.Pow(Radius, 2); }

        public void PrintRadius() => Console.WriteLine($"Радус круга - {Radius}");
        public void PrintDiameter() => Console.WriteLine($"Диаметр круга - {Diameter}");
        
    }
}
