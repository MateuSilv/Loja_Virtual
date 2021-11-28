using Microsoft.EntityFrameworkCore.Migrations;

namespace Malwaro.Migrations
{
    public partial class FormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaDePagamento",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaDePagamento",
                table: "Pedido");
        }
    }
}
