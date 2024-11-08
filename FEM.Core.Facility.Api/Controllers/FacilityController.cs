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
    private readonly IGetUsersFacilities _getUserFacilities;

    public FacilityController(IGetUsersFacilities getUsersFacilities)
    {
        _getUserFacilities = getUsersFacilities;
    }
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

        //IGetUsersFacilities getUsersFacilities = new GetUsersFacilities();
        var result = _getUserFacilities.GetByOrgId(Guid.NewGuid(), Guid.NewGuid());
        return Ok(result);
    }

    [HttpGet("{FacilityId}")]
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

    [HttpPut("{FacilityId}")]
    public async Task<IActionResult> UpdateFacility(Guid FacilityId)
    {
        return Ok();
    }

    [HttpDelete("{FacilityId}")]
    public async Task<IActionResult> DeleteFacility(Guid FacilityId)
    {
        return Ok();
    }
}
