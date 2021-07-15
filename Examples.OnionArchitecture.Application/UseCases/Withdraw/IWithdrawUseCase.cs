namespace Examples.OnionArchitecture.Application.UseCases.Withdraw
{
    using Examples.OnionArchitecture.Domain.ValueObjects;
    using System;
    using System.Threading.Tasks;

    public interface IWithdrawUseCase
    {
        Task<WithdrawOutput> Execute(Guid accountId, Amount amount);
    }
}
