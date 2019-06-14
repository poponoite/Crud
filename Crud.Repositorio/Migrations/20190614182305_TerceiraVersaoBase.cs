using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Repositorio.Migrations
{
    public partial class TerceiraVersaoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Grupos_GrupoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_GrupoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_GrupoId",
                table: "Usuarios",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Grupos_GrupoId",
                table: "Usuarios",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
