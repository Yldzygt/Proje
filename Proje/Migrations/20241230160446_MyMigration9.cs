using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblSiniflar",
                columns: new[] { "SinifAd" ,"Kontenjan" },
                values: new object[] { "Bil100","20" });

            migrationBuilder.InsertData(
               table: "tblSiniflar",
               columns: new[] { "SinifAd", "Kontenjan" },
               values: new object[] { "Bil110", "15" });

            migrationBuilder.InsertData(
               table: "tblSiniflar",
               columns: new[] { "SinifAd", "Kontenjan" },
               values: new object[] { "Bil109", "30" });

            migrationBuilder.InsertData(
               table: "tblSiniflar",
               columns: new[] { "SinifAd", "Kontenjan" },
               values: new object[] { "Bil111", "12" });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
