using Random = System.Random;

namespace Oppgaver.ConsoleStarsTilOppgaveInterface_main
{
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random();
            List<IStars> stars = new List<IStars>
            {
                new PhasesStar(random),
                new PhasesStar(random),
                new PhasesStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
            };
            while (true)
            {
                Console.Clear();     
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
