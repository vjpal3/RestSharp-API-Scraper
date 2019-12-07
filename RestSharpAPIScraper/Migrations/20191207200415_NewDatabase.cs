using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestSharpAPIScraper.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StocksData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScrapeDate = table.Column<DateTime>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    Change = table.Column<decimal>(nullable: true),
                    PercentChange = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StocksData");
        }
    }
}
