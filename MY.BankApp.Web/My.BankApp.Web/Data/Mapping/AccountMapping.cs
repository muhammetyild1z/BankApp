using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My.BankApp.Web.Data.Entities;

namespace My.BankApp.Web.Data.Mapping
{
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x=>x.AccountNumber).IsRequired();

     
        }
    }
}
