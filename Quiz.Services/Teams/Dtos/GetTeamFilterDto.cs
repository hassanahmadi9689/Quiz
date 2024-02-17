using Quiz.Entities;

namespace Quiz.Services.Team.Dtos;

public class GetTeamFilterDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Color? FirstColor { get; set; }
    
}