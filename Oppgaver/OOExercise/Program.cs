namespace Oppgaver.OOExercise;

public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Ola", 19),
            new Person("Magne", 9),
            new Person("Oyvind", 30),
            new Person("Ann", 40),
            new Person("Tarje", 90),
        };
        foreach (var person in people)
        {
            Console.WriteLine(person.Name + " - " + person.CheckAge());
        }
    }
}