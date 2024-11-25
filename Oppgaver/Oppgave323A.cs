namespace Oppgaver;

public class Oppgave323A
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();
        var match = new Match(bet);
       
        while (match.MatchIsRunning)
        {
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            string? command = Console.ReadLine();
            match.GoalsVerdict(command);
            
            Console.WriteLine($"Stillingen er {match.Result()}.");
        }

        var result = match.CheckBet();
        var isBetCorrect = bet != null && bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        Console.WriteLine($"Du tippet {isBetCorrectText}");
    }

    public class Match
    {
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        private readonly string? _bet;
        public bool MatchIsRunning { get; set; }

        public Match(string? bet)
        {
            _bet = bet;
            MatchIsRunning = true;
        }
        public void GoalsVerdict(string? command)
        {
            if (command == "H") HomeGoals++;
            else if (command == "B") AwayGoals++;
            else if (command == "X")
            {
                MatchIsRunning = false;
            }
            else
            {
                Console.WriteLine("Not a valid command");
            }
        }

        public string CheckBet()
        {
            string s = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
            return s; 
        }
        public string Result()
        {
            return HomeGoals+ "-" + AwayGoals;
        }
    }
}

