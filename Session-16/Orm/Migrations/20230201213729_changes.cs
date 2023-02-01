using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PetReport",
                newName: "PetReportID");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Pet",
                newName: "PetType");

            migrationBuilder.RenameColumn(
                name: "AnimalType",
                table: "Pet",
                newName: "PetStatus");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transaction",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transaction",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "PetFoodQty",
                table: "Transaction",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodPrice",
                table: "Transaction",
                type: "float(8)",
                precision: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSold",
                table: "PetReport",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "PetFoodPrice",
                table: "PetFood",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<decimal>(
                name: "PetFoodCost",
                table: "PetFood",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "PetID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pet",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Pet",
                type: "decimal(5,2)",
                precision: 5,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pet",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Income",
                table: "MonthlyLedger",
                type: "float(20)",
                precision: 20,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Expenses",
                table: "MonthlyLedger",
                type: "float(15)",
                precision: 15,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "MonthlyLedger",
                type: "float(20)",
                precision: 20,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<Guid>(
                name: "MonthlyLedID",
                table: "MonthlyLedger",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<double>(
                name: "SalaryPerMonth",
                table: "Employee",
                type: "float(6)",
                precision: 6,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "Employee",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeSurname",
                table: "Employee",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "TIN",
                table: "Customer",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Customer",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerSurname",
                table: "Customer",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger",
                column: "MonthlyLedID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TransactionID",
                table: "Employee",
                column: "TransactionID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Transaction_TransactionID",
                table: "Employee",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Transaction_TransactionID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_PetFood_Transaction_TransactionID",
                table: "PetFood");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_PetFood_TransactionID",
                table: "PetFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger");

            migrationBuilder.DropIndex(
                name: "IX_Employee_TransactionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PetFoodCost",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "PetID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "MonthlyLedID",
                table: "MonthlyLedger");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeSurname",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerSurname",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "PetReportID",
                table: "PetReport",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PetType",
                table: "Pet",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "PetStatus",
                table: "Pet",
                newName: "AnimalType");

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Transaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10);

            migrationBuilder.AlterColumn<double>(
                name: "PetPrice",
                table: "Transaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10);

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodQty",
                table: "Transaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodPrice",
                table: "Transaction",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(8)",
                oldPrecision: 8);

            migrationBuilder.AlterColumn<int>(
                name: "TotalSold",
                table: "PetReport",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodPrice",
                table: "PetFood",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "PetFood",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Pet",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10);

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "Pet",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<double>(
                name: "Total",
                table: "MonthlyLedger",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(20)",
                oldPrecision: 20);

            migrationBuilder.AlterColumn<double>(
                name: "Income",
                table: "MonthlyLedger",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(20)",
                oldPrecision: 20);

            migrationBuilder.AlterColumn<double>(
                name: "Expenses",
                table: "MonthlyLedger",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(15)",
                oldPrecision: 15);

            migrationBuilder.AlterColumn<double>(
                name: "SalaryPerMonth",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(6)",
                oldPrecision: 6);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TIN",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyLedger",
                table: "MonthlyLedger",
                column: "Total");
        }
    }
}
