// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using PrometricGeometry;
using System.Net.Http.Json;
using System.Xml.Linq;

Console.WriteLine("Hello, Shape World!");

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

// Order by area and print
Console.WriteLine("** Ordering by area!!! ***");
shapeList.OrderBy(x => x.Area()).ToList().ForEach(y => { Console.WriteLine($"{y.Name()}, {y.Area()}"); });

//Order by perimiter and print
Console.WriteLine("*** Ordering by perimeter! ***");
shapeList.OrderBy(x => x.Perimeter()).ToList().ForEach(y => { Console.WriteLine($"{y.Name()}, {y.Area()}"); });

// Save as json
// System.Text.Json saved empty objects. Just changed to Newtonsoft for a quick fix, but had to make shapes members public
string json = JsonConvert.SerializeObject(shapeList.ToArray());
File.WriteAllText($"C:\\Temp\\Shapes{DateTime.Now:yyyyMMddHHmmss}.json", json);


Console.WriteLine($"Circles created: {shapeList.Where(c => c.GetType().Name.Equals("Circle")).ToList().Count}");
Console.WriteLine($"Triangles created: {shapeList.Where(c => c.GetType().Name.Equals("Triangle")).ToList().Count}");
Console.WriteLine($"Quadrilaterals created: {shapeList.Where(c => c.GetType().Name.Equals("Quadrilateral")).ToList().Count}");