namespace ViewModels;

public class CreateFullyAmortizedAccountRequestDto
{
    public LoanAccountStatusDto? LoanAccountStatus { get; set; } = new();
}