using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditProductInShoppingList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoppingListId",
                table: "ProductInShoppingList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoppingListId",
                table: "ProductInShoppingList");
        }
    }
}
