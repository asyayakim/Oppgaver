namespace Oppgaver.Oppgave341B
{
    class BuyPointsPerClick : ICommand

    {
        private ClickerGame _game;
        public BuyPointsPerClick(ClickerGame game)
        {
            _game = game;
        }
        public char Character { get; } = 'K';
        public void Run()
        {
            _game.BuyPointsPerClick();
        }
    }
}

