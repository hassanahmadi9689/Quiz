using System.Drawing;
using Color = Quiz.Entities.Color;

namespace Quiz.Services.Team.Dtos;

public class AddTeamDto
{
    public string Name { get; set; }
    public Color FirstColor { get; set; }
    public Color SecondColor { get; set; }
}