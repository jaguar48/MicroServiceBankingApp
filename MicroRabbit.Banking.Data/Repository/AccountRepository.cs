﻿using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _dbContext;

        public AccountRepository( BankingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts;

        }
    }
}
