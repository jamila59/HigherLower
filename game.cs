using System;
using System.Collections.Generic;

 public class HigherLower 
 {
     public int LowerNum;
     public int HigherNum;
     public int Guess;

    public static HigherLower()
    {
        int LowerNum = lowernum;
        int HigherNum = highernum;
        int Guess = ((HigherNum + LowerNum) / 2);
    }
    public static void Main()
    {
        HigherLower instance = new HigherLower(1, 100);
        Guess = ((HigherNum + LowerNum) / 2);
        Console.WriteLine("Is you number higher or lower than", Guess);
        string response = Console.ReadLine();
        while (response != "correct") 
        {
            if (response == "higher")
            {
                LowerNum = Guess;
            }
            else if (response == "lower")
            {
                HigherNum = Guess; 
            } 
            else 
            {
                Console.WriteLine("Your number is", Guess);
            }
            Guess = ((HigherNum + LowerNum) / 2);
            Console.WriteLine("Is you number higher or lower than", Guess);
        }

    }  
 }    
 