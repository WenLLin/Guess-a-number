using System;

namespace GuessNumber
{
    class MachineGuess
    {
        public int MachinePlay()
        {
            Console.WriteLine("\nPick a number between 1 - 100: ");
            int humanPick;
            int count = 0;
            var isValid = int.TryParse(Console.ReadLine(), out humanPick);

            while(!isValid && (humanPick < 1 && humanPick > 101))
            {
                Console.WriteLine("\nInvalid input");
                Console.WriteLine("\nPick a number between 1 - 100: ");
                isValid = int.TryParse(Console.ReadLine(), out humanPick);
            }

            int machineGuess = 50;
            while (true)
            {

                if (machineGuess == humanPick)
                {
                    Console.WriteLine("\nHuman said: You got it!");
                    break;
                }
                else if (machineGuess > humanPick)
                {
                    Console.WriteLine("\nHuman said: too high.");
                    machineGuess /= 2;
                    Console.WriteLine(machineGuess);
                }
                else if (machineGuess < humanPick)
                {
                    Console.WriteLine("\nHuman said: too low.");
                    machineGuess = machineGuess + ((100 - machineGuess) / 2);
                    Console.WriteLine(machineGuess);
                }
                else
                {
                    Console.WriteLine("\nOops, something went wrong.");
                }                
                count++;
            }            
            Console.WriteLine($"It took computer {count} guesses.");
            Console.ReadLine();

            return count;
        }
    }
}
