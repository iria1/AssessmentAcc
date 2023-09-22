using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentAcc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipeCustomer = table.Column<string>(nullable: true),
                    Nama = table.Column<string>(nullable: true),
                    NomorTelp = table.Column<string>(nullable: true),
                    Alamat = table.Column<string>(nullable: true),
                    NomorRekening = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTransactions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransaksiId = table.Column<long>(nullable: false),
                    Jumlah = table.Column<int>(nullable: false),
                    Nama = table.Column<string>(nullable: true),
                    Satuan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomorUrut = table.Column<string>(nullable: true),
                    CustomerId = table.Column<long>(nullable: false),
                    TanggalPemesanan = table.Column<DateTime>(nullable: false),
                    TanggalPengiriman = table.Column<DateTime>(nullable: false),
                    TermOfPayment = table.Column<string>(nullable: true),
                    JumlahNominal = table.Column<double>(nullable: false),
                    StatusApproval = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ItemTransactions");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
