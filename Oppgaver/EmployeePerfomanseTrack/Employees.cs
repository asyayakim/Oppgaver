namespace Oppgaver.EmployeePerfomanseTrack
{
    public class Employees
    {
        public Employees(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
    internal partial record PerformanceTracker
    {
        public void RecordScore(Employees employee)
        {
        }

        public void RecordScore(string employee, int i, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}