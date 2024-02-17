namespace Quiz.Services.Player.Dtos;

public class GetPlayerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birth { get; set; }
    public int TeamId { get; set; }
    
}