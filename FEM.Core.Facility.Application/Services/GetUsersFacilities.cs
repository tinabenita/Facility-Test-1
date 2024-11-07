using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FEM.Core.Facility.Application.Interfaces;

namespace FEM.Core.Facility.Application.Services;

public class GetUsersFacilities : IGetUsersFacilities
{
    public IEnumerable<Domain.Facility> GetByOrgId(Guid UserId, Guid OrgId)
    {
        throw new NotImplementedException();
    }
}
