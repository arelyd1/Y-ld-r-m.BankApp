using Yıldırım.BankApp.Data.İnterfaces;

namespace Yıldırım.BankApp.Data.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class, new();
        void SaveChanges();
        
    }
}
