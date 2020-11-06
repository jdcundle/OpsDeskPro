using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpsDeskProAPI.Migrations
{
    public partial class UpdatePeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Student",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Person",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Member",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Instructor",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Student",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    Line3 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<Guid>(nullable: false),
                    CountryID = table.Column<Guid>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    InstructorId = table.Column<Guid>(nullable: true),
                    MemberId = table.Column<Guid>(nullable: true),
                    PersonId = table.Column<Guid>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Address_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_InstructorId",
                table: "Address",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_MemberId",
                table: "Address",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StudentId",
                table: "Address",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Person",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Member",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructor",
                newName: "ID");
        }
    }
}
