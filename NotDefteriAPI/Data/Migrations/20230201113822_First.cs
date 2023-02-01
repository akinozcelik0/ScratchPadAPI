using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotDefteriAPI.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturulmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DegistirmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notlar",
                columns: new[] { "Id", "Baslik", "DegistirmeZamani", "Icerik", "OlusturulmaZamani" },
                values: new object[] { 1, "Alinacaklar", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4259), "1.Bot\n2.Kod\n3.Pot", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.InsertData(
                table: "Notlar",
                columns: new[] { "Id", "Baslik", "DegistirmeZamani", "Icerik", "OlusturulmaZamani" },
                values: new object[] { 2, "Ozlu Sozler", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4261), "1.Yemek ye\n2.Dua et\n3.Sev", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.InsertData(
                table: "Notlar",
                columns: new[] { "Id", "Baslik", "DegistirmeZamani", "Icerik", "OlusturulmaZamani" },
                values: new object[] { 3, "Gezilecek Yerler", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4262), "1.Ankara\n2.Istanbul\n3.Izmir", new DateTime(2023, 2, 1, 14, 38, 22, 634, DateTimeKind.Local).AddTicks(4261) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notlar");
        }
    }
}
