namespace Oppgaver.ClassStructure;

public class Oppgave330B
{
    public static void Run()
    {
        var school = new ClassHandler.School();
        var students = school.GetStudent("Ola Nordmann");
        var teacher = school.GetTeacher("Elisabeth Turner");
       // Console.WriteLine($"Student: {student}");
        Console.WriteLine($"Teacher: {teacher}");
    }

   
}