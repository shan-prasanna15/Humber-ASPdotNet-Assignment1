using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleCatalogMVCAssignment.Migrations
{
    public partial class shoppingcartAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartId = table.Column<string>(nullable: false),
                    ShoppingCartItemId = table.Column<int>(nullable: false),
                    VehicleVinNo = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Vehicles_VehicleVinNo",
                        column: x => x.VehicleVinNo,
                        principalTable: "Vehicles",
                        principalColumn: "VinNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_VehicleVinNo",
                table: "ShoppingCartItems",
                column: "VehicleVinNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}
