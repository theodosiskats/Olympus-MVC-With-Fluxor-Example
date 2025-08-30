using CSB2.Client.Pages.Components;
using Fluxor;

namespace CSB2.Client.State;

public class LoanAccountStatusReducers
{
    [ReducerMethod]
    public static AppState.LoanAccountStatusState ReduceUpdateLoanAccountStatus(
        AppState.LoanAccountStatusState state,
        LoanAccountStatus.UpdateLoanAccountStatusAction action) =>
        state with
        {
            AccountStatusCode = action.Model.AccountStatusCode,
            AccountStatusDescription = action.Model.AccountStatusDescription,
            DelinquencyStateCode = action.Model.DelinquencyStateCode,
            DelinquencyStateDescription = action.Model.DelinquencyStateDescription,
            InterestDelinquencyDays = action.Model.InterestDelinquencyDays,
            CapitalDelinquencyDays = action.Model.CapitalDelinquencyDays,
            InterestFreeFrom = action.Model.InterestFreeFrom,
            StatementType = action.Model.StatementType,
            JointAccountType = action.Model.JointAccountType,
            Period = action.Model.Period,
            DecreaseTypeCode = action.Model.DecreaseTypeCode
        };
    
    [ReducerMethod]
    public static AppState.LoanAccountStatusState ReduceUpdate(
        AppState.LoanAccountStatusState state,
        LoanAccountStatus.UpdateLoanAccountStatusAction action) =>
        state with
        {
            AccountStatusCode = action.Model.AccountStatusCode,
            AccountStatusDescription = action.Model.AccountStatusDescription
        };
}