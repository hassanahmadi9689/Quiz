using Quiz.Services.Player.Dtos;

namespace Quiz.Services.Player.Contracts;

public interface PlayerServices
{
    Task Add(AddPlayerDto dto);
    List<GetPlayerDto> GetPlayerBySearch(GetFilterPlayerDto dto);
}