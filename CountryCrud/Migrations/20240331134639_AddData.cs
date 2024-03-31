using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CountryCrud.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "Id", "City", "Country", "IsCapital", "Population" },
                values: new object[,]
                {
                    { 1, "Washington", "Usa", true, 10000000 },
                    { 2, "New York", "Usa", false, 20000000 },
                    { 3, "Berlin", "Germany", true, 7000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
