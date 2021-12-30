using System;
namespace OOlab.Classes
{
    public class Square:Shape
    {
        private int SideLength { get; set; }
        public Square(int sideLength) => SideLength = sideLength;

        public override double GetArea() => SideLength * SideLength;


        public override double GetPerimeter() => SideLength * 4;
        
       
        public override string ToString() =>
             $"This is a {this.GetType().Name} with side length {SideLength}, area {GetArea()} and perimeter {GetPerimeter()}";

    }
}
