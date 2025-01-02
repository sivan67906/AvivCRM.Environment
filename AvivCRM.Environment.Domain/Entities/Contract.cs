using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AvivCRM.Environment.Domain.Entities;
public class Contract
{
    public Guid Id { get; set; }
    public string? ContractPrefix { get; set; }
    public string? ContractNumberSeprator { get; set; }
    public int ContractNumberDigits { get; set; }
    public string? ContractNumberExample {  get; set; }


}
