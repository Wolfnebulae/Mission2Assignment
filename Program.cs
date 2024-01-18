using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int numOfRolls = 0;
        int[] diceArray;
        float numRollsTwo = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator! \n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        numOfRolls = int.Parse(System.Console.ReadLine());
        numRollsTwo = numOfRolls;

        diceArray = (int[])ArrayReturn.CalculateArray(numOfRolls);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls");
        System.Console.WriteLine("Total number of rolls = " +  numOfRolls + "\n");

        for (int i = 0; i < diceArray.Length; i++) 
        {
            int numAsterik = (((int)((diceArray[i] / numRollsTwo) * 100)));
            System.Console.WriteLine((i + 2) + ": " + (new string('*', numAsterik)));
        }

        System.Console.WriteLine("\n Thank you for using the dice throwing simulator. Goodbye!");
    }
}