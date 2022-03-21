namespace UdemyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (4, 'Sci-Fi')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (5, 'Adventure')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (6, 'Drama')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (7, 'Crime')");
            Sql("INSERT INTO Genres (GenreId, GenreName) VALUES (8, 'History')");
        }
        
        public override void Down()
        {
        }
    }
}
