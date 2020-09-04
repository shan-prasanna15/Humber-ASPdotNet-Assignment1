﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleCatalogMVCAssignment.Migrations
{
    public partial class AmountAddedToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Vehicles");
        }
    }
}
