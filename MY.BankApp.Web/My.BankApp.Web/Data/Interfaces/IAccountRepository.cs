using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Models;

namespace My.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void CreateAccountRepository(Account model);
    }
}
