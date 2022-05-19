// Created by: Kenny Le
// Created on: May 2022
//
// This program saves to local storage

using System;
using System.Threading.Tasks;
using System.IO;

class Program {
  public static async Task Main()
    {
        int yes = 1;
        string no;
        int counter = 0;
        string text;
      
        Console.WriteLine("Do you want to quit the program?");
        Console.WriteLine("");
        Console.WriteLine("Type 'yes' to end the program or type 'no' to add 1 to the counter");
        yes = Convert.ToInt32(Console.ReadLine());
        no = Convert.ToString(Console.ReadLine());


        text =
            "Number: ";

        await File.WriteAllTextAsync("WriteText.txt", text);
        Console.WriteLine("File Created ...");

        var someText = await File.ReadAllTextAsync(@"WriteText.txt");
        Console.WriteLine(someText);
    }
}