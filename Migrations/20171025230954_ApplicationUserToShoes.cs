using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoeInventory.Migrations
{
    public partial class ApplicationUserToShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Shoes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_UserId",
                table: "Shoes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_AspNetUsers_UserId",
                table: "Shoes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_AspNetUsers_UserId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_UserId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Shoes");
        }
    }
}
