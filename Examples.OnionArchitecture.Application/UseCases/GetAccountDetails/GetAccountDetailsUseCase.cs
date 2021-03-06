namespace Examples.OnionArchitecture.Application.UseCases.GetAccountDetails
{
    using System.Threading.Tasks;
    using Examples.OnionArchitecture.Application.Repositories;
    using System;
    using Examples.OnionArchitecture.Domain.Accounts;

    public sealed class GetAccountDetailsUseCase : IGetAccountDetailsUseCase
    {
        private readonly IAccountReadOnlyRepository _accountReadOnlyRepository;

        public GetAccountDetailsUseCase(IAccountReadOnlyRepository accountReadOnlyRepository)
        {
            _accountReadOnlyRepository = accountReadOnlyRepository;
        }

        public async Task<AccountOutput> Execute(Guid accountId)
        {
            Account account = await _accountReadOnlyRepository.Get(accountId);

            if (account == null)
                throw new AccountNotFoundException($"The account {accountId} does not exists or is not processed yet.");

            AccountOutput output = new AccountOutput(account);
            return output;
        }
    }
}
