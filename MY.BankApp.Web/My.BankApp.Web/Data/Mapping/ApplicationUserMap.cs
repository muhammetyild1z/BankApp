using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace My.BankApp.Web.Data.Mapping
{
    public class ApplicationUserMap: IApplicationMapper
    {
        public List<UserListModel>MapToListOfUserList(List<ApplicationUser> users)
        {
            return users.Select(x=> new UserListModel
            {
                Id= x.Id,
                Name= x.Name,
                SurName= x.SurName
            }).ToList();
        }

        public UserListModel MapToUser(ApplicationUser user)
        {
            return new UserListModel
            {
                Id = user.Id,
                Name = user.Name,
                SurName = user.SurName
            };
        }
    }
}
