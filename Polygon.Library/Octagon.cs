using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    /// <summary>
    /// Octagon implements IRegularPolygon
    /// Octagon inherits from Object
    /// public class Octagon : Object, IRegularPolygon 
    /// Since IRegularPolygon is a contract, our class must implement all of its members.
    /// </summary>
    public class Octagon : IRegularPolygon 
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        /// <summary>
        ///  we must provide method bodies for both of these, we don't have a parent class that provides them.
        ///  Since an interface is a contract, we must implement all of the members. If we try to comment out one
        ///  of these items and build, we get a Compiler Error and our Error Message here is ‘Polygons.Library.Octagon' 
        ///  does not implement interface member ‘Polygons.Library.IRegularPolygon.GetPerimeter'. 
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
