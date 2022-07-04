using Square;

namespace Square.Tests
{
    public class IsRightAngled
    {
        [Theory]
        [InlineData(5, 3, 4, true)]
        [InlineData(15, 12, 9, true)]
        [InlineData(18, 6, 12, false)]
        [InlineData(19, 6, 12, false)]
        public void Rectangle_is_right_angled(double firstSide, double secondSide, double thirdSide, bool expected)
        {
            //act
            bool result = Square.IsRightAngled(firstSide, secondSide, thirdSide);

            //assert
            Assert.Equal(result, expected);
        }
    }
}