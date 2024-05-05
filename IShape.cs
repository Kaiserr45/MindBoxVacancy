namespace ShapeAreaCalculation
{
    /// <summary>
    /// Represents a geometric shape for area calculation.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        double CalculateArea();
    }
}
