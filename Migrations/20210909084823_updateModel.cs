using Microsoft.EntityFrameworkCore.Migrations;

namespace Gimli.Migrations
{
    public partial class updateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OutfitArmCloth_ArmClothes_ArmClothId",
                table: "OutfitArmCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitArmCloth_Outfits_OutfitId",
                table: "OutfitArmCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitBodyCloth_BodyClothes_BodyClothId",
                table: "OutfitBodyCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitBodyCloth_Outfits_OutfitId",
                table: "OutfitBodyCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitFeetCloth_FeetClothes_FeetClothId",
                table: "OutfitFeetCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitFeetCloth_Outfits_OutfitId",
                table: "OutfitFeetCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitHeadCloth_HeadClothes_HeadClothId",
                table: "OutfitHeadCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitHeadCloth_Outfits_OutfitId",
                table: "OutfitHeadCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitLegsCloth_LegsClothes_LegsClothId",
                table: "OutfitLegsCloth");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitLegsCloth_Outfits_OutfitId",
                table: "OutfitLegsCloth");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitLegsCloth",
                table: "OutfitLegsCloth");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitHeadCloth",
                table: "OutfitHeadCloth");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitFeetCloth",
                table: "OutfitFeetCloth");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitBodyCloth",
                table: "OutfitBodyCloth");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitArmCloth",
                table: "OutfitArmCloth");

            migrationBuilder.RenameTable(
                name: "OutfitLegsCloth",
                newName: "OutfitLegsClothes");

            migrationBuilder.RenameTable(
                name: "OutfitHeadCloth",
                newName: "OutfitHeadClothes");

            migrationBuilder.RenameTable(
                name: "OutfitFeetCloth",
                newName: "OutfitFeetClothes");

            migrationBuilder.RenameTable(
                name: "OutfitBodyCloth",
                newName: "OutfitBodyClothes");

            migrationBuilder.RenameTable(
                name: "OutfitArmCloth",
                newName: "OutfitArmClothes");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitLegsCloth_OutfitId",
                table: "OutfitLegsClothes",
                newName: "IX_OutfitLegsClothes_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitLegsCloth_LegsClothId",
                table: "OutfitLegsClothes",
                newName: "IX_OutfitLegsClothes_LegsClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitHeadCloth_OutfitId",
                table: "OutfitHeadClothes",
                newName: "IX_OutfitHeadClothes_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitHeadCloth_HeadClothId",
                table: "OutfitHeadClothes",
                newName: "IX_OutfitHeadClothes_HeadClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitFeetCloth_OutfitId",
                table: "OutfitFeetClothes",
                newName: "IX_OutfitFeetClothes_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitFeetCloth_FeetClothId",
                table: "OutfitFeetClothes",
                newName: "IX_OutfitFeetClothes_FeetClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitBodyCloth_OutfitId",
                table: "OutfitBodyClothes",
                newName: "IX_OutfitBodyClothes_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitBodyCloth_BodyClothId",
                table: "OutfitBodyClothes",
                newName: "IX_OutfitBodyClothes_BodyClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitArmCloth_OutfitId",
                table: "OutfitArmClothes",
                newName: "IX_OutfitArmClothes_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitArmCloth_ArmClothId",
                table: "OutfitArmClothes",
                newName: "IX_OutfitArmClothes_ArmClothId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitLegsClothes",
                table: "OutfitLegsClothes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitHeadClothes",
                table: "OutfitHeadClothes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitFeetClothes",
                table: "OutfitFeetClothes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitBodyClothes",
                table: "OutfitBodyClothes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitArmClothes",
                table: "OutfitArmClothes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitArmClothes_ArmClothes_ArmClothId",
                table: "OutfitArmClothes",
                column: "ArmClothId",
                principalTable: "ArmClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitArmClothes_Outfits_OutfitId",
                table: "OutfitArmClothes",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitBodyClothes_BodyClothes_BodyClothId",
                table: "OutfitBodyClothes",
                column: "BodyClothId",
                principalTable: "BodyClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitBodyClothes_Outfits_OutfitId",
                table: "OutfitBodyClothes",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitFeetClothes_FeetClothes_FeetClothId",
                table: "OutfitFeetClothes",
                column: "FeetClothId",
                principalTable: "FeetClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitFeetClothes_Outfits_OutfitId",
                table: "OutfitFeetClothes",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitHeadClothes_HeadClothes_HeadClothId",
                table: "OutfitHeadClothes",
                column: "HeadClothId",
                principalTable: "HeadClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitHeadClothes_Outfits_OutfitId",
                table: "OutfitHeadClothes",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitLegsClothes_LegsClothes_LegsClothId",
                table: "OutfitLegsClothes",
                column: "LegsClothId",
                principalTable: "LegsClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitLegsClothes_Outfits_OutfitId",
                table: "OutfitLegsClothes",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OutfitArmClothes_ArmClothes_ArmClothId",
                table: "OutfitArmClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitArmClothes_Outfits_OutfitId",
                table: "OutfitArmClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitBodyClothes_BodyClothes_BodyClothId",
                table: "OutfitBodyClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitBodyClothes_Outfits_OutfitId",
                table: "OutfitBodyClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitFeetClothes_FeetClothes_FeetClothId",
                table: "OutfitFeetClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitFeetClothes_Outfits_OutfitId",
                table: "OutfitFeetClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitHeadClothes_HeadClothes_HeadClothId",
                table: "OutfitHeadClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitHeadClothes_Outfits_OutfitId",
                table: "OutfitHeadClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitLegsClothes_LegsClothes_LegsClothId",
                table: "OutfitLegsClothes");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitLegsClothes_Outfits_OutfitId",
                table: "OutfitLegsClothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitLegsClothes",
                table: "OutfitLegsClothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitHeadClothes",
                table: "OutfitHeadClothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitFeetClothes",
                table: "OutfitFeetClothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitBodyClothes",
                table: "OutfitBodyClothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OutfitArmClothes",
                table: "OutfitArmClothes");

            migrationBuilder.RenameTable(
                name: "OutfitLegsClothes",
                newName: "OutfitLegsCloth");

            migrationBuilder.RenameTable(
                name: "OutfitHeadClothes",
                newName: "OutfitHeadCloth");

            migrationBuilder.RenameTable(
                name: "OutfitFeetClothes",
                newName: "OutfitFeetCloth");

            migrationBuilder.RenameTable(
                name: "OutfitBodyClothes",
                newName: "OutfitBodyCloth");

            migrationBuilder.RenameTable(
                name: "OutfitArmClothes",
                newName: "OutfitArmCloth");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitLegsClothes_OutfitId",
                table: "OutfitLegsCloth",
                newName: "IX_OutfitLegsCloth_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitLegsClothes_LegsClothId",
                table: "OutfitLegsCloth",
                newName: "IX_OutfitLegsCloth_LegsClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitHeadClothes_OutfitId",
                table: "OutfitHeadCloth",
                newName: "IX_OutfitHeadCloth_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitHeadClothes_HeadClothId",
                table: "OutfitHeadCloth",
                newName: "IX_OutfitHeadCloth_HeadClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitFeetClothes_OutfitId",
                table: "OutfitFeetCloth",
                newName: "IX_OutfitFeetCloth_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitFeetClothes_FeetClothId",
                table: "OutfitFeetCloth",
                newName: "IX_OutfitFeetCloth_FeetClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitBodyClothes_OutfitId",
                table: "OutfitBodyCloth",
                newName: "IX_OutfitBodyCloth_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitBodyClothes_BodyClothId",
                table: "OutfitBodyCloth",
                newName: "IX_OutfitBodyCloth_BodyClothId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitArmClothes_OutfitId",
                table: "OutfitArmCloth",
                newName: "IX_OutfitArmCloth_OutfitId");

            migrationBuilder.RenameIndex(
                name: "IX_OutfitArmClothes_ArmClothId",
                table: "OutfitArmCloth",
                newName: "IX_OutfitArmCloth_ArmClothId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitLegsCloth",
                table: "OutfitLegsCloth",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitHeadCloth",
                table: "OutfitHeadCloth",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitFeetCloth",
                table: "OutfitFeetCloth",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitBodyCloth",
                table: "OutfitBodyCloth",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OutfitArmCloth",
                table: "OutfitArmCloth",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitArmCloth_ArmClothes_ArmClothId",
                table: "OutfitArmCloth",
                column: "ArmClothId",
                principalTable: "ArmClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitArmCloth_Outfits_OutfitId",
                table: "OutfitArmCloth",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitBodyCloth_BodyClothes_BodyClothId",
                table: "OutfitBodyCloth",
                column: "BodyClothId",
                principalTable: "BodyClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitBodyCloth_Outfits_OutfitId",
                table: "OutfitBodyCloth",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitFeetCloth_FeetClothes_FeetClothId",
                table: "OutfitFeetCloth",
                column: "FeetClothId",
                principalTable: "FeetClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitFeetCloth_Outfits_OutfitId",
                table: "OutfitFeetCloth",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitHeadCloth_HeadClothes_HeadClothId",
                table: "OutfitHeadCloth",
                column: "HeadClothId",
                principalTable: "HeadClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitHeadCloth_Outfits_OutfitId",
                table: "OutfitHeadCloth",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitLegsCloth_LegsClothes_LegsClothId",
                table: "OutfitLegsCloth",
                column: "LegsClothId",
                principalTable: "LegsClothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitLegsCloth_Outfits_OutfitId",
                table: "OutfitLegsCloth",
                column: "OutfitId",
                principalTable: "Outfits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
