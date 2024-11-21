using Microsoft.EntityFrameworkCore.Migrations;

namespace EpsilonLocal.Migrations
{
    public partial class SaExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "İncomingAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "İncomingAmount",
                table: "EpExpenses",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
