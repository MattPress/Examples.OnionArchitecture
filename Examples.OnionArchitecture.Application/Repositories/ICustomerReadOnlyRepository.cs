namespace Examples.OnionArchitecture.Application.Repositories
{
    using Examples.OnionArchitecture.Domain.Customers;
    using System;
    using System.Threading.Tasks;

    public interface ICustomerReadOnlyRepository
    {
        Task<Customer> Get(Guid id);
    }
}
