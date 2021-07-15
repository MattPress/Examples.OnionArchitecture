namespace Examples.OnionArchitecture.Application.UseCases.Withdraw
{
    using Examples.OnionArchitecture.Domain.Accounts;
    using Examples.OnionArchitecture.Domain.ValueObjects;

    public sealed class WithdrawOutput
    {
        public TransactionOutput Transaction { get; }
        public double UpdatedBalance { get; }

        public WithdrawOutput(Debit transaction, Amount updatedBalance)
        {
            Transaction = new TransactionOutput(
                transaction.Description,
                transaction.Amount,
                transaction.TransactionDate);

            UpdatedBalance = updatedBalance;
        }
    }
}
