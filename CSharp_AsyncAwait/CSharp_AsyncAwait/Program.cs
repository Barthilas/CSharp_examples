using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://raw.githubusercontent.com/l3oxer/Doggo/main/README.md";

        Stopwatch sw = new Stopwatch();
        sw.Start();
        var tasks = new List<Task> { SummonDogLocally(), SummonDogFromURL(url) };
        await Task.WhenAll(tasks);

        sw.Stop();
        Console.Write("Finished in: " + sw.Elapsed.TotalSeconds);
    }


    ///Never use async with void, unless for example with click events (void delegates)
    static async Task<string> SummonDogLocally()
    {
        Console.WriteLine("1. Summoning Dog Locally ...");

        string dogText = await File.ReadAllTextAsync("doge.txt");

        //Simulate that it does indeed run parallel.
        Thread.Sleep(1000);

        Console.WriteLine($"2. Dog Summoned Locally \n{dogText}");

        return dogText;
    }

    static async Task SummonDogFromURL(string url)
    {
        Console.WriteLine("1. Summoning Dog from URL ...");

        using (var httpClient = new HttpClient())
        {
            string result = await httpClient.GetStringAsync(url);
            Console.WriteLine($"2. Dog Summoned from URL \n{result}");
        }

    }
}
