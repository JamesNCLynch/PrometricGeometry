using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Triangle : Shape
    {
        [JsonPropertyAttribute]
        private decimal SideA { get; set; }
        [JsonPropertyAttribute]
        private decimal SideB { get; set; }
        [JsonPropertyAttribute]
        private decimal SideC { get; set; }
        [JsonPropertyAttribute]
        private decimal Height { get; set; }
        [JsonPropertyAttribute]
        private decimal Base { get; set; }

        public override string Name =>
            SideA == SideB && SideB == SideC ? "Equilateral" : SideA == SideB || SideA == SideC || SideB == SideC ? "Isosceles" : "Scalene";


        public override decimal Perimeter => SideA + SideB + SideC;

        public override decimal Area => Base * Height / 2;

        private static List<Triangle> allInstancesOfTriangle = new();

        public Triangle(decimal a, decimal b, decimal c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            allInstancesOfTriangle.Add(this);
        }

        public Triangle(decimal tHeight, decimal tBase)
        {
            Height = tHeight;
            Base = tBase;
            allInstancesOfTriangle.Add(this);
        }

        public Triangle(decimal a, decimal b, decimal c, decimal tHeight, decimal tBase)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            Height = tHeight;
            Base = tBase;
            allInstancesOfTriangle.Add(this);
        }

        public Triangle()
        {
            allInstancesOfTriangle.Add(this);
        }

        public static int Count()
        {
            return allInstancesOfTriangle.Count;
        }
    }
}
