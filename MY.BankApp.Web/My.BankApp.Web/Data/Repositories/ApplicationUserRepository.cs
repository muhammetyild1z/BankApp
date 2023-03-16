using My.BankApp.Web.Data.Context;
using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My.BankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository: IApplicationRepostory
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> GetAll()
        {

            return _context.ApplicationUsers.ToList();
        }

        public ApplicationUser GetById(int id)
        {

            return _context.ApplicationUsers.FirstOrDefault(x => x.Id == id);
        }
    }
}
