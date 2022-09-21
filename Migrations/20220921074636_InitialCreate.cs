using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brew_logger_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    Brewers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalGravity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalGravity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlcoholPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalIngredientsPrice = table.Column<int>(type: "int", nullable: false),
                    FinalProductLiters = table.Column<int>(type: "int", nullable: false),
                    PricerPerLiter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BitteringCalculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    IBU = table.Column<int>(type: "int", nullable: false),
                    AlfaSyre = table.Column<float>(type: "real", nullable: false),
                    Yield = table.Column<int>(type: "int", nullable: false),
                    FinishedBrewLiters = table.Column<int>(type: "int", nullable: false),
                    MinutesNotes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitteringCalculations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BitteringCalculations_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FermentingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    Liter = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FermentationStarted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FermentationStopped = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FermentingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FermentingDetails_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramsPerLiter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grams = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alfa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hops_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Malts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Part = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Malts_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MashingProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    KiloGramsOfMalt = table.Column<int>(type: "int", nullable: false),
                    WantedWaterTemperature = table.Column<int>(type: "int", nullable: false),
                    MaltTemperature = table.Column<int>(type: "int", nullable: false),
                    LitersOfWater = table.Column<int>(type: "int", nullable: false),
                    TemperatureOfWater = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MashingProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MashingProcedures_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeerId = table.Column<int>(type: "int", nullable: false),
                    WaterHeatingStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterHeatingEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterHeatingLiters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterHeatingTemperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MashStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MashEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MashLiters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MashTemperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpargeStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpargeEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpargeTemperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpargeLiters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoilStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoilEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoilTemperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoilLiters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingTemperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingLiters = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterTreatments_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitteringCalculations_BeerId",
                table: "BitteringCalculations",
                column: "BeerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FermentingDetails_BeerId",
                table: "FermentingDetails",
                column: "BeerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hops_BeerId",
                table: "Hops",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Malts_BeerId",
                table: "Malts",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_MashingProcedures_BeerId",
                table: "MashingProcedures",
                column: "BeerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterTreatments_BeerId",
                table: "WaterTreatments",
                column: "BeerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitteringCalculations");

            migrationBuilder.DropTable(
                name: "FermentingDetails");

            migrationBuilder.DropTable(
                name: "Hops");

            migrationBuilder.DropTable(
                name: "Malts");

            migrationBuilder.DropTable(
                name: "MashingProcedures");

            migrationBuilder.DropTable(
                name: "WaterTreatments");

            migrationBuilder.DropTable(
                name: "Beers");
        }
    }
}
