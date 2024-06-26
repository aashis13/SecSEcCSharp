using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many inputs would you like to enter?");
        int numberOfInputs;
        while (!int.TryParse(Console.ReadLine(), out numberOfInputs) || numberOfInputs <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }

        string[] inputs = new string[numberOfInputs];

        for (int i = 0; i < numberOfInputs; i++)
        {
            Console.WriteLine($"Enter input #{i + 1}:");
            inputs[i] = Console.ReadLine();
        }

        Console.WriteLine("You've entered:");
        foreach (var input in inputs)
        {
            Console.WriteLine(input);
        }
    }
}
