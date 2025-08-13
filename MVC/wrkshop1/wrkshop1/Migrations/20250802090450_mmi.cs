using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wrkshop1.Migrations
{
    /// <inheritdoc />
    public partial class mmi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "pets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
