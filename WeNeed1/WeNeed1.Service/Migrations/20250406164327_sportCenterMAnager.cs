using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class sportCenterMAnager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "SportsCenters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SportsCenters_ManagerId",
                table: "SportsCenters",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SportsCenters_Users_ManagerId",
                table: "SportsCenters",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SportsCenters_Users_ManagerId",
                table: "SportsCenters");

            migrationBuilder.DropIndex(
                name: "IX_SportsCenters_ManagerId",
                table: "SportsCenters");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "SportsCenters");
        }
    }
}
