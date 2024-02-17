namespace Quiz.Services.Player.Dtos;

public class AddPlayerDto
{
    public string Name { get; set; }
    public DateTime Birth { get; set; }
    public int TeamId { get; set; }
}