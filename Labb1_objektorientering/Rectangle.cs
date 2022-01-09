using System;
namespace Labb1_objektorientering

{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height) : this(width)
        {
            this.height = height;

        }

        public Rectangle(double width)
        {
            this.width = width;
        }

        public override double GetArea()
        {
            double area = 0;

            if (height > 0)
            {
                area = width * height;

            }
            else
            {
                area = width * width;

            }
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = 0;

            if (height > 0)
            {
                perimeter = (width * 2) + (height * 2);

            }
            else
            {
                perimeter = width * 4;

            }

            return perimeter;
        }

        public override string ToString()
        {
            return $"This is a {this.GetType().Name.ToLower()} with height {(height == 0 ? width : height)} and width {width}. The area is {GetArea()} and the perimeter is {GetPerimeter()}.";
        }

    }
}