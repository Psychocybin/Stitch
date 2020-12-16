using Microsoft.EntityFrameworkCore.Migrations;

namespace PletkaRedka.Data.Migrations
{
    public partial class ChangeGalleryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Galleries");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Galleries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Galleries");

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
