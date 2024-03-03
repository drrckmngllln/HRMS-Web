using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(m => m.Department, o => o.MapFrom(d => d.Department.Name))
                .ForMember(m => m.Position, o => o.MapFrom(p => p.Position.Name));

            //Attendances
            CreateMap<Attendance, AttendanceDto>()
                .ForMember(m => m.Employee, o => o.MapFrom(d => d.Employee.FullName));
                
            // CreateMap<AttendanceDto, Attendance>()
            //     .ForMember(m => m.EmployeeId, o => o.MapFrom(d => d.Employee));
        }
    }
}