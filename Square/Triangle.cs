namespace Square;

internal class Triangle
{
    private double firstSide = default;
    private double secondSide = default;
    private double thirdSide = default;
    public Triangle()
    {

    }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public double GetSquare(double firstSide, double secondSide, double thirdSide)
    {
        var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
    }

    public bool IsRightAngled()
    {
        if ((this.firstSide == SqrtSumOfSquaresOfСathetuses(this.secondSide, this.thirdSide))
            || (this.secondSide == SqrtSumOfSquaresOfСathetuses(this.firstSide, this.thirdSide))
            || (this.thirdSide == SqrtSumOfSquaresOfСathetuses(this.secondSide, this.firstSide)))
        {
            return true;
        }
        return false;
    }

    private double SqrtSumOfSquaresOfСathetuses(double firstSide, double secondSide)
    {
        var sumOfSquaresOfСathetuses = Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2);
        return Math.Sqrt(sumOfSquaresOfСathetuses);
    }
}
