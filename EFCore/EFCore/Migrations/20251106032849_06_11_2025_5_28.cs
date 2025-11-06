using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class _06_11_2025_5_28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentID1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentID1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentID1",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees");

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentID",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID1",
                table: "Employees",
                column: "DepartmentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID1",
                table: "Employees",
                column: "DepartmentID1",
                principalTable: "Departments",
                principalColumn: "ID");
        }
    }
}
