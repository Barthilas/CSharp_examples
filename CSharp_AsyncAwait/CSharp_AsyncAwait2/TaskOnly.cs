using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AsyncAwait2
{
    /// <summary>
    /// How it was done before Async/Await.
    /// </summary>
    public class TaskOnly
    {
        public static void Execute()
        {
            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });
            var task2 = Task.Run(() =>
            {
                return Calculate2();
            });

            //Blocks thread till these tasks finish. Difference from "WhenAll".
            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();

            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate3(result1, result2);
        }

        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculate result 1");
            return 100;
        }

        static int Calculate2()
        {
            Console.WriteLine("Calculate result 2");
            return 200;
        }

        static int Calculate3(int result1, int result2)
        {
            Console.WriteLine("Calculate result 3");
            return result1 + result2;
        }
    }


}
