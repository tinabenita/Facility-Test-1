using FEM.Core.Facility.Application.Interfaces;
using FEM.Core.Facility.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FEM.Core.Facility.Api.Controllers;

//[Authorize(Roles = )]
[Route("api/[controller]")]
[ApiController]
public class FacilityController : ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetFacilities()
    {
        //TODO: Get org id and user id from JWT token
        Guid orgId = Guid.NewGuid();
        Guid userId = Guid.NewGuid();

        //TODO: List of facilities = 

        IGetUsersFacilities getUsersFacilities = new GetUsersFacilities();

        return Ok(getUsersFacilities.GetByOrgId());
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
