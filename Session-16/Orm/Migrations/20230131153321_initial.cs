using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryPerMonth = table.Column<double>(type: "float", nullable: false),
                    EmployeeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyLedger",
                columns: table => new
                {
                    Total = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<double>(type: "float", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => x.Total);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetID);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.PetFoodID);
                });

            migrationBuilder.CreateTable(
                name: "PetReport",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    TotalSold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetReport", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetPrice = table.Column<double>(type: "float", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodQty = table.Column<double>(type: "float", nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "PetReport");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
