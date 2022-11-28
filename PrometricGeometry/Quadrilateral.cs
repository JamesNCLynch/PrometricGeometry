using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Quadrilateral : Shape
    {
        private decimal Width { get; set; }
        private decimal Length { get; set; }

        public Quadrilateral(decimal width, decimal length)
        {
            Width = width;
            Length = length;
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
    }
}
