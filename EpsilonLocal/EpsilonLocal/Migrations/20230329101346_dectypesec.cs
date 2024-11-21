using Microsoft.EntityFrameworkCore.Migrations;

namespace EpsilonLocal.Migrations
{
    public partial class dectypesec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "İncomingAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "İncomingAmount",
                table: "EpExpenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
