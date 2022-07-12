using HSPA.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPA.Models.Repositories
{
    public class PropertyRepository : GenericRepository<TblProperty>, IPropertyRepository
    {
        public PropertyRepository(HSPAContext hSPAContext) : base(hSPAContext)
        {
        }

        public List<TblProperty> Search(string keyword)
        {
            return GetAll().Where(p => p.PropertyType.Contains(keyword)).ToList();
        }
    }
}
