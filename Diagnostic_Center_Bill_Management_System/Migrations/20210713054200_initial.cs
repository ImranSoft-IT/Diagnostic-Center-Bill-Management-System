using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diagnostic_Center_Bill_Management_System.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestTypeSetups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestType_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Slno = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypeSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestSetups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TestFee = table.Column<float>(type: "real", nullable: false),
                    Slno = table.Column<long>(type: "bigint", nullable: false),
                    TestTypeSetupId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestSetups_TestTypeSetups_TestTypeSetupId",
                        column: x => x.TestTypeSetupId,
                        principalTable: "TestTypeSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNo = table.Column<long>(type: "bigint", nullable: false),
                    TestSetupId = table.Column<long>(type: "bigint", nullable: false),
                    ReqTestFee = table.Column<float>(type: "real", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayAmount = table.Column<float>(type: "real", nullable: false),
                    Slno = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestRequests_TestSetups_TestSetupId",
                        column: x => x.TestSetupId,
                        principalTable: "TestSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestRequests_TestSetupId",
                table: "TestRequests",
                column: "TestSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSetups_TestTypeSetupId",
                table: "TestSetups",
                column: "TestTypeSetupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestRequests");

            migrationBuilder.DropTable(
                name: "TestSetups");

            migrationBuilder.DropTable(
                name: "TestTypeSetups");
        }
    }
}
