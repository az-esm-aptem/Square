using System;


namespace Square
{
    public class Polygon:Figure
    {
        Point[] coordinates; //координаты вершин многоугольника
        double[,] coordMatrix;
        int tops;
        public Polygon(params Point[]coord) : base()
        {
            tops = coord.Length;
            coordinates = new Point[tops];
            coord.CopyTo(coordinates, 0);
            coordMatrix = new double[2, tops];
            
        }

        public void setMatrix() //составление матрицы
        {
            for (int j = 0; j < tops; j++)
            {
                coordMatrix[0, j] = coordinates[j].x; //1-й столбец x
            }
            for (int j = 0; j < tops; j++)
            {
                coordMatrix[1, j] = coordinates[j].y; //2-й столбец y
            }
        }
        

        public override double squareCalculation()  //метод Гаусса
        {
            setMatrix();
            double plusTmp = 0;
            double minusTmp = 0;
            for (int i = 0; i < tops; i++)
            {
                if (i == tops - 1)
                {
                    plusTmp += coordMatrix[0, i] * coordMatrix[1, 0]; //умножение последнего x на первый y
                    minusTmp += coordMatrix[1, i] * coordMatrix[0, 0]; //умножение последнего y на первый x
                }
                else
                {
                    plusTmp += coordMatrix[0, i] * coordMatrix[1, i + 1]; //x1*y2  и т.д.
                    minusTmp += coordMatrix[1, i] * coordMatrix[0, i + 1]; //y1*x2 и т.д.
                }
            }
            return 0.5 * Math.Abs(plusTmp - minusTmp);

            



        }
    }
}
