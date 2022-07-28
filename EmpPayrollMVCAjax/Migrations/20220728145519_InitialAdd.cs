using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpPayrollMVCAjax.Migrations
{
    public partial class InitialAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emp1",
                table: "Emp1");

            migrationBuilder.RenameTable(
                name: "Emp1",
                newName: "EmpAjax");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpAjax",
                table: "EmpAjax",
                column: "Emp_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpAjax",
                table: "EmpAjax");

            migrationBuilder.RenameTable(
                name: "EmpAjax",
                newName: "Emp1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emp1",
                table: "Emp1",
                column: "Emp_Id");
        }
    }
}
