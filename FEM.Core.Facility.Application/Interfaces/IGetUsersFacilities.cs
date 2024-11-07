using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fa = FEM.Core.Facility.Domain;

namespace FEM.Core.Facility.Application.Interfaces;

public interface IGetUsersFacilities
{
    public IEnumerable<fa.Facility> GetByOrgId(Guid UserId, Guid OrgId);
    
}
