using Mission2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        RollDice roller = new RollDice();

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        int numRolls = int.Parse(Console.ReadLine());

        int[] results = roller.DiceRoll(numRolls);

        PrintHistogram(results, numRolls);
    }

    static void PrintHistogram(int[] results, int numRolls)
    {
        Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS:\nEach '*' represents 1% of the total number of rolls. \nTotal number of rolls = {numRolls}");
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (results[i] * 100) / numRolls;
            Console.Write($"{i}: {new string('*', percentage)}  \n");
        }
    }
}