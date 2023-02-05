using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
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
                    EmployeeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SalaryPerMonth = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false),
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
                    MonthlyLedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Month = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Income = table.Column<double>(type: "float(20)", precision: 20, nullable: false),
                    Expenses = table.Column<double>(type: "float(15)", precision: 15, nullable: false),
                    Total = table.Column<double>(type: "float(20)", precision: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => x.MonthlyLedID);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PetType = table.Column<int>(type: "int", nullable: false),
                    PetStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false),
                    Cost = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false)
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
                    PetFoodPrice = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false),
                    PetFoodCost = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.PetFoodID);
                });

            migrationBuilder.CreateTable(
                name: "PetReports",
                columns: table => new
                {
                    PetReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    AnimalType = table.Column<int>(type: "int", nullable: false),
                    TotalSold = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetReports", x => x.PetReportID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float(10)", precision: 10, scale: 5, nullable: false),
                    PetPrice = table.Column<double>(type: "float(10)", precision: 10, nullable: false),
                    TotalPrice = table.Column<double>(type: "float(10)", precision: 10, scale: 5, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transaction_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Transaction_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_Transaction_PetFood_PetFoodID",
                        column: x => x.PetFoodID,
                        principalTable: "PetFood",
                        principalColumn: "PetFoodID");
                    table.ForeignKey(
                        name: "FK_Transaction_Pet_PetID",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "PetID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetFoodID",
                table: "Transaction",
                column: "PetFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "PetReports");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
