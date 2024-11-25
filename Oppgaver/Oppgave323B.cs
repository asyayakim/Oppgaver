namespace Oppgaver;

public class Oppgave323B
{
    public void Run()
    {
        Console.WriteLine("Oppgave323B");
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" +
                      " - halvgardering: HU, HB, UB\n" +
                      " - helgardering: HUB\n" +
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        var betsText = Console.ReadLine();
        if (betsText != null)
        {
            var matches = new TwelveMatches(betsText);

            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") break;
                if (int.TryParse(command, out int matchNo) && matchNo >= 1 && matchNo <= 12)
                    Console.Write("Kommandoer: \n" +
                                  " - H = scoring hjemmelag\n" +
                                  " - B = scoring bortelag\n" +
                                  " - X = kampen er ferdig\n" +
                                  "Angi kommando: ");
                var team = Console.ReadLine()?.ToUpper();
                if (team == "H" || team == "B")
                {
                    bool homeTeam = team == "H";
                    matches.AddGoal(matchNo, homeTeam);
                }

                int correctCount = matches.ShowScores();
                Console.WriteLine($"Du har {correctCount} rette.");
            }
        }
    }

    class Match
    {
        private int _homeGoals;
        private int _awayGoals;
        private string _bet;

        public Match(string bet)
        {
            _bet = bet;
        }

        public void AddGoal(bool isHomeTeam)
        {
            if (isHomeTeam) _homeGoals++;
            else _awayGoals++;
        }

        public bool IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }

        public string GetScore()
        {
            return _homeGoals + "-" + _awayGoals;
        }
    }

    class TwelveMatches
    {
        private static Match[] _matches = null!;

        public TwelveMatches(string betsText)
        {
            string[] bets = betsText.Split(',');
            _matches = new Match[2];
            for (var i = 0; i < 2; i++)
            {
                _matches[i] = new Match(bets?[i] ?? string.Empty);
            }
        }

        public void AddGoal(int matchNo, bool isHomeTeam)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = _matches[selectedIndex];
            selectedMatch.AddGoal(isHomeTeam);
        }

        public int ShowScores()
        {
            int correctCount = 0;
            for (var index = 0; index < _matches.Length; index++)
            {
                var match = _matches[index];
                var theMatchNo = index + 1;
                bool isBetCorrect = match.IsBetCorrect();
                if (isBetCorrect) correctCount++;
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                Console.WriteLine($"Kamp {theMatchNo}: {match.GetScore()} - {isBetCorrectText}");
            }

            return correctCount;
        }
    }
}