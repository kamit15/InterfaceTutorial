using System;

namespace Polygons
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        //private int _numberOfSides; // Name of backing field

        //public int NumberOfSides // Name of property
        //{
        //    get { return _numberOfSides; }  //Getter and Setter to access backing field
        //    set { _numberOfSides = value; }
        //}

        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
