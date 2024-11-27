namespace Oppgaver
{
    public class Oppgave329A
    {
        public static void Run()
        {
            var players = new[]
            {
                new Player("Per", 10),
                new Player("Pål", 10),
                new Player("Espen", 10)
            };
            Player.Count(players);

            foreach (var player in players)
            {
                player.ShowNameAndPoints();
            }
        }

        public class Player
        {
            public string PlayerName { get; set; }
            public int PlayerScore { get; set; }
            private static readonly Random Random = new Random();

            public Player(string playerName, int playerScore)
            {
                PlayerName = playerName;
                PlayerScore = playerScore;
            }

            public static void Count(Player[] players)
            {
                for (var round = 1; round <= 10; round++)
                {
                    var playerIndex1 = Random.Next(players.Length);
                    var playerIndex2 = (playerIndex1 + 1 + Random.Next(2)) % players.Length;
                    var player1 = players[playerIndex1];
                    var player2 = players[playerIndex2];
                    player1.Play(player2);
                }
            }

            public void Play(Player player)
            {
                var randomWinner = Random.Next(15);
                if (randomWinner == 1)
                {
                    player.PlayerScore --;
                    PlayerScore++;
                }
                else
                {
                    PlayerScore --;
                    player.PlayerScore ++;
                }
            }

            public void ShowNameAndPoints()
            {
                Console.WriteLine($"{PlayerName} + {PlayerScore}");
            }
        }
    }
}