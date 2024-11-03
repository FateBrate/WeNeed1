using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.Requests;

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

            CreateMap<Database.Squad, SquadResponseDto>();
            CreateMap<SquadRequestDto, Database.Squad>();
        }
    }
}
