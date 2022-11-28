using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Triangle : Shape
    {
        private decimal SideA { get; set; }
        private decimal SideB { get; set; }
        private decimal SideC { get; set; }
        private decimal Height { get; set; }
        private decimal Base { get; set; }

        public Triangle(decimal a, decimal b, decimal c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public Triangle(decimal tHeight, decimal tBase)
        {
            Height = tHeight;
            Base = tBase;
        }

        public Triangle(decimal a, decimal b, decimal c, decimal tHeight, decimal tBase)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            Height = tHeight;
            Base = tBase;
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
    }
}
