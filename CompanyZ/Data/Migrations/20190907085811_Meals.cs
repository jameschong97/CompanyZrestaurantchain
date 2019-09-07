using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyZ.Data.Migrations
{
    public partial class Meals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MealName = table.Column<string>(maxLength: 60, nullable: false),
                    MealType = table.Column<string>(maxLength: 30, nullable: false),
                    MealDesc = table.Column<string>(maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meal");
        }
    }
}
