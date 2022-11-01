using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lambdas
{
    public class MathServiceByEvent
    {
        //Event way
        public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public void MultiplyNumbers(double value1, double value2)
        {
            System.Timers.Timer time = new System.Timers.Timer(5000);
            MathPerformed(this, new MathPerformedEventArgs { Result = value1 * value2 });
        }
    }
}
