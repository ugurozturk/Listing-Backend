using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UOzturk.Listing.Migrations
{
    public partial class Listing_Tables_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemCreatedList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    ListTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemCreatedList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemCreatedList_ListType_ListTypeId",
                        column: x => x.ListTypeId,
                        principalTable: "ListType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCreatedList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    ListTypeId = table.Column<int>(nullable: false),
                    ListOwnerUserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCreatedList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCreatedList_AbpUsers_ListOwnerUserId",
                        column: x => x.ListOwnerUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCreatedList_ListType_ListTypeId",
                        column: x => x.ListTypeId,
                        principalTable: "ListType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemCreatedListItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    IsPc = table.Column<bool>(nullable: false),
                    IsXBox = table.Column<bool>(nullable: false),
                    IsPs = table.Column<bool>(nullable: false),
                    IsVideo = table.Column<bool>(nullable: false),
                    SystemCreatedListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemCreatedListItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemCreatedListItem_SystemCreatedList_SystemCreatedListId",
                        column: x => x.SystemCreatedListId,
                        principalTable: "SystemCreatedList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCreatedListItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Score = table.Column<short>(nullable: false),
                    UserCreatedListId = table.Column<int>(nullable: true),
                    SystemCreatedListItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCreatedListItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCreatedListItem_SystemCreatedListItem_SystemCreatedListItemId",
                        column: x => x.SystemCreatedListItemId,
                        principalTable: "SystemCreatedListItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCreatedListItem_UserCreatedList_UserCreatedListId",
                        column: x => x.UserCreatedListId,
                        principalTable: "UserCreatedList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCreatedListItemTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 25, nullable: true),
                    UserCreatedListItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCreatedListItemTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCreatedListItemTag_UserCreatedListItem_UserCreatedListItemId",
                        column: x => x.UserCreatedListItemId,
                        principalTable: "UserCreatedListItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemCreatedList_ListTypeId",
                table: "SystemCreatedList",
                column: "ListTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemCreatedListItem_SystemCreatedListId",
                table: "SystemCreatedListItem",
                column: "SystemCreatedListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreatedListItemTag_UserCreatedListItemId",
                table: "UserCreatedListItemTag",
                column: "UserCreatedListItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreatedList_ListOwnerUserId",
                table: "UserCreatedList",
                column: "ListOwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreatedList_ListTypeId",
                table: "UserCreatedList",
                column: "ListTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreatedListItem_SystemCreatedListItemId",
                table: "UserCreatedListItem",
                column: "SystemCreatedListItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreatedListItem_UserCreatedListId",
                table: "UserCreatedListItem",
                column: "UserCreatedListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCreatedListItemTag");

            migrationBuilder.DropTable(
                name: "UserCreatedListItem");

            migrationBuilder.DropTable(
                name: "SystemCreatedListItem");

            migrationBuilder.DropTable(
                name: "UserCreatedList");

            migrationBuilder.DropTable(
                name: "SystemCreatedList");

            migrationBuilder.DropTable(
                name: "ListType");
        }
    }
}
