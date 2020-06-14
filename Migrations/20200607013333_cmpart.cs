using Microsoft.EntityFrameworkCore.Migrations;

namespace FAcT.Migrations
{
    public partial class cmpart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "statusID",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_statusID",
                table: "Articulos",
                column: "statusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Status_statusID",
                table: "Articulos",
                column: "statusID",
                principalTable: "Status",
                principalColumn: "statusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Status_statusID",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_statusID",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "statusID",
                table: "Articulos");
        }
    }
}
