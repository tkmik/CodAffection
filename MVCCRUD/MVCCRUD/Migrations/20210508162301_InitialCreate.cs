using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    EmpCode = table.Column<string>(type: "NVARCHAR(10)", nullable: false),
                    Position = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    OfficeLocation = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
