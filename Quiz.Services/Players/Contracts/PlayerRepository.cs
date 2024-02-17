using Quiz.Services.Player.Dtos;

namespace Quiz.Services.Player.Contracts;

public interface PlayerRepository
{
    void Add(Entities.Player player);
    Entities.Player? IsExist(string name);
    bool IsExistPlayer(int id);
    bool IsExistTeam(int id);
    List<GetPlayerDto> GetByAge(GetFilterPlayerDto dto);

}