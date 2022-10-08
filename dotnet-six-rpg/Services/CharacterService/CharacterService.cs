using dotnet_six_rpg.Dtos.Character;

namespace dotnet_six_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> _characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "John"}
    };

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
    {
        return new ServiceResponse<List<GetCharacterDto>> {Data = _characters};
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
        var serviceResponse = new ServiceResponse<GetCharacterDto>();
        var character = _characters.FirstOrDefault(c => c.Id == id);
        serviceResponse.Data = character;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
        _characters.Add(newCharacter);
        serviceResponse.Data = _characters;
        return serviceResponse;
    }
}