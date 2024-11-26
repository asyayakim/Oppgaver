namespace Oppgaver;

public class Oppgave323C
{
    public void Run()
    {
        Console.WriteLine("Welcome to Oppgave323C!");
        GameConsole gameConsole = new GameConsole();
        int numTurns = 0;
        bool player1Turn = true;

        while (!gameConsole.CheckVictory() && numTurns != 9)
        {
            gameConsole.Show();
            if (player1Turn)
                Console.WriteLine("Player 1 Turn");
            else
                Console.WriteLine("Player 2 Turn");
            string? choice = Console.ReadLine();
            if (int.TryParse(choice, out int gridIndex) && gridIndex>= 1 
                                                        && gridIndex <= 9
                                                        && gameConsole.Grid[gridIndex -1]!= "X"
                                                        && gameConsole.Grid[gridIndex - 1] != "O")
            {
                gridIndex--;
                gameConsole.Grid[gridIndex] =  player1Turn ? "O" : "X";
                numTurns++;
                player1Turn = !player1Turn;
                Console.WriteLine($"Turn :{numTurns}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        gameConsole.Show();
        if (gameConsole.CheckVictory())
        {
            Console.WriteLine("You Win!");
        }
        else
        {
            Console.WriteLine("It is a draw!");
        }
    }

    class GameConsole
    {
        public string[] Grid = new string[9]
        {
            "1", "2", "3",
            "4", "5", "6",
            "7", "8", "9"
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
                    Console.Write(Grid[i * 3 + j] + " ");
                }

                Console.WriteLine("|");
            }

            Console.WriteLine(" └──────┘");
        }

        public bool CheckVictory()
        {
            bool row1 = Grid[0] == Grid[1] && Grid[1] == Grid[2];
            bool row2 = Grid[3] == Grid[4] && Grid[4] == Grid[5];
            bool row3 = Grid[6] == Grid[7] && Grid[7] == Grid[8];
            bool col1 = Grid[0] == Grid[3] && Grid[3] == Grid[6];
            bool col2 = Grid[1] == Grid[4] && Grid[4] == Grid[7];
            bool col3 = Grid[2] == Grid[5] && Grid[5] == Grid[8];
            bool diagDown = Grid[0] == Grid[4] && Grid[4] == Grid[8];
            bool diagUp = Grid[6] == Grid[4] && Grid[4] == Grid[2];

            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }
    }
}