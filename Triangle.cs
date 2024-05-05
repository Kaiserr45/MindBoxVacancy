namespace ShapeAreaCalculation
{
    /// <summary>
    /// Represents a triangle shape for area calculation.
    /// </summary>
    internal class Triangle : ITriangle
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Invalid triangle sides: a triangle with these side lengths cannot exist.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public bool IsRightTriangle()
        {
            return IsPythagoreanTriple(side1, side2, side3) || IsPythagoreanTriple(side1, side3, side2) || IsPythagoreanTriple(side2, side3, side1);
        }

        private bool IsPythagoreanTriple(double a, double b, double c)
        {
            return a*a + b*b == c*c;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return area;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
