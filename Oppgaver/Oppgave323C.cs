namespace Oppgaver;

public class Oppgave323C
{
    public void Run()
    {
        Console.WriteLine("Welcome to Oppgave323C!");
        GameConsole gameConsole = new GameConsole();

        gameConsole.Show();
    }

    class GameConsole
    {
        string[] grid = new string[9]
        {
            "o", " ", " ",
            " ", " ", "o", 
            "×", "×", " "  
        };
    
        public void Show()
        {
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌──────┐");

            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + "│");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i * 3 + j] + " ");
                }

                Console.WriteLine("|");
              
            }

            Console.WriteLine(" └──────┘");
        }
    }
}