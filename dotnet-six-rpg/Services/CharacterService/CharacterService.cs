namespace dotnet_six_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> _characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "John"}
    };

    public async Task<List<Character>> GetAllCharacters()
    {
        return _characters;
    }

    public async Task<Character> GetCharacterById(int id)
    {
        return _characters.FirstOrDefault(c => c.Id == id);
    }

    public async Task<List<Character>> AddCharacter(Character newCharacter)
    {
        _characters.Add(newCharacter);
        return _characters;
    }
}