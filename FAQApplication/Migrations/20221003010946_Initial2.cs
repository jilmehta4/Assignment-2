using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FAQApplication.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqID",
                keyValue: "1",
                column: "TopicID",
                value: "bootstrap");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqID",
                keyValue: "3",
                column: "TopicID",
                value: "javascript");

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FaqID", "Answer", "CategoryID", "Question", "TopicID" },
                values: new object[] { "2", "A general purpose object oriented language", "general", "What is C#?", "c#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FaqID",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqID",
                keyValue: "1",
                column: "TopicID",
                value: "c#");

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "FaqID",
                keyValue: "3",
                column: "TopicID",
                value: "bootstrap");
        }
    }
}
