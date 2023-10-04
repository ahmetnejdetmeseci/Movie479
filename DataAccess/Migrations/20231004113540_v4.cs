using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Record_GenreId_GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Record_MovieId_MovieGuId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Record_DirectorId_DirectorGuId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Record_GenreId_GenreGuId",
                table: "Record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Record",
                table: "Record");

            migrationBuilder.RenameTable(
                name: "Record",
                newName: "Records");

            migrationBuilder.RenameIndex(
                name: "IX_Record_GenreId_GenreGuId",
                table: "Records",
                newName: "IX_Records_GenreId_GenreGuId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_DirectorId_DirectorGuId",
                table: "Records",
                newName: "IX_Records_DirectorId_DirectorGuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                columns: new[] { "Id", "GuId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Records_GenreId_GenreGuId",
                table: "MovieGenres",
                columns: new[] { "GenreId", "GenreGuId" },
                principalTable: "Records",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Records_MovieId_MovieGuId",
                table: "MovieGenres",
                columns: new[] { "MovieId", "MovieGuId" },
                principalTable: "Records",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Records_DirectorId_DirectorGuId",
                table: "Records",
                columns: new[] { "DirectorId", "DirectorGuId" },
                principalTable: "Records",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Records_GenreId_GenreGuId",
                table: "Records",
                columns: new[] { "GenreId", "GenreGuId" },
                principalTable: "Records",
                principalColumns: new[] { "Id", "GuId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Records_GenreId_GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Records_MovieId_MovieGuId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Records_DirectorId_DirectorGuId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Records_GenreId_GenreGuId",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Record");

            migrationBuilder.RenameIndex(
                name: "IX_Records_GenreId_GenreGuId",
                table: "Record",
                newName: "IX_Record_GenreId_GenreGuId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_DirectorId_DirectorGuId",
                table: "Record",
                newName: "IX_Record_DirectorId_DirectorGuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Record",
                table: "Record",
                columns: new[] { "Id", "GuId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Record_GenreId_GenreGuId",
                table: "MovieGenres",
                columns: new[] { "GenreId", "GenreGuId" },
                principalTable: "Record",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Record_MovieId_MovieGuId",
                table: "MovieGenres",
                columns: new[] { "MovieId", "MovieGuId" },
                principalTable: "Record",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Record_DirectorId_DirectorGuId",
                table: "Record",
                columns: new[] { "DirectorId", "DirectorGuId" },
                principalTable: "Record",
                principalColumns: new[] { "Id", "GuId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Record_GenreId_GenreGuId",
                table: "Record",
                columns: new[] { "GenreId", "GenreGuId" },
                principalTable: "Record",
                principalColumns: new[] { "Id", "GuId" });
        }
    }
}
