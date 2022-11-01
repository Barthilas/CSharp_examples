namespace CSharp_AsyncAwait2
{
    public class AsyncTask
    {
        /// <summary>
        /// How asynchronous programming should be handled nowadays.
        /// </summary>
        /// <returns></returns>
        public static async Task Execute()
        {
            //This will print first, because its awaited
            //await Calculate1_2();

            //Calculate 3 first then rest, because its not awaited. Save to variable to remove the C# warning.
            Task delayTask = Calculate1_2();
            Calculate3();
            Console.Read();
        }

        //DO NOT PAIR ASYNC WITH VOID, UNLESS ITS CLICK DELEGATE/EVENT.
        async static Task Calculate1_2()
        {
            var result1 = await Task.Run(() =>
            {
                return Calculate1();
            });

            Calculate2(result1);
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