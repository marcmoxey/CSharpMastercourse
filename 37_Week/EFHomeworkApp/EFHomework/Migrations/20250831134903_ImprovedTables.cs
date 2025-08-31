using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFHomework.Migrations
{
    /// <inheritdoc />
    public partial class ImprovedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Peoples");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
