using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e206ae07-e677-4aba-92aa-e85d43bb9baf", "b613e3e1-45a3-454a-a91a-f6574fc80b75", "Administrator", "ADMINISTRATOR" },
                    { "e206aea7-e677-4aba-92cc-e85d43bb9baf", "8b4ddbb8-211b-4266-964c-60b6769484c0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e206ae07-e677-4aba-92cc-e85d43bb9baf", 0, "59b82dba-c226-4056-8859-e11befcedc03", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lectorcorp@inbox.lv", false, "dasdasd", "asdasdasd", false, null, "LECTORCORP@INBOX.LV", null, "AQAAAAEAACcQAAAAEDaA8Gsri2v2gdI4N3e2TA+49Etfd0kbeBwCgQLokEmwd6/P/mVSTbrsWzb39zDkNw==", null, false, "f6829258-f47e-4d9f-b389-b4cdf5b586ec", null, false, null },
                    { "f8070bd8-3380-4b73-ba3e-091549e282b5", 0, "683c061e-e4f7-4947-86dc-0ec4ef017626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lectorcorp@her.lv", false, "User", "User", false, null, "LECTORCORP@HER.COM", null, "AQAAAAEAACcQAAAAELoCW73F9mgwo7wrrPHgjWWGok6rwCoyD6w4gMXRfWEh9ea2GOxLSTszYE/dP0mFeg==", null, false, "6c27b9e6-9227-49c3-b9be-5931766746f2", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e206ae07-e677-4aba-92aa-e85d43bb9baf", "e206ae07-e677-4aba-92cc-e85d43bb9baf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e206aea7-e677-4aba-92cc-e85d43bb9baf", "f8070bd8-3380-4b73-ba3e-091549e282b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e206ae07-e677-4aba-92aa-e85d43bb9baf", "e206ae07-e677-4aba-92cc-e85d43bb9baf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e206aea7-e677-4aba-92cc-e85d43bb9baf", "f8070bd8-3380-4b73-ba3e-091549e282b5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92aa-e85d43bb9baf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206aea7-e677-4aba-92cc-e85d43bb9baf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92cc-e85d43bb9baf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5");
        }
    }
}
