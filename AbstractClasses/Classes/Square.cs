using System.Collections.Generic;

namespace AbstractClasses.Classes
{
    class Square : Polygon
    {
        public Square()
        {

            Vertices = new List<Point>() {new Point(-1, -1),
                                          new Point(-1, 1),
                                          new Point(1, 1),
                                          new Point(1, -1)};

            DefaultScaleModifier = 40;

        }

        protected override List<Point> Vertices { get; set; }
        protected override double DefaultScaleModifier { get; set; }

    }
}
