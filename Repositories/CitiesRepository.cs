using Microsoft.EntityFrameworkCore;
using SailPointAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailPointAPI.Repositories
{
    public class CitiesRepository : ICitiesRepository
    {
        private readonly CitiesContext _context;
        public CitiesRepository(CitiesContext context)
        {
            _context = context;
        }
        public async Task<City> Create(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return city;
            //throw new NotImplementedException();
        }

        public async Task Delete(string cityName)
        {
            var cityToDelete = await _context.Cities.FindAsync(cityName);
            _context.Cities.Remove(cityToDelete);
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<City>> Get()
        {
            return await _context.Cities.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<City> Get(string cityName)
        {
            return await _context.Cities.FindAsync(cityName);
            //throw new NotImplementedException();
        }

        public List<City> GetCityNameByPrefix(string cityName)
        {
            return _context.Cities.Where(c => EF.Functions.Like(c.CityName, $"{cityName}%")).ToList<City>();
            //throw new NotImplementedException();
        }

        public async Task Update(City city)
        {
            _context.Entry(city).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }
    }
}
