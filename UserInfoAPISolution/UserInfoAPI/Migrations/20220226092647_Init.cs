using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserInfoAPI.Migrations
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentees", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                    RenteesUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                columns: new[] { "UserId", "About", "DOB", "Fee", "FullName", "Gender", "Image", "IsActive", "NickName" },
                values: new object[,]
                {
                    { "elicam@email.com", "Call me queen.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, "Elizabeth Cambridge", "Female", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTL6pp1VJnOv1D9ATTMZz2ZGzP93IKty-zVQw&usqp=CAU", true, "Eli" },
                    { "philc@email.com", "Call me king.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, "Phillip Cambridge", "Male", "http://www.zebuinvestments.com/wp-content/uploads/2020/05/Guy-Final.jpg", false, "Phil" }
                });

            migrationBuilder.InsertData(
                table: "Renters",
                columns: new[] { "UserId", "About", "DOB", "FullName", "Gender", "Image", "IsActive", "NickName" },
                values: new object[,]
                {
                    { "johndoe@email.com", "Will call you queen.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", "Male", "", true, "John" },
                    { "janedoe@email.com", "Will call you king.", new DateTime(1974, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Doe", "Female", "", false, "Jane" }
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
