using CSB2.Client.Pages.Components;
using CSB2.Client.State;
using CSB2.Client.ViewModels;
using Fluxor;
using Microsoft.AspNetCore.Components;
using ViewModels;

namespace CSB2.Client.Pages;

public partial class CreateFullyAmortizedAccount
{
    [Inject] 
    private IState<AppState.LoanAccountStatusState> LoanAccountStatusState { get; set; } = null!;
    
    [Inject]
    private IActionSubscriber ActionSubscriber { get; set; } = null!;
    
    private CreateFullyAmortizedAccountRequestDto Model { get; set; } = new();
    
    protected override void OnInitialized()
    {
        SubscribeToActions();
        base.OnInitialized();
    }

    private void SubscribeToActions()
    {
        SubscribeToAction<LoanAccountStatus.UpdateLoanAccountStatusAction>(HandleLoanAccountStatusChange);
    }

    private void HandleLoanAccountStatusChange(LoanAccountStatus.UpdateLoanAccountStatusAction data)
    {
        Model.LoanAccountStatus = LoanAccountStatusViewModel.MapToDto(data.Model);
    }
}