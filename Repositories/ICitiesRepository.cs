using SailPointAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailPointAPI.Repositories
{
    public interface ICitiesRepository
    {
        Task<IEnumerable<City>> Get();
        Task<City> Get(string cityName);
        List<City> GetCityNameByPrefix(string cityName);
        Task<City> Create(City city);
        Task Update(City city);
        Task Delete(string cityName);
    }
}
