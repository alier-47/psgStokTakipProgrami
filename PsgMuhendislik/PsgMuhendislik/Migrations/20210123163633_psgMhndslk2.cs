using Microsoft.EntityFrameworkCore.Migrations;

namespace PsgMuhendislik.Migrations
{
    public partial class psgMhndslk2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_musterilerDetay",
                table: "musterilerDetay");

            migrationBuilder.DropColumn(
                name: "MaasGirisDurum",
                table: "Calisanlar");

            migrationBuilder.RenameTable(
                name: "musterilerDetay",
                newName: "MusterilerDetay");

            migrationBuilder.AddColumn<int>(
                name: "MaasGirisiDurum",
                table: "Calisanlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusterilerDetay",
                table: "MusterilerDetay",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MusterilerDetay",
                table: "MusterilerDetay");

            migrationBuilder.DropColumn(
                name: "MaasGirisiDurum",
                table: "Calisanlar");

            migrationBuilder.RenameTable(
                name: "MusterilerDetay",
                newName: "musterilerDetay");

            migrationBuilder.AddColumn<int>(
                name: "MaasGirisDurum",
                table: "Calisanlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_musterilerDetay",
                table: "musterilerDetay",
                column: "ID");
        }
    }
}
