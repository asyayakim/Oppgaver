namespace Oppgaver.Oppgave341B
{
    class BuySuperPointsPerClick : ICommand
    {
        private ClickerGame _game;
        public char Character { get; set; } = 'S';

        public BuySuperPointsPerClick(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.BuySuperPointsPerClick();
        }
    }
}

