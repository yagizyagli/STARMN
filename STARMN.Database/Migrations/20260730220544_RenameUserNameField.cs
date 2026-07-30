using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STARMN.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KullanicAdi",
                table: "User",
                newName: "KullaniciAdi");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KullaniciAdi",
                table: "User",
                newName: "KullanicAdi");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
