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
        public int FindHighestScore()
        {
            var score = _listOfEmployees.OrderByDescending(e => e.Score);
            return score.First().Score;
            
        }
        public int FindLowestScore()
        {
            var score = _listOfEmployees.OrderByDescending(e => e.Score);
            return score.Last().Score;
        }
        public void FindEmployeeNameByScore(int lowest, List<Employees> employees)
        {
            var id = _listOfEmployees.Find(e => e.Score == lowest)?.Id;
            
            foreach (var employee in employees)
            {
                if (employee.Id == id)
                {
                    var nameScore = employee.Name;
                    Console.WriteLine(nameScore);
                }
            }
        }
    }
}
