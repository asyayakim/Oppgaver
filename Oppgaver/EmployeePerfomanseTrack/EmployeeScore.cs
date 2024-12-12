namespace Oppgaver.EmployeePerfomanseTrack
{
    public class EmployeeScore
    {
        public string Id { get; }
        public int Score { get; }
        public DateTime Time { get; }

        public EmployeeScore(string id, int score, DateTime dateTime)
        {
            Id = id;
            Score = score;
            Time = dateTime;
        }
        
    }
}