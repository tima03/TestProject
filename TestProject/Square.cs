using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject
{
    internal class Square:Figure
    {
        private double Height, Width;

        public Square() {
            this.Width = 0;
            this.Height = 0;
            this.SetArea(Width * Height);
        }

        public Square(float width, float height)
        {
            this.Width = width;
            this.Height = height;
            this.SetArea(Width * Height);
        }

        public void SetWidth(double width) => this.Width = width;
        public void SetHeight(double height) => this.Height = height;
    
        public double GetWidth() { return this.Width; }
        public double GetHeight() { return this.Height; }

        public void PrintWidth() => Console.WriteLine($"Ширина прямоугольника - {Width}");
        public void PrintHeight() => Console.WriteLine($"Высота прямоугольника - {Height}");

    }
}
