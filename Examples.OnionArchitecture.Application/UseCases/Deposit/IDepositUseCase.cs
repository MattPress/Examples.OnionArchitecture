namespace Examples.OnionArchitecture.Application.UseCases.Deposit
{
    using Examples.OnionArchitecture.Domain.ValueObjects;
    using System;
    using System.Threading.Tasks;

    public interface IDepositUseCase
    {
        Task<DepositOutput> Execute(Guid accountId, Amount amount);
    }
}
