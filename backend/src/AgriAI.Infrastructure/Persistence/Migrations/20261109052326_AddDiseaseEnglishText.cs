using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriAI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiseaseEnglishText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CausesEn",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConditionsEn",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreventionEn",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SymptomsEn",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatmentEn",
                table: "Diseases",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { null, null, "Regular irrigation, balanced fertilization, and routine monitoring of the plants.", "Uniform green leaves with no spots or yellowing, and normal growth of stems and fruit.", null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Alternaria solani, which spreads in warm, humid weather.", "Warm weather (about 24-29 °C) with high humidity, and frequent rain or overhead irrigation.", "Crop rotation, avoiding overhead irrigation, and removing infected plant debris.", "Dark brown spots with concentric rings (target-like) on the lower leaves, surrounded by yellowing; leaves later dry out and fall.", "Spray a copper-based fungicide or chlorothalonil, and remove infected leaves." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus-like organism Phytophthora infestans, which spreads in cool, wet weather.", "Cool, mild weather (about 10-24 °C) with very high humidity and cloudy or rainy conditions.", "Plant resistant varieties, ensure good ventilation, and avoid keeping leaves wet for long periods.", "Oily grey-green spots on leaves and fruit that turn brown, with white mold under the leaf in high humidity.", "Apply preventive fungicides before infection appears, and destroy severely infected plants." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Septoria lycopersici, spread by splashing water and humidity.", "Moderate temperatures (about 20-25 °C) with high humidity; infection spreads through splashing rain and irrigation.", "Crop rotation, reducing leaf wetness, and cleaning the field of plant debris.", "Small round spots with grey centers and dark brown edges on the lower leaves; tiny black dots may appear in the middle of the spot.", "Fungicides and removal of infected leaves." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "Xanthomonas bacteria, spread by rain, splashing water, and contaminated seed.", "Warm, humid weather (about 24-30 °C) with rain, wind, and overhead irrigation.", "Use healthy seed, avoid overhead irrigation, and rotate crops.", "Small dark, water-soaked spots on leaves, and rough, slightly raised brown spots on fruit.", "Spray copper compounds and remove severely infected plants." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Fusarium oxysporum, which survives in soil for many years.", "Warm soil (about 27-28 °C), slightly acidic soil, and root wounds.", "Plant resistant varieties, sterilize the soil, and rotate crops.", "Yellowing of lower leaves, often starting on one side of the plant, followed by general wilting and brown discoloration of the vessels when the stem is cut.", "There is no effective cure once infected; remove infected plants and treat the soil." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "A virus transmitted by the whitefly.", "Warm, dry weather that increases whitefly populations, especially in neighboring plantings.", "Control whiteflies, use protective netting, and plant resistant varieties.", "Leaves curl upward and their edges turn yellow, with stunted plants and reduced fruit set.", "There is no cure for the virus; remove infected plants and control the vector (whitefly)." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { null, null, "Balanced fertilization, keeping an appropriate water level, and routine field monitoring.", "Uniform dark green leaves and even tiller growth with no spots or scorching.", null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Magnaporthe oryzae, which spreads with high humidity and excess nitrogen fertilization.", "High humidity, long periods of dew, and moderate temperatures (about 25-28 °C), with excess nitrogen fertilization.", "Plant resistant varieties, moderate nitrogen fertilization, and avoid very dense planting.", "Diamond- or spindle-shaped spots with grey centers and brown margins on leaves; it may also affect the neck and panicles, causing them to dry and break.", "Spray suitable fungicides at the first signs of symptoms, and remove infected straw residues." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "Xanthomonas oryzae bacteria, spread by irrigation water, rain, and wind.", "High temperatures (about 25-34 °C) with rain, wind, and flooded fields.", "Use healthy seed and resistant varieties, and avoid excess nitrogen fertilization.", "Yellow to white water-soaked streaks that start at the leaf edges and extend along the leaf, after which the leaf dries.", "No effective cure once it has spread; rely on prevention and drain water from infected fields." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Bipolaris oryzae, linked to nutrient deficiency and poor soil.", "High humidity and warm temperatures (about 25-30 °C), with poor soil or water stress and nutrient deficiency.", "Balanced fertilization (especially potassium), healthy seed, and improving soil fertility.", "Small oval brown spots on leaves, often with a grey center; it may also affect the grains.", "Treat seed with a fungicide, and spray a fungicide when needed." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Rhizoctonia solani, which spreads with dense planting, humidity, and heat.", "High heat and humidity (about 28-32 °C), with dense planting and excess nitrogen fertilization.", "Reduce planting density, moderate nitrogen fertilization, and remove weeds and crop residues.", "Oval grey-green spots on the leaf sheath near the water line that grow and merge, and may reach the upper leaves.", "Spray suitable fungicides, and improve ventilation and water drainage." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { null, null, "Plant resistant varieties, balanced fertilization, and routine field monitoring.", "Uniform green leaves without pustules or spots, with full heads and even growth.", null });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Puccinia striiformis, which spreads in cool, humid weather by wind.", "Cool, mild weather (about 10-15 °C) with dew and high humidity; spores spread by wind.", "Plant resistant varieties, sow at the right time, and remove volunteer plants.", "Yellow pustules arranged in parallel lengthwise stripes on the leaves, releasing yellow powder when touched.", "Spray suitable fungicides at the first signs of symptoms." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Puccinia triticina, which spreads by wind in warm, humid weather.", "Moderate to warm temperatures (about 15-25 °C) with dew or high humidity.", "Plant resistant varieties, and avoid late sowing and dense planting.", "Small round orange-to-brown pustules scattered over the upper leaf surface.", "Spray suitable fungicides and monitor the field regularly." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Puccinia graminis, which spreads by wind in warm, humid weather.", "Warm, humid weather (about 20-30 °C) with dew, and rapid spread by wind.", "Plant resistant varieties, sow early, and remove alternate host plants.", "Long reddish-brown pustules on stems and sheaths; the skin tears over them and brown powder is released.", "Spray suitable fungicides as soon as infection appears." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Zymoseptoria tritici, spread by splashing water and humidity.", "Moderate temperatures (about 15-25 °C) with rain or high humidity, and splashing that carries the spores.", "Crop rotation, removal of crop residues, and planting resistant varieties.", "Irregular yellow to brown blotches on the lower leaves, with tiny black dots appearing inside them.", "Spray suitable fungicides at the start of infection." });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CausesEn", "ConditionsEn", "PreventionEn", "SymptomsEn", "TreatmentEn" },
                values: new object[] { "The fungus Blumeria graminis, which spreads with high humidity and excess plant density.", "High humidity and moderate temperatures (about 15-22 °C), with dense planting and excess nitrogen fertilization.", "Avoid excess nitrogen fertilization, reduce planting density, and plant resistant varieties.", "White-grey powdery growth on leaves and sheaths that later turns into dark spots.", "Spray suitable fungicides and improve ventilation." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CausesEn",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "ConditionsEn",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "PreventionEn",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "SymptomsEn",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "TreatmentEn",
                table: "Diseases");
        }
    }
}
