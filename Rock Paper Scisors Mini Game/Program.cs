
using System;
class Program
{
    static void Main()
    {
        bool playerWantsToPlayAgain = true;
        while (playerWantsToPlayAgain)
        {
            string[] moves = { "Rock", "Paper", "Scissors" };
            Random rd = new Random();
            var randomIndex = rd.Next(0, moves.Length);
            string computerMove = moves[randomIndex];

            Console.WriteLine($"Please pick your move: {moves[0]}, {moves[1]} or {moves[2]}.");


            string playerMove = Console.ReadLine();

            while (playerMove != moves[0] && playerMove != moves[1] && playerMove != moves[2])
            {
                Console.WriteLine($"{playerMove} is not valid move, please pick: {moves[0]}, {moves[1]} or {moves[2]}.");
                playerMove = Console.ReadLine();
            }

            Console.WriteLine($"Your pick: {playerMove}, computer picks: {computerMove}.");

            if (computerMove == playerMove)
            {
                Console.WriteLine("This is a tie!");
            }
            else
            {
                bool playerWinCoditionsOne = playerMove == moves[0] && computerMove == moves[2];
                bool playerWinCoditionsTwo = playerMove == moves[1] && computerMove == moves[0];
                bool playerWinCoditionsThree = playerMove == moves[2] && computerMove == moves[1];

                if (playerWinCoditionsOne || playerWinCoditionsTwo || playerWinCoditionsThree)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
            }
            Console.WriteLine("================================");
            Console.WriteLine("Do you want to play again? [y/n]");
            string playerChoise = Console.ReadLine();
            while(playerChoise != "y" && playerChoise != "n")
            {
                Console.WriteLine("Please pick \"y\" or \"n\" ");
                playerChoise = Console.ReadLine();
            }
            if (playerChoise == "n")
            {
                playerWantsToPlayAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing the game!");
    }
}