using System.ComponentModel.DataAnnotations;
using McMaster.Extensions.CommandLineUtils;

[Command(Name = "hello", Description = "A simple Hello World CLI tool")]
[HelpOption("-h|--help")]
class Program
{
    public static int Main(string[] args)
        => CommandLineApplication.Execute<Program>(args);

    [Option("-n|--name", Description = "The name to greet")]
    public string Name { get; set; } = "World";

    [Option("-c|--count", Description = "Number of times to greet")]
    [Range(1, 100)]
    public int Count { get; set; } = 1;

    private void OnExecute()
    {
        for (var i = 0; i < Count; i++)
        {
            Console.WriteLine($"Hello, {Name}!");
        }
    }
}
