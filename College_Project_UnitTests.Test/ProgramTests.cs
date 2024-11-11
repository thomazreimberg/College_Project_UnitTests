namespace College_Project_UnitTests.Test
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void CalculateRectangleArea_ValidInput_ReturnsCorrectArea()
        {
            double width = 5;
            double height = 10;
            double expected = 50;

            double result = AreaCalculator.CalculateRectangleArea(width, height);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateRectangleArea_NegativeInput_ThrowsArgumentException()
        {
            double width = -5;
            double height = 10;

            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateRectangleArea(width, height));
        }

        [Test]
        public void CalculateCircleArea_ValidInput_ReturnsCorrectArea()
        {
            double radius = 7;
            double expected = Math.PI * Math.Pow(radius, 2);

            double result = AreaCalculator.CalculateCircleArea(radius);

            Assert.That(result, Is.EqualTo(expected).Within(1e-5));
        }

        [Test]
        public void CalculateCircleArea_ZeroOrNegativeRadius_ThrowsArgumentException()
        {
            double radius = 0;

            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateCircleArea(radius));
        }

        [Test]
        public void CalculateTriangleArea_ValidInput_ReturnsCorrectArea()
        {
            double baseLength = 6;
            double height = 8;
            double expected = 0.5 * baseLength * height;

            double result = AreaCalculator.CalculateTriangleArea(baseLength, height);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateTriangleArea_NegativeInput_ThrowsArgumentException()
        {
            double baseLength = -6;
            double height = 8;

            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateTriangleArea(baseLength, height));
        }

        [Test]
        public void CalculateComplexShapeArea_ValidInputs_ReturnsCorrectArea()
        {
            double rectangleWidth = 5;
            double rectangleHeight = 10;
            double circleRadius = 7;
            double triangleBase = 6;
            double triangleHeight = 8;

            double expectedRectangleArea = AreaCalculator.CalculateRectangleArea(rectangleWidth, rectangleHeight);
            double expectedCircleArea = AreaCalculator.CalculateCircleArea(circleRadius);
            double expectedTriangleArea = AreaCalculator.CalculateTriangleArea(triangleBase, triangleHeight);
            double expectedTotalArea = expectedRectangleArea + expectedCircleArea + expectedTriangleArea;

            double result = expectedRectangleArea + expectedCircleArea + expectedTriangleArea;

            Assert.That(result, Is.EqualTo(expectedTotalArea).Within(1e-5));
        }

        [Test]
        public void CalculateComplexShapeArea_NegativeInput_ThrowsArgumentException()
        {
            double rectangleWidth = -5;
            double rectangleHeight = 10;
            double triangleBase = -6;
            double triangleHeight = 8;

            // Testando cada método separadamente para verificar a exceção
            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateRectangleArea(rectangleWidth, rectangleHeight));
            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateTriangleArea(triangleBase, triangleHeight));

            double circleRadius = -7;
            Assert.Throws<ArgumentException>(() => AreaCalculator.CalculateCircleArea(circleRadius));
        }

        [Test]
        public void CalculateShapeArea_WithMultipleShapes_ReturnsCorrectTotalArea()
        {
            double[] rectangleWidths = { 5, 3, 8 };
            double[] rectangleHeights = { 10, 4, 6 };
            double[] circleRadii = { 7, 2, 5 };

            double expectedTotalArea = 0;
            for (int i = 0; i < rectangleWidths.Length; i++)
            {
                expectedTotalArea += AreaCalculator.CalculateRectangleArea(rectangleWidths[i], rectangleHeights[i]);
            }

            foreach (var radius in circleRadii)
            {
                expectedTotalArea += AreaCalculator.CalculateCircleArea(radius);
            }

            double result = expectedTotalArea;

            Assert.That(result, Is.EqualTo(expectedTotalArea).Within(1e-5));
        }
    }
}
