using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrideSync.Data.Migrations
{
    /// <inheritdoc />
    public partial class PersonData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "People");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
