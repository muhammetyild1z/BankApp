using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Models;

namespace My.BankApp.Web.Data.Mapping
{
    public class AccountMap: IAccountMapper
    {
        public Account AccountCreateModelToAccount(AccountCreateModel createModel )
        {
            return new Account
            {
                Bakance = createModel.Bakance,
                ApplicationUserId = createModel.ApplicationUserId,
                AccountNumber = createModel.AccountNumber,
               
            };

        }
    }
}
