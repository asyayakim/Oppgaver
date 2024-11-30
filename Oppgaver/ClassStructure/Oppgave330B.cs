namespace Oppgaver.ClassStructure;

public class Oppgave330B
{
    public static void Run()
    {
        var school = new ClassHandler.School();
        var students = school.GetStudentList();
        var schedule = school.GenerateSchedule();
        Console.WriteLine("Generated Schedule:");
        foreach (var slot in schedule)
        {
            Console.WriteLine($"{slot.Time} - {slot.Course} in {slot.Room} (Teacher: {slot.Teacher})");
        }
        school.AssignStudentsToRooms();
        school.PrintRooms();

        Console.WriteLine($"Students: {students}");
    }
}