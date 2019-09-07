using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyZ.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IngredientName = table.Column<string>(maxLength: 60, nullable: false),
                    IngredientType = table.Column<string>(maxLength: 30, nullable: false),
                    IngredientDesc = table.Column<string>(maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
