using Microsoft.EntityFrameworkCore.Migrations;

namespace UOzturk.Listing.Migrations
{
    public partial class UserCreatedListItemEntityBugFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCreatedListItem_SystemCreatedListItem_SystemCreatedListItemId",
                table: "UserCreatedListItem");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCreatedListItem_UserCreatedList_UserCreatedListId",
                table: "UserCreatedListItem");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedListId",
                table: "UserCreatedListItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SystemCreatedListItemId",
                table: "UserCreatedListItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SystemCreatedList",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCreatedListItem_SystemCreatedListItem_SystemCreatedListItemId",
                table: "UserCreatedListItem",
                column: "SystemCreatedListItemId",
                principalTable: "SystemCreatedListItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCreatedListItem_UserCreatedList_UserCreatedListId",
                table: "UserCreatedListItem",
                column: "UserCreatedListId",
                principalTable: "UserCreatedList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCreatedListItem_SystemCreatedListItem_SystemCreatedListItemId",
                table: "UserCreatedListItem");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCreatedListItem_UserCreatedList_UserCreatedListId",
                table: "UserCreatedListItem");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedListId",
                table: "UserCreatedListItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SystemCreatedListItemId",
                table: "UserCreatedListItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SystemCreatedList",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCreatedListItem_SystemCreatedListItem_SystemCreatedListItemId",
                table: "UserCreatedListItem",
                column: "SystemCreatedListItemId",
                principalTable: "SystemCreatedListItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCreatedListItem_UserCreatedList_UserCreatedListId",
                table: "UserCreatedListItem",
                column: "UserCreatedListId",
                principalTable: "UserCreatedList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
