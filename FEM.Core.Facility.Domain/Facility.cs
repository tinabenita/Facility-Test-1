namespace FEM.Core.Facility.Domain;

/// <summary>
/// Facility Domain Class
/// </summary>
/// <param name="FacilityId">Facility Id</param>
/// <param name="Name">Name of the facility/building</param>
/// <param name="StreetAddress">Street Address of the facility</param>
/// <param name="City">City of the facility</param>
/// <param name="Country">Country of the facility</param>
/// <param name="Pincode">Pincode of the facility</param>
/// <param name="OrgId">Organization Id</param>
public record Facility(
    Guid FacilityId, 
    string Name,  
    string StreetAddress,
    string City,
    string Country,
    string Pincode,
    Guid OrgId
    );
