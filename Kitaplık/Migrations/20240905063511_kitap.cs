using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitaplık.Migrations
{
    public partial class kitap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Kitaplar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Kitaplar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
