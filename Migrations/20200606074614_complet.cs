using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class complet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClasifarticulosID",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ubicacionID",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clasificacionclientes",
                columns: table => new
                {
                    ClasfclientesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificacionclientes", x => x.ClasfclientesID);
                });

            migrationBuilder.CreateTable(
                name: "ClasificaciondeArticulos",
                columns: table => new
                {
                    ClasifarticulosID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificaciondeArticulos", x => x.ClasifarticulosID);
                });

            migrationBuilder.CreateTable(
                name: "Clasificacionsuplidores",
                columns: table => new
                {
                    clasifsuplidoresID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificacionsuplidores", x => x.clasifsuplidoresID);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    empresaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.empresaID);
                });

            migrationBuilder.CreateTable(
                name: "Formadeenvio",
                columns: table => new
                {
                    formadeenvioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formadeenvio", x => x.formadeenvioID);
                });

            migrationBuilder.CreateTable(
                name: "Formadepago",
                columns: table => new
                {
                    formadepagoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formadepago", x => x.formadepagoID);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    monedaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.monedaID);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    paisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Pais = table.Column<int>(maxLength: 20, nullable: false),
                    nombre_pais = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.paisID);
                });

            migrationBuilder.CreateTable(
                name: "Puestodetrabajo",
                columns: table => new
                {
                    puestodetrabID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestodetrabajo", x => x.puestodetrabID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    statusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.statusID);
                });

            migrationBuilder.CreateTable(
                name: "Suplidores",
                columns: table => new
                {
                    SuplidoresID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(maxLength: 20, nullable: false),
                    Celular = table.Column<string>(maxLength: 20, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidores", x => x.SuplidoresID);
                });

            migrationBuilder.CreateTable(
                name: "Tasadecambio",
                columns: table => new
                {
                    tasadecambioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasadecambio", x => x.tasadecambioID);
                });

            migrationBuilder.CreateTable(
                name: "Tiposdocumentos",
                columns: table => new
                {
                    tipodocumentoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiposdocumentos", x => x.tipodocumentoID);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    ubicacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.ubicacionID);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    vendedorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(maxLength: 20, nullable: false),
                    Celular = table.Column<string>(maxLength: 20, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.vendedorID);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    provinciaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Provincia = table.Column<int>(maxLength: 20, nullable: false),
                    nombre_provincia = table.Column<string>(maxLength: 50, nullable: false),
                    paisID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.provinciaID);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_paisID",
                        column: x => x.paisID,
                        principalTable: "Pais",
                        principalColumn: "paisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    empleadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(maxLength: 20, nullable: false),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(maxLength: 20, nullable: false),
                    Celular = table.Column<string>(maxLength: 20, nullable: false),
                    Correo = table.Column<string>(maxLength: 50, nullable: false),
                    empresaID = table.Column<int>(nullable: false),
                    puestodetrabID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.empleadoID);
                    table.ForeignKey(
                        name: "FK_Empleado_Empresa_empresaID",
                        column: x => x.empresaID,
                        principalTable: "Empresa",
                        principalColumn: "empresaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Puestodetrabajo_puestodetrabID",
                        column: x => x.puestodetrabID,
                        principalTable: "Puestodetrabajo",
                        principalColumn: "puestodetrabID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    municipioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Municipio = table.Column<int>(maxLength: 20, nullable: false),
                    nombre_municipio = table.Column<string>(maxLength: 50, nullable: false),
                    provinciaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.municipioID);
                    table.ForeignKey(
                        name: "FK_Municipio_Provincia_provinciaID",
                        column: x => x.provinciaID,
                        principalTable: "Provincia",
                        principalColumn: "provinciaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    sectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Sector = table.Column<int>(maxLength: 20, nullable: false),
                    nombre_sector = table.Column<string>(maxLength: 50, nullable: false),
                    municipioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.sectorID);
                    table.ForeignKey(
                        name: "FK_Sector_Municipio_municipioID",
                        column: x => x.municipioID,
                        principalTable: "Municipio",
                        principalColumn: "municipioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosClasifarticulosID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ubicacionID",
                table: "Articulos",
                column: "ubicacionID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_empresaID",
                table: "Empleado",
                column: "empresaID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_puestodetrabID",
                table: "Empleado",
                column: "puestodetrabID");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_provinciaID",
                table: "Municipio",
                column: "provinciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_paisID",
                table: "Provincia",
                column: "paisID");

            migrationBuilder.CreateIndex(
                name: "IX_Sector_municipioID",
                table: "Sector",
                column: "municipioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosClasifarticulosID",
                principalTable: "ClasificaciondeArticulos",
                principalColumn: "ClasifarticulosID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Ubicacion_ubicacionID",
                table: "Articulos",
                column: "ubicacionID",
                principalTable: "Ubicacion",
                principalColumn: "ubicacionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Ubicacion_ubicacionID",
                table: "Articulos");

            migrationBuilder.DropTable(
                name: "Clasificacionclientes");

            migrationBuilder.DropTable(
                name: "ClasificaciondeArticulos");

            migrationBuilder.DropTable(
                name: "Clasificacionsuplidores");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Formadeenvio");

            migrationBuilder.DropTable(
                name: "Formadepago");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Suplidores");

            migrationBuilder.DropTable(
                name: "Tasadecambio");

            migrationBuilder.DropTable(
                name: "Tiposdocumentos");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Puestodetrabajo");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ubicacionID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ubicacionID",
                table: "Articulos");
        }
    }
}
