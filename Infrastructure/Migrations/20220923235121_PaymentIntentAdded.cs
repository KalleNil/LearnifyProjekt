using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PaymentIntentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e40914e-3585-4139-b1d2-d4712583c346");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b65fc8d-6bcb-4176-8232-c0a1291c10c8");

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "282d6379-94d4-4d14-8ed2-2ad9dee0e97b", "e5482346-1b5a-411f-82cf-461aef11eb50", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09038785-79fd-474b-8cb0-24c54a1f4e92", "37e1d477-d64d-48ed-8375-145c16180dbe", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09038785-79fd-474b-8cb0-24c54a1f4e92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "282d6379-94d4-4d14-8ed2-2ad9dee0e97b");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Basket");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b65fc8d-6bcb-4176-8232-c0a1291c10c8", "6516273a-99b9-4d5d-92fb-00c42139a99e", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e40914e-3585-4139-b1d2-d4712583c346", "45881c62-17ed-448f-b660-f5362084f27b", "Instructor", "INSTRUCTOR" });
        }
    }
}
