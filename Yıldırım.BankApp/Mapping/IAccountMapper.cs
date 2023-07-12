using Yıldırım.BankApp.Data.Entities;
using Yıldırım.BankApp.Models;

namespace Yıldırım.BankApp.Mapping
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
