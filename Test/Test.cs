using System;
using Square;

namespace Test
{
    class Test
    {
        static public bool TestOk(Figure t, double result)
        {
            if (Math.Abs(SquareCalculation.Calculate(t) - result) < 0.001)
            {
                Console.WriteLine("Test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Test failed");
                return false;
            }
        }
    }
}
