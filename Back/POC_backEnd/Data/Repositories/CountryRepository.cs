using POC_backEnd.Context;
using POC_backEnd.Data.Interface;
using POC_backEnd.Models;

namespace POC_backEnd.Data.Repositories;

public class CountryRepository : ICountryRepository
{
    public readonly PocTotalMediaContext _context;

    public CountryRepository(PocTotalMediaContext context)
    {
        _context = context;
    }

    public IEnumerable<Country> GetCountries()
    {
        var countryList = _context.country.ToList();

        return countryList;
    }
}
