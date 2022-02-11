using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NookApplication.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Rentees",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fee = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentees", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renters", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "InterestRentee",
                columns: table => new
                {
                    InterestsIntId = table.Column<int>(type: "int", nullable: false),
                    RenteesUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestRentee", x => new { x.InterestsIntId, x.RenteesUserId });
                    table.ForeignKey(
                        name: "FK_InterestRentee_Interests_InterestsIntId",
                        column: x => x.InterestsIntId,
                        principalTable: "Interests",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestRentee_Rentees_RenteesUserId",
                        column: x => x.RenteesUserId,
                        principalTable: "Rentees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "IntId", "IntName" },
                values: new object[,]
                {
                    { 1, "Cafe-hopping" },
                    { 2, "Pottery-making" }
                });

            migrationBuilder.InsertData(
                table: "Rentees",
                columns: new[] { "UserId", "About", "DOB", "Email", "Fee", "FullName", "Gender", "NickName", "Password" },
                values: new object[,]
                {
                    { 101, "Call me queen.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "elicam@email.com", 20.0, "Elizabeth Cambridge", false, "Eli", "elipass" },
                    { 102, "Call me king.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "philc@email.com", 20.0, "Phillip Cambridge", true, "Phil", "philpass" }
                });

            migrationBuilder.InsertData(
                table: "Renters",
                columns: new[] { "UserId", "About", "DOB", "Email", "FullName", "Gender", "NickName", "Password" },
                values: new object[,]
                {
                    { 101, "Will call you queen.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@email.com", "John Doe", true, "John", "johnpass" },
                    { 102, "Will call you king.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "janedoe@email.com", "Jane Doe", false, "Jane", "janepass" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestRentee_RenteesUserId",
                table: "InterestRentee",
                column: "RenteesUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestRentee");

            migrationBuilder.DropTable(
                name: "Renters");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Rentees");
        }
    }
}
