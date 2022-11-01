namespace CSharp_AsyncAwait2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //result: 2,1,3
            //TaskOnly.Execute();

            //result: 3,1,2
            //TaskOnly2.Execute();

            //result 3,1,2
            //Check code, interesting plot-twist.
            AsyncTask.Execute();
        }

    }
}