namespace Examples.OnionArchitecture.Application.UseCases.Deposit
{
    using Examples.OnionArchitecture.Domain.Accounts;
    using Examples.OnionArchitecture.Domain.ValueObjects;

    public sealed class DepositOutput
    {
        public TransactionOutput Transaction { get; }
        public double UpdatedBalance { get; }

        public DepositOutput(
            Credit credit,
            Amount updatedBalance)
        {
            Transaction = new TransactionOutput(
                credit.Description,
                credit.Amount,
                credit.TransactionDate);

            UpdatedBalance = updatedBalance;
        }
    }
}
