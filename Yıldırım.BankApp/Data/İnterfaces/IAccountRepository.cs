using Yıldırım.BankApp.Data.Entities;

namespace Yıldırım.BankApp.Data.İnterfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
        object GetQueryable();
    }
}
