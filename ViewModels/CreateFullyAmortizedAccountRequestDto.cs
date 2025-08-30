namespace ViewModels;

public class CreateFullyAmortizedAccountRequestDto
{
    public string? AccountNumber { get; set; }
    public string? AccountName { get; set; }
    public string? AccountType { get; set; }
    public LoanAccountStatusDto? LoanAccountStatus { get; set; } = new();
    public string? CoDebtors { get; set; }
    public string? Administrators { get; set; }
}