using Microsoft.EntityFrameworkCore.Migrations;

namespace Gimli.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmClothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmClothes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyClothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyClothes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeetClothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeetClothes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadClothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadClothes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LegsClothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegsClothes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outfits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutfitArmCloth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutfitId = table.Column<int>(type: "int", nullable: false),
                    ArmClothId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitArmCloth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitArmCloth_ArmClothes_ArmClothId",
                        column: x => x.ArmClothId,
                        principalTable: "ArmClothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitArmCloth_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitBodyCloth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutfitId = table.Column<int>(type: "int", nullable: false),
                    BodyClothId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitBodyCloth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitBodyCloth_BodyClothes_BodyClothId",
                        column: x => x.BodyClothId,
                        principalTable: "BodyClothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitBodyCloth_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitFeetCloth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutfitId = table.Column<int>(type: "int", nullable: false),
                    FeetClothId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitFeetCloth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitFeetCloth_FeetClothes_FeetClothId",
                        column: x => x.FeetClothId,
                        principalTable: "FeetClothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitFeetCloth_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitHeadCloth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutfitId = table.Column<int>(type: "int", nullable: false),
                    HeadClothId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitHeadCloth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitHeadCloth_HeadClothes_HeadClothId",
                        column: x => x.HeadClothId,
                        principalTable: "HeadClothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitHeadCloth_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitLegsCloth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutfitId = table.Column<int>(type: "int", nullable: false),
                    LegsClothId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitLegsCloth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitLegsCloth_LegsClothes_LegsClothId",
                        column: x => x.LegsClothId,
                        principalTable: "LegsClothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitLegsCloth_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutfitArmCloth_ArmClothId",
                table: "OutfitArmCloth",
                column: "ArmClothId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitArmCloth_OutfitId",
                table: "OutfitArmCloth",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitBodyCloth_BodyClothId",
                table: "OutfitBodyCloth",
                column: "BodyClothId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitBodyCloth_OutfitId",
                table: "OutfitBodyCloth",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitFeetCloth_FeetClothId",
                table: "OutfitFeetCloth",
                column: "FeetClothId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitFeetCloth_OutfitId",
                table: "OutfitFeetCloth",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitHeadCloth_HeadClothId",
                table: "OutfitHeadCloth",
                column: "HeadClothId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitHeadCloth_OutfitId",
                table: "OutfitHeadCloth",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitLegsCloth_LegsClothId",
                table: "OutfitLegsCloth",
                column: "LegsClothId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitLegsCloth_OutfitId",
                table: "OutfitLegsCloth",
                column: "OutfitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutfitArmCloth");

            migrationBuilder.DropTable(
                name: "OutfitBodyCloth");

            migrationBuilder.DropTable(
                name: "OutfitFeetCloth");

            migrationBuilder.DropTable(
                name: "OutfitHeadCloth");

            migrationBuilder.DropTable(
                name: "OutfitLegsCloth");

            migrationBuilder.DropTable(
                name: "ArmClothes");

            migrationBuilder.DropTable(
                name: "BodyClothes");

            migrationBuilder.DropTable(
                name: "FeetClothes");

            migrationBuilder.DropTable(
                name: "HeadClothes");

            migrationBuilder.DropTable(
                name: "LegsClothes");

            migrationBuilder.DropTable(
                name: "Outfits");
        }
    }
}
