using Newtonsoft.Json;

namespace PrometricGeometry
{
    public class Circle : Shape
    {
        private const decimal Pi = 3.14m;
        [JsonPropertyAttribute]
        private decimal Radius { get; set; }
        public override string Name => GetType().Name;
        public override decimal Perimeter => 2 * Pi * Radius;
        public override decimal Area => Pi * Radius * Radius;

        private static List<Circle> allInstancesOfCircle = new();

        public Circle(decimal r)
        {
            Radius = r;
            allInstancesOfCircle.Add(this);
        }
        public Circle()
        {
            allInstancesOfCircle.Add(this);
        }
        public static int Count()
        {
            return allInstancesOfCircle.Count;
        }
    }
}
