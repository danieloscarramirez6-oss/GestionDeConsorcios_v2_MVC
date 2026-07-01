using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeConsorcios_v2_MVC.Migrations
{
    /// <inheritdoc />
    public partial class cambioModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "UnidadesFuncionales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadesFuncionales_UsuarioId",
                table: "UnidadesFuncionales",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadesFuncionales_Usuarios_UsuarioId",
                table: "UnidadesFuncionales",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnidadesFuncionales_Usuarios_UsuarioId",
                table: "UnidadesFuncionales");

            migrationBuilder.DropIndex(
                name: "IX_UnidadesFuncionales_UsuarioId",
                table: "UnidadesFuncionales");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "UnidadesFuncionales");
        }
    }
}
