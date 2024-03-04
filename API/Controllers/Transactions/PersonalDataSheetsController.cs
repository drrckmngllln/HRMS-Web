using API.Dtos;
using AutoMapper;
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

    [HttpGet("PersonalInformation/{id}")]
    public async Task<ActionResult<PersonalInformationDto>> GetPersonalInformationAsync(int id)
    {
        var spec = new PersonaInformationSpecifications(id);
        var personalInformation = await _unitOfWork.Repository<PersonalInformation>().GetEntityWithSpec(spec);
        var data = _mapper.Map<PersonalInformation, PersonalInformationDto>(personalInformation);
        return Ok(data);
    }

    [HttpGet("FamilyBackground/{id}")]
    public async Task<ActionResult<FamilyBackgroundDto>> GetFamilyBackgroundAsync(int id)
    {
        var spec = new FamilyBackgroundSpecifications(id);
        var familyBackground = await _unitOfWork.Repository<FamilyBackground>().GetEntityWithSpec(spec);
        var data = _mapper.Map<FamilyBackground, FamilyBackgroundDto>(familyBackground);

        
        return Ok(data);
    }

    [HttpGet("NameOfChildren/{id}")]
    public async Task<ActionResult<IReadOnlyList<NameOfChildrenDto>>> GetNameOfChildrenAsync(int id)
    {
        var spec = new NameOfChildrenSpecifications(id);
        var nameOfChildren = await _unitOfWork.Repository<NameOfChildren>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<NameOfChildren>, IReadOnlyList<NameOfChildrenDto>>(nameOfChildren);
        return Ok(data);
    }

    [HttpGet("EducationalBackground/{id}")]
    public async Task<ActionResult<IReadOnlyList<EducationalBackgroundDto>>> GetEducationalBackgroundAsync(int id)
    {
        var spec = new EducationalBackgroundSpecifications(id);
        var educationalBackground = await _unitOfWork.Repository<EducationalBackground>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<EducationalBackground>, IReadOnlyList<EducationalBackgroundDto>>(educationalBackground);
        return Ok(data);
    }

    [HttpGet("CivilServiceEligibility/{id}")]
    public async Task<ActionResult<CivilServiceEligibilityDto>> GetCivilServiceEligibilityAsync(int id)
    {
        var spec = new CivilServiceEligibilitySpecifications(id);
        var civilServiceEligibility = await _unitOfWork.Repository<CivilServiceEligibility>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<CivilServiceEligibility>, IReadOnlyList<CivilServiceEligibilityDto>>(civilServiceEligibility);
        return Ok(data);
    }

    [HttpGet("WorkExperience/{id}")]
    public async Task<ActionResult<IReadOnlyList<WorkExperienceDto>>> GetWorkExperienceAsync(int id)
    {
        var spec = new WorkExperienceSpecifications(id);
        var workExperience = await _unitOfWork.Repository<WorkExperience>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<WorkExperience>, IReadOnlyList<WorkExperienceDto>>(workExperience);
        return Ok(data);
    }

    [HttpGet("VoluntaryWork/{id}")]
    public async Task<ActionResult<IReadOnlyList<VoluntaryWorkDto>>> GetVoluntaryWorkAsync(int id)
    {
        var spec = new VoluntaryWorkSpecifications(id);
        var voluntaryWork = await _unitOfWork.Repository<VoluntaryWork>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<VoluntaryWork>, IReadOnlyList<VoluntaryWorkDto>>(voluntaryWork);
        return Ok(data);
    }

    [HttpGet("LearningAndDevelopment/{id}")]
    public async Task<ActionResult<IReadOnlyList<LearningAndDevelopmentDto>>> GetLearningAndDevelopmentAsync(int id)
    {
        var spec = new LearningAndDevelopmentSpecifications(id);
        var learningAndDevelopment = await _unitOfWork.Repository<LearningAndDevelopment>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<LearningAndDevelopment>, IReadOnlyList<LearningAndDevelopmentDto>>(learningAndDevelopment);
        return Ok(data);
    }

    [HttpGet("OtherInformation/{id}")]
    public async Task<ActionResult<IReadOnlyList<OtherInformationDto>>> GetOtherInformationAsync(int id)
    {
        var spec = new OtherInformationSpecifications(id);
        var otherInformation = await _unitOfWork.Repository<OtherInformation>().ListAsync(spec);
        var data = _mapper.Map<IReadOnlyList<OtherInformation>, IReadOnlyList<OtherInformationDto>>(otherInformation);
        return Ok(data);
    }
}