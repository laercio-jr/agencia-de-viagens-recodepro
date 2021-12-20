using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLaercio.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Viajante = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TemGuia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagens");
        }
    }
}
