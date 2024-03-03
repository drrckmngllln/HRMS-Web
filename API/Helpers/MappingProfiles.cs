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
            //Employees
            CreateMap<Employee, EmployeeDto>()
                .ForMember(m => m.Department, o => o.MapFrom(d => d.Department.Name))
                .ForMember(m => m.Position, o => o.MapFrom(d => d.Position.Name));
            CreateMap<PersonalInformation, PersonalInformationDto>()
                .ForMember(m => 
                    m.EmployeeNumber, o => o.MapFrom(d => d.EmployeeNumber.EmployeeNumber));
            //Attendances
            CreateMap<Attendance, AttendanceDto>()
                .ForMember(m => m.Employee, o => o.MapFrom(d => d.Employee.FullName));
                
        }
    }
}