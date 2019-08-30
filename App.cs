using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class App
    {
        int humanAverage;
        int computerAverage;
        int countHuman;
        int countComputer;

        public App()
        {
            this.humanAverage = 0;
            this.computerAverage = 0;
            this.countHuman = 0;
            this.countComputer = 0;
        }

        public void Run()
        {
            Menu();
            Console.ReadLine();
        }

        public void Menu()
        {         
            HumanGuess humanPlays = new HumanGuess();
            MachineGuess computerPlays = new MachineGuess();

            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                Console.WriteLine("1: Human Guess\t2. Computer Guess\t3. Average Comparison\tESC: Exit");
                cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                        humanAverage += humanPlays.HumanPlay();
                        countHuman++;                        
                        break;
                    case ConsoleKey.D2:
                        computerAverage += computerPlays.MachinePlay();
                        countComputer++;
                        break;
                    case ConsoleKey.D3:
                        humanAverage = humanAverage / countHuman;
                        computerAverage = computerAverage / countComputer;
                        Console.WriteLine($"\nAverage for Human is {humanAverage}\n" +
                            $"Average for Computer is {computerAverage} ");
                        Console.ReadLine();
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);            
        }
    }    
}
