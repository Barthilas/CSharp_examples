namespace CSharp_AsyncAwait2
{
    /// <summary>
    /// How it was done before Async/Await another example.
    /// </summary>
    public static class TaskOnly2
    {
        public static void Execute()
        {
            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });
            var awaiter1 = task1.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {
                var result1 = awaiter1.GetResult();
                Calculate2(result1);
            });
            Calculate3();
            //wait
            Console.Read();
        }


        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculate result 1");
            return 100;
        }

        static int Calculate2(int result1)
        {
            Console.WriteLine("Calculate result 2");
            return result1 * 2;
        }

        static int Calculate3()
        {
            Console.WriteLine("Calculate result 3");
            return 300;
        }
    }
}