using Quiz.Services.Team.Dtos;

namespace Quiz.Services.Team.Contracts;

public interface TeamRepository
{
    void Add(Entities.Team team);
    
    Entities.Team? IsExist(string name);
    public List<GetTeamDto> GetTeam(GetTeamFilterDto dto);
}