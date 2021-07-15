﻿namespace Examples.OnionArchitecture.Application.Repositories
{
    using Examples.OnionArchitecture.Domain.Accounts;
    using System;
    using System.Threading.Tasks;

    public interface IAccountReadOnlyRepository
    {
        Task<Account> Get(Guid id);        
    }
}
