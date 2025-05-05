using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G03_Ef01.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sales");

            migrationBuilder.CreateTable(
                name: "departments",
                schema: "sales",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NewGuid"),
                    DepartmentName = table.Column<string>(name: "Department Name", type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "hr"),
                    DateCreation = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DeptId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departments",
                schema: "sales");
        }
    }
}
