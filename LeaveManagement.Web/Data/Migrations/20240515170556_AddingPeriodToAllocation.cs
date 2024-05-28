using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc13d7e-7159-4105-ae59-d5d16b4373d9", "AQAAAAEAACcQAAAAEAqsRiuFEGj1Rpkz7lcgI6jnJETG4YqWjWGrW1GbIyr46sY4D1jYH9HabnWkzlukpw==", "efd519e7-8012-4210-8f4c-2dcfdc489b4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8070bd8-3380-4b73-ba3e-091549e282b5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9802bde9-f9af-4f28-a193-ec289351008b", "AQAAAAEAACcQAAAAEG1BM3VvYUPOMZWUWLOjteIetvM/aADNocanLVAJNLE8SYe0vm1T8xcZ1BKo+3dxtQ==", "6a2904c0-d065-4762-81d0-da2816739947" });
        }
    }
}
