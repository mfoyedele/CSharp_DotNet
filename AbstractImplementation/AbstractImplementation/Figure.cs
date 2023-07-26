using System;

namespace AbstractImplementation
{
    public class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

    }
    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
    }

}