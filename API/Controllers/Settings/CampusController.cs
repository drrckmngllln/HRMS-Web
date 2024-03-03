using Core.Entities.Settings;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Controllers.Settings
{
    public class CampusController : BaseApiController
    {
        private readonly ISettingsService<Campus> _campusRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CampusController(ISettingsService<Campus> campusRepo, IUnitOfWork unitOfWork)
        {
            _campusRepo = campusRepo;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Campus>>> GetCampusesAsync([FromQuery] string search)
        {
            var spec = new CampusesSpecifications(search);
            return Ok(await _unitOfWork.Repository<Campus>().ListAsync(spec));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Campus>> GetByIdAsync(int id)
        {
            var spec = new CampusesSpecifications(id);
            return Ok(await _unitOfWork.Repository<Campus>().ListAsync(spec));
        }


        [HttpPost("create")]
        public async Task<ActionResult<Campus>> CreateCampusAsync(Campus entity)
        {
            _unitOfWork.Repository<Campus>().Add(entity);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpPut("update")]
        public async Task<ActionResult<Campus>> UpdateCampusAsync(Campus entity)
        {
            _unitOfWork.Repository<Campus>().Update(entity);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Campus>> DeleteCampusAsync(Campus campus)
        {
            _unitOfWork.Repository<Campus>().Delete(campus);
            await _unitOfWork.Complete();
            return NoContent();
        }
    }
}