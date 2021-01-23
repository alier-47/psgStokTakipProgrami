using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsgMuhendislik.Migrations
{
    public partial class psgMhndslk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalisanCizelgesi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanID = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    GunSayisi = table.Column<double>(nullable: false),
                    Aciklama = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalisanCizelgesi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CalisanEDevlet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanID = table.Column<int>(nullable: false),
                    TcNo = table.Column<string>(maxLength: 11, nullable: true),
                    Sifre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalisanEDevlet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(maxLength: 50, nullable: true),
                    IsBaslangicTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    AlacakTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CalismaSekli = table.Column<string>(maxLength: 50, nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaasGirisDurum = table.Column<int>(nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CalisanlarDetay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanID = table.Column<int>(nullable: false),
                    OdemeId = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    AlacakTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdenenTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalisanlarDetay", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(maxLength: 150, nullable: true),
                    Telefon = table.Column<string>(maxLength: 50, nullable: true),
                    Borc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FirmalarDetay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaID = table.Column<int>(nullable: false),
                    OdemeId = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    AlinanMalTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdenenTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdemeSekli = table.Column<string>(maxLength: 50, nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmalarDetay", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GelenOdemeler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gelenOdemeId = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GelenOdemeler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Harcamalar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    harcamaid = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harcamalar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "İdris",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İdris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(maxLength: 50, nullable: true),
                    Sifre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(maxLength: 150, nullable: true),
                    Telefon = table.Column<string>(maxLength: 50, nullable: true),
                    BinaAdi = table.Column<string>(maxLength: 150, nullable: true),
                    Borc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    OdemeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    OdemeSekli = table.Column<string>(maxLength: 50, nullable: true),
                    Not = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "musterilerDetay",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(nullable: false),
                    OdemeId = table.Column<int>(nullable: false),
                    EklenenTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdenenTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdemeSekli = table.Column<string>(maxLength: 50, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    Aciklama = table.Column<string>(maxLength: 150, nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Silme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musterilerDetay", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalisanCizelgesi");

            migrationBuilder.DropTable(
                name: "CalisanEDevlet");

            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "CalisanlarDetay");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "FirmalarDetay");

            migrationBuilder.DropTable(
                name: "GelenOdemeler");

            migrationBuilder.DropTable(
                name: "Harcamalar");

            migrationBuilder.DropTable(
                name: "İdris");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "musterilerDetay");
        }
    }
}
