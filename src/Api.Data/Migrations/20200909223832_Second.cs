using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DirectoryId",
                table: "GeometricForm",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeometricForm_DirectoryId",
                table: "GeometricForm",
                column: "DirectoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeometricForm_Directory_DirectoryId",
                table: "GeometricForm",
                column: "DirectoryId",
                principalTable: "Directory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeometricForm_Directory_DirectoryId",
                table: "GeometricForm");

            migrationBuilder.DropIndex(
                name: "IX_GeometricForm_DirectoryId",
                table: "GeometricForm");

            migrationBuilder.DropColumn(
                name: "DirectoryId",
                table: "GeometricForm");
        }
    }
}
