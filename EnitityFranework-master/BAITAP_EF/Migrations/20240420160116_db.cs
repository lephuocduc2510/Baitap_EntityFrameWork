using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BAITAP_EF.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyID);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    classID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.classID);
                    table.ForeignKey(
                        name: "FK_Lops_Faculties_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    classID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Lops_classID",
                        column: x => x.classID,
                        principalTable: "Lops",
                        principalColumn: "classID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyID", "FacultyName" },
                values: new object[,]
                {
                    { 1, "Cong Nghe So" },
                    { 2, "Co Khi" },
                    { 3, "Dien-Dien Tu" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "classID", "FacultyID", "className" },
                values: new object[,]
                {
                    { 1, 1, "21T1" },
                    { 2, 1, "21T2" },
                    { 3, 1, "21T3" },
                    { 4, 1, "20T3" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Age", "Name", "Phone", "classID" },
                values: new object[,]
                {
                    { 1, "Quang Trị", 20, "Le Phuoc Duc", "0123456789", 3 },
                    { 2, "Quang Trị", 20, "Hoang Ngoc triet", "1234567890", 1 },
                    { 3, "Quang Nam", 20, "Le Thi Hong Nhung", "0123456789", 2 },
                    { 4, "Quang Nam", 21, "Nguyen Van A", "1234567890", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lops_FacultyID",
                table: "Lops",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_classID",
                table: "Students",
                column: "classID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
