namespace Oppgaver.Oppgave341B;

class Exit : ICommand
{
    public char Character { get;} = 'X';

    public void Run()
    {
        Environment.Exit(0);
    }
}