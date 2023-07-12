using System.Collections.Generic;
using System.Linq;
using Yıldırım.BankApp.Data.Context;
using Yıldırım.BankApp.Data.Entities;
using Yıldırım.BankApp.Data.İnterfaces;

namespace Yıldırım.BankApp.Data.Repositories
{
    public class AccountResponsitory : IAccountRepository
    {
        private readonly BankContext _context;
        public AccountResponsitory(BankContext context)
        {
            _context = context;
        }
        public void Create(Account account)
        {
            
            //_context.Accounts.Add(account);
            _context.Set<Account>().Add(account);
            _context.SaveChanges();
        }
        public void Remove(Account account)
        {
            _context.Set<Account>().Remove(account);
            _context.SaveChanges();
        }
        public List<Account> GetAll()
        {
            return _context.Set<Account>().ToList();
        }

        void IAccountRepository.Create(Account account)
        {
            throw new System.NotImplementedException();
        }

        object IAccountRepository.GetQueryable()
        {
            throw new System.NotImplementedException();
        }
    }
}
