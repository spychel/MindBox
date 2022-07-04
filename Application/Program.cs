
var radius = 5;
var areaOfCircle = Square.Square.GetSquare(radius);

double firstSide = 5;
double secondSide = 5;
double thirdSide = 5;

var areaOfTriangle = Square.Square.GetSquare(firstSide, secondSide, thirdSide);
var isRightAngled = Square.Square.IsRightAngled(firstSide, secondSide, thirdSide);
System.Console.WriteLine($"Circle\nCircle radius: {radius}\nCircle area: {areaOfCircle}\n");
System.Console.WriteLine($"Triangle\nTriangle sides: {firstSide}, {secondSide}, {thirdSide}\nTriangle area: {areaOfTriangle}\nTriangle is right-angled: { (isRightAngled ? "Yes" : "No") }");