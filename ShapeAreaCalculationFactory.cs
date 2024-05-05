namespace ShapeAreaCalculation
{
    /// <summary>
    /// Provides methods for creating instances of geometric shapes and calculating their areas.
    /// </summary>
    public class ShapeAreaCalculationFactory
    {
        /// <summary>
        /// Creates a new instance of Circle with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>A new instance of Circle.</returns>
        public IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Creates a new instance of Triangle with the specified side lengths.
        /// </summary>
        /// <param name="side1">The length of the first side.</param>
        /// <param name="side2">The length of the second side.</param>
        /// <param name="side3">The length of the third side.</param>
        /// <returns>A new instance of Triangle.</returns>
        public ITriangle CreateTriangle(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3);
        }
    }
}
