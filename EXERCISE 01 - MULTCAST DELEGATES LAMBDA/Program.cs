using System;
using Services;
namespace EXERCISE_01___MULTCAST_DELEGATES_LAMBDA {
    delegate void BinaryNumericOperatiom(double n1, double n2);
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinaryNumericOperatiom op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            


        }
    }
}
