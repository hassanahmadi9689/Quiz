using Quiz.Services.Player.Contracts;
using Quiz.Services.Player.Dtos;
using Taav.Contract;

namespace Quiz.Services.Player;

public class PlayerAppServices : PlayerServices
{
    private readonly PlayerRepository _repository;
    private readonly UnitOfWork _unitOfWork;

    public PlayerAppServices(PlayerRepository repository, UnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task Add(AddPlayerDto dto)
    {
        var findTeam = _repository.IsExistTeam(dto.TeamId);
        if (!findTeam)
        {
            throw new Exception("Team Not Found");
        }

        var player = new Entities.Player()
        {
            Name = dto.Name,
            Birth = dto.Birth,
            TeamId = dto.TeamId
        };
        _repository.Add(player);
        await _unitOfWork.Complete();

    }

    public List<GetPlayerDto> GetPlayerBySearch(GetFilterPlayerDto dto)
    {
        return _repository.GetByAge(dto);
    }
}