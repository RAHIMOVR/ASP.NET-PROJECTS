using Microsoft.EntityFrameworkCore.Migrations;

namespace EpsilonLocal.Migrations
{
    public partial class Flupda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "İncomingAmount",
                table: "EpExpenses",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "İncomingAmount",
                table: "EpExpenses",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
