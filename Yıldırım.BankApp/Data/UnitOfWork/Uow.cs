using Yıldırım.BankApp.Data.Context;
using Yıldırım.BankApp.Data.İnterfaces;
using Yıldırım.BankApp.Data.Repositories;

namespace Yıldırım.BankApp.Data.UnitOfWork
{
    public class Uow :IUow
    {
        private readonly BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
