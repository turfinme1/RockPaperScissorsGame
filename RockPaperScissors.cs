using System;

const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
string computerMove = null;
string playerMove=null;
int playerWins = 0;
int computerWins = 0;
while (true)
{
    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
    playerMove = Console.ReadLine().ToLower();
    if (playerMove=="end")
    {
        break;
    }
    switch (playerMove)
    {
        case "r":
        case "rock":
            playerMove = Rock;
            break;
        case "p":
        case "paper":
            playerMove = Paper;
            break;
        case "s":
        case "scissors":
            playerMove = Scissors;
            break;
        default:
            Console.WriteLine("Invalid input. Try again...");
            continue;
    }

    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);
    switch (computerRandomNumber)
    {
        case 1:
            computerMove = Rock;
            break;
        case 2:
            computerMove = Paper;
            break;
        case 3:
            computerMove = Scissors;
            break;
        default:
            break;
    }
    switch ((playerMove, computerMove))
    {
        case (Rock, Scissors):
        case (Paper,Rock):
        case (Scissors, Paper):
            playerWins++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"The CPU chose {computerMove}. ");
            Console.WriteLine($"Your {playerMove} beats {computerMove}.\nPlayer score: {playerWins}, CPU score: {computerWins}");
            break;
        case (Rock, Paper):
        case (Paper, Scissors):
        case (Scissors, Rock):
            computerWins++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"The CPU chose {computerMove}. ");
            Console.WriteLine($"Your {playerMove} loses against {computerMove}.\nPlayer score: {playerWins}, CPU score: {computerWins}");
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"The CPU chose {computerMove}. ");
            Console.WriteLine($"It's a draw.\nPlayer score: {playerWins}, CPU score: {computerWins}");
            break;
    }
    Console.ResetColor();
}