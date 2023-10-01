using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENSI.Migrations
{
    /// <inheritdoc />
    public partial class IdDirecteur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SecuriteDirecteur",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Securite_Directeur",
                table: "SecuriteDirecteur",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Securite_Directeur",
                table: "SecuriteDirecteur");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SecuriteDirecteur");
        }
    }
}
