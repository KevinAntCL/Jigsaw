using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaJigsaw.Migrations
{
    public partial class Mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rompecocos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumPiezas = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(maxLength: 20, nullable: true),
                    RangoEdad = table.Column<string>(nullable: false),
                    Autor = table.Column<string>(maxLength: 20, nullable: true),
                    Distribuidor = table.Column<string>(maxLength: 20, nullable: true),
                    Tema = table.Column<string>(maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: true),
                    Medidas = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rompecocos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rompecocos");
        }
    }
}
