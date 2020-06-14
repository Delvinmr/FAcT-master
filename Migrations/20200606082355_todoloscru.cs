using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class todoloscru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Tasadecambio");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Suplidores");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Codigo_Sector",
                table: "Sector");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Puestodetrabajo");

            migrationBuilder.DropColumn(
                name: "Codigo_Provincia",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Codigo_Pais",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Codigo_Municipio",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Vendedores",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Unidaddemedidas",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Ubicacion",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Tasadecambio",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Suplidores",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Status",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_Sector",
                table: "Sector",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Puestodetrabajo",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_Provincia",
                table: "Provincia",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_Pais",
                table: "Pais",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_Municipio",
                table: "Municipio",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Moneda",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Marca",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Formadepago",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Formadeenvio",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Empresa",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Empleado",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Clasificacionsuplidores",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "ClasificaciondeArticulos",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Clasificacionclientes",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Articulos",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }
    }
}
