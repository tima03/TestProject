using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace TestProject
{
    public abstract class Figure
    {
        private string Name;
        private double X, Y;
        private double Area;

        public Figure() {
            this.Name = "Empty";
            this.X = 0;
            this.Y = 0;
            this.Area = 0;
        }

        public Figure(string name) {
            this.Name = name;
            this.X = 0;
            this.Y = 0;
            this.Area = 0;
        }

        public Figure(string name, double x, double y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Area = 0;
        }

        public void SetName(string name) => this.Name = name;
        public void SetX(double x) => this.X = x;
        public void SetY(double y) => this.Y = y;
        public void SetArea(double area) { if (area > 0) { this.Area = area; } else { this.Area = 0; } }

        public string GetName() { return this.Name; }
        public double GetX() { return this.X; }
        public double GetY() { return this.Y; }
        public double GetArea() { return this.Area; }

        public void PrintName() => Console.WriteLine($"Фигура - {Name}");
        public void PrintX() => Console.WriteLine($"Координата X центра фигуры - {X}");
        public void PrintY() => Console.WriteLine($"Координата Y центра фигуры - {Y}");
        public void PrintXY() => Console.WriteLine($"Координаты центра фигуры - {X},{Y}");
        public void PrintArea() => Console.WriteLine($"Площадь фигуры - {Area}");
    }

}