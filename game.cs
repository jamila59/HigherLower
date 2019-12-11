using System;
using System.Collections.Generic;

public class HighLow
{
    public int HighNum;
    public int LowNum;
    public int Guess;
    public string Hint;

    public HighLow (int highNum, int lowNum)
    {
        HighNum = highNum;
        LowNum = lowNum;
    }

    public void Guessing()
    {
        Guess = (HighNum+LowNum)/2;
        Console.WriteLine("Is your number higher or lower than "+Guess+"? (Higher/Lower/Correct)");
        Hint = Console.ReadLine();
        while (Hint != "Correct")
        {
            
            if (Hint == "Higher")
            {
                LowNum = Guess;
                Console.WriteLine("Lower number: "+ LowNum);
            }
            else if (Hint == "Lower")
            {
                HighNum = Guess;
                Console.WriteLine("Higher number: "+ HighNum);
            }
            Guess = (HighNum+LowNum)/2;
            Console.WriteLine("Is your number higher or lower than "+Guess+"? (Higher/Lower/Correct)");
            Hint = Console.ReadLine();
            
            
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Would you like to play the Higher/Lower game? (Yes/No)");
        string choice = Console.ReadLine();
        while (choice == "Yes")
        {
            HighLow gameTime = new HighLow(100,0);
            Console.WriteLine("Okay");
            gameTime.Guessing();
            Console.WriteLine("Great! I guessed your number.  Would you like to play again? (Yes/No)");
            choice = Console.ReadLine();
        }

    }
}