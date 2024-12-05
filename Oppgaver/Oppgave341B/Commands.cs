namespace Oppgaver.Oppgave341B;

public class Commands
{
    private ICommand[] _commands;
    public Commands(ClickerGame game)
    {
        _commands = new ICommand[]
        {
            new Exit(),
            new IncreasePointsPerClick(game),
            new BuyPointsPerClick(game),
            new BuySuperPointsPerClick(game)
        };
    }
    public void Run(char commandChar)
    {
        var command = FindCommand(commandChar);
        if (command != null) command.Run();
        {
            command.Run();
        }
    }

    private ICommand FindCommand(char commandChar)
    {
        foreach (var command in _commands)
        {
            if (command.Character == commandChar) return command;
        }

        return null;
    }
}