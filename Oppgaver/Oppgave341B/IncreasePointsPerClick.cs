namespace Oppgaver.Oppgave341B
{
    public class IncreasePointsPerClick : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = ' ';

        public IncreasePointsPerClick(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.IncreasePointsPerClick();
        }
    }
}
