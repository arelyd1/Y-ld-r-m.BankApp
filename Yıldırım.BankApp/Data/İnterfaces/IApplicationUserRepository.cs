using System.Collections.Generic;
using System.ComponentModel;
using Yıldırım.BankApp.Data.Entities;

namespace Yıldırım.BankApp.Data.İnterfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
