using ViewModels;

namespace CSB2.Client.ViewModels;

public class LoanAccountStatusViewModel
{
    public string? AccountStatusCode { get; set; }
    public string? AccountStatusDescription { get; set; }
    public string? DelinquencyStateCode { get; set; }
    public string? DelinquencyStateDescription { get; set; }
    public int? InterestDelinquencyDays { get; set; }
    public int? CapitalDelinquencyDays { get; set; }
    public DateOnly? InterestFreeFrom { get; set; }
    public int? StatementType { get; set; }
    public int? JointAccountType { get; set; }
    public int? Period { get; set; }
    public int? DecreaseTypeCode { get; set; }


    public static LoanAccountStatusViewModel MapFromDto(LoanAccountStatusDto dto)
    {
        return new LoanAccountStatusViewModel
        {
            AccountStatusCode = dto.AccountStatusCode,
            AccountStatusDescription = dto.AccountStatusDescription,
            DelinquencyStateCode = dto.DelinquencyStateCode,
            DelinquencyStateDescription = dto.DelinquencyStateDescription,
            InterestDelinquencyDays = dto.InterestDelinquencyDays,
            CapitalDelinquencyDays = dto.CapitalDelinquencyDays,
            InterestFreeFrom = dto.InterestFreeFrom,
            StatementType = dto.StatementType,
            JointAccountType = dto.JointAccountType,
            Period = dto.Period,
            DecreaseTypeCode = dto.DecreaseTypeCode
        };
    }

    public static LoanAccountStatusDto MapToDto(LoanAccountStatusViewModel vm)
    {
        return new LoanAccountStatusDto
        {
            AccountStatusCode = vm.AccountStatusCode,
            AccountStatusDescription = vm.AccountStatusDescription,
            DelinquencyStateCode = vm.DelinquencyStateCode,
            DelinquencyStateDescription = vm.DelinquencyStateDescription,
            InterestDelinquencyDays = vm.InterestDelinquencyDays,
            CapitalDelinquencyDays = vm.CapitalDelinquencyDays,
            InterestFreeFrom = vm.InterestFreeFrom,
            StatementType = vm.StatementType,
            JointAccountType = vm.JointAccountType,
            Period = vm.Period,
            DecreaseTypeCode = vm.DecreaseTypeCode
        };
    }
}