namespace dotnet_six_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> _characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "John"}
    };

    public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
    {
        return new ServiceResponse<List<Character>> {Data = _characters};
    }

    public async Task<ServiceResponse<Character>> GetCharacterById(int id)
    {
        var serviceResponse = new ServiceResponse<Character>();
        var character = _characters.FirstOrDefault(c => c.Id == id);
        serviceResponse.Data = character;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        _characters.Add(newCharacter);
        serviceResponse.Data = _characters;
        return serviceResponse;
    }
}