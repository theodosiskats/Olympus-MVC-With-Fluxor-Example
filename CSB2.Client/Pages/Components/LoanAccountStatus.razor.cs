using CSB2.Client.ViewModels;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace CSB2.Client.Pages.Components;

public partial class LoanAccountStatus
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }
    
    private LoanAccountStatusViewModel Model { get; set; } = new();

    private void DispatchChanges()
    {
        Dispatcher.Dispatch(Model);
    }
}