using Fluxor;

namespace CSB2.Client.State;

[FeatureState]
public record AppState
{
    public bool IsInitialized { get; init; }

    public AppState()  // must have empty ctor for Fluxor
    {
        IsInitialized = false;
    }
    
    [FeatureState]
    public record LoanAccountStatusState
    (
        string? AccountStatusCode,
        string? AccountStatusDescription,
        string? DelinquencyStateCode,
        string? DelinquencyStateDescription,
        int? InterestDelinquencyDays,
        int? CapitalDelinquencyDays,
        DateOnly? InterestFreeFrom,
        int? StatementType,
        int? JointAccountType,
        int? Period,
        int? DecreaseTypeCode
    )
    {
        // Fluxor requires a parameterless ctor
        private LoanAccountStatusState() : this(null, null, null, null, null, null, null, null, null, null, null) { }
    }
}