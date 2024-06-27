using System.Text;

namespace RoundRobin.Doubles;

public class Planner
{

    public void Start()
    {
        Console.WriteLine("-- Round Robin Doubles");

        ShowNet();

        Console.ResetColor();
    }

    public void ShowNet()
    {
        var rr10 = GetNet10();

        var orig = DTour(rr10, "Net10");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(orig);

        var stat = STour(rr10);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(stat);
    }

    #region statistics

    private string STour(Tour tour)
    {
        var mx = MaxTour(tour);
        StringBuilder b = new($"Max ({mx + 1})");

        var players = Enumerable.Range(0, mx + 1).Select(i => new Summary() {
            Self = i,
            Played = CountTour(tour, i),
            Partners = PartsTour(tour, i, mx + 1),
            Opponents = OpposTour(tour, i, mx + 1)

        });
        b.AppendLine(string.Join("", players.Select(p => DSummary(p))));

        return b.ToString();
    }

    private static string DSummary(Summary s)
    {
        StringBuilder b = new();
        b.AppendLine($"-- {s.Self + 1} ({s.Played})");
        b.Append("Partners  ");
        b.Append(string.Join(", ", s.Partners.Select((v, i) => $"{i + 1}-{v}")));
        b.AppendLine($" ({s.Partners.Sum(x => x)})");
        b.Append("Opponents ");
        b.Append(string.Join(", ", s.Opponents.Select((v, i) => $"{i + 1}-{v}")));
        b.AppendLine($" ({s.Opponents.Sum(x => x)})");
        return b.ToString();
    }

    private static int[] PartsTour(Tour tour, int s, int mx)
    {
        return Enumerable.Range(0, mx).Select(i => PartTour(tour, s, i)).ToArray();
    }

    private static int PartTour(Tour tour, int s, int n)
    {
        return tour.Rounds.Sum(r => PartRound(r, s, n));

        int PartRound(Round round, int s, int n)
        {
            return round.Courts.Sum(c => PartCourt(c, s, n));
        }

        int PartCourt(Court court, int s, int n)
        {
            return PartTeam(court.Team1, s, n) + PartTeam(court.Team2, s, n);
        }

        int PartTeam(Team team, int s, int n)
        {
            return s != n && team.Players.Contains(s) && team.Players.Contains(n) ? 1 : 0;
        }
    }

    private static int[] OpposTour(Tour tour, int s, int mx)
    {
        return Enumerable.Range(0, mx).Select(i => OppoTour(tour, s, i)).ToArray();
    }

    private static int OppoTour(Tour tour, int s, int n)
    {
        return tour.Rounds.Sum(r => OppoRound(r, s, n));

        int OppoRound(Round round, int s, int n)
        {
            return round.Courts.Sum(c => OppoCourt(c, s, n));
        }

        int OppoCourt(Court court, int s, int n)
        {
            return s != n && (court.Team1.Players.Contains(s) && court.Team2.Players.Contains(n) || court.Team1.Players.Contains(n) && court.Team2.Players.Contains(s)) ? 1 :0;
        }

    }

    private static int CountTour(Tour tour, int n)
    {
        return tour.Rounds.Sum(r => CountRound(r, n));

        int CountRound(Round round, int n)
        {
            return round.Courts.Sum(c => CountCourt(c, n));
        }

        int CountCourt(Court court, int n)
        {
            return CountTeam(court.Team1, n) + CountTeam(court.Team2, n);
        }

        int CountTeam(Team team, int n)
        {
            return team.Players.Count(c => c == n);
        }
    }

    private static int MaxTour(Tour tour)
    {
        return tour.Rounds.Max(r => MaxRound(r));

        int MaxRound(Round round)
        {
            return round.Courts.Max(c => MaxCourt(c));
        }

        int MaxCourt(Court court)
        {
            return Math.Max(MaxTeam(court.Team1), MaxTeam(court.Team2));
        }

        int MaxTeam(Team team)
        {
            return team.Players.Max();
        }
    }

    #endregion

    #region basic

    private static string DTour(Tour tour, string name)
    {
        StringBuilder b = new($"-- Tour {name} (Rounds {tour.Rounds.Count})");
        b.AppendLine();
        b.AppendLine(string.Join(
            Environment.NewLine,
            tour.Rounds.Select(r => string.Join(", ", r.Courts.Select(c => DCourt(c))))
        ));
        return b.ToString();

        string DCourt(Court c)
        {
            return $"{DTeam(c.Team1)} {DTeam(c.Team2)}";
        }

        string DTeam(Team t)
        {
            return t.Players.Count > 1 ? $"{t.Players[0] + 1,2}-{t.Players[1] + 1,-2}" : t.Players[0].ToString();
        }

    }

    #endregion

    #region example

    private static Tour GetNet10()
    {
        return new Tour(new([
            new(new([
                new(new([0, 6]), new([5, 8])),
                new(new([9, 4]), new([3, 2]))
            ])),
            new(new([
                new(new([0, 2]), new([3, 6])),
                new(new([1, 7]), new([8, 4]))
            ])),
            new(new([
                new(new([7, 3]), new([6, 2])),
                new(new([9, 5]), new([1, 8]))
            ])),
            new(new([
                new(new([9, 6]), new([4, 5])),
                new(new([1, 0]), new([7, 2]))
            ])),
            new(new([
                new(new([1, 4]), new([0, 8])),
                new(new([5, 7]), new([3, 9]))
            ])),
            new(new([
                new(new([4, 6]), new([9, 1])),
                new(new([5, 2]), new([7, 8]))
            ])),
            new(new([
                new(new([3, 0]), new([1, 5])),
                new(new([9, 2]), new([6, 7]))
            ])),
            new(new([
                new(new([3, 8]), new([0, 4]))
            ]))
        ]));
    }

    #endregion

}
