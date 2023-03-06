namespace POC_backEnd.Models;

public partial class Country
{
    public Country()
    {
        VatRates = new HashSet<VatRate>();
    }

    public int CountryId { get; set; }
    public string? CountryName { get; set; }

    public virtual ICollection<VatRate> VatRates { get; set; }
}
