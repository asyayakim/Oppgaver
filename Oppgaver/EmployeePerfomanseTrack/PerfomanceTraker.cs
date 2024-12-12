using System.Runtime.CompilerServices;

namespace Oppgaver.EmployeePerfomanseTrack
{
    public class PerformanceTracker
    {
        public List<EmployeeScore> _listOfEmployees = new ();
        public void RecordScore(string id, int score, DateTime dateTime)
        {
            var employeeScore = new EmployeeScore(id, score, dateTime);
            _listOfEmployees.Add(employeeScore);
        }

        public void FindHighestScore()
        {
            var score = _listOfEmployees.OrderByDescending(e => e.Score);
            Console.WriteLine($"Highest - " + score.First().Score + " Lowest - " + score.Last().Score);
        }
    }
}
