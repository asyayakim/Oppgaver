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
            if (gameConsole.Grid.Contains(choice) && choice!= "X" && choice != "O")
            {
                int gridIndex = Convert.ToInt32(choice) - 1;
 
                if (player1Turn)
                    gameConsole.Grid[gridIndex] = "X";
                else
                    gameConsole.Grid[gridIndex] = "O";
                numTurns++;
                Console.WriteLine(numTurns);
            }
            player1Turn = !player1Turn;
        }
        gameConsole.Show();
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