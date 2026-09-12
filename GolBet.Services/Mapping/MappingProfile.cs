using AutoMapper;
using GolBet.Entities;
using GolBet.Services.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GolBet.Services.Mapping;

public class MappingProfile : Profile

{
    public MappingProfile()

    {
        CreateMap<Match, MatchDto>();
    }

}
