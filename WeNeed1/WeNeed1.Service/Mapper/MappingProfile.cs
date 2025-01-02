using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.Requests;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<UserRequestDto, Database.User>();
            CreateMap<UserUpdateDto,Database.User>();

            CreateMap<Database.Team, TeamResponseDto>();
            CreateMap<TeamRequestDto, Database.Team>();
            CreateMap<Database.Team, TeamResponseDto>()
                .ForMember(dest => dest.TeamMembers, opt => opt.MapFrom(src => src.UserTeams.Select(ut => ut.User)));

            CreateMap<Squad, SquadResponseDto>()
                .ForMember(dest => dest.UserSquads, opt => opt.MapFrom(src => src.UserSquads.Select(us => us.User)));
            CreateMap<SquadRequestDto, Database.Squad>();
            
            
        }
    }
}
