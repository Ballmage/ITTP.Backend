using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTP.Persistance.Migrations
{
    public partial class OneMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RevokedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    RevokedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Admin", "Birthday", "CreatedBy", "CreatedOn", "Gender", "Login", "ModifiedBy", "ModifiedOn", "Name", "Password", "RevokedBy", "RevokedOn" },
                values: new object[] { "7b1bb49b-fe35-4747-93d4-cd3da1131a6f", true, new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "database", new DateTime(2023, 5, 28, 17, 36, 29, 464, DateTimeKind.Local).AddTicks(7154), 1, "admin", null, null, "Николай", "asd123", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
