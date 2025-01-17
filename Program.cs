// See https://aka.ms/new-console-template for more information

using ConsoleApp2;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int rollCount = int.Parse(Console.ReadLine());
        
        int[] totalrolls = diceRoll.DiceRoll(rollCount);
        
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            double result = ((double)totalrolls[iCount] / rollCount) * 100;
            Console.Write($"{iCount}: ");
            
            for (int i = 0; i < result; i++)
            {
                 Console.Write("*");
            }
        
            Console.WriteLine();
        }

    }
    
}