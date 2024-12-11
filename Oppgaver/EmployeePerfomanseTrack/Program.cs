// namespace Oppgaver.EmployeePerfomanseTrack;
//
// public class Program
// {
//     static void Main(string[] args)
//     {
//         List<Employees> employees = new List<Employees>
//         {
//             new Employees("Jane Doe", "001"),
//             new Employees("John Smith", "002"),
//             new Employees("Alice Johnson", "003"),
//             new Employees("Robert Brown", "004")
//         };
//         var performanceTracker = new PerformanceTracker();
//
//         performanceTracker.RecordScore("001", 85, new DateTime(2024, 12, 1));
//         performanceTracker.RecordScore("001", 90, new DateTime(2024, 12, 5));
//
//         performanceTracker.RecordScore("002", 75, new DateTime(2024, 12, 2));
//         performanceTracker.RecordScore("002", 80, new DateTime(2024, 12, 6));
//         performanceTracker.RecordScore("002", 78, new DateTime(2024, 12, 9));
//
//         performanceTracker.RecordScore("003", 95, new DateTime(2024, 12, 3));
//
//         performanceTracker.RecordScore("004", 60, new DateTime(2024, 12, 1));
//         performanceTracker.RecordScore("004", 65, new DateTime(2024, 12, 4));
//
//         foreach (var employee in employees)
//         {
//             PrintHighestScore(employee, performanceTracker);
//         }
//     }
//
//     private static void PrintHighestScore(Employees employee, PerformanceTracker performanceTracker)
//     {
//         var highestScore = performanceTracker.RecordScore(employee);
//     }
// }
//
