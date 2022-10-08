using AutoMapper;
using dotnet_six_rpg.Dtos.Character;

namespace dotnet_six_rpg;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Character, GetCharacterDto>();
        CreateMap<AddCharacterDto, Character>();
        CreateMap<UpdateCharacterDto, Character>();
    }
}