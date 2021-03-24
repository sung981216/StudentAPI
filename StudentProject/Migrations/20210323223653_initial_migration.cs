using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentProject.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "2ca13eac-1169-407c-bec4-c3271ec4e245", "Jane", "Smith", "Medicine" },
                    { "ddaa9bb0-4d81-4da4-a6d1-1f275599ef5a", "John", "Fisher", "Engineering" },
                    { "35373e1e-fe24-4933-bfa1-be47c6048814", "Pamela", "Baker", "Food Science" },
                    { "c264866b-4c36-4de3-8ec8-4c9cb29ef197", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
