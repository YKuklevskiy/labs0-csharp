using System.Collections.Generic;

namespace AbstractClasses.Classes
{
    class Triangle : Polygon
    {
        public Triangle()
        {

            Vertices = new List<Point>() {new Point(0, 2),
                                          new Point(1.5, -1),
                                          new Point(-1.5, -1)};

            DefaultScaleModifier = 30;

        }

        protected override List<Point> Vertices { get; set; }
        protected override double DefaultScaleModifier { get; set; }

    }
}
