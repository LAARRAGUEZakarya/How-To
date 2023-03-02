﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace How_To.Migrations
{
    public partial class deleteuserfromarticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_AspNetUsers_userId",
                table: "articles");

            migrationBuilder.DropIndex(
                name: "IX_articles_userId",
                table: "articles");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "articles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "articles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_articles_userId",
                table: "articles",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_AspNetUsers_userId",
                table: "articles",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
