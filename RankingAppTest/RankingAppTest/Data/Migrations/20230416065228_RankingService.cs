﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RankingAppTest.Data.Migrations
{
    public partial class RankingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "GameResults",
               columns: table => new
               {
                   id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   UserId = table.Column<int>(type: "int", nullable: false),
                   UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Score = table.Column<int>(type: "int", nullable: false),
                   Date = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_GameResults", x => x.id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameResults");
        }
    }
}
