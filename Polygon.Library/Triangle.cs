using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : base(3, length)
        {
        }

        /// <summary>
        /// If we comment out this code then we will get compile time error
        /// 'Triangle' does not implement inherited abstract member 'AbstractRegularPolygon.GetArea()'
        /// Compiler is forcing us to provide our own implementation of the GetArea method.
        /// If we don't provide it , we cannot build.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
