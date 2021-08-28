using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Point
{
    public double x;
    public double y;
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

namespace AbstractClasses.Classes
{
    abstract class Polygon
    {

        public Polygon()
        {
            Vertices = new List<Point>();
            DefaultScaleModifier = 1;
        }

        public Polygon(List<Point> vertices, double scaleModifier)
        {
            Vertices = vertices;
            DefaultScaleModifier = scaleModifier;
        }

        protected abstract List<Point> Vertices { get; set; }
        protected abstract double DefaultScaleModifier { get; set; }

        public Point[] GetTransformedVertices(Point centerPosition, double rotation = 0, double scale = 1)
        {

            Point[] transformedVertices = Vertices.ToArray<Point>();

            Point p;

            rotation = rotation / 180 * Math.PI;

            for (int i = 0; i < transformedVertices.Count(); i++)
            {
                p = transformedVertices[i];

                p.x = (p.x * Math.Cos(rotation) + p.y * Math.Sin(rotation))
                    * scale * DefaultScaleModifier
                    + centerPosition.x;
                p.y = (-transformedVertices[i].x * Math.Sin(rotation) + p.y * Math.Cos(rotation))
                    * scale * DefaultScaleModifier
                    + centerPosition.y;

                transformedVertices[i] = p;
            }

            return transformedVertices;

        }

        public static void DrawPolygon(Point[] vertices)
        {

            Console.WriteLine("Draw polygon!");
            StringBuilder sb = new StringBuilder();
            foreach (Point vertex in vertices)
                sb.Append($"({vertex.x}, {vertex.y}); ");
            Console.WriteLine(sb.ToString());

        }

    }
}
