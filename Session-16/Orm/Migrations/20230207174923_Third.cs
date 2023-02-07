using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Pet_PetID",
                table: "TransactionLine");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLine_PetID",
                table: "TransactionLine");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetFoodID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "PetFoodID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "PetID",
                table: "Transaction");

            migrationBuilder.AlterColumn<double>(
                name: "PetPrice",
                table: "TransactionLine",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodPrice",
                table: "TransactionLine",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodCost",
                table: "TransactionLine",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "LineTotal",
                table: "TransactionLine",
                type: "float(10)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<Guid>(
                name: "SpecialOfferID",
                table: "TransactionLine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SpecialOfferID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionLineID",
                table: "PetFood",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "SpecialOffer",
                columns: table => new
                {
                    SpecialOfferID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetFoodPrice = table.Column<double>(type: "float", nullable: false),
                    TransactionLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffer", x => x.SpecialOfferID);
                    table.ForeignKey(
                        name: "FK_SpecialOffer_PetFood_PetFoodID",
                        column: x => x.PetFoodID,
                        principalTable: "PetFood",
                        principalColumn: "PetFoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_PetID",
                table: "TransactionLine",
                column: "PetID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_SpecialOfferID",
                table: "TransactionLine",
                column: "SpecialOfferID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOffer_PetFoodID",
                table: "SpecialOffer",
                column: "PetFoodID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Pet_PetID",
                table: "TransactionLine",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine",
                column: "SpecialOfferID",
                principalTable: "SpecialOffer",
                principalColumn: "SpecialOfferID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Pet_PetID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine");

            migrationBuilder.DropTable(
                name: "SpecialOffer");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLine_PetID",
                table: "TransactionLine");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLine_SpecialOfferID",
                table: "TransactionLine");

            migrationBuilder.DropColumn(
                name: "SpecialOfferID",
                table: "TransactionLine");

            migrationBuilder.DropColumn(
                name: "SpecialOfferID",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "TransactionLineID",
                table: "PetFood");

            migrationBuilder.AlterColumn<double>(
                name: "PetPrice",
                table: "TransactionLine",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodPrice",
                table: "TransactionLine",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "PetFoodCost",
                table: "TransactionLine",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "LineTotal",
                table: "TransactionLine",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AddColumn<Guid>(
                name: "PetFoodID",
                table: "Transaction",
                type: "uniqueidentifier",
                maxLength: 30,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PetID",
                table: "Transaction",
                type: "uniqueidentifier",
                maxLength: 30,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_PetID",
                table: "TransactionLine",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetFoodID",
                table: "Transaction",
                column: "PetFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_PetFood_PetFoodID",
                table: "Transaction",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Pet_PetID",
                table: "TransactionLine",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
