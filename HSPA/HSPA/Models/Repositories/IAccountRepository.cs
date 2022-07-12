using HSPA.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPA.Models.Repositories
{
    public interface IAccountRepository : IGenericRepository<TblAccount>
    {
        public List<TblAccount> Login(string Email, string Password);
    }
}
