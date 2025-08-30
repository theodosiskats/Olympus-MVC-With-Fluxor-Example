using CSB2.Client.ViewModels;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Orchestrator;
using ViewModels;

namespace CSB2.Client.Pages.Components;

public partial class LoanAccountStatus
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }
    
    private LoanAccountStatusViewModel Model { get; set; } = new();

    protected override void OnInitialized()
    {
        FetchLoanAccountStatus();
        base.OnInitialized();
    }

    private void FetchLoanAccountStatus()
    {
        //Faking a call to the Orchestrator
        var fetchedDataFromOrchestrator = GetLoanAccountStatusConsumer.GetLoanAccountStatusDetails();
        Model = LoanAccountStatusViewModel.MapFromDto(fetchedDataFromOrchestrator);
    }

    private void DispatchChanges()
    {
        Dispatcher.Dispatch(Model);
    }
}