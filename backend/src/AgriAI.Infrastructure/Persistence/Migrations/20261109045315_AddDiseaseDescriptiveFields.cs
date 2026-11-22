using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiseaseDescriptiveFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Diseases",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PathogenType",
                table: "Diseases",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ScientificName",
                table: "Diseases",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Severity",
                table: "Diseases",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpreadRate",
                table: "Diseases",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Conditions", "ImageUrl", "PathogenType", "ScientificName", "Severity", "SpreadRate" },
                values: new object[] { null, null, "None", null, "None", "None" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conditions",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "PathogenType",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "ScientificName",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "Severity",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "SpreadRate",
                table: "Diseases");
        }
    }
}
