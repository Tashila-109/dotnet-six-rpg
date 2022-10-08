namespace dotnet_six_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> _characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "John"}
    };

    public List<Character> GetAllCharacters()
    {
        return _characters;
    }

    public Character GetCharacterById(int id)
    {
        return _characters.FirstOrDefault(c => c.Id == id);
    }

    public List<Character> AddCharacter(Character newCharacter)
    {
        return _characters;
    }
}