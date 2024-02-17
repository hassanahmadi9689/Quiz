namespace Quiz.Services.Player.Dtos;

public class GetFilterPlayerDto
{
    public string Name { get; set; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
}