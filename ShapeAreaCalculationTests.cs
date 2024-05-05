using NUnit.Framework;
using ShapeAreaCalculation;

namespace ShapeAreaCalculationTests;

[TestFixture]
internal class ShapeAreaCalculationTests
{
    [TestCase(0)]
    [TestCase(-5)]
    public void TestImpossibleCircle(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [TestCase(5, 78.53981633974483)]
    [TestCase(10, 314.1592653589793)]
    public void TestCircleAreaCalculation(double radius, double expectedResult)
    {
        Circle circle = new Circle(5);

        Assert.That(circle.CalculateArea(), Is.EqualTo(78.53981633974483).Within(0.0001));
    }

    [TestCase(1, 2, 3)]
    [TestCase(3, 4, 8)]
    public void TestImpossibleTriangle(double side1, double side2, double side3)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }

    [TestCase(3, 4, 5, 6)]
    [TestCase(6, 8, 10, 24)]
    [TestCase(1, 1, 1, 0.4330127018922193)]
    public void TestTriangleAreaCalculation(double side1, double side2, double side3, double expectedResult)
    {
        Triangle triangle = new Triangle(side1, side2, side3);

        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedResult).Within(0.0001));
    }

    [TestCase(3, 4, 5, true)]
    [TestCase(5, 12, 13, true)]
    [TestCase(6, 8, 10, true)]
    [TestCase(1, 1, 1, false)]
    [TestCase(3, 4, 6, false)]
    public void TestTriangleRight(double side1, double side2, double side3, bool expectedResult)
    {
        Triangle triangle = new Triangle(side1, side2, side3);
        bool isRightTriangle = triangle.IsRightTriangle();

        Assert.That(isRightTriangle, Is.EqualTo(expectedResult));
    }
}