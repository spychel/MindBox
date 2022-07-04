using Square;
namespace Square.Tests;

public class AreaCalculate
{
    [Theory]
    [InlineData(0.05, 0.008)]
    [InlineData(1.05, 3.464)]
    [InlineData(2, 12.566)]
    [InlineData(123.99, 48297.338)]
    [InlineData(25, 1963.495)]
    public void Area_of_the_circle_is_calculated_correct(double value, double expected)
    {
        //act
        double result = Square.GetSquare(value);

        //assert
        Assert.Equal(result, expected);
    }

    [Theory]
    [InlineData(6, 7, 12, 14.948)]
    [InlineData(8, 6, 12, 21.331)]
    [InlineData(18, 6, 12, 0)]
    [InlineData(19, 6, 12, Double.NaN)]
    public void Area_of_the_rectangle_is_calculated_correct(double firstSide, double secondSide, double thirdSide, double expected)
    {
        //act
        double result = Square.GetSquare(firstSide, secondSide, thirdSide);

        //assert
        Assert.Equal(result, expected);
    }
}