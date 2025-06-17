using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datatablesProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CariHesaplar",
                columns: table => new
                {
                    HesapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariHesapAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cariVergiNO = table.Column<int>(type: "int", nullable: false),
                    CariTelNO = table.Column<int>(type: "int", nullable: false),
                    CariAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CariILce = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CariHesaplar", x => x.HesapID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CariHesaplar");
        }
    }
}
