using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yıldırım.BankApp.Data.Entities;

namespace Yıldırım.BankApp.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.AccountNumber).IsRequired(true);

            builder.Property(x => x.Balance).HasColumnType("decimal(18,3)");
            builder.Property(x => x.Balance).IsRequired(true);
            
        }

        
    }
}
