using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KAIRA.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brands",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Brands",
                newName: "Name");
        }
    }
}
