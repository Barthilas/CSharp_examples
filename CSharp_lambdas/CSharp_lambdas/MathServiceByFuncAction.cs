using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lambdas
{
    //replace delegates with Func<T> and Action<T> (no return type)
    public class MathServiceByFuncAction
    {
        public Action<double> MathPerformed;
        public Func<double, double, double> CalculationHandler;
        public void CalculateNumbers(double value1, double value2, Func<double, double, double> calculation)
        {
            System.Timers.Timer time = new System.Timers.Timer(5000);
            MathPerformed(calculation(value1, value2));
        }
    }
}
