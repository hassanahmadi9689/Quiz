namespace Quiz.Entities;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Color FirstColor { get; set; }
    public Color SecondColor { get; set; }
    public HashSet<Player> Players { get; set; }
}