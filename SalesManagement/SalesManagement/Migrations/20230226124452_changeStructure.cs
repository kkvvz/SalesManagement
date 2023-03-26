using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SalesManagement.Migrations
{
    public partial class changeStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_Sales_SaleId",
                table: "ProductSale");

            migrationBuilder.AddColumn<long>(
                name: "ProductCount",
                table: "ProductSale",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Number = table.Column<string>(type: "text", nullable: false),
                    Importer = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "ProductPurchase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PurchaseNumber = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: true),
                    ProductCount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPurchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPurchase_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPurchase_Purchases_PurchaseNumber",
                        column: x => x.PurchaseNumber,
                        principalTable: "Purchases",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchase_ProductId",
                table: "ProductPurchase",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchase_PurchaseNumber",
                table: "ProductPurchase",
                column: "PurchaseNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_Sales_SaleId",
                table: "ProductSale",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_Sales_SaleId",
                table: "ProductSale");

            migrationBuilder.DropTable(
                name: "ProductPurchase");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "ProductSale");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_Sales_SaleId",
                table: "ProductSale",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }
    }
}
