using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PublishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c869d6-f83f-4009-9619-70b3446e81bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59186202-a0f1-4261-b3d0-5102fe547441");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "800e9453-3869-42be-8c9b-22b7f4fec9ac", "8db685b5-2953-44af-84cd-af744d84083d", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3724b9a-822a-4f9d-b3e6-6ff08a117ae0", "6eba0675-1c7c-4910-bff9-55835ffa9292", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800e9453-3869-42be-8c9b-22b7f4fec9ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3724b9a-822a-4f9d-b3e6-6ff08a117ae0");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09c869d6-f83f-4009-9619-70b3446e81bd", "00accdea-3d7d-4e85-bb31-ac5ebb246807", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59186202-a0f1-4261-b3d0-5102fe547441", "0f5261c9-4675-4b56-8d1a-4e85e20744c1", "Instructor", "INSTRUCTOR" });
        }
    }
}
