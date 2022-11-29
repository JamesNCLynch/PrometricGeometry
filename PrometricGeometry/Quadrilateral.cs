using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Quadrilateral : Shape
    {
        [JsonPropertyAttribute]
        private decimal Width { get; set; }
        [JsonPropertyAttribute]
        private decimal Length { get; set; }

        private static List<Quadrilateral> allInstancesOfQuadrilateral = new();

        public Quadrilateral(decimal width, decimal length)
        {
            Width = width;
            Length = length;
            allInstancesOfQuadrilateral.Add(this);
        }
        public Quadrilateral()
        {
            allInstancesOfQuadrilateral.Add(this);
        }
        public override decimal Area()
        {
            return Width * Length;
        }

        public override string Name()
        {
            return Width.Equals(Length) ? "Square" : "Rectagle";
        }

        public override decimal Perimeter()
        {
            return (Width + Length) * 2;
        }

        public static int Count()
        {
            return allInstancesOfQuadrilateral.Count();
        }
    }
}
