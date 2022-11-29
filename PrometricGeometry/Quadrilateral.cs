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

        public override string Name => Width.Equals(Length) ? "Square" : "Rectagle";

        public override decimal Perimeter => (Width + Length) * 2;

        public override decimal Area => Width * Length;

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

        public static int Count()
        {
            return allInstancesOfQuadrilateral.Count();
        }
    }
}
