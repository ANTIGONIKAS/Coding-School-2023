using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orm.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_PetFood_PetFoodID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_PetFood_PetFoodID",
                table: "TransactionLine",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine",
                column: "SpecialOfferID",
                principalTable: "SpecialOffer",
                principalColumn: "SpecialOfferID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_PetFood_PetFoodID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_PetFood_PetFoodID",
                table: "TransactionLine",
                column: "PetFoodID",
                principalTable: "PetFood",
                principalColumn: "PetFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_SpecialOffer_SpecialOfferID",
                table: "TransactionLine",
                column: "SpecialOfferID",
                principalTable: "SpecialOffer",
                principalColumn: "SpecialOfferID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
