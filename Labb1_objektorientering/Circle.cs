using System;
namespace Labb1_objektorientering

{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = (2 * Math.PI) * radius;
            return perimeter;
        }

        public override string ToString()
        {
            return $"This is a {this.GetType().Name.ToLower()} with radius {radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}.";
        }

       
    }
}