using POC_backEnd.Context;
using POC_backEnd.Data.Interface;
using POC_backEnd.Models;

namespace POC_backEnd.Data.Repositories;

public class VatRateRepository : IVatRateRepository
{
    public readonly PocTotalMediaContext context;

    public VatRateRepository(PocTotalMediaContext context)
    {
        this.context = context;
    }

    public List<VatRate> GetAllVatRates()
    {
        return context.vatrates.ToList();
    }

    public List<VatRate> GetAllVatRatesByCountry(Country country)
    {
        var vatRates = new List<VatRate>();
        vatRates = context.vatrates.Where(s => s.CountryId == country.CountryId).ToList();

        return vatRates;
    }

    public List<VatRate> GetVatRatesByCountryName(string countryName)
    {
        var vatRates = new List<VatRate>();
        vatRates = context.vatrates.Where(s => s.Country.CountryName == countryName).ToList();

        return vatRates;
    }
}
