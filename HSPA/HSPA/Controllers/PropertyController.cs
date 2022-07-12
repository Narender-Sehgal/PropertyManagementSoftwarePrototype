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
    [Route("api/property")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private IPropertyRepository propertyRepository;
        public PropertyController(IPropertyRepository _propertyRepository)
        {
            propertyRepository =  _propertyRepository;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var propertyList = propertyRepository.GetAll().ToList();
                return Ok(propertyList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Produces("application/json")]
        [HttpGet("find/{id}")]
        public async Task<IActionResult> Find(int id)
        {
            try
            {
                var propertyInfo = await propertyRepository.GetById(id);
                return Ok(propertyInfo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Produces("application/json")]
        [HttpGet("Search/{keyword}")]
        public async Task<IActionResult> Search(string keyword)
        {
            try
            {
                if(keyword != null)
                {
                    return Ok(propertyRepository.Search(keyword));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public async Task<IActionResult> Create(TblProperty property)
        {
            try
            {
                await propertyRepository.Create(property);
                return Ok(property);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPut("update")]
        public async Task<IActionResult> Update(TblProperty property)
        {
            try
            {
                await propertyRepository.Update(property.Id, property);
                return Ok(property);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await propertyRepository.Delete(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
