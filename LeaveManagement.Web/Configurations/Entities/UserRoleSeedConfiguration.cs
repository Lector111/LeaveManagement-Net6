using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e206ae07-e677-4aba-92aa-e85d43bb9baf",
                    UserId = "e206ae07-e677-4aba-92cc-e85d43bb9baf"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "e206aea7-e677-4aba-92cc-e85d43bb9baf",
                    UserId = "f8070bd8-3380-4b73-ba3e-091549e282b5"
                }
            );
        }
    }
}