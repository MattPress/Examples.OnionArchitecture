namespace Examples.OnionArchitecture.Domain.Accounts
{
    using Examples.OnionArchitecture.Domain.ValueObjects;
    using System;

    public interface ITransaction
    {
        Amount Amount { get; }
        string Description { get; }
        DateTime TransactionDate { get; }
    }
}
