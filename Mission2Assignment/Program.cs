// See https://aka.ms/new-console-template for more information
namespace Mission2Assignment;
internal class Program
{
    private static void Main(string[] args)
    {
        CalculateRolls cr = new CalculateRolls();
            
        Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
                          "How many dice rolls would you like to simulate?");

        int count = int.Parse(Console.ReadLine());

        
        int[] rollCounts = cr.SimulateRolls(count);
        
        PrintRolls(rollCounts, count);
    }

    private static void PrintRolls(int[] rollCounts, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");
        Console.WriteLine();
        
        for (int i = 0; i < rollCounts.Length; i++)
        {
            int rollValue = i + 2; 
            double percent = (rollCounts[i] / (double)totalRolls) * 100.0;

            int stars = (int)Math.Round(percent);

            Console.Write($"{rollValue}: ");
            Console.WriteLine(new string('*', stars));
        }
        
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
