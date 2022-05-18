using System;
using System.Threading.Tasks;
using System.IO;

class Program {
  public static async Task Main()
    {
        string text =
            "A class is the most powerful data type in C#. Like a structure, " +
            "a class defines the data and behavior of the data type. ";

        await File.WriteAllTextAsync("WriteText.txt", text);
        Console.WriteLine("File Created ...");

        var someText = await File.ReadAllTextAsync(@"WriteText.txt");
        Console.WriteLine(someText);
    }
}