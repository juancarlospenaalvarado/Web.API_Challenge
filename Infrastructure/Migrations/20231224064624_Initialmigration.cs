using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPermiso",
                table: "Permisos");

            migrationBuilder.AddColumn<int>(
                name: "TipoPermisosId",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoPermisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermisos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TipoPermisosId",
                table: "Permisos",
                column: "TipoPermisosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermisosId",
                table: "Permisos",
                column: "TipoPermisosId",
                principalTable: "TipoPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermisosId",
                table: "Permisos");

            migrationBuilder.DropTable(
                name: "TipoPermisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_TipoPermisosId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "TipoPermisosId",
                table: "Permisos");

            migrationBuilder.AddColumn<string>(
                name: "TipoPermiso",
                table: "Permisos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
