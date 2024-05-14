using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRolesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92aa-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "efdd5ee1-c0d2-4c52-9286-2a703ff3b560");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206aea7-e677-4aba-92cc-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "fe4e1ae3-3a91-4375-8882-1ca3a64bf9d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92cc-e85d43bb9baf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "abc13d7e-7159-4105-ae59-d5d16b4373d9", true, "LECTORCORP@INBOX.LV", "AQAAAAEAACcQAAAAEAqsRiuFEGj1Rpkz7lcgI6jnJETG4YqWjWGrW1GbIyr46sY4D1jYH9HabnWkzlukpw==", "efd519e7-8012-4210-8f4c-2dcfdc489b4a", "lectorcorp@inbox.lv" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9802bde9-f9af-4f28-a193-ec289351008b", true, "LECTORCORP@HER.COM", "AQAAAAEAACcQAAAAEG1BM3VvYUPOMZWUWLOjteIetvM/aADNocanLVAJNLE8SYe0vm1T8xcZ1BKo+3dxtQ==", "6a2904c0-d065-4762-81d0-da2816739947", "lectorcorp@her.lv" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92aa-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "b613e3e1-45a3-454a-a91a-f6574fc80b75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206aea7-e677-4aba-92cc-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "8b4ddbb8-211b-4266-964c-60b6769484c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92cc-e85d43bb9baf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "59b82dba-c226-4056-8859-e11befcedc03", false, null, "AQAAAAEAACcQAAAAEDaA8Gsri2v2gdI4N3e2TA+49Etfd0kbeBwCgQLokEmwd6/P/mVSTbrsWzb39zDkNw==", "f6829258-f47e-4d9f-b389-b4cdf5b586ec", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "683c061e-e4f7-4947-86dc-0ec4ef017626", false, null, "AQAAAAEAACcQAAAAELoCW73F9mgwo7wrrPHgjWWGok6rwCoyD6w4gMXRfWEh9ea2GOxLSTszYE/dP0mFeg==", "6c27b9e6-9227-49c3-b9be-5931766746f2", null });
        }
    }
}
