using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double length, double width, double height) 
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * ((Width * Length) + (Width * Height) + (Length * Height));
        }

        public double Perimeter()
        {
            return 4 * (Width + Length + Height);
        }

        public double Volume()
        {
            return Width * Length * Height;
        }
    }
}
