using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(int width, int length) 
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
