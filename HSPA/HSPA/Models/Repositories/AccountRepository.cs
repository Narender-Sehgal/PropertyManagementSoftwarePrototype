using HSPA.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPA.Models.Repositories
{
    public class AccountRepository : GenericRepository<TblAccount>, IAccountRepository
    {
        public AccountRepository(HSPAContext hSPAContext) : base(hSPAContext)
        {
        }

        public List<TblAccount> Login(string Email, string Password)
        {
            try
            { 
                if(Email != null && Password != null)
                {
                    return GetAll().Where(p => p.Email.Contains(Email) && p.Password.Contains(Password)).ToList();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    }
}
