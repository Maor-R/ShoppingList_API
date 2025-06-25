using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListAPI.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingListNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ShoppingLists");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ShoppingLists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ShoppingLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ShoppingLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
