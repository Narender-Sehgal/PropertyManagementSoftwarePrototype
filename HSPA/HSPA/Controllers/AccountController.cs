using HSPA.Models;
using HSPA.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountRepository accountRepository;
        public AccountController(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("Register")]
        public async Task<IActionResult> Register(TblAccount account)
        {
            try
            {
                await accountRepository.Create(account);
                return Ok(account);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Produces("application/json")]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            try
            {
                return Ok(accountRepository.Login(Email, Password));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
