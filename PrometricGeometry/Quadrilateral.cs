using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Quadrilateral : Shape
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }

        public static List<Quadrilateral> allInstancesOfQuadrilateral = new();

        public Quadrilateral(decimal width, decimal length)
        {
            Width = width;
            Length = length;
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

        public override int Count()
        {
            return allInstancesOfQuadrilateral.Count();
        }
    }
}
