using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    /// <inheritdoc />
    public partial class test6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Restaurants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Restaurants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
