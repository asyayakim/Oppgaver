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
        var match = new Match();
       
        while (match.MatchIsRunning)
        {
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            string? command = Console.ReadLine();
            match.GoalsVerdict(command);
            
            Console.WriteLine($"Stillingen er {match.HomeGoals}-{match.AwayGoals}.");
        }

        var result = match.Result();
        var isBetCorrect = bet != null && bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        Console.WriteLine($"Du tippet {isBetCorrectText}");
    }

    public class Match
    {
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public bool MatchIsRunning { get; set; }

        public Match()
        {
            HomeGoals = 0;
            AwayGoals = 0;
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

        public string Result()
        {
            string s = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
            return s;
        }
    }
}

