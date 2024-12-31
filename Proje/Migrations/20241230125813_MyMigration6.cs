using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDers_tblDersler_DersId",
                table: "tblOgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDers_tblOgrenciler_OgrenciId",
                table: "tblOgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_tblSiniflar_SinifId",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSiniflar",
                table: "tblSiniflar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblDersler",
                table: "tblDersler");

            migrationBuilder.RenameTable(
                name: "tblSiniflar",
                newName: "Siniflar");

            migrationBuilder.RenameTable(
                name: "tblOgrenciler",
                newName: "Ogrenciler");

            migrationBuilder.RenameTable(
                name: "tblDersler",
                newName: "Dersler");

            migrationBuilder.RenameIndex(
                name: "IX_tblSiniflar_SinifAd",
                table: "Siniflar",
                newName: "IX_Siniflar_SinifAd");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciler_SinifId",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_SinifId");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciler_Numara",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_Numara");

            migrationBuilder.RenameIndex(
                name: "IX_tblDersler_DersKod",
                table: "Dersler",
                newName: "IX_Dersler_DersKod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar",
                column: "SinifId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler",
                column: "OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dersler",
                table: "Dersler",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDers_Dersler_DersId",
                table: "tblOgrenciDers",
                column: "DersId",
                principalTable: "Dersler",
                principalColumn: "DersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDers_Ogrenciler_OgrenciId",
                table: "tblOgrenciDers",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDers_Dersler_DersId",
                table: "tblOgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciDers_Ogrenciler_OgrenciId",
                table: "tblOgrenciDers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siniflar",
                table: "Siniflar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dersler",
                table: "Dersler");

            migrationBuilder.RenameTable(
                name: "Siniflar",
                newName: "tblSiniflar");

            migrationBuilder.RenameTable(
                name: "Ogrenciler",
                newName: "tblOgrenciler");

            migrationBuilder.RenameTable(
                name: "Dersler",
                newName: "tblDersler");

            migrationBuilder.RenameIndex(
                name: "IX_Siniflar_SinifAd",
                table: "tblSiniflar",
                newName: "IX_tblSiniflar_SinifAd");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "tblOgrenciler",
                newName: "IX_tblOgrenciler_SinifId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_Numara",
                table: "tblOgrenciler",
                newName: "IX_tblOgrenciler_Numara");

            migrationBuilder.RenameIndex(
                name: "IX_Dersler_DersKod",
                table: "tblDersler",
                newName: "IX_tblDersler_DersKod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSiniflar",
                table: "tblSiniflar",
                column: "SinifId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler",
                column: "OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblDersler",
                table: "tblDersler",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDers_tblDersler_DersId",
                table: "tblOgrenciDers",
                column: "DersId",
                principalTable: "tblDersler",
                principalColumn: "DersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciDers_tblOgrenciler_OgrenciId",
                table: "tblOgrenciDers",
                column: "OgrenciId",
                principalTable: "tblOgrenciler",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_tblSiniflar_SinifId",
                table: "tblOgrenciler",
                column: "SinifId",
                principalTable: "tblSiniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
