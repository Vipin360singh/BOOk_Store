using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ListPrice50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "ListPrice50", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesent vitae sodales libero. praesent Molw", "SJJ0999999", 99.0, 0.0, 90.0, 80.0, 85, "Fortune of Time" },
                    { 2, "Billy Spark second", "Praesent vitae sodales libero. praesent Molw second.", "SJJ7999099", 199.0, 0.0, 190.0, 180.0, 185, "Fortune of Time second" },
                    { 3, "Billy Spark third", "Praesent vitae sodales libero. praesent Molw third", "SJJ7999999", 299.0, 0.0, 290.0, 280.0, 285, "Fortune of Time third" },
                    { 4, "Billy Spark fourth", "Praesent vitae sodales libero. praesent Molw fourth", "SEEJJ7999999", 399.0, 0.0, 390.0, 380.0, 385, "Fortune of Time fourth" },
                    { 5, "Billy Spark fifth", "Praesent vitae sodales libero. praesent Molw fifth", "SJJ79999999", 499.0, 0.0, 490.0, 480.0, 485, "Fortune of Time fifth" },
                    { 6, "Billy Spark sixth", "Praesent vitae sodales libero. praesent Molw sixth", "SJJZ7999999", 599.0, 0.0, 590.0, 580.0, 585, "Fortune of Time sixth" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
