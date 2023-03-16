using My.BankApp.Web.Data.Entities;
using System.Collections.Generic;

namespace My.BankApp.Web.Data.Interfaces
{
    public interface IApplicationRepostory
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
