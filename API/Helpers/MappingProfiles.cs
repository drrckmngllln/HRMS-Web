using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(m => m.Department, o => o.MapFrom(d => d.Department.Name))
                .ForMember(m => m.Position, o => o.MapFrom(p => p.Position.Name))
                .ReverseMap();
        }
    }
}