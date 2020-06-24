using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class cbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Vendedores",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Unidaddemedidas",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Ubicacion",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Tiposdocumentos",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Tasadecambio",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Suplidores",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Status",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Sector",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Puestodetrabajo",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Provincia",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Pais",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Municipio",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Moneda",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Marca",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Formadepago",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Formadeenvio",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Empresa",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Empleado",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Clientes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Clientes",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Clasificacionsuplidores",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "ClasificaciondeArticulos",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Clasificacionclientes",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Articulos",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Unidaddemedidas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Ubicacion");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Tiposdocumentos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Tasadecambio");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Sector");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Puestodetrabajo");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Municipio");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Moneda");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Marca");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Formadepago");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Formadeenvio");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Clasificacionsuplidores");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "ClasificaciondeArticulos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Clasificacionclientes");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Articulos");

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
