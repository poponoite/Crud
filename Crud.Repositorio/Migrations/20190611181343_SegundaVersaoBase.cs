using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Repositorio.Migrations
{
    public partial class SegundaVersaoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioId1",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_UsuarioId1",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Grupos");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(int));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Grupos_GrupoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_GrupoId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Grupos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Grupos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_UsuarioId1",
                table: "Grupos",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioId1",
                table: "Grupos",
                column: "UsuarioId1",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
