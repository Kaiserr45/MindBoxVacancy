namespace ShapeAreaCalculation
{
    /// <summary>
    /// Represents a circle shape for area calculation.
    /// </summary>
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius of the circle must be a positive number and cannot be zero.");
            }
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
