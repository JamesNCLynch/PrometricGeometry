using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Triangle : Shape
    {
        public decimal SideA { get; set; }
        public decimal SideB { get; set; }
        public decimal SideC { get; set; }
        public decimal Height { get; set; }
        public decimal Base { get; set; }

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
