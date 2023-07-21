using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWepApp.BlazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class BuffetModelAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Broths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Broths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noodles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BrothId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noodles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Noodles_Broths_BrothId",
                        column: x => x.BrothId,
                        principalTable: "Broths",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Garnishs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NoodleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garnishs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garnishs_Noodles_NoodleId",
                        column: x => x.NoodleId,
                        principalTable: "Noodles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garnishs_NoodleId",
                table: "Garnishs",
                column: "NoodleId");

            migrationBuilder.CreateIndex(
                name: "IX_Noodles_BrothId",
                table: "Noodles",
                column: "BrothId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garnishs");

            migrationBuilder.DropTable(
                name: "Noodles");

            migrationBuilder.DropTable(
                name: "Broths");
        }
    }
}
