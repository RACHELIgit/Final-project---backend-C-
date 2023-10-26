using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contextdal.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    AgeGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.AgeGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriesByUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.OccupationId);
                });

            migrationBuilder.CreateTable(
                name: "ReasonTravel",
                columns: table => new
                {
                    ReasonTravelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonTravelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonTravel", x => x.ReasonTravelId);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "TimeTravel",
                columns: table => new
                {
                    TimeTravelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeTravelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTravel", x => x.TimeTravelId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ItemsImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    AgeGroupId = table.Column<int>(type: "int", nullable: false),
                    OccupationId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemsId);
                    table.ForeignKey(
                        name: "FK_Items_AgeGroup_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroup",
                        principalColumn: "AgeGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupation",
                        principalColumn: "OccupationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "SectorId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    SectorId = table.Column<int>(type: "int", nullable: true),
                    OccupationId = table.Column<int>(type: "int", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UsersId);
                    table.ForeignKey(
                        name: "FK_Users_AgeGroup_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroup",
                        principalColumn: "AgeGroupId");
                    table.ForeignKey(
                        name: "FK_Users_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId");
                    table.ForeignKey(
                        name: "FK_Users_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupation",
                        principalColumn: "OccupationId");
                    table.ForeignKey(
                        name: "FK_Users_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "SectorId");
                });

            migrationBuilder.CreateTable(
                name: "ItemToCategory",
                columns: table => new
                {
                    ItemToCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemToCategory", x => x.ItemToCategoryId);
                    table.ForeignKey(
                        name: "FK_ItemToCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "CategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemToCategory_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "ItemsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemToCategory_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "UsersId");
                });

            migrationBuilder.CreateTable(
                name: "TravelToUser",
                columns: table => new
                {
                    TravelToUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelToUserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    TravelToUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonTravelId = table.Column<int>(type: "int", nullable: false),
                    TimeTravelId = table.Column<int>(type: "int", nullable: false),
                    Descriebe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelToUser", x => x.TravelToUserId);
                    table.ForeignKey(
                        name: "FK_TravelToUser_ReasonTravel_ReasonTravelId",
                        column: x => x.ReasonTravelId,
                        principalTable: "ReasonTravel",
                        principalColumn: "ReasonTravelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelToUser_TimeTravel_TimeTravelId",
                        column: x => x.TimeTravelId,
                        principalTable: "TimeTravel",
                        principalColumn: "TimeTravelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelToUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTravelToUser",
                columns: table => new
                {
                    ItemTravelToUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelToUserId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DidTake = table.Column<bool>(type: "bit", nullable: false),
                    Reminder = table.Column<bool>(type: "bit", nullable: false),
                    ReminderDeatiles = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTravelToUser", x => x.ItemTravelToUserId);
                    table.ForeignKey(
                        name: "FK_ItemTravelToUser_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "ItemsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTravelToUser_TravelToUser_TravelToUserId",
                        column: x => x.TravelToUserId,
                        principalTable: "TravelToUser",
                        principalColumn: "TravelToUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_AgeGroupId",
                table: "Items",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GenderId",
                table: "Items",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OccupationId",
                table: "Items",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SectorId",
                table: "Items",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemToCategory_CategoriesId",
                table: "ItemToCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemToCategory_ItemsId",
                table: "ItemToCategory",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemToCategory_UsersId",
                table: "ItemToCategory",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTravelToUser_ItemsId",
                table: "ItemTravelToUser",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTravelToUser_TravelToUserId",
                table: "ItemTravelToUser",
                column: "TravelToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelToUser_ReasonTravelId",
                table: "TravelToUser",
                column: "ReasonTravelId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelToUser_TimeTravelId",
                table: "TravelToUser",
                column: "TimeTravelId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelToUser_UsersId",
                table: "TravelToUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AgeGroupId",
                table: "Users",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OccupationId",
                table: "Users",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectorId",
                table: "Users",
                column: "SectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemToCategory");

            migrationBuilder.DropTable(
                name: "ItemTravelToUser");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "TravelToUser");

            migrationBuilder.DropTable(
                name: "ReasonTravel");

            migrationBuilder.DropTable(
                name: "TimeTravel");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
