using System;
namespace OOlab.Classes
{
    public class Rectangle:Shape
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public Rectangle(int width , int height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;


        public override double GetPerimeter() => (Width * 2) + (Height * 2);

        public override string ToString() =>
            $"This is a {this.GetType().Name} with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}"; 
    }
}
