using System.Collections.Generic;
using System.Linq;
using Yıldırım.BankApp.Data.Context;
using Yıldırım.BankApp.Data.Entities;
using Yıldırım.BankApp.Data.İnterfaces;
using Yıldırım.BankApp.Models;

namespace Yıldırım.BankApp.Data.Repositories
{
    public class ApplicationUserRepository: IApplicationUserRepository
    {
        private BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        public BankContext Context { get; }

       
        public ApplicationUser GetById(int id)
        {
            return Context.ApplicationUsers.SingleOrDefault(
                x => x.Id == id);
        }
        public void Create(ApplicationUser user)
        {
            //var test = _context.ApplicationUsers;
            //var test2 = _context.Set<ApplicationUser>();
            //_context.ApplicationUsers.Add(user);
            _context.Set<ApplicationUser>().Add(user);
            _context.SaveChanges();
        }
        public void Remove(ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Remove(user);
            _context.SaveChanges();
        }
        public List<ApplicationUser> GetAll()
        {
            return _context.Set<ApplicationUser>().ToList();
        }

    }
}
