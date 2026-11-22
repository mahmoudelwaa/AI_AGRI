using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDesignDrivenFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Farms",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Farms",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoilType",
                table: "Farms",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfectionPatternAr",
                table: "Diseases",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfectionPatternEn",
                table: "Diseases",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Diagnoses",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImageSizeBytes",
                table: "Diagnoses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Crops",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crops",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "InfectionPatternAr", "InfectionPatternEn" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "SoilType",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "InfectionPatternAr",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "InfectionPatternEn",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "ImageSizeBytes",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Crops");
        }
    }
}
