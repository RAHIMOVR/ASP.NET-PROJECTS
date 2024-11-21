using Microsoft.EntityFrameworkCore.Migrations;

namespace EpsilonLocal.Migrations
{
    public partial class IntMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ExpenseAmount",
                table: "EpExpenses",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
