using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.API_Versioning.Models.DTOs;

namespace Web.API_Versioning.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countriesDomainModel = CountriesData.Get();
            
            // Map Domain Model to DTO
            var response = new List<CountryDto>();
            foreach (var countryDomain in countriesDomainModel)
            {
                response.Add(new CountryDto
                {
                    Id = countryDomain.Id,
                    Name = countryDomain.Name
                });
            }

            return Ok(response);
        }
    }
}
