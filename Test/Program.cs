using System;
using Square;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle
            Circle c1 = new Circle(5);
            Console.WriteLine(SquareCalculation.Calculate(c1));
            Debug.Assert(Test.TestOk(c1, 78.54));

            //Triangle
            
            Triangle t1 = new Triangle(3, 5, 4);
            Console.WriteLine(SquareCalculation.Calculate(t1));
            Console.WriteLine(t1.isRectangular());
            Debug.Assert(Test.TestOk(t1, 6));


            //Poligon

            {
                Point p1 = new Point(3, 4);
                Point p2 = new Point(5, 11);
                Point p3 = new Point(12, 8);
                Point p4 = new Point(9, 5);
                Point p5 = new Point(5, 6);
                Polygon pol1 = new Polygon(p1, p2, p3, p4);
                Console.WriteLine(SquareCalculation.Calculate(pol1));
                Debug.Assert(Test.TestOk(pol1, 35));
            }

            {
                Point p1 = new Point(2, 4);
                Point p2 = new Point(3, -8);
                Point p3 = new Point(1, 2);
                Polygon pol1 = new Polygon(p1, p2, p3);
                Console.WriteLine(SquareCalculation.Calculate(pol1));
                Debug.Assert(Test.TestOk(pol1, 7));
            }

            {
                Point p1 = new Point(-4, 5);
                Point p2 = new Point(3, 5);
                Point p3 = new Point(3, -1);
                Point p4 = new Point(-4, -1);
                Polygon pol1 = new Polygon(p1, p2, p3, p4);
                Console.WriteLine(SquareCalculation.Calculate(pol1));
                Debug.Assert(Test.TestOk(pol1, 42));
            }


            
        }
    }
}
