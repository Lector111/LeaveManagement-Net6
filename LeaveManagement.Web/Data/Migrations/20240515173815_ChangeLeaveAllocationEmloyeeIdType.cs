using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangeLeaveAllocationEmloyeeIdType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92aa-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "212a541c-8638-4aee-808c-8c08a071780e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206aea7-e677-4aba-92cc-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "b5e1c936-c805-4d53-a7c0-46b6fcae3c2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92cc-e85d43bb9baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5aca268-fc60-4466-ad94-f8a63bcb4581", "AQAAAAEAACcQAAAAENHcTKQQqE/UrL0xcfOSAmTdYafKyaKi9+rzAIWJtHxSIlRrrfqkHncW+ZDEMjQoGQ==", "b4540fcf-dda3-4c28-a4c1-90a83c69c01c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d4fe45-b827-4570-8c1f-8625384110ab", "AQAAAAEAACcQAAAAEOBfui2yD8Al8jjCY6oegTBj8joZzzP/n4yoAvUew8q72s7AjSSWHolokAlsvc1RvA==", "37499752-54e5-4601-91a9-4cf2adeac065" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92aa-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "514fd101-37a8-47bd-abbe-347919e81cf5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e206aea7-e677-4aba-92cc-e85d43bb9baf",
                column: "ConcurrencyStamp",
                value: "200f420f-cdbe-43c2-a580-76e1b02f0476");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e206ae07-e677-4aba-92cc-e85d43bb9baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0e935c6-6e99-4295-b8a0-c5a29d773e3b", "AQAAAAEAACcQAAAAEHHrdycMYstTYlWy0kah4PDT+Bkei7FOuvkRpJKqdQsi7XsnFELE7kt/LQ+JPDC2ZA==", "44ceee8a-edfe-4e3e-aaad-4d26143bd600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13bfecb9-354a-4791-94c2-6cf230ec31f5", "AQAAAAEAACcQAAAAEG0vuQ6bwgKlA0aWJ1EbwK4c2iwvrFsu8UIKwLXRV2aA7PfE+JjnwFKpeMovWSR92Q==", "48e1bc35-7c38-4b68-85a7-0de88e30234b" });
        }
    }
}
