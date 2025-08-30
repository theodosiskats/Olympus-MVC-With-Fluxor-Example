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
        FetchLoanAccountStatusDetails();
        base.OnInitialized();
    }

    private void FetchLoanAccountStatusDetails()
    {
        //Faking a call to the Orchestrator
        var fetchedDataFromOrchestrator = GetLoanAccountStatusConsumer.GetLoanAccountStatusDetails();
        Model = LoanAccountStatusViewModel.MapFromDto(fetchedDataFromOrchestrator);
        DispatchChanges();
    }

    private void DispatchChanges()
    {
        Dispatcher.Dispatch(Model);
        StateHasChanged();
    }
}