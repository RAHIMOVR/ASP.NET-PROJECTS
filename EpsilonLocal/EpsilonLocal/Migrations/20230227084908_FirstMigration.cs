using Microsoft.EntityFrameworkCore.Migrations;

namespace EpsilonLocal.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EpExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    İncomingAmount = table.Column<float>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExpenseAmount = table.Column<float>(nullable: false),
                    Person = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EpPayables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Contractor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<float>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpPayables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EpReceivables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Edv = table.Column<float>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpReceivables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    İncomingAmount = table.Column<float>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExpenseAmount = table.Column<float>(nullable: false),
                    Person = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtPayables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Contractor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<float>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtPayables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtReceivables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Edv = table.Column<float>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtReceivables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpExpenses");

            migrationBuilder.DropTable(
                name: "EpPayables");

            migrationBuilder.DropTable(
                name: "EpReceivables");

            migrationBuilder.DropTable(
                name: "EtExpenses");

            migrationBuilder.DropTable(
                name: "EtPayables");

            migrationBuilder.DropTable(
                name: "EtReceivables");
        }
    }
}
