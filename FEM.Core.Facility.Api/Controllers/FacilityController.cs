using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FEM.Core.Facility.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetFacilities()
        {
            return Ok();
        }

        [HttpGet("{FacilityId: guid}")]
        public async Task<IActionResult> GetFacilityById(Guid FacilityId)
        {
            return Ok();
        }

        [HttpGet("NameId")]
        public async Task<IActionResult> GetFacilityNameIdPair()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFacility()
        {
            return Created();
        }

        [HttpPut("{FacilityId: guid}")]
        public async Task<IActionResult> UpdateFacility(Guid FacilityId)
        {
            return Ok();
        }

        [HttpDelete("{FacilityId: guid}")]
        public async Task<IActionResult> DeleteFacility(Guid FacilityId)
        {
            return Ok();
        }
    }
}
