using System;
using System.Collections.Generic;
using System.Linq;
using AbstractClasses.Classes;

// Создать абстрактный класс, 2-3 функции, 2-3 свойства
// 2-4 функции, которые принимают в себя класс и работают с ними

namespace AbstractClasses
{
    class Program
    {

        static void DrawInitialPolygons(List<Polygon> polygons, Point[] centers)
        {

            for (int i = 0; i < centers.Count(); i++)
            {
                Polygon.DrawPolygon(polygons[i].GetTransformedVertices(centers[i]));
            }

        }

        static void Main(string[] args)
        {

            List<Polygon> polygons = new List<Polygon>() { new Triangle(), new Square() };
            Point[] centers = new Point[2];
            centers[0].x = 31;
            centers[0].y = 200;
            centers[1].x = 0;
            centers[1].y = 0;

            DrawInitialPolygons(polygons, centers);

            Square square = new Square();

            Polygon.DrawPolygon(square.GetTransformedVertices(new Point(0, 0), 93, 2));

            Console.ReadKey();

        }
    }
}
