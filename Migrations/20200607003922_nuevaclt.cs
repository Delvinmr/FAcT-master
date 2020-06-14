using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class nuevaclt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tipodocumentoID",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentostipodocumentoID",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_tiposdocumentostipodocumentoID",
                table: "Clientes",
                column: "tiposdocumentostipodocumentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentostipodocumentoID",
                table: "Clientes",
                column: "tiposdocumentostipodocumentoID",
                principalTable: "Tiposdocumentos",
                principalColumn: "tipodocumentoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentostipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_tiposdocumentostipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "tipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "tiposdocumentostipodocumentoID",
                table: "Clientes");
        }
    }
}
