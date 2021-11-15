using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Original.API.DomainModels;

namespace Original.API.Data.EntityTypeConfigurations
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.ToTable();

            builder.HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "",
                    LastName = "",
                    EmailAddress = ""
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "",
                    LastName = "",
                    EmailAddress = ""
                });
        }
    }
}
