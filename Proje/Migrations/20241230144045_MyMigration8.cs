using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_Siniflar_SinifId",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar");

            migrationBuilder.RenameTable(
                name: "Siniflar",
                newName: "tblSiniflar");

            migrationBuilder.RenameIndex(
                name: "IX_Siniflar_SinifAd",
                table: "tblSiniflar",
                newName: "IX_tblSiniflar_SinifAd");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSiniflar",
                table: "tblSiniflar",
                column: "SinifId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_tblSiniflar_SinifId",
                table: "tblOgrenciler",
                column: "SinifId",
                principalTable: "tblSiniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_tblSiniflar_SinifId",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSiniflar",
                table: "tblSiniflar");

            migrationBuilder.RenameTable(
                name: "tblSiniflar",
                newName: "Siniflar");

            migrationBuilder.RenameIndex(
                name: "IX_tblSiniflar_SinifAd",
                table: "Siniflar",
                newName: "IX_Siniflar_SinifAd");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar",
                column: "SinifId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_Siniflar_SinifId",
                table: "tblOgrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
