using AutoMapper;
using dotnet_six_rpg.Dtos.Character;

namespace dotnet_six_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> _characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "John"}
    };
    
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
    {
        return new ServiceResponse<List<GetCharacterDto>> {Data = _characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList()};
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
        var serviceResponse = new ServiceResponse<GetCharacterDto>();
        var character = _characters.FirstOrDefault(c => c.Id == id);
        serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
        var character = _mapper.Map<Character>(newCharacter);
        character.Id = _characters.Max(c => c.Id) + 1;
        _characters.Add(character);
        serviceResponse.Data = _characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        return serviceResponse;
    }
}