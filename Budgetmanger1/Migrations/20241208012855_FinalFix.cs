using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Budgetmanger1.Migrations
{
    /// <inheritdoc />
    public partial class FinalFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Transactions",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transactions",
                newName: "IX_Transactions_MyProperty");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transactions",
                type: "nvarchar(75)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_MyProperty",
                table: "Transactions",
                column: "MyProperty",
                principalTable: "Categories",
                principalColumn: "MyProperty",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_MyProperty",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Transactions",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_MyProperty",
                table: "Transactions",
                newName: "IX_Transactions_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transactions",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "MyProperty",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
