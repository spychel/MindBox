namespace Square;

public class Square
{
    public static double GetSquare(double radius)
    {
        double result = new Circle().GetSquare(radius);
        return (double)Math.Round(result, 3);
    }

    public static double GetSquare(double firstSide, double secondSide, double thirdSide)
    {
        double result = new Triangle().GetSquare(firstSide, secondSide, thirdSide);
        return (double)Math.Round(result, 3);
    }

    public static bool IsRightAngled(double firstSide, double secondSide, double thirdSide)
    {
        return IsRightAngled(new Triangle(firstSide, secondSide, thirdSide));
    }

    private static bool IsRightAngled(Triangle triangle)
    {
        return triangle.IsRightAngled();
    }

}
