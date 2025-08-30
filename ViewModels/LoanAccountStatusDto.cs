namespace ViewModels;

public class LoanAccountStatusDto
{
    public string? AccountStatusCode { get; set; }
    public string? AccountStatusDescription { get; set; }
    public string? DelinquencyStateCode { get; set; }
    public string? DelinquencyStateDescription { get; set; }
    public int? InterestDelinquencyDays { get; set; }
    public int? CapitalDelinquencyDays { get; set; }
    public DateOnly? InterestFreeFrom { get; set; }
    public int? StatementType { get; set; }
    public int? JointAccountType { get; set; }
    public int? Period { get; set; }
    public int? DecreaseTypeCode { get; set; }
}