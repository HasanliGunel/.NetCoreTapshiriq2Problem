using Microsoft.EntityFrameworkCore.Migrations;

namespace Tapshiriq2.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorWorkss_Workss_WorksId",
                table: "AuthorWorkss");

            migrationBuilder.DropIndex(
                name: "IX_AuthorWorkss_WorksId",
                table: "AuthorWorkss");

            migrationBuilder.AddColumn<int>(
                name: "AuthorWorksID",
                table: "Workss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Biographies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biographies", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workss_AuthorWorksID",
                table: "Workss",
                column: "AuthorWorksID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workss_AuthorWorkss_AuthorWorksID",
                table: "Workss",
                column: "AuthorWorksID",
                principalTable: "AuthorWorkss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workss_AuthorWorkss_AuthorWorksID",
                table: "Workss");

            migrationBuilder.DropTable(
                name: "Biographies");

            migrationBuilder.DropIndex(
                name: "IX_Workss_AuthorWorksID",
                table: "Workss");

            migrationBuilder.DropColumn(
                name: "AuthorWorksID",
                table: "Workss");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorWorkss_WorksId",
                table: "AuthorWorkss",
                column: "WorksId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorWorkss_Workss_WorksId",
                table: "AuthorWorkss",
                column: "WorksId",
                principalTable: "Workss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
