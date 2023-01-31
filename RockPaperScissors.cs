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
    if ((playerMove == Rock && computerMove == Scissors) ||
        (playerMove == Paper && computerMove == Rock) ||
        (playerMove == Scissors && computerMove == Paper))
    {
        playerWins++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"The CPU chose {computerMove}. ");
        Console.WriteLine($"Your {playerMove} beats {computerMove}.\nPlayer score: {playerWins}, CPU score: {computerWins}");
    }
    else if ((playerMove == Rock && computerMove == Paper) ||
             (playerMove == Paper && computerMove == Scissors) ||
             (playerMove == Scissors && computerMove == Rock))
    {
        computerWins++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"The CPU chose {computerMove}. ");
        Console.WriteLine($"Your {playerMove} loses against {computerMove}.\nPlayer score: {playerWins}, CPU score: {computerWins}");
    }
    else if ((playerMove == Rock && computerMove == Rock) ||
             (playerMove == Paper && computerMove == Paper) ||
             (playerMove == Scissors && computerMove == Scissors))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"The CPU chose {computerMove}. ");
        Console.WriteLine($"You and the CPU chose {playerMove}. It's a draw.\nPlayer score: {playerWins}, CPU score: {computerWins}");
    }
    Console.ResetColor();
}