using System;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissorsGame
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

            string playerMoveOriginal = Console.ReadLine();
            string playerMove = playerMoveOriginal.ToLower();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again!");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = string.Empty;

            if (computerRandomNumber == 1)
            {
                computerMove = rock;
            }
            else if (computerRandomNumber == 2)
            {
                computerMove = paper;
            }
            else if (computerRandomNumber == 3)
            {
                computerMove = scissors;
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            if (computerMove == rock && playerMove == paper || computerMove == paper && playerMove == scissors || computerMove == scissors && playerMove == rock)
            {
                Console.WriteLine("You win!");
            }
            else if (computerMove == paper && playerMove == rock || computerMove == scissors && playerMove == paper || computerMove == rock && playerMove == scissors)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
