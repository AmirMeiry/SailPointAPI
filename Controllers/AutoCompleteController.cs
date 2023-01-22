using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SailPointAPI.Models;
using SailPointAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace SailPointAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoCompleteController : ControllerBase
    {
        private readonly ICitiesRepository _citiesRepository;
        public AutoCompleteController(ICitiesRepository CitiesRepository)
        {
            _citiesRepository = CitiesRepository;
        }
        [HttpGet]
        public IActionResult Get(string prefix)
        {
            try
            {
                if (string.IsNullOrEmpty(prefix)) return Ok(string.Empty);
                var suggestions = GetSuggestions(prefix);
                return Ok(suggestions);
            }
            catch(Exception ex)
            {
                return NotFound(string.Empty);
            }
        }
        private List<string> GetSuggestions(string prefix)
        {
            var cities = _citiesRepository.GetCityNameByPrefix(prefix);
            return cities.Select(x => x.CityName).ToList();
        }
    }
}
