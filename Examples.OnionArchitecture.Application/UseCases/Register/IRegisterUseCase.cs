namespace Examples.OnionArchitecture.Application.UseCases.Register
{
    using System.Threading.Tasks;

    public interface IRegisterUseCase
    {
        Task<RegisterOutput> Execute(string pin, string name, double initialAmount);
    }
}
