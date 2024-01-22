using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_NANY.Migrations
{
    public partial class Enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildProfile",
                columns: table => new
                {
                    Child_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Child_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildProfile", x => x.Child_Id);
                });

            migrationBuilder.CreateTable(
                name: "NanyProfile",
                columns: table => new
                {
                    Nany_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nany_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    NPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NanyProfile", x => x.Nany_Id);
                });

            migrationBuilder.CreateTable(
                name: "NanySchedule",
                columns: table => new
                {
                    Schedule_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shift_Id = table.Column<int>(type: "int", nullable: false),
                    Nany_Id = table.Column<int>(type: "int", nullable: false),
                    Child_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NanySchedule", x => x.Schedule_Id);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RePass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Shift_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    shift_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shift_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Shift_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildProfile");

            migrationBuilder.DropTable(
                name: "NanyProfile");

            migrationBuilder.DropTable(
                name: "NanySchedule");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "Shift");
        }
    }
}
