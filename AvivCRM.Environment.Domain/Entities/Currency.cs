namespace AvivCRM.Environment.Domain.Entities;
public class Currency
{
    public Guid Id { get; set; }
    public string? CurrencyName { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? CurrencyCode { get; set; }
    public string? IsCryptocurrency { get; set; }
    public int USDPrice { get; set; }
    public int ExchangeRate { get; set; }
    public string? CurrencyPosition {get;set;}
    public string? ThousandSeparator {get;set;}
    public string? DecimalSeparator {get;set;}
    public int NumberofDecimals { get;set;}
    public ICollection<Applications> Applications { get; set; } = new List<Applications>();
}
