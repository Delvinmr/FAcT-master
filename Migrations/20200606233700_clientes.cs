using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(maxLength: 20, nullable: false),
                    Celular = table.Column<string>(maxLength: 20, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false),
                    ClasfclientesID = table.Column<int>(nullable: false),
                    ClasificacionclientesClasfclientesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteID);
                    table.ForeignKey(
                        name: "FK_Clientes_Clasificacionclientes_ClasificacionclientesClasfclientesID",
                        column: x => x.ClasificacionclientesClasfclientesID,
                        principalTable: "Clasificacionclientes",
                        principalColumn: "ClasfclientesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClasificacionclientesClasfclientesID",
                table: "Clientes",
                column: "ClasificacionclientesClasfclientesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
