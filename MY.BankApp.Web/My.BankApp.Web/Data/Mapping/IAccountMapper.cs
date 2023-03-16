using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Models;

namespace My.BankApp.Web.Data.Mapping
{
    public interface IAccountMapper
    {
        Account AccountCreateModelToAccount(AccountCreateModel createModel);
    }
}
