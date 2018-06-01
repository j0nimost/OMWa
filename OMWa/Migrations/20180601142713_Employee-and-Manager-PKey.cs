using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OMWa.Migrations
{
    public partial class EmployeeandManagerPKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    JobId = table.Column<string>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    Fullname = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobRole = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<byte[]>(nullable: true),
                    UsersId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Managers_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ManagersJobId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Managers_ManagersJobId",
                        column: x => x.ManagersJobId,
                        principalTable: "Managers",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    JobId = table.Column<string>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    Fullname = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobRole = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<byte[]>(nullable: true),
                    UsersId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagersJobId",
                table: "Departments",
                column: "ManagersJobId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UsersId",
                table: "Employees",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UsersId",
                table: "Managers",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
