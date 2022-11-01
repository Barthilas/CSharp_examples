using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lambdas
{
    public class MathServiceByDelegate
    {
        //Delegate way
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public event MathPerformedHandler MathPerformed;
        public delegate void MathPerformedHandler(double result);
        public delegate double CalculationHandler(double value1, double value2);

        public void MultiplyNumbers(double value1, double value2)
        {
            System.Timers.Timer time = new System.Timers.Timer(5000);
            //MathPerformed(this, new MathPerformedEventArgs { Result = value1 * value2 });
            MathPerformed(value1 * value2);
        }

        //level 2 modify operation on numbers by delegate
        public void CalculateNumbers(double value1, double value2, CalculationHandler calculation)
        {
            System.Timers.Timer time = new System.Timers.Timer(5000);
            MathPerformed(calculation(value1, value2));
        }
    }
}
