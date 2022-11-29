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

        public override decimal Area()
        {
            return Base * Height / 2;
        }

        public override string Name()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return "Equilateral";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }

        public override decimal Perimeter()
        {
            return SideA + SideB + SideC;
        }
        
        public static int Count()
        {
            return allInstancesOfTriangle.Count;   
        }
    }
}
