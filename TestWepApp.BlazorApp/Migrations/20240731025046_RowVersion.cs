using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWepApp.BlazorApp.Migrations
{
    //add-migration RowVersion -Context TestWepApp.BlazorApp.Models.Candidates.CandidateAppDbContext
    //update-database -Context TestWepApp.BlazorApp.Models.Candidates.CandidateAppDbContext
    //script-migration -Context TestWepApp.BlazorApp.Models.Candidates.CandidateAppDbContext

    /// <inheritdoc />
    public partial class RowVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyToken",
                table: "Candidates",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyToken",
                table: "Candidates");
        }
    }
}
