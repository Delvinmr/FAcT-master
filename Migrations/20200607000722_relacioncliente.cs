using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class relacioncliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "paisID",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "provinciaID",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_paisID",
                table: "Clientes",
                column: "paisID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_provinciaID",
                table: "Clientes",
                column: "provinciaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pais_paisID",
                table: "Clientes",
                column: "paisID",
                principalTable: "Pais",
                principalColumn: "paisID");



            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Provincia_provinciaID",
                table: "Clientes",
                column: "provinciaID",
                principalTable: "Provincia",
                principalColumn: "provinciaID");
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pais_paisID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Provincia_provinciaID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_paisID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_provinciaID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "paisID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "provinciaID",
                table: "Clientes");
        }
    }
}
