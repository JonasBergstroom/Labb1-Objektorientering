using System;
namespace Labb1_objektorientering

{
    public class Square : Shape
    {
        public double sideLength { get; set; }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public override double GetArea()
        {
            double area = sideLength * sideLength;
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = sideLength * 4;
            return perimeter;
        }

        public override string ToString()
        {
            return $"This is a {this.GetType().Name.ToLower()} with side length {sideLength}. The area is {GetArea()} and the perimeter is {GetPerimeter()}.";
        }
    }
}

