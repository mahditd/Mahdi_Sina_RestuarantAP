using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EMAIL = table.Column<string>(type: "TEXT", nullable: false),
                    NAME = table.Column<string>(type: "TEXT", nullable: false),
                    PHONENUMBER = table.Column<string>(type: "TEXT", nullable: false),
                    POSTALCODE = table.Column<string>(type: "TEXT", nullable: false),
                    orderlistjson = table.Column<string>(type: "TEXT", nullable: false),
                    commentJson = table.Column<string>(type: "TEXT", nullable: false),
                    complaintJson = table.Column<string>(type: "TEXT", nullable: false),
                    subscribtion = table.Column<int>(type: "INTEGER", nullable: false),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
