using AutoMapper;
using WeNeed1.Model.Payloads;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, Model.User>()
                .ForMember(dest => dest.SportsCenter, opt => opt.MapFrom(src => src.SportsCenter));
            CreateMap<UserRequestDto, User>();
            CreateMap<UserUpdateDto,User>();

            CreateMap<Team, TeamResponseDto>();
            CreateMap<TeamRequestDto,Team>();
            CreateMap<Team, TeamResponseDto>()
                .ForMember(dest => dest.TeamMembers, opt => opt.MapFrom(src => src.UserTeams.Select(ut => ut.User)));

            CreateMap<Squad, SquadResponseDto>()
                .ForMember(dest => dest.UserSquads, opt => opt.MapFrom(src => src.UserSquads.Select(us => us.User)));
            CreateMap<SquadRequestDto,Squad>();

            CreateMap<SportsCenter, SportsCenterResponseDto>();
            CreateMap<SportsCenterRequestDto,SportsCenter>();

            CreateMap<Review, ReviewResponseDto>();
            CreateMap<ReviewRequestDto, Review>();

            CreateMap<SportsField, SportFieldResponseDto>();
            CreateMap<SportFieldRequestDto, SportsField>();
            
            CreateMap<Match, MatchResponseDto>();
            CreateMap<MatchRequestDto, Match>();
            
            CreateMap<Comment, CommentResponseDto>();
            CreateMap<CommentRequestDto, Comment>();

            CreateMap<Reservation, ReservationResponseDto>()
                .ForMember(dest => dest.SportFieldResponseDto, opt => opt.MapFrom(src => src.SportsField));
            CreateMap<ReservationRequestDto, Reservation>();
        }
    }
}
