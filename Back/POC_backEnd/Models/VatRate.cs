namespace POC_backEnd.Models;

public partial class VatRate
{
    public int VatRateId { get; set; }
    public decimal VatNumber { get; set; }
    public int CountryId { get; set; }

    public virtual Country? Country { get; set; }
}
