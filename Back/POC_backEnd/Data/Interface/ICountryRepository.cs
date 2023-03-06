using POC_backEnd.Models;

namespace POC_backEnd.Data.Interface
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
    }
}
