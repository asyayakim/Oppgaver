namespace Oppgaver.Oppgave341B
{
    public class ClickerGame
    {
        public int Points { get; set; }
        public int PointsPerClick = 1;
        public int PointsPerClickIncrease = 1;

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void IncreasePointsPerClick()
        {
            Points += PointsPerClick;
        }

        public void BuyPointsPerClick()
        {
            Points -= 10;                                   
            PointsPerClick += PointsPerClickIncrease;  
        }

        public void BuySuperPointsPerClick()
        {
            Points -= 100;            
            PointsPerClickIncrease++; 
        }
    }
}

