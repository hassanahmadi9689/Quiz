using Quiz.Services.Team.Dtos;

namespace Quiz.Services.Team.Contracts;

public interface TeamServices
{
    Task Add(AddTeamDto dto);
    public List<GetTeamDto> GetTeam(GetTeamFilterDto dto);
}