using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class InitialMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    IdMMusican = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastNamme = table.Column<string>(maxLength: 50, nullable: false),
                    Nickname = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.IdMMusican);
                });

            migrationBuilder.CreateTable(
                name: "MusicLabels",
                columns: table => new
                {
                    IdMusicLabel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicLabels", x => x.IdMusicLabel);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    IdAlbum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(maxLength: 50, nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    IdMusicLabel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.IdAlbum);
                    table.ForeignKey(
                        name: "FK_Albums_MusicLabels_IdMusicLabel",
                        column: x => x.IdMusicLabel,
                        principalTable: "MusicLabels",
                        principalColumn: "IdMusicLabel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    IdTrack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackName = table.Column<string>(maxLength: 20, nullable: false),
                    Duration = table.Column<float>(nullable: false),
                    IdMusicAlbum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.IdTrack);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_IdMusicAlbum",
                        column: x => x.IdMusicAlbum,
                        principalTable: "Albums",
                        principalColumn: "IdAlbum",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicianTrack",
                columns: table => new
                {
                    IdMusicanTrack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrack = table.Column<int>(nullable: true),
                    IdMusican = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianTrack", x => x.IdMusicanTrack);
                    table.ForeignKey(
                        name: "FK_MusicianTrack_Musicians_IdMusican",
                        column: x => x.IdMusican,
                        principalTable: "Musicians",
                        principalColumn: "IdMMusican",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MusicianTrack_Tracks_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Tracks",
                        principalColumn: "IdTrack",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_IdMusicLabel",
                table: "Albums",
                column: "IdMusicLabel");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianTrack_IdMusican",
                table: "MusicianTrack",
                column: "IdMusican");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianTrack_IdTrack",
                table: "MusicianTrack",
                column: "IdTrack");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdMusicAlbum",
                table: "Tracks",
                column: "IdMusicAlbum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianTrack");

            migrationBuilder.DropTable(
                name: "Musicians");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "MusicLabels");
        }
    }
}
