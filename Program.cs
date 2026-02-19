
using System;

class Program
{
    static void Main()
    {
        //secret string 
        string secret = "bfcg";

        string guess = "";
        int guessCount = 0;

        Console.WriteLine("I have chosen 4 letters between a and g.");
        Console.WriteLine("Guess the corect order.");
        Console.WriteLine();

        // Loop until correct answer
        do
        {
            guessCount++;

               Console.WriteLine("Guess #" + guessCount);
              Console.Write("Enter 4 lowercase letters and you can't repeat: ");
            guess = Console.ReadLine();

            int rightSpot = 0;
            int wrongSpot = 0;

            // check each spot in the guess
            for (int i = 0; i < secret.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    // correct and in the right spot
                    rightSpot++;
                }
                else
                {
                    // see if letter is somewhere else
                    for (int j = 0; j < secret.Length; j++)
                    {
                        if (guess[i] == secret[j])
                        {
                            wrongSpot++;
                        }
                    }
                }
            }

            // clues
            if (guess != secret)
            {
                Console.WriteLine("- " + rightSpot + " is in the right position");
                Console.WriteLine("- " + wrongSpot + " is in the wrong position");
                Console.WriteLine();
            }

        } while (guess != secret);

        Console.WriteLine();
        Console.WriteLine("You guessed it in " + guessCount + " tries. Great job.");
    }
}
