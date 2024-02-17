using System.Runtime.Serialization;
using Quiz.Services.Player.Contracts;
using Quiz.Services.Player.Dtos;

namespace Quiz.Persistence.Ef.Player;

public class EfPlayerRepository : PlayerRepository
{
    private readonly EfDataContext _context;

    public EfPlayerRepository(EfDataContext context)
    {
        _context = context;
    }

    public void Add(Entities.Player player)
    {
        _context.Add(player);
    }

    public Entities.Player? IsExist(string name)
    {
        var find = _context.Player.SingleOrDefault(_ => _.Name == name);
        return find;
    }

    public bool IsExistPlayer(int id)
    {
        return _context.Player.Any(_ => _.Id == id);
    }

    public bool IsExistTeam(int id)
    {
        return _context.Team.Any(_ => _.Id == id);
    }

    public List<GetPlayerDto> GetByAge(GetFilterPlayerDto dto)
    {
        var player = _context.Player.Select(_ => new GetPlayerDto()
        {
            Id = _.Id,
            Name = _.Name,
            Birth = _.Birth,
            TeamId = _.Team.Id
        }).ToList();

        var filterPlayer = player.Where(_ =>
            _.Birth.Year - DateTime.Now.Year > dto.MinAge &&
            _.Birth.Year - DateTime.Now.Year < dto.MaxAge).ToList();
        return filterPlayer;
    }
}