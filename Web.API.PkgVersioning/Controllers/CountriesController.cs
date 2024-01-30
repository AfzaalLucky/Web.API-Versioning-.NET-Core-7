using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Web.API.PkgVersioning.Models.DTOs;

namespace Web.API.PkgVersioning.Controllers
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("[controller]")]
    [ApiVersion(1)]
    [ApiVersion(2)]
    public class CountriesController : ControllerBase
    {
        [MapToApiVersion(1)]
        [HttpGet]
        public IActionResult GetV1()
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

        [MapToApiVersion(2)]
        [HttpGet]
        public IActionResult GetV2()
        {
            var countriesDomainModel = CountriesData.Get();

            // Map Domain Model to DTO
            var response = new List<CountryDtoV2>();
            foreach (var countryDomain in countriesDomainModel)
            {
                response.Add(new CountryDtoV2
                {
                    Id = countryDomain.Id,
                    CountryName = countryDomain.Name
                });
            }

            return Ok(response);
        }
    }
}