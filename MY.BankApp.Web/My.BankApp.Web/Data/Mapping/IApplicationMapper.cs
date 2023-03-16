using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Models;
using System.Collections.Generic;

namespace My.BankApp.Web.Data.Mapping
{
    public interface IApplicationMapper
    {
         List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
         UserListModel MapToUser(ApplicationUser user);
    }
}
