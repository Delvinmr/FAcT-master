using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    marcaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.marcaID);
                });

            migrationBuilder.CreateTable(
                name: "Unidaddemedidas",
                columns: table => new
                {
                    unidaddemedisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidaddemedidas", x => x.unidaddemedisID);
                });

            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    articulosID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(maxLength: 50, nullable: false),
                    Itebis = table.Column<decimal>(maxLength: 50, nullable: false),
                    unidaddemedisID = table.Column<int>(nullable: false),
                    unidaddemedidasunidaddemedisID = table.Column<int>(nullable: true),
                    marcaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.articulosID);
                    table.ForeignKey(
                        name: "FK_Articulos_Marca_marcaID",
                        column: x => x.marcaID,
                        principalTable: "Marca",
                        principalColumn: "marcaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articulos_Unidaddemedidas_unidaddemedidasunidaddemedisID",
                        column: x => x.unidaddemedidasunidaddemedisID,
                        principalTable: "Unidaddemedidas",
                        principalColumn: "unidaddemedisID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_marcaID",
                table: "Articulos",
                column: "marcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_unidaddemedidasunidaddemedisID",
                table: "Articulos",
                column: "unidaddemedidasunidaddemedisID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Unidaddemedidas");
        }
    }
}
