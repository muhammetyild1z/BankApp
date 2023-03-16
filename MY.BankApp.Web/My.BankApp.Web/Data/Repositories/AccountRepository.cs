using My.BankApp.Web.Data.Context;
using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Data.Interfaces;
using My.BankApp.Web.Models;

namespace My.BankApp.Web.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public void CreateAccountRepository(Account model)
        {
            _context.Accounts.Add(model);
            _context.SaveChanges();
        }
    }
}
