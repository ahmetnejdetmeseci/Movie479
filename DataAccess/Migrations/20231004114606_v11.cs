using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Records_DirectorId_DirectorGuId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_GenreId_GenreGuId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_GenreId_GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_MovieId_MovieGuId",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "DirectorGuId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "GenreGuId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "GenreGuId",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "MovieGuId",
                table: "MovieGenres");

            migrationBuilder.AlterColumn<string>(
                name: "GuId",
                table: "Records",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Records",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Records_DirectorId",
                table: "Records",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_GenreId",
                table: "Records",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Records_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Records_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Records_DirectorId",
                table: "Records",
                column: "DirectorId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Records_GenreId",
                table: "Records",
                column: "GenreId",
                principalTable: "Records",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Records_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Records_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Records_DirectorId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Records_GenreId",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_DirectorId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_GenreId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres");

            migrationBuilder.AlterColumn<string>(
                name: "GuId",
                table: "Records",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Records",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "DirectorGuId",
                table: "Records",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenreGuId",
                table: "Records",
                type: "varchar(255)",
                nullable: true);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                columns: new[] { "Id", "GuId" });

            migrationBuilder.CreateIndex(
                name: "IX_Records_DirectorId_DirectorGuId",
                table: "Records",
                columns: new[] { "DirectorId", "DirectorGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_Records_GenreId_GenreGuId",
                table: "Records",
                columns: new[] { "GenreId", "GenreGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId_GenreGuId",
                table: "MovieGenres",
                columns: new[] { "GenreId", "GenreGuId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId_MovieGuId",
                table: "MovieGenres",
                columns: new[] { "MovieId", "MovieGuId" });

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
    }
}
