using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Square
{
    public class Triangle:Figure
    {
        public List<double> sides;  //стороны треугольника

        public Triangle(double side1, double side2, double side3) : base()
        {
            if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2) //проверка на существование треугольника
            {
                sides = new List<double> { side1, side2, side3 };           
            }
            else
            {
                throw new Exception("Triangle does not exist");
            }
        }

        public override double squareCalculation() //вычисление площади
        {
            double p = sides.ToArray().Sum()/2.0;
            double temp = p;
            foreach (var i in sides)
            {
                temp *= (p - i);
            }
            return Math.Sqrt(temp);
        }

        public bool isRectangular() //проверка на прямоуголность
        {
            if (sides.ElementAt(0) * sides.ElementAt(0) + sides.ElementAt(1) * sides.ElementAt(1) == sides.ElementAt(2) * sides.ElementAt(2)) return true;
            else if (sides.ElementAt(1) * sides.ElementAt(1) + sides.ElementAt(2) * sides.ElementAt(2) == sides.ElementAt(0) * sides.ElementAt(0)) return true;
            else if (sides.ElementAt(2) * sides.ElementAt(2) + sides.ElementAt(0) * sides.ElementAt(0) == sides.ElementAt(1) * sides.ElementAt(1)) return true;
            else return false;
        }
    }
}
