using Newtonsoft.Json;

namespace PrometricGeometry
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Circle : Shape
    {
        private const decimal Pi = 3.14m;
        [JsonPropertyAttribute]
        private decimal Radius { get; set; }
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

        public override decimal Area()
        {
            return Pi * Radius * Radius;
        }

        public override string Name()
        {
            return this.GetType().Name;
        }

        public override decimal Perimeter()
        {
            return 2 * Pi * Radius;
        }
        public static int Count()
        {
            return allInstancesOfCircle.Count;
        }
    }
}
