namespace ViewModels;

public class CreateOpenRevolvingAccountRequestDto
{
    public LoanAccountStatusDto? LoanAccountStatus { get; set; } = new();
}