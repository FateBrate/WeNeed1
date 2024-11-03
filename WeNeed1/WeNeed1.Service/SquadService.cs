using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service
{
    public class SquadService:BaseCRUDService<SquadResponseDto,Database.Squad,BaseSearchObject,SquadRequestDto,SquadRequestDto>,ISquadService
    {
        public SquadService(WeNeed1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<SquadResponseDto> GetById(int id)
        {
            var entity = await _context.Squads
                .Include(s => s.Team) 
                .FirstOrDefaultAsync(s => s.Id == id);

            if (entity == null)
            {
                throw new Exception("Squad not found");
            }

            return _mapper.Map<SquadResponseDto>(entity);
        }
        }
    
}
