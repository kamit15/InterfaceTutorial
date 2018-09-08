using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    /// <summary>
    ///  The property's NumberOfSides and SideLength look like automatic properties, but they are not. 
    ///  This is just a declaration that properties with these names and types need to exist in the class that implements the interface.
    ///  This can get a bit confusing, especially since the syntax is exactly the same, but in an interface, these are just declarations.
    /// </summary>
    public interface IRegularPolygon //Convention in C# for interface is to start with char 'I'
    {
        //public int NumberOfSides { get; set; } //The modifier 'public' is not valid for this item Polygon.Library
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
