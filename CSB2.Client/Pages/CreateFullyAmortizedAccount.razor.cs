using CSB2.Client.ViewModels;
using Fluxor;
using Microsoft.AspNetCore.Components;
using ViewModels;

namespace CSB2.Client.Pages;

public partial class CreateFullyAmortizedAccount
{
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
        SubscribeToAction<LoanAccountStatusViewModel>(HandleLoanAccountStatusChange);
    }

    private void HandleLoanAccountStatusChange(LoanAccountStatusViewModel viewModel)
    {
        Model.LoanAccountStatus = LoanAccountStatusViewModel.MapToDto(viewModel);
    }
}