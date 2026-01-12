namespace Mission2Assignment;

internal class CalculateRolls
{
    private int[] countRolls;
    
    public int[] SimulateRolls(int rolls)
    {
        countRolls = new int[11];
        Random rand = new Random();

        for (int i = 0; i < rolls; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;
            
            countRolls[sum - 2]++;  
        }
        return countRolls;
    }
}