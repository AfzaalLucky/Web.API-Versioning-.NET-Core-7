using Web.API_Versioning.Models.Domain;

namespace Web.API_Versioning
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[] {
                new {Id =1, Name = "United States"},
                new {Id =2, Name = "United Kingdom"},
                new {Id =3, Name = "Saudi Arabia"},
                new {Id =4, Name = "Egypt"},
                new {Id =5, Name = "Iraq"},
                new {Id =6, Name = "Iran"},
                new {Id =7, Name = "Oman"},
                new {Id =8, Name = "United Arab Emirates"},
                new {Id =9, Name = "Indiana"},
                new {Id =10, Name = "Bahrain"},
            };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
