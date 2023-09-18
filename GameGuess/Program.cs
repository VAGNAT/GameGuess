using GameGuess.Game;
using GameGuess.Game.Interfaces;
using GameGuess.Output;
using GameGuess.Output.Interfaces;
using GameGuess.Resources;
using GameGuess.Secrets;

bool exit = false;

IOutput output = new ConsoleOutput();
output.WriteLine(Message.Welcome);

IOutputGameMessage outputGame = new ConsoleOutputGame();
ISecret<int> secret = new SecretNumber();

while (!exit)
{
    output.WriteLine(Message.SelectGame);
    string? input = Console.ReadLine();
    if (input is null)
    {
        break;
    }

    IGame? game;

    switch (input.ToUpper())
    {
        case "Q":
            exit = true;
            break;
        case "1":
            game = new GuessNumber(outputGame, secret);
            game.Start();
            break;
        case "2":
            game = new GuessNumberLimitedAttempts(outputGame, secret);
            game.Start();
            break;
        default:
            output.WriteLine(Message.DefectString);
            break;
    }    
}

