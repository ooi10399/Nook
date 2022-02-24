using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NookAppointmentAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RenteeUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenterUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fees = table.Column<double>(type: "float", nullable: false),
                    PlacementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "EndDateTime", "Fees", "PlacementDate", "RenteeUserName", "RenterUserName", "StartDateTime", "Status", "UpdateDate" },
                values: new object[] { 101, new DateTime(2022, 12, 31, 15, 15, 23, 0, DateTimeKind.Unspecified), 22.300000000000001, new DateTime(2022, 10, 31, 15, 15, 0, 0, DateTimeKind.Unspecified), "101", "102", new DateTime(2021, 12, 31, 14, 50, 44, 0, DateTimeKind.Unspecified), "Pending", new DateTime(2022, 10, 31, 15, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "EndDateTime", "Fees", "PlacementDate", "RenteeUserName", "RenterUserName", "StartDateTime", "Status", "UpdateDate" },
                values: new object[] { 102, new DateTime(2022, 1, 14, 13, 10, 44, 0, DateTimeKind.Unspecified), 43.0, new DateTime(2022, 1, 13, 15, 15, 0, 0, DateTimeKind.Unspecified), "102", "105", new DateTime(2022, 1, 14, 12, 42, 23, 0, DateTimeKind.Unspecified), "Completed", new DateTime(2022, 1, 14, 15, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "EndDateTime", "Fees", "PlacementDate", "RenteeUserName", "RenterUserName", "StartDateTime", "Status", "UpdateDate" },
                values: new object[] { 103, new DateTime(2022, 1, 30, 19, 30, 53, 0, DateTimeKind.Unspecified), 23.5, new DateTime(2022, 1, 10, 15, 15, 0, 0, DateTimeKind.Unspecified), "103", "103", new DateTime(2022, 1, 30, 17, 46, 53, 0, DateTimeKind.Unspecified), "Completed", new DateTime(2022, 1, 31, 15, 15, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
