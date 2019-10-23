using System;


namespace Square
{
    public class Circle:Figure
    {
        Point centre; //центр круга (опционально)
        public double radius { get; private set; }   //радиус окружности 
        public Circle(double r, double x = 0, double y = 0) : base()
        {
            centre = new Point(x, y);
            if (r >= 0) // проверка радиуса
            {
                radius = r;
            }
            else
            {
                throw new Exception("Negative radius");
            }
            
        }
        public override double squareCalculation() //вычисление площади
        {
            return (Math.PI * radius * radius);
        }
    }
}
