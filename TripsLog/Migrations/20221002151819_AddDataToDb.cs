using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripsLog.Migrations
{
    public partial class AddDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accommodation", "AccommodationEmail", "AccommodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 1, "AFC", "jdal@dajiwl.com", "2443243324", "afc", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "dwhilaw", "dawwda", "dwnhuadwlio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1);
        }
    }
}
