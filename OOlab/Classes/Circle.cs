using System;
namespace OOlab.Classes
{
    public class Circle:Shape
    {
        public int Radius { get; set; }
        public Circle(int radius) => Radius = radius;

        public override double GetArea() => Radius * Radius * Math.PI;

        public override double GetPerimeter() => (Radius + Radius) * Math.PI;

        public override string ToString() =>
          $"This is a {this.GetType().Name} with radius {Radius}. The Area is {GetArea()} and perimeter is {GetPerimeter()}"; 
    }
}
