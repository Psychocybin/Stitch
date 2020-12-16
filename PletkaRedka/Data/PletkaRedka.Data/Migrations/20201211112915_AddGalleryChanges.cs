using Microsoft.EntityFrameworkCore.Migrations;

namespace PletkaRedka.Data.Migrations
{
    public partial class AddGalleryChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Galleries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_UserId",
                table: "Galleries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_AspNetUsers_UserId",
                table: "Galleries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_AspNetUsers_UserId",
                table: "Galleries");

            migrationBuilder.DropIndex(
                name: "IX_Galleries_UserId",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Galleries");
        }
    }
}
