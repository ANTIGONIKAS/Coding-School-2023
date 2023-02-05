using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Transaction");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "MonthlyLedger",
                newName: "TotalSold");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionLineID",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<double>(
                name: "TotalSold",
                table: "PetReports",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Pet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionID");

            migrationBuilder.CreateTable(
                name: "TransactionLine",
                columns: table => new
                {
                    TransactionLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", nullable: false),
                    PetFoodCost = table.Column<double>(type: "float", nullable: false),
                    PetPrice = table.Column<double>(type: "float", nullable: false),
                    PriceDiscount = table.Column<double>(type: "float", nullable: false),
                    LineTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLine", x => x.TransactionLineID);
                    table.ForeignKey(
                        name: "FK_TransactionLine_PetFood_PetFoodID",
                        column: x => x.PetFoodID,
                        principalTable: "PetFood",
                        principalColumn: "PetFoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLine_Pet_PetID",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLine_Transaction_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transaction",
                        principalColumn: "TransactionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_PetFoodID",
                table: "TransactionLine",
                column: "PetFoodID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_PetID",
                table: "TransactionLine",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_TransactionID",
                table: "TransactionLine",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropTable(
                name: "TransactionLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransactionLineID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "TotalSold",
                table: "MonthlyLedger",
                newName: "Total");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Transaction",
                type: "uniqueidentifier",
                maxLength: 100,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSold",
                table: "PetReports",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID");
        }
    }
}
