using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_tblOgrenciDers",
                table: "tblOgrenciDers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler");

            migrationBuilder.RenameTable(
                name: "tblOgrenciDers",
                newName: "OgrenciDers");

            migrationBuilder.RenameTable(
                name: "Ogrenciler",
                newName: "tblOgrenciler");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciDers_OgrenciId",
                table: "OgrenciDers",
                newName: "IX_OgrenciDers_OgrenciId");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciDers_DersId",
                table: "OgrenciDers",
                newName: "IX_OgrenciDers_DersId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "tblOgrenciler",
                newName: "IX_tblOgrenciler_SinifId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_Numara",
                table: "tblOgrenciler",
                newName: "IX_tblOgrenciler_Numara");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OgrenciDers",
                table: "OgrenciDers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler",
                column: "OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_Dersler_DersId",
                table: "OgrenciDers",
                column: "DersId",
                principalTable: "Dersler",
                principalColumn: "DersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_tblOgrenciler_OgrenciId",
                table: "OgrenciDers",
                column: "OgrenciId",
                principalTable: "tblOgrenciler",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOgrenciler_Siniflar_SinifId",
                table: "tblOgrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_Dersler_DersId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_tblOgrenciler_OgrenciId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOgrenciler_Siniflar_SinifId",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgrenciler",
                table: "tblOgrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OgrenciDers",
                table: "OgrenciDers");

            migrationBuilder.RenameTable(
                name: "tblOgrenciler",
                newName: "Ogrenciler");

            migrationBuilder.RenameTable(
                name: "OgrenciDers",
                newName: "tblOgrenciDers");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciler_SinifId",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_SinifId");

            migrationBuilder.RenameIndex(
                name: "IX_tblOgrenciler_Numara",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_Numara");

            migrationBuilder.RenameIndex(
                name: "IX_OgrenciDers_OgrenciId",
                table: "tblOgrenciDers",
                newName: "IX_tblOgrenciDers_OgrenciId");

            migrationBuilder.RenameIndex(
                name: "IX_OgrenciDers_DersId",
                table: "tblOgrenciDers",
                newName: "IX_tblOgrenciDers_DersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler",
                column: "OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgrenciDers",
                table: "tblOgrenciDers",
                column: "Id");

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
    }
}
