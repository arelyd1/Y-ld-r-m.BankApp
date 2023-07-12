using System.Collections.Generic;
using Yıldırım.BankApp.Data.Entities;
using Yıldırım.BankApp.Models;

namespace Yıldırım.BankApp.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);
    }
}
