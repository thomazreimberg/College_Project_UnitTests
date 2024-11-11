namespace College_Project_UnitTests
{
    public class AreaCalculator
    {
        public static double CalculateRectangleArea(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("A largura e a altura devem ser maiores que zero.");
            }
            return width * height;
        }

        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("O raio deve ser maior que zero.");
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            if (baseLength <= 0 || height <= 0)
            {
                throw new ArgumentException("A base e a altura devem ser maiores que zero.");
            }
            return 0.5 * baseLength * height;
        }
    }
}
