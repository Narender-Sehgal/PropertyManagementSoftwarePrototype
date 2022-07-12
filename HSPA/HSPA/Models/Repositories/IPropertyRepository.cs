using HSPA.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPA.Models.Repositories
{
    public interface IPropertyRepository : IGenericRepository<TblProperty>
    {
        public List<TblProperty> Search(string keyword);
    }
}

