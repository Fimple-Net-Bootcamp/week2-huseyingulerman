using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace week2_huseyingulerman.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Temperature",
                table: "Satellites",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Temperature",
                table: "Planets",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 35 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, -100 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 200 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 50 });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 80 });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, -1 });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { true, -3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Temperature",
                table: "Satellites",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Temperature",
                table: "Planets",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 35m });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, -100m });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 200m });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 3m });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 50m });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 80m });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, -1m });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 4m });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, 3m });

            migrationBuilder.UpdateData(
                table: "Satellites",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsActive", "Temperature" },
                values: new object[] { false, -3m });
        }
    }
}
