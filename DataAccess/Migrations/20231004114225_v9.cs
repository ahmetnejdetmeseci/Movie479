using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Records");

            migrationBuilder.AddColumn<string>(
                name: "GenreGuId",
                table: "MovieGenres",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieGuId",
                table: "MovieGenres",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "Year",
                table: "Records",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<double>(
                name: "Revenue",
                table: "Records",
                type: "double",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<string>(
                name: "GuId",
                table: "Records",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Records",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Records",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Records",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectorGuId",
                table: "Records",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director_Name",
                table: "Records",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Records",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "GenreGuId",
                table: "Records",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre_Name",
                table: "Records",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRetired",
                table: "Records",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Records",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                columns: new[] { "Id", "GuId" });

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

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_GenreId_GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_MovieId_MovieGuId",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_DirectorId_DirectorGuId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_GenreId_GenreGuId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "MovieGuId",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DirectorGuId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Director_Name",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "GenreGuId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Genre_Name",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "IsRetired",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Records");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Movies");

            migrationBuilder.AlterColumn<short>(
                name: "Year",
                table: "Movies",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Revenue",
                table: "Movies",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GuId",
                table: "Movies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GuId = table.Column<string>(type: "longtext", nullable: true),
                    IsRetired = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Surname = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GuId = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");
        }
    }
}
