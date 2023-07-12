using Yıldırım.BankApp.Data.Entities;
using Yıldırım.BankApp.Models;

namespace Yıldırım.BankApp.Mapping
{
    public class AccountMapper :IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance,
            };
        }
    }
}

