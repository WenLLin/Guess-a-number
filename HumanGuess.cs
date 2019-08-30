using System;

namespace GuessNumber
{
    class HumanGuess
    {
        public int HumanPlay()
        {
            Random rand = new Random();
            int computerPick = rand.Next(1, 1000);
            int count = 0;

            while (true)
            {   
                Console.WriteLine("\nTake a guess between number 1 - 1000: ");
                int humanGuess = Convert.ToInt32(Console.ReadLine());

                if (humanGuess == computerPick)
                {
                    Console.WriteLine("You guessed the number");
                    break;
                }
                else if (humanGuess < computerPick)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else if (humanGuess > computerPick)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                count++;
            }
            Console.WriteLine($"It took you {count} guesses.");
            Console.ReadLine();
            return count;
        }
    }
}
