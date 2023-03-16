using Microsoft.EntityFrameworkCore;
using My.BankApp.Web.Data.Entities;
using My.BankApp.Web.Data.Mapping;

namespace My.BankApp.Web.Data.Context
{
    public class BankContext: DbContext
    {

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public BankContext(DbContextOptions<BankContext> options) :base(options) 
        {
        
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserMapping());
            modelBuilder.ApplyConfiguration(new AccountMapping());

            base.OnModelCreating(modelBuilder);
        }


    }
}
