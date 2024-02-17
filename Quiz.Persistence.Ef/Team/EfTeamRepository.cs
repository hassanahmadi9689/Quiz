using Quiz.Services.Team.Contracts;
using Quiz.Services.Team.Dtos;

namespace Quiz.Persistence.Ef.Team;

public class EfTeamRepository : TeamRepository
{
    private readonly EfDataContext _context;

    public EfTeamRepository(EfDataContext context)
    {
        _context = context;
    }


    public void Add(Entities.Team team)
    {
        _context.Team.Add(team);
    }

    

    public Entities.Team? IsExist(string name)
    {
        var singleOrDefault = _context.Team.SingleOrDefault(_ => _.Name == name);
        return singleOrDefault;
    }

    public List<GetTeamDto> GetTeam(GetTeamFilterDto dto)
    {
        var team = _context.Team.Select(_ => new GetTeamDto()
        {
            Id = _.Id,
            Name = _.Name,
            
        }).ToList();
        var FindTeam = team.Where(_ => _.Name.Contains(dto.Name)).ToList();
        if (FindTeam is null)
        {
            throw new Exception("Team not found");
        }
        return FindTeam;
    }

}