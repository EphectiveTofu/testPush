using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetlecture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddedById",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_AddedById",
                table: "Students",
                column: "AddedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_AddedById",
                table: "Students",
                column: "AddedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_AddedById",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AddedById",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddedById",
                table: "Students");
        }
    }
}
