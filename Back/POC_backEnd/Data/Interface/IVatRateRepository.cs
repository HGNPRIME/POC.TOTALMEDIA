using POC_backEnd.Models;

namespace POC_backEnd.Data.Interface;

public interface IVatRateRepository
{
    List<VatRate> GetAllVatRates();
    List<VatRate> GetAllVatRatesByCountry(Country country);
    List<VatRate> GetVatRatesByCountryName(string countryName);
}
