using Microsoft.EntityFrameworkCore.Migrations;

namespace Tapshiriq2.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workss_AuthorWorkss_AuthorWorksID",
                table: "Workss");

            migrationBuilder.RenameColumn(
                name: "AuthorWorksID",
                table: "Workss",
                newName: "WorksID");

            migrationBuilder.RenameIndex(
                name: "IX_Workss_AuthorWorksID",
                table: "Workss",
                newName: "IX_Workss_WorksID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Workss_Workss_WorksID",
                table: "Workss",
                column: "WorksID",
                principalTable: "Workss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorWorkss_Workss_WorksId",
                table: "AuthorWorkss");

            migrationBuilder.DropForeignKey(
                name: "FK_Workss_Workss_WorksID",
                table: "Workss");

            migrationBuilder.DropIndex(
                name: "IX_AuthorWorkss_WorksId",
                table: "AuthorWorkss");

            migrationBuilder.RenameColumn(
                name: "WorksID",
                table: "Workss",
                newName: "AuthorWorksID");

            migrationBuilder.RenameIndex(
                name: "IX_Workss_WorksID",
                table: "Workss",
                newName: "IX_Workss_AuthorWorksID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workss_AuthorWorkss_AuthorWorksID",
                table: "Workss",
                column: "AuthorWorksID",
                principalTable: "AuthorWorkss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
