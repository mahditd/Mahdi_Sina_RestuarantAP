using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "complaintListJson",
                table: "Admins",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "complaintListJson",
                table: "Admins");
        }
    }
}
