using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false),
                    Director_Name = table.Column<string>(type: "longtext", nullable: true),
                    Surname = table.Column<string>(type: "longtext", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsRetired = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Genre_Name = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Year = table.Column<short>(type: "smallint", nullable: true),
                    Revenue = table.Column<double>(type: "double", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: true),
                    DirectorGuId = table.Column<string>(type: "varchar(255)", nullable: true),
                    GenreGuId = table.Column<string>(type: "varchar(255)", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => new { x.Id, x.GuId });
                    table.ForeignKey(
                        name: "FK_Records_Records_DirectorId_DirectorGuId",
                        columns: x => new { x.DirectorId, x.DirectorGuId },
                        principalTable: "Records",
                        principalColumns: new[] { "Id", "GuId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_Records_GenreId_GenreGuId",
                        columns: x => new { x.GenreId, x.GenreGuId },
                        principalTable: "Records",
                        principalColumns: new[] { "Id", "GuId" });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovieGuId = table.Column<string>(type: "varchar(255)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    GenreGuId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MovieGenres_Records_GenreId_GenreGuId",
                        columns: x => new { x.GenreId, x.GenreGuId },
                        principalTable: "Records",
                        principalColumns: new[] { "Id", "GuId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Records_MovieId_MovieGuId",
                        columns: x => new { x.MovieId, x.MovieGuId },
                        principalTable: "Records",
                        principalColumns: new[] { "Id", "GuId" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId_GenreGuId",
                table: "MovieGenres",
                columns: new[] { "GenreId", "GenreGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId_MovieGuId",
                table: "MovieGenres",
                columns: new[] { "MovieId", "MovieGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_Records_DirectorId_DirectorGuId",
                table: "Records",
                columns: new[] { "DirectorId", "DirectorGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_Records_GenreId_GenreGuId",
                table: "Records",
                columns: new[] { "GenreId", "GenreGuId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
