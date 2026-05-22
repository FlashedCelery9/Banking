using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banking.Migrations
{
    /// <inheritdoc />
    public partial class Update_Transactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Person",
                table: "Incomes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Remainder",
                table: "Incomes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Person",
                table: "Expenses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Remainder",
                table: "Expenses",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Currencies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "none");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "none");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Person",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "Remainder",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "Person",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Remainder",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Currencies");
        }
    }
}
