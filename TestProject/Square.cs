using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject
{
    public class Square:Figure
    {
        private double Height, Width;

        public Square() {
            this.SetName("Square");
            this.Width = 0;
            this.Height = 0;
            this.SetArea(Width * Height);
        }

        public Square(float width, float height)
        {
            this.SetName("Square");
            if (width > 0) { this.Width = width; } else { this.Width = 0; }
            if (height > 0) { this.Height = height; } else { this.Height = 0; }
            this.SetArea(Width * Height);
        }

        public void SetWidth(double width) { if (width > 0) { this.Width = width; } else { this.Width = 0; } }
        public void SetHeight(double height) { if (height > 0) { this.Height = height; } else { this.Height = 0; } }

        public double GetWidth() { return this.Width; }
        public double GetHeight() { return this.Height; }

        public void PrintWidth() => Console.WriteLine($"Ширина прямоугольника - {Width}");
        public void PrintHeight() => Console.WriteLine($"Высота прямоугольника - {Height}");

    }
}
