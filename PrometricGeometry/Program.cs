// See https://aka.ms/new-console-template for more information
using PrometricGeometry;

Console.WriteLine("Hello, World!");

var shapeList = new List<Shape>();

var circle3 = new Circle(3.00m);
var circle7 = new Circle(7.00m);

var triangleE = new Triangle(4m, 4m, 4m, 3m, 2m);
var triangleI = new Triangle(4m, 6m, 4m, 3m, 2m);
var triangleS = new Triangle(4m, 6m, 5m, 3m, 2m);

var quadS = new Quadrilateral(5m, 5m);
var quadR = new Quadrilateral(4m, 6m);

shapeList.Add(circle7);
shapeList.Add(circle3);
shapeList.Add(triangleE);
shapeList.Add(triangleI);
shapeList.Add(triangleS);
shapeList.Add(quadR);
shapeList.Add(quadS);

shapeList.OrderBy(x => x.Area()).ToList().ForEach(y => { Console.WriteLine($"{y.Name()}, {y.Area()}"); });