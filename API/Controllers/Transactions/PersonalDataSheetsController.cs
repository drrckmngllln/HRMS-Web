using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Transactions;

public class PersonalDataSheetsController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PersonalDataSheetsController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    private async Task<bool> CheckExisting<TEntity>() where TEntity : BaseEntity
    {
        var item = await _unitOfWork.Repository<TEntity>().ListAllAsync();
        if (item.Any()) return true;
        return false;
    }

    private async Task<int> GetEmployeeIdAsync(string employeeNumber)
    {
        var employee = await _unitOfWork.Repository<Employee>().ListAllAsync();
        return employee.FirstOrDefault(x => x.EmployeeNumber == employeeNumber).Id;
    }

    [HttpGet("PersonalInformation/{id}")]
    public async Task<ActionResult<PersonalInformationDto>> GetPersonalInformationAsync(int id)
    {
        var spec = new PersonaInformationSpecifications(id);
        var personalInformation = await _unitOfWork.Repository<PersonalInformation>().GetEntityWithSpec(spec);
        if (personalInformation != null)
        {
            var data = _mapper.Map<PersonalInformation, PersonalInformationDto>(personalInformation);
            return Ok(data);
        }

        return BadRequest("No Record Exists");
    }

    [HttpPost("PersonalInformation/create")]
    public async Task<ActionResult> AddPersonalInformationAsync(PersonalInformationDto personalInformationDto)
    {
        if (!await CheckExisting<PersonalInformation>())
        {
            var item = new PersonalInformation
            {
                EmployeeNumberId = await GetEmployeeIdAsync(personalInformationDto.EmployeeNumber.ToString()),
                Surname = personalInformationDto.Surname,
                Firstname = personalInformationDto.Firstname,
                Middlename = personalInformationDto.Middlename,
                DateOfBirth = personalInformationDto.DateOfBirth,
                Sex = (Sex)personalInformationDto.Sex,
                CivilStatus = (CivilStatus)personalInformationDto.CivilStatus,
                Height = personalInformationDto.Height,
                BloodType = personalInformationDto.BloodType,
                GsisIdNo = personalInformationDto.GsisIdNo,
                PagibigIdNo = personalInformationDto.PagibigIdNo,
                PhilhealthNo = personalInformationDto.PhilhealthNo,
                SssNo = personalInformationDto.SssNo,
                TinNo = personalInformationDto.TinNo,
                AgencyEmployeeNo = personalInformationDto.AgencyEmployeeNo
            };
            _unitOfWork.Repository<PersonalInformation>().Add(item);
            await _unitOfWork.Complete();
            return Ok("Successfully added");
        }
        return BadRequest("No duplicate entry");
    }

    [HttpPut("PersonalInformation/update")]
    public async Task<ActionResult> UpdatePersonalInformation(PersonalInformationDto personalInformationDto)
    {
        var item = new PersonalInformation
        {
            Id = personalInformationDto.Id,
            EmployeeNumberId = await GetEmployeeIdAsync(personalInformationDto.EmployeeNumber.ToString()),
            Surname = personalInformationDto.Surname,
            Firstname = personalInformationDto.Firstname,
            Middlename = personalInformationDto.Middlename,
            DateOfBirth = personalInformationDto.DateOfBirth,
            Sex = (Sex)personalInformationDto.Sex,
            CivilStatus = (CivilStatus)personalInformationDto.CivilStatus,
            Height = personalInformationDto.Height,
            BloodType = personalInformationDto.BloodType,
            GsisIdNo = personalInformationDto.GsisIdNo,
            PagibigIdNo = personalInformationDto.PagibigIdNo,
            PhilhealthNo = personalInformationDto.PhilhealthNo,
            SssNo = personalInformationDto.SssNo,
            TinNo = personalInformationDto.TinNo,
            AgencyEmployeeNo = personalInformationDto.AgencyEmployeeNo
        };
        _unitOfWork.Repository<PersonalInformation>().Update(item);
        await _unitOfWork.Complete();
        return Ok("Personal information updated");
    }



    [HttpGet("FamilyBackground/{id}")]
    public async Task<ActionResult<FamilyBackgroundDto>> GetFamilyBackgroundAsync(int id)
    {
        var spec = new FamilyBackgroundSpecifications(id);
        var familyBackground = await _unitOfWork.Repository<FamilyBackground>().GetEntityWithSpec(spec);
        var data = _mapper.Map<FamilyBackground, FamilyBackgroundDto>(familyBackground);
        return Ok(data);
    }

    [HttpPost("FamilyBackground/create")]
    public async Task<ActionResult> AddFamilyBackgroundAsync(FamilyBackgroundDto familyBackgroundDto)
    {
        if (await CheckExisting<FamilyBackground>())
        {
            var item = new FamilyBackground
            {
                EmployeeNumberId = await GetEmployeeIdAsync(familyBackgroundDto.EmployeeNumber.ToString()),
                SpouseSurname = familyBackgroundDto.SpouseSurname,
                SpouseFirstName = familyBackgroundDto.SpouseFirstName,
                SpouseMiddlename = familyBackgroundDto.SpouseMiddlename,
                Occupation = familyBackgroundDto.Occupation,
                EmployerName = familyBackgroundDto.EmployerName,
                BusinessAddress = familyBackgroundDto.BusinessAddress,
                TelephoneNumber = familyBackgroundDto.TelephoneNumber,
                FatherSurname = familyBackgroundDto.FatherSurname,
                FatherFirstname = familyBackgroundDto.FatherFirstname,
                FatherMiddlename = familyBackgroundDto.FatherMiddlename,
                MotherSurnamne = familyBackgroundDto.MotherSurnamne,
                MotherFirstname = familyBackgroundDto.MotherFirstname,
                MotherMiddlename = familyBackgroundDto.MotherMiddlename
            };
            _unitOfWork.Repository<FamilyBackground>().Add(item);
            await _unitOfWork.Complete();
            return Ok("Family Background added");
        }
        return BadRequest("No duplicate entry");
    }

    [HttpGet("NameOfChildren/{id}")]
    public async Task<ActionResult<IReadOnlyList<NameOfChildrenDto>>> GetNameOfChildrenAsync(int id)
    {
        var spec = new NameOfChildrenSpecifications(id);
        var nameOfChildren = await _unitOfWork.Repository<NameOfChildren>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<NameOfChildren>, IReadOnlyList<NameOfChildrenDto>>(nameOfChildren);
        return Ok(data);
    }

    [HttpPost("NameOfChildren/create")]
    public async Task<ActionResult> AddNameOfChildren(NameOfChildrenDto nameOfChildrenDto)
    {
        var item = new NameOfChildren
        {
            EmployeeNumberId = await GetEmployeeIdAsync(nameOfChildrenDto.EmployeeNumber),
            Fullname = nameOfChildrenDto.Fullname,
            DateOfBirth = nameOfChildrenDto.DateOfBirth
        };
        _unitOfWork.Repository<NameOfChildren>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Name of children added");
    }


    [HttpGet("EducationalBackground/{id}")]
    public async Task<ActionResult<IReadOnlyList<EducationalBackgroundDto>>> GetEducationalBackgroundAsync(int id)
    {
        var spec = new EducationalBackgroundSpecifications(id);
        var educationalBackground = await _unitOfWork.Repository<EducationalBackground>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<EducationalBackground>, IReadOnlyList<EducationalBackgroundDto>>(educationalBackground);
        return Ok(data);
    }

    [HttpPost("EducationalBackground/create")]
    public async Task<ActionResult> AddEducationalBackground(EducationalBackgroundDto educationalBackgroundDto)
    {
        var item = new EducationalBackground
        {
            EmployeeNumberId = await GetEmployeeIdAsync(educationalBackgroundDto.EmployeeNumber.ToString()),
            Level = (EducationalLevel)educationalBackgroundDto.Level,
            NameOfSchool = educationalBackgroundDto.NameOfSchool,
            Course = educationalBackgroundDto.Course,
            PeriodStart = educationalBackgroundDto.PeriodStart,
            PeriodEnd = educationalBackgroundDto.PeriodEnd,
            UnitsEarned = educationalBackgroundDto.UnitsEarned,
            YearGraduated = educationalBackgroundDto.YearGraduated,
            AcademicHonors = educationalBackgroundDto.AcademicHonors
        };
        _unitOfWork.Repository<EducationalBackground>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Educational background added");
    }

    [HttpGet("CivilServiceEligibility/{id}")]
    public async Task<ActionResult<CivilServiceEligibilityDto>> GetCivilServiceEligibilityAsync(int id)
    {
        var spec = new CivilServiceEligibilitySpecifications(id);
        var civilServiceEligibility = await _unitOfWork.Repository<CivilServiceEligibility>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<CivilServiceEligibility>, IReadOnlyList<CivilServiceEligibilityDto>>(civilServiceEligibility);
        return Ok(data);
    }

    [HttpPost("CivilServiceEligibility/create")]
    public async Task<ActionResult> AddCivilServiceEligibility(CivilServiceEligibilityDto civilServiceEligibilityDto)
    {
        var item = new CivilServiceEligibility
        {
            EmployeeNumberId = await GetEmployeeIdAsync(civilServiceEligibilityDto.EmployeeNumber.ToString()),
            Eligibility = civilServiceEligibilityDto.Eligibility,
            Rating = civilServiceEligibilityDto.Rating,
            DateOfExamination = civilServiceEligibilityDto.DateOfExamination,
            PlaceOfExamination = civilServiceEligibilityDto.PlaceOfExamination,
            LicenseNumber = civilServiceEligibilityDto.LicenseNumber,
            DateOfValidity = civilServiceEligibilityDto.DateOfValidity
        };
        _unitOfWork.Repository<CivilServiceEligibility>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Civil service eligibility added");
    }

    [HttpGet("WorkExperience/{id}")]
    public async Task<ActionResult<IReadOnlyList<WorkExperienceDto>>> GetWorkExperienceAsync(int id)
    {
        var spec = new WorkExperienceSpecifications(id);
        var workExperience = await _unitOfWork.Repository<WorkExperience>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<WorkExperience>, IReadOnlyList<WorkExperienceDto>>(workExperience);
        return Ok(data);
    }

    [HttpPost("WorkExperience/create")]
    public async Task<ActionResult> AddWorkExperience(WorkExperienceDto workExperienceDto)
    {
        var item = new WorkExperience
        {
            EmployeeNumberId = await GetEmployeeIdAsync(workExperienceDto.EmployeeNumber.ToString()),
            StartDate = workExperienceDto.StartDate,
            EndDate = workExperienceDto.EndDate,
            Position = workExperienceDto.Position,
            Department = workExperienceDto.Department,
            MonthlySalary = workExperienceDto.MonthlySalary,
            PayGrade = workExperienceDto.PayGrade,
            StatusOfAppointment = workExperienceDto.StatusOfAppointment,
            GovernmentService = workExperienceDto.GovernmentService
        };
        _unitOfWork.Repository<WorkExperience>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Work experience added");
    }

    [HttpGet("VoluntaryWork/{id}")]
    public async Task<ActionResult<IReadOnlyList<VoluntaryWorkDto>>> GetVoluntaryWorkAsync(int id)
    {
        var spec = new VoluntaryWorkSpecifications(id);
        var voluntaryWork = await _unitOfWork.Repository<VoluntaryWork>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<VoluntaryWork>, IReadOnlyList<VoluntaryWorkDto>>(voluntaryWork);
        return Ok(data);
    }

    [HttpPost("VoluntaryWork/create")]
    public async Task<ActionResult> AddVoluntaryWork(VoluntaryWorkDto voluntaryWorkDto)
    {
        var item = new VoluntaryWork
        {
            EmployeeNumberId = await GetEmployeeIdAsync(voluntaryWorkDto.EmployeeNumber.ToString()),
            NameAndAddressOfOrganization = voluntaryWorkDto.NameAndAddressOfOrganization,
            StartDate = voluntaryWorkDto.StartDate,
            EndDate = voluntaryWorkDto.EndDate,
            NumberOfHours = voluntaryWorkDto.NumberOfHours,
            NatureOfWork = voluntaryWorkDto.NatureOfWork
        };
        _unitOfWork.Repository<VoluntaryWork>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Voluntary work added");
    }

    [HttpGet("LearningAndDevelopment/{id}")]
    public async Task<ActionResult<IReadOnlyList<LearningAndDevelopmentDto>>> GetLearningAndDevelopmentAsync(int id)
    {
        var spec = new LearningAndDevelopmentSpecifications(id);
        var learningAndDevelopment = await _unitOfWork.Repository<LearningAndDevelopment>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<LearningAndDevelopment>, IReadOnlyList<LearningAndDevelopmentDto>>(learningAndDevelopment);
        return Ok(data);
    }

    [HttpPost("LearningAndDevelopment/create")]
    public async Task<ActionResult> AddLearningAndDevelopment(LearningAndDevelopmentDto learningAndDevelopmentDto)
    {
        var item = new LearningAndDevelopment
        {
            EmployeeNumberId = await GetEmployeeIdAsync(learningAndDevelopmentDto.EmployeeNumber.ToString()),
            TitleOfLearningAndDevelopment = learningAndDevelopmentDto.TitleOfLearningAndDevelopment,
            StartDate = learningAndDevelopmentDto.StartDate,
            EndDate = learningAndDevelopmentDto.EndDate,
            NumberOfHours = learningAndDevelopmentDto.NumberOfHours,
            TypeOfLd = learningAndDevelopmentDto.TypeOfLd,
            Conducted = learningAndDevelopmentDto.Conducted
        };
        _unitOfWork.Repository<LearningAndDevelopment>().Add(item);
        await _unitOfWork.Complete();

        return Ok("Learning and development added");
    }

    [HttpGet("OtherInformation/{id}")]
    public async Task<ActionResult<IReadOnlyList<OtherInformationDto>>> GetOtherInformationAsync(int id)
    {
        var spec = new OtherInformationSpecifications(id);
        var otherInformation = await _unitOfWork.Repository<OtherInformation>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<OtherInformation>, IReadOnlyList<OtherInformationDto>>(otherInformation);
        return Ok(data);
    }
    [HttpPost("OtherInformation/create")]
    public async Task<ActionResult> AddOtherInformation(OtherInformationDto otherInformationDto)
    {
        var item = new OtherInformation
        {
            EmployeeNumberId = await GetEmployeeIdAsync(otherInformationDto.EmployeeNumber.ToString()),
            SpecialSkills = otherInformationDto.SpecialSkills,
            NonAcademicDestinction = otherInformationDto.NonAcademicDestinction,
            Organization = otherInformationDto.Organization
        };
        _unitOfWork.Repository<OtherInformation>().Add(item);
        await _unitOfWork.Complete();
        return Ok("Other information added");
    }

}