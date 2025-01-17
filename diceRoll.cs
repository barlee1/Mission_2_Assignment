
namespace ConsoleApp2;
public class diceRoll
{
    public static int[] DiceRoll(int rollCount)
    {
        Random random = new Random();
        int[] totalrolls = new int[13];
        for (int iCount = 0; iCount < rollCount; iCount++)
        {
            int dice1 = random.Next(1, 7); // Generates a number between 1 and 6 (upper bound is exclusive)
            int dice2 = random.Next(1, 7);

            int finaldice = dice1 + dice2;
            totalrolls[finaldice]++;
        }
    
        return totalrolls;
    } 
    
}
