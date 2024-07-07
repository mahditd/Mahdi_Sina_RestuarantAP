using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    /// <inheritdoc />
    public partial class DBM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    complaintListJson = table.Column<string>(type: "TEXT", nullable: false),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    foodListJson = table.Column<string>(type: "TEXT", nullable: false),
                    canReserve = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    rate = table.Column<float>(type: "REAL", nullable: false),
                    orderList = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    reserveList = table.Column<string>(type: "TEXT", nullable: false),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
