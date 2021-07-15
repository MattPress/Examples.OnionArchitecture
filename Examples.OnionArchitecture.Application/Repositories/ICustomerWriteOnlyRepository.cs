namespace Examples.OnionArchitecture.Application.Repositories
{
    using Examples.OnionArchitecture.Domain.Customers;
    using System.Threading.Tasks;

    public interface ICustomerWriteOnlyRepository
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
    }
}
