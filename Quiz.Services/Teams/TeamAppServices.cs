using Quiz.Services.Team.Contracts;
using Quiz.Services.Team.Dtos;
using Taav.Contract;

namespace Quiz.Services.Team;

public class TeamAppServices : TeamServices
{
    private readonly TeamRepository _repository;
    private readonly UnitOfWork _unitOfWork;

    public TeamAppServices(TeamRepository repository, UnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task Add(AddTeamDto dto)
    {
        var isexist = _repository.IsExist(dto.Name);
        if (isexist is null)
        {
            var team = new Entities.Team()
            {
                Name = dto.Name,
                FirstColor = dto.FirstColor,
                SecondColor = dto.SecondColor
            };
            _repository.Add(team);
            await _unitOfWork.Complete();
        }
        else
        {
            throw new Exception("wrong name");
        }
        
    }

    public List<GetTeamDto> GetTeam(GetTeamFilterDto dto)
    {
        return _repository.GetTeam(dto);
    }
}