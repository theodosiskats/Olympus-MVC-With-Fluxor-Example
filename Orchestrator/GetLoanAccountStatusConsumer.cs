using ViewModels;

namespace Orchestrator;

public static class GetLoanAccountStatusConsumer
{
    public static LoanAccountStatusDto GetLoanAccountStatusDetails()
    {
        return new LoanAccountStatusDto()
        {
            AccountStatusCode = "1",
            AccountStatusDescription = "Active",
            DelinquencyStateCode = "1",
            DelinquencyStateDescription = "No Delinquency",
            InterestDelinquencyDays = 0,
            CapitalDelinquencyDays = 0,
            InterestFreeFrom = new DateOnly(2023, 1, 1),
            StatementType = 1,
        };
    }
        
}