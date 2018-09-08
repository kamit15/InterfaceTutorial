using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) : base(length, length)
        {
        }

        /// <summary>
        /// Nothing is forcing us to implement GetArea Method, We can comment this method and the application will build successfully but will get error while running
        /// It will use the default behaviour from the base class
        /// </summary>
        /// <returns></returns>
        public override double GetArea()  
        {
            return SideLength * SideLength;
        }
    }
}
