using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicTechMVC.Data.Migrations
{
    public partial class AddDescriptionToCategoryItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CategoryItem",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItem");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CategoryItem");
        }
    }
}
