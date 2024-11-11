using College_Project_UnitTests;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Área do Retângulo (5, 10): " + AreaCalculator.CalculateRectangleArea(5, 10));
        Console.WriteLine("Área do Círculo (raio 7): " + AreaCalculator.CalculateCircleArea(7));
    }
}