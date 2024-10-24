using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovieTickets.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerName",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ProducerDpURL",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ProducerBio",
                table: "Producers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameColumn(
                name: "MovieName",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MovieDescription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CinemaName",
                table: "Cinemas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CinemaLogoURL",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "CinemaDescription",
                table: "Cinemas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Cinemas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorID",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieID",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorName",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ActorDpURL",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ActorBio",
                table: "Actors",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CinemaID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProducerID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "CinemaID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducerID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProducerName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "ProducerDpURL");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Producers",
                newName: "ProducerBio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "ProducerID");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "movieCategory");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "CinemaID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "MovieName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "MovieDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cinemas",
                newName: "CinemaName");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "CinemaLogoURL");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "CinemaDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "CinemaId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors_Movies",
                newName: "ActorID");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieID");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ActorName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "ActorDpURL");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Actors",
                newName: "ActorBio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorID",
                table: "Actors_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieID",
                table: "Actors_Movies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
