using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahdi_Sina_AP_Project.Migrations
{
    /// <inheritdoc />
    public partial class DB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ISEDITED = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ISCHECKED = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
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
                    orderlistJson = table.Column<string>(type: "TEXT", nullable: false),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reserve",
                columns: table => new
                {
                    RESERVETIME = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    CANRESERVE = table.Column<bool>(type: "INTEGER", nullable: false),
                    NAME = table.Column<string>(type: "TEXT", nullable: false),
                    RATE = table.Column<int>(type: "INTEGER", nullable: false),
                    ADDRESS = table.Column<string>(type: "TEXT", nullable: false),
                    USERNAME = table.Column<string>(type: "TEXT", nullable: false),
                    PASSWORD = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    RATE = table.Column<float>(type: "REAL", nullable: false),
                    IMAGEPATH = table.Column<string>(type: "TEXT", nullable: false),
                    INGREDIENTS = table.Column<string>(type: "TEXT", nullable: false),
                    FOODCOUNT = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    METHOD = table.Column<int>(type: "INTEGER", nullable: true),
                    RESTAURANTID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Food_Restaurants_RESTAURANTID",
                        column: x => x.RESTAURANTID,
                        principalTable: "Restaurants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_RESTAURANTID",
                table: "Food",
                column: "RESTAURANTID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Reserve");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
