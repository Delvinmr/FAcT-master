using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class listotodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Unidaddemedidas_unidaddemedidasunidaddemedisID",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Clasificacionclientes_ClasificacionclientesClasfclientesID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentostipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Puestodetrabajo_puestodetrabID",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidaddemedidas",
                table: "Unidaddemedidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiposdocumentos",
                table: "Tiposdocumentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Puestodetrabajo",
                table: "Puestodetrabajo");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_puestodetrabID",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ClasificacionclientesClasfclientesID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_tiposdocumentostipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clasificacionsuplidores",
                table: "Clasificacionsuplidores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClasificaciondeArticulos",
                table: "ClasificaciondeArticulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clasificacionclientes",
                table: "Clasificacionclientes");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_unidaddemedidasunidaddemedisID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "unidaddemedisID",
                table: "Unidaddemedidas");

            migrationBuilder.DropColumn(
                name: "tipodocumentoID",
                table: "Tiposdocumentos");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "apellidos",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "puestodetrabID",
                table: "Puestodetrabajo");

            migrationBuilder.DropColumn(
                name: "puestodetrabID",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "ClasfclientesID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClasificacionclientesClasfclientesID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "tipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "tiposdocumentostipodocumentoID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "clasifsuplidoresID",
                table: "Clasificacionsuplidores");

            migrationBuilder.DropColumn(
                name: "ClasifarticulosID",
                table: "ClasificaciondeArticulos");

            migrationBuilder.DropColumn(
                name: "ClasfclientesID",
                table: "Clasificacionclientes");

            migrationBuilder.DropColumn(
                name: "ClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Itebis",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "unidaddemedidasunidaddemedisID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "unidaddemedisID",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "monedaID",
                table: "Moneda",
                newName: "MonedaID");

            migrationBuilder.AddColumn<int>(
                name: "SuplidoresID",
                table: "Vendedores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentosID",
                table: "Vendedores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unidaddemedidasID",
                table: "Unidaddemedidas",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentosID",
                table: "Tiposdocumentos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionsuplidoresID",
                table: "Suplidores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PuestodetrabajoID",
                table: "Puestodetrabajo",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MonedaID",
                table: "Pais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PuestodetrabajoID",
                table: "Empleado",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentosID",
                table: "Empleado",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionclientesID",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentosID",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionsuplidoresID",
                table: "Clasificacionsuplidores",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasificaciondeArticulosID",
                table: "ClasificaciondeArticulos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionclientesID",
                table: "Clasificacionclientes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasificaciondeArticulosID",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unidaddemedidasID",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidaddemedidas",
                table: "Unidaddemedidas",
                column: "unidaddemedidasID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiposdocumentos",
                table: "Tiposdocumentos",
                column: "tiposdocumentosID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Puestodetrabajo",
                table: "Puestodetrabajo",
                column: "PuestodetrabajoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clasificacionsuplidores",
                table: "Clasificacionsuplidores",
                column: "ClasificacionsuplidoresID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClasificaciondeArticulos",
                table: "ClasificaciondeArticulos",
                column: "ClasificaciondeArticulosID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clasificacionclientes",
                table: "Clasificacionclientes",
                column: "ClasificacionclientesID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_SuplidoresID",
                table: "Vendedores",
                column: "SuplidoresID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_tiposdocumentosID",
                table: "Vendedores",
                column: "tiposdocumentosID");

            migrationBuilder.CreateIndex(
                name: "IX_Suplidores_ClasificacionsuplidoresID",
                table: "Suplidores",
                column: "ClasificacionsuplidoresID");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_MonedaID",
                table: "Pais",
                column: "MonedaID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PuestodetrabajoID",
                table: "Empleado",
                column: "PuestodetrabajoID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_tiposdocumentosID",
                table: "Empleado",
                column: "tiposdocumentosID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClasificacionclientesID",
                table: "Clientes",
                column: "ClasificacionclientesID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_tiposdocumentosID",
                table: "Clientes",
                column: "tiposdocumentosID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasificaciondeArticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_unidaddemedidasID",
                table: "Articulos",
                column: "unidaddemedidasID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosID",
                principalTable: "ClasificaciondeArticulos",
                principalColumn: "ClasificaciondeArticulosID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Unidaddemedidas_unidaddemedidasID",
                table: "Articulos",
                column: "unidaddemedidasID",
                principalTable: "Unidaddemedidas",
                principalColumn: "unidaddemedidasID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Clasificacionclientes_ClasificacionclientesID",
                table: "Clientes",
                column: "ClasificacionclientesID",
                principalTable: "Clasificacionclientes",
                principalColumn: "ClasificacionclientesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentosID",
                table: "Clientes",
                column: "tiposdocumentosID",
                principalTable: "Tiposdocumentos",
                principalColumn: "tiposdocumentosID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Puestodetrabajo_PuestodetrabajoID",
                table: "Empleado",
                column: "PuestodetrabajoID",
                principalTable: "Puestodetrabajo",
                principalColumn: "PuestodetrabajoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Tiposdocumentos_tiposdocumentosID",
                table: "Empleado",
                column: "tiposdocumentosID",
                principalTable: "Tiposdocumentos",
                principalColumn: "tiposdocumentosID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Moneda_MonedaID",
                table: "Pais",
                column: "MonedaID",
                principalTable: "Moneda",
                principalColumn: "MonedaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suplidores_Clasificacionsuplidores_ClasificacionsuplidoresID",
                table: "Suplidores",
                column: "ClasificacionsuplidoresID",
                principalTable: "Clasificacionsuplidores",
                principalColumn: "ClasificacionsuplidoresID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Suplidores_SuplidoresID",
                table: "Vendedores",
                column: "SuplidoresID",
                principalTable: "Suplidores",
                principalColumn: "SuplidoresID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Tiposdocumentos_tiposdocumentosID",
                table: "Vendedores",
                column: "tiposdocumentosID",
                principalTable: "Tiposdocumentos",
                principalColumn: "tiposdocumentosID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosID",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Unidaddemedidas_unidaddemedidasID",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Clasificacionclientes_ClasificacionclientesID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentosID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Puestodetrabajo_PuestodetrabajoID",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Tiposdocumentos_tiposdocumentosID",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Moneda_MonedaID",
                table: "Pais");

            migrationBuilder.DropForeignKey(
                name: "FK_Suplidores_Clasificacionsuplidores_ClasificacionsuplidoresID",
                table: "Suplidores");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Suplidores_SuplidoresID",
                table: "Vendedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Tiposdocumentos_tiposdocumentosID",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_SuplidoresID",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_tiposdocumentosID",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidaddemedidas",
                table: "Unidaddemedidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiposdocumentos",
                table: "Tiposdocumentos");

            migrationBuilder.DropIndex(
                name: "IX_Suplidores_ClasificacionsuplidoresID",
                table: "Suplidores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Puestodetrabajo",
                table: "Puestodetrabajo");

            migrationBuilder.DropIndex(
                name: "IX_Pais_MonedaID",
                table: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_PuestodetrabajoID",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_tiposdocumentosID",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ClasificacionclientesID",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_tiposdocumentosID",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clasificacionsuplidores",
                table: "Clasificacionsuplidores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClasificaciondeArticulos",
                table: "ClasificaciondeArticulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clasificacionclientes",
                table: "Clasificacionclientes");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasificaciondeArticulosID",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_unidaddemedidasID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "SuplidoresID",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "tiposdocumentosID",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "unidaddemedidasID",
                table: "Unidaddemedidas");

            migrationBuilder.DropColumn(
                name: "tiposdocumentosID",
                table: "Tiposdocumentos");

            migrationBuilder.DropColumn(
                name: "ClasificacionsuplidoresID",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "PuestodetrabajoID",
                table: "Puestodetrabajo");

            migrationBuilder.DropColumn(
                name: "MonedaID",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "PuestodetrabajoID",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "tiposdocumentosID",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "ClasificacionclientesID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "tiposdocumentosID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClasificacionsuplidoresID",
                table: "Clasificacionsuplidores");

            migrationBuilder.DropColumn(
                name: "ClasificaciondeArticulosID",
                table: "ClasificaciondeArticulos");

            migrationBuilder.DropColumn(
                name: "ClasificacionclientesID",
                table: "Clasificacionclientes");

            migrationBuilder.DropColumn(
                name: "ClasificaciondeArticulosID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "unidaddemedidasID",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "MonedaID",
                table: "Moneda",
                newName: "monedaID");

            migrationBuilder.AddColumn<int>(
                name: "unidaddemedisID",
                table: "Unidaddemedidas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "tipodocumentoID",
                table: "Tiposdocumentos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Suplidores",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Suplidores",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "apellidos",
                table: "Suplidores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "puestodetrabID",
                table: "Puestodetrabajo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "puestodetrabID",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasfclientesID",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificacionclientesClasfclientesID",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipodocumentoID",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tiposdocumentostipodocumentoID",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "clasifsuplidoresID",
                table: "Clasificacionsuplidores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasifarticulosID",
                table: "ClasificaciondeArticulos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasfclientesID",
                table: "Clasificacionclientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClasifarticulosID",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Itebis",
                table: "Articulos",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "unidaddemedidasunidaddemedisID",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "unidaddemedisID",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidaddemedidas",
                table: "Unidaddemedidas",
                column: "unidaddemedisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiposdocumentos",
                table: "Tiposdocumentos",
                column: "tipodocumentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Puestodetrabajo",
                table: "Puestodetrabajo",
                column: "puestodetrabID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clasificacionsuplidores",
                table: "Clasificacionsuplidores",
                column: "clasifsuplidoresID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClasificaciondeArticulos",
                table: "ClasificaciondeArticulos",
                column: "ClasifarticulosID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clasificacionclientes",
                table: "Clasificacionclientes",
                column: "ClasfclientesID");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_puestodetrabID",
                table: "Empleado",
                column: "puestodetrabID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClasificacionclientesClasfclientesID",
                table: "Clientes",
                column: "ClasificacionclientesClasfclientesID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_tiposdocumentostipodocumentoID",
                table: "Clientes",
                column: "tiposdocumentostipodocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosClasifarticulosID");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_unidaddemedidasunidaddemedisID",
                table: "Articulos",
                column: "unidaddemedidasunidaddemedisID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificaciondeArticulos_ClasificaciondeArticulosClasifarticulosID",
                table: "Articulos",
                column: "ClasificaciondeArticulosClasifarticulosID",
                principalTable: "ClasificaciondeArticulos",
                principalColumn: "ClasifarticulosID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Unidaddemedidas_unidaddemedidasunidaddemedisID",
                table: "Articulos",
                column: "unidaddemedidasunidaddemedisID",
                principalTable: "Unidaddemedidas",
                principalColumn: "unidaddemedisID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Clasificacionclientes_ClasificacionclientesClasfclientesID",
                table: "Clientes",
                column: "ClasificacionclientesClasfclientesID",
                principalTable: "Clasificacionclientes",
                principalColumn: "ClasfclientesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Tiposdocumentos_tiposdocumentostipodocumentoID",
                table: "Clientes",
                column: "tiposdocumentostipodocumentoID",
                principalTable: "Tiposdocumentos",
                principalColumn: "tipodocumentoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Puestodetrabajo_puestodetrabID",
                table: "Empleado",
                column: "puestodetrabID",
                principalTable: "Puestodetrabajo",
                principalColumn: "puestodetrabID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
