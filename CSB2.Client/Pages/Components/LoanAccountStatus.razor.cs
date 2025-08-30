using CSB2.Client.State;
using CSB2.Client.ViewModels;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace CSB2.Client.Pages.Components;

public partial class LoanAccountStatus
{
    [Inject] private IState<AppState.LoanAccountStatusState> LoanAccountStatusState { get; set; } = null!;
    [Inject] private IDispatcher Dispatcher { get; set; } = null!;
    
    private LoanAccountStatusViewModel Model { get; set; } = new();

    public record UpdateLoanAccountStatusAction(LoanAccountStatusViewModel Model);
    private void DispatchChanges()
    {
        Dispatcher.Dispatch(new UpdateLoanAccountStatusAction(Model));
    }
}