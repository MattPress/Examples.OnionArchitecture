namespace Examples.OnionArchitecture.Infrastructure.InMemoryDataAccess
{
    using Examples.OnionArchitecture.Domain.Accounts;
    using Examples.OnionArchitecture.Domain.Customers;
    using System.Collections.ObjectModel;

    public class Context
    {
        public Collection<Customer> Customers { get; set; }
        public Collection<Account> Accounts { get; set; }

        public Context()
        {
            Customers = new Collection<Customer>();
            Accounts = new Collection<Account>();
        }
    }
}
