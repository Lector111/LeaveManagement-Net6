using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "e206ae07-e677-4aba-92cc-e85d43bb9baf",
                    Email = "lectorcorp@inbox.lv",
                    NormalizedEmail = "LECTORCORP@INBOX.LV",
                    UserName = "lectorcorp@inbox.lv",
                    NormalizedUserName = "LECTORCORP@INBOX.LV",
                    Firstname = "dasdasd",
                    Lastname = "asdasdasd",
                    PasswordHash = hasher.HashPassword(null, "Test111!"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "f8070bd8-3380-4b73-ba3e-091549e282b5",
                    Email = "lectorcorp@her.lv",
                    NormalizedEmail = "LECTORCORP@HER.COM",
                    UserName = "lectorcorp@her.lv",
                    NormalizedUserName = "LECTORCORP@HER.COM",
                    Firstname = "User",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Test111!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}