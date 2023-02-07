using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class Five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");
        }
    }
}
