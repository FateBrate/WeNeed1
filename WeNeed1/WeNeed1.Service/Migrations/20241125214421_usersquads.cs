using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class usersquads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SquadUser");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Squads",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsersSquad",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SquadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSquad", x => new { x.UserId, x.SquadId });
                    table.ForeignKey(
                        name: "FK_UsersSquad_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersSquad_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Squads_UserId",
                table: "Squads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSquad_SquadId",
                table: "UsersSquad",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Squads_Users_UserId",
                table: "Squads",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squads_Users_UserId",
                table: "Squads");

            migrationBuilder.DropTable(
                name: "UsersSquad");

            migrationBuilder.DropIndex(
                name: "IX_Squads_UserId",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Squads");

            migrationBuilder.CreateTable(
                name: "SquadUser",
                columns: table => new
                {
                    SquadsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadUser", x => new { x.SquadsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SquadUser_Squads_SquadsId",
                        column: x => x.SquadsId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SquadUser_UsersId",
                table: "SquadUser",
                column: "UsersId");
        }
    }
}
