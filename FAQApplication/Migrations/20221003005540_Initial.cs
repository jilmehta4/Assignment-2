using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FAQApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FaqID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FaqID);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "general", "General" },
                    { "history", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "TopicName" },
                values: new object[,]
                {
                    { "bootstrap", "Bootstrap" },
                    { "c#", "C#" },
                    { "javascript", "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FaqID", "Answer", "CategoryID", "Question", "TopicID" },
                values: new object[,]
                {
                    { "1", "A CSS framework for creating responsive web apps for multiple screen sizes.", "general", "What is Bootstrap?", "c#" },
                    { "3", "A general purpose scripting language that executes in a web broser.", "general", "What is JavaScript?", "bootstrap" },
                    { "4", "In 2011", "history", "When was Bootstrap first released?", "bootstrap" },
                    { "5", "In 2002", "history", "When was c# first released?", "c#" },
                    { "6", "In 1995.", "history", "When was JavaScript first released?", "javascript" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryID",
                table: "FAQs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicID",
                table: "FAQs",
                column: "TopicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
